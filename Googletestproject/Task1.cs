using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Googletestproject
{
    class Demos
    {
        IWebDriver driver;

        [SetUp]

        public void Setup()
        {
            driver = new ChromeDriver("C:/Users/Rytses/source/repos");
            driver.Manage().Window.FullScreen();
        }

        string username = "rytis.seskevicius@gmail.com";
        string password = "Labaslabas123";
        public void goToUrl()
        {
            driver.Url = "http://automationpractice.com/index.php";
        }
        public void Login(string username, string password)
        {
            goToUrl();
            driver.FindElement(By.ClassName("login")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.Id("email")).SendKeys(username);
            driver.FindElement(By.Id("passwd")).SendKeys(password);
            Thread.Sleep(2000);

            driver.FindElement(By.Id("SubmitLogin")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.Id("header_logo")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.ClassName("ajax_add_to_cart_button")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.ClassName("button-medium")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.ClassName("standard-checkout")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.Name("processAddress")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.Id("cgv")).Click();
            driver.FindElement(By.ClassName("standard-checkout")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.ClassName("bankwire")).Click();
            Thread.Sleep(4000);

            driver.FindElement(By.Id("cart_navigation")).FindElement(By.ClassName("button-medium")).Click();
            Thread.Sleep(2000);
        }

        [Test]

        public void ValidTest()
        {
            Login("rytis.seskevicius@gmail.com", "Labaslabas123");
        }  
        
    }
}
