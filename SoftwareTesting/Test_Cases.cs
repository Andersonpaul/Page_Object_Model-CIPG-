using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Test_Base;

namespace SoftwareTesting
{
    public class Test_Cases : Test_Base.Base
    {

        public Test_Cases(RemoteWebDriver driver) : base(driver) { }
        
        public void Login(string username,string password)
        {
            //driver.FindElement(By.Id("Login1_UserName")).Clear();
            //driver.FindElement(By.Id("Login1_Password")).Clear();
            driver.FindElement(By.Id("Login1_UserName")).SendKeys(username);
            driver.FindElement(By.Id("Login1_Password")).SendKeys(password);
            driver.FindElement(By.Id("Login1_LoginButton")).Click();
        }
    }
}
