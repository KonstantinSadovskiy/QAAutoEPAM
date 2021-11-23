using NUnit.Framework;
using SeleniumWebdriver.PageObjects.Yandex;
using SeleniumWebdriver.PageObjects.MailRu;
using SeleniumWebdriver.Models;
using SeleniumWebdriver.Service;

namespace SeleniumWebDriver.Tests
{
    public class LoginTests : BaseTest
    {
        private User fakeMailRuUser = UserCreator.CreateNotExistingMailRuUser();
        private User yandexUser = UserCreator.CreateValidYandexUser();
        private User mailRuUser = UserCreator.CreateValidMailRuUser();
        private User mailRuEmptyPasswordUser = UserCreator.CreateEmptyPasswordMailRuUser();
        private User mailRuWrongPasswordUser = UserCreator.CreateWrongPasswordMailRuUser();

        [Category("All")]
        [Category("Smoke")]
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

        [Category("All")]
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

        [Category("All")]
        [Category("Smoke")]
        [Test]
        public void EmptyEmailMailRu()
        {
            string errorMessage = "The \"Account name\" field is required";

            string actualMessage = new MailRuAuthorizationEmailPageObject(_webDriver)
                .SubmitEmailExpectedError()
                .GetEmptyEmailMessageText();

            Assert.AreEqual(actualMessage, errorMessage);
        }

        [Category("All")]
        [Test]
        public void WrongEmailMailRu()
        {
            string errorMessage = "That account is not registered";

            string actualMessage = new MailRuAuthorizationEmailPageObject(_webDriver)
                .InputEmail(fakeMailRuUser.Email)
                .SubmitEmailExpectedError()
                .GetWrongEmailMessageText();

            Assert.AreEqual(actualMessage, errorMessage);
        }

        [Category("All")]
        [Test]
        public void EmptyPasswordMailRu()
        {
            string errorMessage = "The \"Password\" field is required";

            string actualMessage = new MailRuAuthorizationEmailPageObject(_webDriver)
                .InputEmail(mailRuEmptyPasswordUser.Email)
                .SubmitEmail()
                .SubmitPasswordExpectedError()
                .GetWrongPasswordMessageText();

            Assert.AreEqual(actualMessage, errorMessage);
        }

        [Category("All")]
        [Test]
        public void WrongPasswordMailRu()
        {
            string errorMessage = "Incorrect password. Try again";

            string actualMessage = new MailRuAuthorizationEmailPageObject(_webDriver)
                .InputEmail(mailRuWrongPasswordUser.Email)
                .SubmitEmail()
                .InputPassword(mailRuWrongPasswordUser.Password)
                .SubmitPasswordExpectedError()
                .GetWrongPasswordMessageText();

            Assert.AreEqual(actualMessage, errorMessage);
        }
    }
}