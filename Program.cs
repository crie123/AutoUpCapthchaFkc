
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //вызов ввода почты и пароля
            ConsoleComms consoleComms = new ConsoleComms();
            consoleComms.Data();
            //вызов основы
            AutoLoginExec test = new AutoLoginExec();
            test.OpenUp();
            consoleComms = new ConsoleComms();
        }
    }
    public class AutoLoginExec : Names
    {
        public void OpenUp()
        {
            // creating Browser Instance
            FirefoxOptions options = new FirefoxOptions();
            WebDriver driver = new FirefoxDriver("C:\\", options);
            //Maximizing the Browser
            driver.Manage().Window.Maximize();
            // Opening the URL
            driver.Navigate().GoToUrl("https://www.example.com");
            // Locate sign in
            var signIn = driver.FindElement(_signinButton);
            signIn.Click();
            // Select mail
            var mailSelector = driver.FindElement(_mailSelector);
            mailSelector.Click();
            Thread.Sleep(1000);
            // Insert mail
            var insertMail = driver.FindElement(_mailField);
            insertMail.SendKeys(_mail);
            // Captcha checkbox click
            Thread.Sleep(7000);
            var captchaCheckbox = driver.FindElement(_captchaCheckbox);
            captchaCheckbox.Click();
            //Say go on
            var buttonGoOn = driver.FindElement(_goOn);
            Thread.Sleep(30000);
            buttonGoOn.Click();
            // Password insert
            var insertPassword = driver.FindElement(_passwordField);
            Thread.Sleep(1000);
            insertPassword.SendKeys(_pass);
            //Click enter
            var enter = driver.FindElement(_enterButton);
            enter.Click();
            Thread.Sleep(3000);
            //Click personal space
            var personalSpace = driver.FindElement(_personalSpace);
            personalSpace.Click();
            Thread.Sleep(1500);
            //Click post update
            var postUpdate = driver.FindElement(_postUpdate);
            postUpdate.Click();
            //Quit acc
            var quitAcc = driver.FindElement(_quitAcc);
            quitAcc.Click();
        }

    }
}
