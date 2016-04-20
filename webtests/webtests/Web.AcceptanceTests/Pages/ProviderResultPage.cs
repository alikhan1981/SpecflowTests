﻿using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sfa.Eds.Das.Web.AcceptanceTests.Pages
{
    using Sfa.Das.WebTest.Infrastructure;

    class ProviderResultPage : BasePage
    {
        /// <summary>
        /// Purpose of this class is to 
        /// Create and maintain all Provider Page objects 
        /// Create and maintain business methods  associated to this page.
        /// </summary>
        SearchPage srchPage;

        By providerlist = By.XPath(".//*[@id='provider-results']/div[1]/div[2]/p");
        By providerlist1 = By.XPath(".//*[@id='provider-results']/div[1]/article/header/h2/a");
        By selectprovider = By.XPath(".//*[@id='provider-results']/div[1]/article[1]/header/h2/a");
        By providerwebsite = By.XPath(".//*[@id='provider-results']/div[1]/article[1]/dl/dt[2]");
        By providereSatisfaction = By.CssSelector(".employer-satisfaction");
        By providerlSatisfaction = By.CssSelector(".learner-satisfaction");
        By providerLocation = By.XPath(".//*[@id='provider-results']/div[1]/article[3]/dl/dd[2]");

        By resultItems = By.CssSelector("#provider-results .result");
        private By resultsContainer = By.Id("provider-results");

        public void WaitToLoad()
        {
            base.WaitFor(resultsContainer);
        }

        public void verifyProviderResultsPage()
        {
            Assert.True(FindElements(resultItems).Any(ElementIsDisplayed));
        }

        public void verifyProvidersearchResultsInfo(String info)
        {

            switch (info)
            {
                case "website":
                    Assert.True(isDisplayed(providerwebsite));
                    break;

                case "Employer satisfaction":
                    Assert.True(isDisplayed(providereSatisfaction));
                    break;
                case "Learner satisfaction":
                    Assert.True(isDisplayed(providerlSatisfaction));
                    break;


            }

            //Sleep(4000); added conditional wait and taken out this hard sleep. (to reduce the test exuection time)
            Assert.True(isDisplayed(providerlist));
        }

        public void chooseProvider()
        {
            click(selectprovider);
            //Sleep(3000);
        }


        public void verifyProviderinSearchResults(String p0)
        {
            Assert.True(isElementPresent(providerlist1, p0));
        }

        public void verifyProviderLocationinSearchResults(String p0)
        {
            verifyTextMessage(providerLocation, p0);
        }

        public void verifyProviderNotinSearchResults(String p0)
        {
            Assert.True(isElementNotPresent(providerlist1, p0));
        }
    }
}

