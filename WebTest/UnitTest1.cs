using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;


namespace WebTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Login()
        {
              IWebDriver page = new ChromeDriver();
            page.Url = "https://opensource-demo.orangehrmlive.com/";
            page.Manage().Window.Maximize();
            page.FindElement(By.Id("txtUsername")).SendKeys("Admin");
            page.FindElement(By.Id("txtPassword")).SendKeys("admin123");
            page.FindElement(By.Id("btnLogin")).Click();

            page.FindElement(By.Id("menu_admin_viewAdminModule")).Click();
            //search tab accessing
            page.FindElement(By.Id("searchSystemUser_userName")).SendKeys("Admin");
            
            //page.FindElement(By.Id("searchSystemUser_userType")).SendKeys("All");
            //Drop down function
            var drpdwn = page.FindElement(By.Id("searchSystemUser_userType"));
            //selecting object
            var drpdwnObj = new SelectElement(drpdwn);
            drpdwnObj.SelectByText("Admin");
            page.FindElement(By.Id("searchBtn")).Click();
            page.FindElement(By.Id("btnAdd")).Click();
            page.FindElement(By.Id("systemUser_userType")).SendKeys("Admin");
            page.FindElement(By.Id("systemUser_employeeName_empName")).SendKeys("Tester");
             
             //Assert.AreEqual("")
             
        }
        [TestMethod]
        public void Logout()
        {
            //IWebDriver page = new ChromeDriver();
            //page.Url = "https://opensource-demo.orangehrmlive.com/";
            //page.FindElement(By.Id("Mp_btn")).Click();
            //Assert.AreEqual("")
            //page.FindElement(By.Id("welcome-menu")).Click();

        }
    }
}
