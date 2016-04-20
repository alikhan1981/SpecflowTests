using QAWorksTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace QAWorksTest.StepDefinitions
{
    [Binding]
    public class ContactUsPageSteps
    {

        ContactPage contPage;

        public ContactUsPageSteps()
        {
            contPage = new ContactPage();
        }

        [Given(@"I am on the QAWorks Staging Site")]
        public void GivenIAmOnTheQAWorksStagingSite()
        {
            contPage.navigateHomePage();
        }

        [When(@"I am on Contactus page")]
        public void WhenIAmOnContactusPage()
        {

            
            contPage.goToContactpage();
        }
        [When(@"I enter invalid email '(.*)'")]
        public void WhenIEnterInvalidEmail(string p0, string email)
        {
            contPage.entervalue(p0, email);
        }

        [When(@"I enter name ""(.*)""")]
        public void WhenIEnterName(string p0, string name)
        {
            contPage.entervalue(p0, name);
        }

        [When(@"I enter message ""(.*)""")]
        public void WhenIEnterMessage(string p0, String message)
        {
            contPage.entervalue(p0, message);
        }

        [When(@"I submit form")]
        public void WhenISubmitForm()
        {
            contPage.clickSubmit();
        }

        [When(@"I leave name field empty")]

        [When(@"I leave email address field empty")]
        [When(@"I leave message field empty")]
        [Then(@"I should be able to contact QAWorks with the following information")]
        public void WhenILeaveEmailAddressFieldEmpty(Table table)
        {
            contPage.fillinContactPageForm(table);
        }


        [Then(@"I should see error message as ""(.*)""")]
        public void ThenIShouldSeeErrorMessageAs(string p0)
        {
            contPage.verifyErrormessage(p0);

        }



    }
}
