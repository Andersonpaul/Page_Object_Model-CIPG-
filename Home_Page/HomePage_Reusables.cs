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
    public class Reusables1 : Test_Base.Base
    {

        public Reusables1(RemoteWebDriver driver) : base(driver) { }
        
        public void reusables1()
        {
            Test11 obj = new Test11(driver);           
            obj.start(Links.xpath1);
            obj.start(Links.xpath2);
            obj.start(Links.xpath3);
            obj.start(Links.xpath4);
        }
    }
}
