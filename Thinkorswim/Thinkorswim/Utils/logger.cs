using System.IO;
using Serilog;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Linq;
using System.Xml.Serialization;

namespace Thinkorswim.Tests.Utils
{
    public static class Log
    {
        static Log()
        { 
            File.Delete("Thinkorswim.log");
            Serilog.Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.File("Thinkorswim.log",
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger();
            
         
        }
        public static void Info(string message)
        {
            Serilog.Log.Information(message);
        }

        public static void LogStat(TestContext testContext)
        {
            if (testContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                try
                {
                    Screenshot screenshot = ((ITakesScreenshot)Driver.DriverSingleton.GetWebDriver()).GetScreenshot();

                    if (!Directory.Exists("Screenshots")) Directory.CreateDirectory("Screenshots");
                    if (Directory.GetFiles(@"Screenshots\").Length == 0)
                        screenshot.SaveAsFile(@"Screenshots\Screen" + testContext.Test.MethodName + "_0.jpg");
                    else
                    {
                        string fileName = @"Screenshots\Screen" + testContext.Test.MethodName + "_" + System.Convert.ToString(
                            Directory.GetFiles(@"Screenshots\").Select(item => System.Convert.ToInt32(item.Split('_')[1].Split(".")[0]))
                            .OrderByDescending(item => item).First() + 1) + ".jpg";

                        screenshot.SaveAsFile(fileName);
                    }
                }
                catch { }
            }
        }
    }
}
