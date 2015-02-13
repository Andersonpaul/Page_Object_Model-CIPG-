using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using Test_Base;


namespace Home_Page
{
    public class Test11 : Test_Base.Base
    {

        public Test11(RemoteWebDriver driver) : base(driver) { }
       
        public void start(string str)
        {
            driver.FindElement(By.XPath(str)).Click();
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(600));         
        }
    }
}
