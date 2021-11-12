using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumWebdriver.Driver;
using SeleniumWebdriver;
using SeleniumWebdriver.PageObjects.Yandex;
using SeleniumWebdriver.PageObjects.MailRu;

namespace SeleniumWebDriver.Tests
{
    class NameChangeTest
    {
        private IWebDriver _webDriver;

        private User yandexUser = new User { Email = "testNo.3@yandex.by", Password = "ButThenTheyBuriedHerAlive" };
        private User mailRuUser = new User { Email = "testingqano.2@mail.ru", Password = "OneEvening1945" };
        private const string newName = "FLDOPS";

        [SetUp]
        public void Setup()
        {
            _webDriver = DriverSingleton.GetDriver();
            DriverSingleton.MaximizeWindow();
        }

        [Test]
        public void CheckIfNameChangedCorrect()
        {
            var yandexValidUser = new YandexLoginNickPageObject(_webDriver)
                .InputNick(yandexUser.Email)
                .SubmitNick()
                .InputPassword(yandexUser.Password)
                .SubmitPassword()
                .OpenUserPopUp()
                .GoToInboxPage()
                .OpenSpamTab()
                .OpenNewestLetter()
                .InputLetterReply(newName)
                .SendReply()
                .ConfirmReplySuccess();

            //Unexpected alert open: { Alert text: }
            //System.Threading.Thread.Sleep(500);
            var mailRuValidUser = new MailRuAuthorizationEmailPageObject(_webDriver)
                .InputEmail(mailRuUser.Email)
                .SubmitEmail()
                .InputPassword(mailRuUser.Password)
                .SubmitPassword()
                .OpenReply();
            string recievedName = mailRuValidUser.GetReplyText();
            var actualName = mailRuValidUser
                .OpenProfilePopUp()
                .EnterProfileEditor()
                .InputNewNick(recievedName)
                .SaveChanges()
                .GetNickname();

            Assert.AreEqual(newName, actualName);
        }

        [TearDown]
        public void QuitDriver()
        {
            DriverSingleton.CloseDriver();
        }
    }
}
