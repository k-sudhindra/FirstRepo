using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Appium;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Android;

namespace NUnitProject
{
    [TestClass]
    public class DemoUnitTest
    {
        AppiumDriver<IWebElement> driver;
        [TestMethod]
        public void FirstMethod()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DemoFunc()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("deviceName", "CustomDotNetClient");
            capabilities.SetCapability("appPackage", "com.android2.calculator3");
            capabilities.SetCapability("appActivity", "com.xlythe.calculator.material.Theme.Orange");
            capabilities.IsJavaScriptEnabled = true;
            driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);
            Screenshot sc = driver.GetScreenshot();
            sc.SaveAsFile(@"C:\Work\Screen.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //driver.
            driver.CloseApp();
            Console.WriteLine(driver);
            Assert.IsNotNull(driver.Context);            
        }
    }
}
