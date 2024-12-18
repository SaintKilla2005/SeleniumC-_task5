using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
namespace Lab5Selenium
{
 

    public class Tests
        {
        private IWebDriver driver;
        private readonly By _signInButton = By.XPath("//span[text()='Войти']"); 
        private readonly By _secondButton = By.CssSelector("body > div._25d45facb5--overlay--nBBXF > div > div > div._25d45facb5--body--BXqWC > div > div > div > div._25d45facb5--row--wlZQo > div > form > div._25d45facb5--buttons--f0vot > button._25d45facb5--button--KVooB._25d45facb5--button--gs5R_._25d45facb5--M--I5Xj6._25d45facb5--button--jsxTC._25d45facb5--full-width--LjV3t > span");
        private readonly By _AuthInputButton = By.XPath("//input[@name='username']");
        private readonly By _continueButton = By.CssSelector("body > div._25d45facb5--overlay--nBBXF > div > div > div._25d45facb5--body--BXqWC > div > div > div > div._25d45facb5--row--wlZQo > div > form > div._25d45facb5--buttons--f0vot > button._25d45facb5--button--KVooB._25d45facb5--button--gs5R_._25d45facb5--M--I5Xj6._25d45facb5--button--wvpRY._25d45facb5--full-width--LjV3t > span");
        private readonly By _passwordButton = By.CssSelector("body > div._25d45facb5--overlay--nBBXF > div > div > div._25d45facb5--body--BXqWC > div > div > div > div._25d45facb5--row--wlZQo > div > form > div._25d45facb5--cont--mcZXH > div:nth-child(2) > div > input");
        private readonly By _finalcontinueButton = By.CssSelector("body > div._25d45facb5--overlay--nBBXF > div > div > div._25d45facb5--body--BXqWC > div > div > div > div._25d45facb5--row--wlZQo > div > form > div._25d45facb5--buttons--f0vot > button");
        private readonly By _postAnAd = By.CssSelector("#header-frontend > div > div._25d45facb5--wrapper--LQPOO._25d45facb5--static--KWF5p > div:nth-child(1) > div > div._25d45facb5--place--MmHod > a > span");
        private const string _login = "leshadychenko@mail.ru";
        private const string _password = "leshalesha1234";

        [SetUp]
            public void Setup()
            {
            //В методе под атрибутом SetUp происходит то, что будет перед тестом 
            //в скобках прописываем инициализацию экземпляров (их вызов), переходим на веб-страницу.
                driver = new OpenQA.Selenium.Chrome.ChromeDriver();
                driver.Navigate().GoToUrl("https://cian.ru");
                driver.Manage().Window.Maximize();
            }

            [Test]
            public void Test1() //В атрибуте Test прописываем, что мы проверяем (действия, переходы, вкладки, подсчеты и т.д. Например:[Test, Description("My really really cool test")])
            {
                var singIn = driver.FindElement(_signInButton);
                singIn.Click();
                Thread.Sleep(1000);
                var anotherWay = driver.FindElement(_secondButton);
                anotherWay.Click();
                Thread.Sleep(1000);
                var login = driver.FindElement(_AuthInputButton);
                login.SendKeys(_login);
                Thread.Sleep(1000);
                var continueButton = driver.FindElement(_continueButton);
                continueButton.Click();
                Thread.Sleep(1000);
                var textboxpswd = driver.FindElement(_passwordButton);
                textboxpswd.SendKeys(_password);
                Thread.Sleep(1000);
                var finalcontinuebutton = driver.FindElement(_finalcontinueButton);
                finalcontinuebutton.Click();
            Thread.Sleep(4000);
        }

        [Test]
        public void Test2() { 

        }

            [TearDown]
            //закрытие веб браузера
            public void TearDown() //Метод TearDown вызывается после прохождения тестов. Здесь происходит закрытие веб-приложений
            {

            driver.Close();
            }

        }
    

}