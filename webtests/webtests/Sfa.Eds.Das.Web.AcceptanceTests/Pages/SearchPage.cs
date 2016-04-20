﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sfa.Eds.Das.Web.AcceptanceTests.Pages
{
    using Sfa.Das.WebTest.Infrastructure;

    public class SearchPage : BasePage


    {

        /// <summary>
        /// Purpose of this class is to 
        /// Create and maintain all Search Page objects and methods.
        /// Any changes to search functionality can be maintained under this page.
        /// </summary>

        // private IWebDriver driver;
        By searchBox = By.Id("keywords");
        By searchButton = By.Id("submit-keywords");

        // Search Results Page
        By searchresult = By.XPath(".//*[@id='standard-results']/div[1]/p");
        By searchkeywordresult = By.XPath(".//*[@id='standard-results']/div[1]/article/header/h2/a");
        By firstStandardinresult = By.XPath(".//*[@id='standard-results']/div[1]/article[1]/header/h2/a");
        By searchResultcount = By.CssSelector(".column-two-thirds>div>p>b");
        By typicallength = By.XPath(".//*[@id='standard-results']/div[1]/article/dl/dd[2]");

        By Invalidsearchmessage = By.XPath(".//*[@id='standard-results']/div[1]/div[2]/p");

        public void Navigate()
        {
            base.Navigate();
            WaitForSearchPage();
        }

        public void WaitForSearchPage()
        {
            WaitFor(searchButton);
        }

        public void launchLandingPage()
        {
            Launch("Home Page - Employer Apprenticeship Search");
            Sleep(3000);
        }

        public void OpenStandarDetails(String standard)
        {
            Open(standard);
            // Sleep(3000);
        }

        public void OpenFrameworkDetails(String framework)
        {
            OpenFramework(framework);
            // Sleep(3000);
        }

        public void SearchKeyword(String keyword)
        {
            type(keyword, searchBox);

        }

        public void clickSearchBox()
        {
            click(searchButton);
        }






        public void verifyresultsPages()
        {

            // Sleep(4000);
            Assert.True(isDisplayed(searchresult));
        }

        public void verifyStandardFoundinResultPage(String keyword)
        {

            // Sleep(4000);
            //Console.WriteLine("There are" + " " + getText(searchResultcount) +" "+  "apprenticeships matching your search for" +" " +  "'"+keyword.ToLower()+"'" + ".");
            verifyTextMessage(searchresult, "There are" + " " + GetText(searchResultcount) + " " + "apprenticeships matching your search for" + " " + "'" + keyword.ToLower() + "'" + ".");


        }

        public void verifySearchedStandardFoundinResultPage(String expected_result)
        {
            // Sleep(4000);
            Assert.True(isElementPresent(searchkeywordresult, expected_result));
        }

        public void verifyStandardinTopofList(String keyword)
        {
            //Sleep(4000);
            Assert.True(isElementPresent(firstStandardinresult, keyword));
        }

        public void VerifyresultCount()
        {

            Assert.True(GetText(searchResultcount).Contains("Total results found:"));
        }

        public void Verifylength()
        {

            Assert.True(GetText(typicallength).Contains("24 to 36 months"));
        }


        public void VerifyresultCount_invalidSearch()
        {

            Assert.True(GetText(searchResultcount).Contains("Total results found: 0"));
        }

        public void verifySearchresultMessage(String msg)
        {
            Assert.True(GetText(Invalidsearchmessage).Contains(msg));
        }

        public void Open(string standard)
        {
            driver.Navigate().GoToUrl(baseUrl + "Apprenticeship/Standard/" + standard);

        }

        public void OpenFramework(string framework)
        {
            driver.Navigate().GoToUrl(baseUrl + "Apprenticeship/Framework/" + framework);

        }


        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }




    }


}
