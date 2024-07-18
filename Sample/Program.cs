using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class Program
    {
       

        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
        }

        [Test]
        public void TestExecute()
        {
            driver.Navigate().GoToUrl("https://www.demoblaze.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//a[.='Contact']")).Click();
            driver.FindElement(By.Id("recipient-email")).SendKeys("Sample@gmail.com");
            driver.FindElement(By.Id("recipient-name")).SendKeys("Sample");
            driver.FindElement(By.Id("message-text")).SendKeys("Sample phone");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
