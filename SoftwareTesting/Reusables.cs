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
    public class Reusables : Test_Base.Base
    {

        public Reusables(RemoteWebDriver driver) : base(driver) { }
           
        public void test()
        {
            Test_Cases test = new Test_Cases(driver);
            //test.Login(Constants.empty_username, Constants.empty_password);
            //test.Login(Constants.empty_username, Constants.password);
            //test.Login(Constants.wrong_username, Constants.password);
            test.Login(Constants.username, Constants.password);
        }
    }
}
