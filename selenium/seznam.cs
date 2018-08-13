using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;



namespace selenium
{
    public class Seznam
    {
     public static void Prihlas(string jmeno, string heslo)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.seznam.cz");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.FindElement(By.ClassName("expander__button")).Click();


            IWebElement username = driver.FindElement(By.ClassName("login-form__input-wrap"));
            username.SendKeys(jmeno);

            IWebElement password = driver.FindElement(By.ClassName("input-w-button__input-wrap"));
            password.SendKeys(heslo);
            //driver.FindElement(By.XPath("//*[@id='hp - app']/div/div[1]/div[2]/div/div/div[4]/div[2]/div/div/div[2]/div[1]/div/div/div/div[2]/div/div[2]/form/div[2]/div/button")).Click();
            password.SendKeys(Keys.Enter);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='user']/button")).Click();
            driver.FindElement(By.LinkText("Odhlásit se")).Click();
        }


    }
}
