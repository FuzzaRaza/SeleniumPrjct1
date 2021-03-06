﻿using System;
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
            page.FindElement(By.Id("resetBtn")).Click();
            page.FindElement(By.Id("btnAdd")).Click();
            page.FindElement(By.Id("systemUser_userType")).SendKeys("Admin");
            page.FindElement(By.Id("systemUser_employeeName_empName")).SendKeys("Tester");
            page.FindElement(By.Id("btnCancel")).Click();
            page.FindElement(By.Id("menu_admin_Job")).Click();
            page.FindElement(By.Id("menu_admin_viewJobTitleList")).Click();
            page.FindElement(By.Id("btnAdd")).Click();
            page.FindElement(By.Id("jobTitle_jobTitle")).SendKeys("Assistant Manager");
            page.FindElement(By.Id("jobTitle_jobDescription")).SendKeys("Managerial Position");
            page.FindElement(By.Id("jobTitle_note")).SendKeys("Best of luck!!!");
            page.FindElement(By.Id("btnSave")).Click();
            //Assert.AreEqual("")

        }
        [TestMethod]
        public void Logout()
        {
            IWebDriver page = new ChromeDriver();
            page.Url = "https://opensource-demo.orangehrmlive.com/";
            page.Manage().Window.Maximize();
            page.FindElement(By.Id("txtUsername")).SendKeys("Admin");
            page.FindElement(By.Id("txtPassword")).SendKeys("admin123");
            page.FindElement(By.Id("btnLogin")).Click();
            //page.FindElement(By.Id("Mp_btn")).Click();
            //Assert.AreEqual("")
            page.FindElement(By.Id("welcome")).Click();
            page.FindElement(By.XPath("//*[@Logout]")).Click();
        }
    }
}
