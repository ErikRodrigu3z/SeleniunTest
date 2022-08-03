using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Login()
        {
            string path = Environment.CurrentDirectory + @"\Drivers";
            try
            {
                ChromeDriver driver = new ChromeDriver(path);
                driver.Navigate().GoToUrl("https://www.facebook.com/");
                               
                //User input
                IWebElement userInput = driver.FindElement(By.Id("email"));
                userInput.SendKeys("prueba@gmail.com");

                //password input
                IWebElement password = driver.FindElement(By.Id("pass"));
                password.SendKeys("Erik1234.");

                //submit button
                Thread.Sleep(1000);
                IWebElement siguiente = driver.FindElement(By.Name("login"));
                siguiente.Submit();

                Assert.Pass("OK");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

            
        }
    }
}