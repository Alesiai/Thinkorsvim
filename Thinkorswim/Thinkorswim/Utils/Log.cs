using System.IO;
using Serilog;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Linq;

namespace Thinkorswim.Tests.Utils
{
    public static class Log
    {
        static Log()
        {
            if (!Directory.Exists("LogFiles")) Directory.CreateDirectory("LogFiles");
            File.Delete("LogFiles/Thinkorswim.log");
            Serilog.Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.File("LogFiles/Thinkorswim.log",
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

                    if (!Directory.Exists("LogFiles/Screenshots")) Directory.CreateDirectory("LogFiles/Screenshots");
                    if (Directory.GetFiles(@"LogFiles\Screenshots\").Length == 0)
                        screenshot.SaveAsFile(@"LogFiles\Screenshots\Screen" + testContext.Test.MethodName + "_0.jpg");
                    else
                    {
                        string fileName = @"LogFiles\Screenshots\Screen" + testContext.Test.MethodName + "_" + System.Convert.ToString(
                            Directory.GetFiles(@"LogFiles\Screenshots\").Select(item => System.Convert.ToInt32(item.Split('_')[1].Split(".")[0]))
                            .OrderByDescending(item => item).First() + 1) + ".jpg";

                        screenshot.SaveAsFile(fileName);
                    }

                    Info("FAILED");
                }
                catch { }
            }
        }

        public static void LogStat(NUnit.Framework.Interfaces.ITestResult result)
        {
            
        }
    }
}
