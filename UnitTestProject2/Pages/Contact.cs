using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2.Pages
{
    class Contact
    {

        IWebDriver driver;// = new ChromeDriver();
        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void OpenTest()
        {
            driver.Navigate().GoToUrl("https://www.ebiquity.com/en");
            Console.WriteLine("Opened URL");
        }
        [TearDown]
        public void EndTest()
        {
            driver.Close();
            /*
            //Find the Element and click on contact page 
            IWebElement element = driver.FindElement(By.Id("contact"));

            //element.driver.FindElement(By.Id("contact")).Click();

            //How can we help
            element.FindElement(By.Id("00Nw0000008iSjb")).SendKeys("Sales Inquiry");

            //Email
            element.FindElement(By.Id("email")).SendKeys("Test@gmail.com");

            //Fname
            element.FindElement(By.Id("first_name")).SendKeys("Hiren");

            //Sname
            element.FindElement(By.Id("last_name")).SendKeys("Moghe");

            //company
            element.FindElement(By.Id("company")).SendKeys("ABC Ltd");

            //jobtitle
            element.FindElement(By.Id("title")).SendKeys("SalesManager");

            //Business Area
            element.FindElement(By.CssSelector("option[value='4']")); 

            //phone number
            element.FindElement(By.Id("phone")).SendKeys("0785245675");

            //Your region
            element.FindElement(By.CssSelector("option[value='9']"));

            //Phone no
            element.FindElement(By.Id("00Nw0000008iSjJ")).SendKeys("0785245675");

            //Email no
            element.FindElement(By.Id("00Nw0000008iSjI")).SendKeys("Test@gmail.com");

            //Contact Submit
            element.FindElement(By.Id("contactSubmit")).Click();
            */
            
        }

       
    }
}

