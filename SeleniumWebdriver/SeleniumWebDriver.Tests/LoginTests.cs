using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumWebdriver.Driver;
using SeleniumWebdriver;
using SeleniumWebdriver.PageObjects.Yandex;
using SeleniumWebdriver.PageObjects.MailRu;

namespace SeleniumWebDriver.Tests
{
    public class LoginTests
    {
        private IWebDriver _webDriver;

        private User fakeUser = new User("itsahahahahafake", "fakefake");
        private User yandexUser = new User("testNo.3@yandex.by", "ButThenTheyBuriedHerAlive");
        private User mailRuUser = new User("testingqano.2@mail.ru", "OneEvening1945");

        [SetUp]
        public void Setup()
        {
            _webDriver = DriverSingleton.GetDriver();
            DriverSingleton.MaximizeWindow();
        }

        [Test]
        public void LoginYandex()
        {
            var actualPage = new YandexLoginNickPageObject(_webDriver)
                .InputNick(yandexUser.Email)
                .SubmitNick()
                .InputPassword(yandexUser.Password)
                .SubmitPassword();

            Assert.IsTrue(actualPage is YandexProfilePageObject);
        }

        [Test]
        public void LoginMailRu()
        {
            var actualPage = new MailRuAuthorizationEmailPageObject(_webDriver)
                .InputEmail(mailRuUser.Email)
                .SubmitEmail()
                .InputPassword(mailRuUser.Password)
                .SubmitPassword();

            Assert.IsTrue(actualPage is MailRuInboxPageObject);
        }

        [Test]
        public void EmptyEmailMailRu()
        {
            string errorMessage = "The \"Account name\" field is required";

            string actualMessage = new MailRuAuthorizationEmailPageObject(_webDriver)
                .SubmitEmailExpectedError()
                .GetEmptyEmailMessageText();

            Assert.AreEqual(actualMessage, errorMessage);
        }

        [Test]
        public void WrongEmailMailRu()
        {
            string errorMessage = "That account is not registered";

            string actualMessage = new MailRuAuthorizationEmailPageObject(_webDriver)
                .InputEmail(fakeUser.Email)
                .SubmitEmailExpectedError()
                .GetWrongEmailMessageText();

            Assert.AreEqual(actualMessage, errorMessage);
        }

        [Test]
        public void EmptyPasswordMailRu()
        {
            string errorMessage = "The \"Password\" field is required";

            string actualMessage = new MailRuAuthorizationEmailPageObject(_webDriver)
                .InputEmail(mailRuUser.Email)
                .SubmitEmail()
                .SubmitPasswordExpectedError()
                .GetWrongPasswordMessageText();

            Assert.AreEqual(actualMessage, errorMessage);
        }

        [Test]
        public void WrongPasswordMailRu()
        {
            string errorMessage = "Incorrect password. Try again";

            string actualMessage = new MailRuAuthorizationEmailPageObject(_webDriver)
                .InputEmail(mailRuUser.Email)
                .SubmitEmail()
                .InputPassword(fakeUser.Password)
                .SubmitPasswordExpectedError()
                .GetWrongPasswordMessageText();

            Assert.AreEqual(actualMessage, errorMessage);
        }

        [TearDown]
        public void QuitDriver()
        {
            DriverSingleton.CloseDriver();
        }
    }
}