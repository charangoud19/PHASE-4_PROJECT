using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LoginwithSpecFlow.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        public IWebDriver driver;
        [Given(@"User is at the Login Page")]
        public void GivenUserIsAtTheLoginPage()
        {
            driver = new ChromeDriver();
            driver.Url = "http://localhost:51434/";
        }
        [When(@"User enter '([^']*)' and '([^']*)'")]
        public void WhenUserEnterAnd(string charan, string indra)
        {
            driver.FindElement(By.Id("username")).SendKeys("charan");
            driver.FindElement(By.Id("password")).SendKeys("indra");
        }

        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[2]/form/div/center/div/div[7]/div/input")).Click();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {

        }
    }
}