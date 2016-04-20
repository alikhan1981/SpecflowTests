using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.PageObjects;

namespace QAWorksTest.Pages
{

    public class ContactPage : BasePage
    {

        [FindsBy(How = How.Id, Using = "ctl00_MainContent_NameBox")]
        public IWebElement name { get; set; }


        [FindsBy(How = How.Id, Using = "ctl00_MainContent_EmailBox")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_MainContent_NameBox")]
        public IWebElement submit { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_MainContent_MessageBox")]
        public IWebElement message { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='menu']/li[1]/a")]
        public IWebElement contactlink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_MainContent_SendButton']")]
        public IWebElement errObj { get; set; }


        //public By name => By.Id("ctl00_MainContent_NameBox");

        //public By email => By.Id("ctl00_MainContent_EmailBox");

        //public By message => By.Id("ctl00_MainContent_MessageBox");

        //public By submit => By.Id("ctl00_MainContent_SendButton");

        // By name = By.Id("ctl00_MainContent_NameBox");
        // By email = By.Id("ctl00_MainContent_EmailBox");
        // By message = By.Id("ctl00_MainContent_MessageBox");
        // By submit = By.Id("ctl00_MainContent_SendButton");
        // By contactlink = By.XPath(".//*[@id='menu']/li[1]/a");
        // By errObj = By.XPath(".//*[@id='ctl00_MainContent_SendButton']");


        public void navigateHomePage()
        {
            Launch("Home Page - QAWorks");
        }

        public void goToContactpage()
        {
            contactlink.Click();
        }

        public void entervalue(String text, String field)
        {
            switch (field)
            {
                case "email":
                    email.SendKeys(text);
                    break;

                case "name":
                    name.SendKeys(text);
                    break;

                case "message":
                    message.SendKeys(text);
                    break;
            }


        }

        public void clickSubmit()
        {
            submit.Click();

        }

        public void verifyErrormessage(String errinfo)
        {
            verifyTextMessage(errObj, errinfo);
        }
        public void fillinContactPageForm(Table datatable)
        {
            foreach (var row in datatable.Rows)
            {
                //var selector = datatable.row[0];
                find(By.Id(row[0])).SendKeys(row[1]);
                //click(submit); as staging not responding so used prod url hence submit step is commented.
            }

        }


    }
}