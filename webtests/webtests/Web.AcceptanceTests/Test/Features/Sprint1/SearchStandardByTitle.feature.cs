﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sfa.Eds.Das.Web.AcceptanceTests.Test.Features.Sprint1
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Search standards by title")]
    public partial class SearchStandardsByTitleFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SearchStandardByTitle.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Search standards by title", "In order to choose an apprenticeship\r\nAs an employer \r\nI want to be able to Searc" +
                    "h by title", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search By title1")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        [NUnit.Framework.TestCaseAttribute("Actuarial Technician", null)]
        public virtual void SearchByTitle1(string title, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "smoke"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search By title1", @__tags);
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("I am on Search landing page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.And(string.Format("I enter keyword \'{0}\' in search box", title), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.When("I click on search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then(string.Format("I should see matching \'{0}\' standards on result page", title), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search By title")]
        [NUnit.Framework.CategoryAttribute("regression")]
        [NUnit.Framework.TestCaseAttribute("actuarial technician", "Actuarial Technician", null)]
        [NUnit.Framework.TestCaseAttribute("financial adviser", "Financial Services Customer Adviser", null)]
        [NUnit.Framework.TestCaseAttribute("software engineer", "Aerospace Software Development Engineer", null)]
        [NUnit.Framework.TestCaseAttribute("car mechanic", "Motor Vehicle Service and Maintenance Technician [light vehicle]", null)]
        [NUnit.Framework.TestCaseAttribute("manufacturing engineer", "Aerospace Engineer", null)]
        [NUnit.Framework.TestCaseAttribute("manager", "Senior Housing Property Management", null)]
        [NUnit.Framework.TestCaseAttribute("legal services", "Legal Services: Criminal Prosecution", null)]
        [NUnit.Framework.TestCaseAttribute("designer", "Design: Design", null)]
        [NUnit.Framework.TestCaseAttribute("dental nurse", "Dental Nurse", null)]
        [NUnit.Framework.TestCaseAttribute("electrician", "Installation Electrician/Maintenance Electrician", null)]
        public virtual void SearchByTitle(string title, string expected, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "regression"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search By title", @__tags);
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
 testRunner.Given("I am on Search landing page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
 testRunner.And(string.Format("I enter keyword \'{0}\' in search box", title), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.When("I click on search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then(string.Format("I should see matching \'{0}\' standards on result page", expected), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Standards searched to display level informaiton")]
        [NUnit.Framework.IgnoreAttribute()]
        public virtual void StandardsSearchedToDisplayLevelInformaiton()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Standards searched to display level informaiton", new string[] {
                        "ignore"});
#line 38
this.ScenarioSetup(scenarioInfo);
#line 39
testRunner.Given("I am on Search landing page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 40
testRunner.And("I enter keyword \'{p0}\' in search box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
testRunner.When("I click on search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
testRunner.Then("I should see level information againts again standards found", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
