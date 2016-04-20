using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using System.Diagnostics.Eventing;
using System.Collections.Generic;

namespace QAWorksTest.Pages
{
   public class BasePage
    {

        /// <summary>
        /// Puprose of this Base class is to
        /// Create and maintain generic functions which will be called across other pages.
        /// 
        /// </summary>
        public IWebDriver driver;
        private static string baseUrl;

        //public object ConfigurationManager { get; private set; }

        public BasePage()
        {

            driver = (IWebDriver)FeatureContext.Current["driver"];
           baseUrl = ConfigurationManager.AppSettings["baseUrl"];

        }


        public void type(string inputText, By locator)
        {
            find(locator).SendKeys(inputText);
        }

        public IWebElement find(By locator)
        {

            //   WebDriverWait wait = new (WebDriverWait(driver, TimeSpan.FromSeconds(15)));
            //wait.Until(ExpectedConditions.ElementIsVisible(locator));
            return driver.FindElement(locator);
        }

        public void verifyPage(string pageTitle)
        {
            if (!pageTitle.Equals(driver.Title))
            {
                throw new InvalidOperationException("This page is not " + pageTitle + ". The title is: " + driver.Title);
            }
        }


        public void Launch(string pageTitle)
        {
           // driver.Navigate().GoToUrl("http://QAWorks.com");
            driver.Navigate().GoToUrl(baseUrl);
            verifyPage(pageTitle);
        }


       
        public void click(By locator)
        {
            find(locator).Click();
        }


        public string getText(By locator)
        {
            return find(locator).Text;

        }

      
        public bool verifyTextMessage(IWebElement element, String text)
        {
            if (element.Text.Contains(text))
                return true;
            else
                return false;
        }


    }
}

    

