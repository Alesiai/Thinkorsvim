using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;

namespace Thinkorswim.Tests.Utils
{
    public class TestListener : ITestListener
    {
        public void SendMessage(TestMessage message)
        {
            Log.Info(Convert.ToString(message));
        }

        public void TestFinished(ITestResult result)
        {
            Log.LogStat(result);
        }

        public void TestOutput(TestOutput output)
        {
            Log.Info(Convert.ToString(output));
        }

        public void TestStarted(ITest test)
        { }

    }
}