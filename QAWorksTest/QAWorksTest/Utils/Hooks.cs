using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace QAWorksTest.Utils
{
    [Binding]
    public sealed class Hooks
    {

        static IWebDriver localDriver;
        static RemoteWebDriver driver; // used to run test on saucelabs or browserstack tool.
        //load from app.config
        static string host = ConfigurationManager.AppSettings["host"];
        static string baseurl = ConfigurationManager.AppSettings["baseUrl"];
        static string testExecution = ConfigurationManager.AppSettings["testExecutionType"];
        //public static CustomRemoteDriver driver { get; private set; }

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks


        [BeforeFeature]
        public static void BeforeFeatureRun()
        {
            
                Console.Write("#####################  Feature Run- Started  ######################");
                Console.Write("Feature : " + FeatureContext.Current.FeatureInfo.Title);

                if (testExecution == "headless") // headlessrun is performed on deployment server.
                {
                    localDriver = new PhantomJSDriver();
                    FeatureContext.Current["driver"] = localDriver;
                }
                else
                {
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();

                }


            

        }

        [BeforeScenario]

        public static void BeforeWebScenario()
        {
           

                ScenarioContext.Current["driver"] = localDriver;
                Console.Write("Test Scenario ##### : " + ScenarioContext.Current.ScenarioInfo.Title);
           

        }

        [AfterScenario]
        public static void AfterWebScenario()
        {
            //do nothing



        }

        [AfterFeature()]
        public static void AfterFeatureRun()
        {


            // Console.Write($ "######################Feature "+ { FeatureContext.Current.FeatureInfo'}'+" Run-Ended #######################");

            localDriver.Quit(); // kill driver after feature run.

        }

    }

}

