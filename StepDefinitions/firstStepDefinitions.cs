using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public  class firstStepDefinitions
    {
        IWebDriver driver = null;

        public firstStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }


        [Given(@"user is on Google Page")]
        public void googlaunch()
        {
         
            driver.Navigate().GoToUrl("https://google.com");
        }


        [When(@"user search for a product")]
        public void searchProd()
        {
            driver.FindElement(By.Name("q")).SendKeys("Revisiting Selenium C#");
            Thread.Sleep(3000);
        }


        [Then(@"the search operation should be successful")]
        public void CloseGoogle()
        {
            //driver.Close();
        }

    }
}
