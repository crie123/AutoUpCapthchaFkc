using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace ConsoleApp1
{
    public partial class Names : ConsoleComms
    {
        protected readonly By _signinButton = By.XPath("/html/body/div[5]/div/div[2]/ul/li[2]/a");
        protected readonly By _mailSelector = By.XPath("/html/body/div[2]/div[2]/div[1]/div[1]/div[2]/a");
        protected readonly By _mailField = By.XPath("//*[@id='email']");
        protected readonly By _captchaCheckbox = By.XPath("//iframe[starts-with(@name, 'a-') and starts-with(@src, 'https://www.google.com/recaptcha')]");
        protected readonly By _goOn = By.XPath("//*[@id='check-user']");
        protected readonly By _passwordField = By.XPath("//*[@id='password']");
        protected readonly By _enterButton = By.XPath("//*[@id='login']");
        protected readonly By _personalSpace = By.XPath("/html/body/div[5]/div/div[2]/ul/li[5]/a[2]");
        protected readonly By _postUpdate = By.XPath("/html/body/div[7]/div[1]/div[4]/div[2]/div/div[4]/div[2]/a");
        protected readonly By _quitAcc = By.XPath("/html/body/div[7]/div[1]/div[3]/div[3]/div/ul/li[7]/a");

        protected string _mail = "";
        protected string _pass = "";

    }
}
