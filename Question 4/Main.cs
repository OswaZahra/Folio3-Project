using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class Main
    {
        //IWebDriver driver = new ChromeDriver();
        SearchFunctionality testSearchFunctionality = new SearchFunctionality();
        
        [TestMethod]
        public void TestMethod1()
        {
            Core_Page.SeleniumInit();
            testSearchFunctionality.Test("https://www.airblue.com/");
            Core_Page.driver.Close();
        }
        [TestMethod]
        public void TestMethod2()
        {

            Core_Page.SeleniumInit();
            testSearchFunctionality.Test2("https://www.airblue.com/");
            Core_Page.driver.Close();
        }



    }
}
