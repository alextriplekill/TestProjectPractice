using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("chromedriver");
            INavigation navigation = driver.Navigate();
            navigation.GoToUrl("http://google.com");
            driver.Manage().Window.Maximize();
            IWebElement searchField = driver.FindElement(By.Name("q"));            
            searchField.SendKeys("Jojo");
            searchField.SendKeys(Keys.Enter);
            IWebElement searchResults = driver.FindElement(By.XPath("//*[@id = 'mBMHK']"));
            Assert.IsTrue(searchResults.Displayed);
            Console.ReadKey();
        }
    }
}
