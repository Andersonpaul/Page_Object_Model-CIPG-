using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Test_Base //This base class is meant for inheritance by all classes requiring a RemoteWebDriver instance.
{
    
    public class Base
    {
       public RemoteWebDriver driver;
       
        public Base(RemoteWebDriver driver)
        {
            this.driver = driver;
        }
       
    }
}
