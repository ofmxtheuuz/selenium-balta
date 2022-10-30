using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using System;

namespace ChromeDriverBalta
{
    class Program
    {
        static void Main(string[] args)
        {
            const string url = "https://youtube.com";

            ChromeDriver cd = new ChromeDriver();
            cd.Manage().Window.Maximize();
            cd.Navigate().GoToUrl(url);

            Thread.Sleep(1000); 

            cd.FindElement(By.Name("search_query")).SendKeys("balta.io");
            cd.FindElement(By.Id("search-icon-legacy")).Click();
        }
    }
}
