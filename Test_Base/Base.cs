using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Remote;


namespace Test_Base
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
