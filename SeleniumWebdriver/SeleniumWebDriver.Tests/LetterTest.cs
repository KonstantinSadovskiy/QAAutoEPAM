using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumWebdriver.Driver;
using SeleniumWebdriver;
using SeleniumWebdriver.PageObjects.Yandex;
using SeleniumWebdriver.PageObjects.MailRu;

namespace SeleniumWebDriver.Tests
{
    class LetterTest
    {
        private IWebDriver _webDriver;

        private User yandexUser = new User{Email = "testNo.3@yandex.by", Password = "ButThenTheyBuriedHerAlive"};
        private User mailRuUser = new User { Email = "testingqano.2@mail.ru", Password = "OneEvening1945" };
        private string letterTheme = "WebDriver - Test";
        private string letterText = "Neutral Milk Hotel — музыкальный коллектив из США, основанный в 1991 году Джеффом Мэнгамом и исполнявший эклектичный lo-fi/психоделический фолк.\n" +
                                    "Группа известна своими экспериментами со звуком, абстрактными поэтичными текстами и широким разнообразием используемых инструментов.";

        [SetUp]
        public void Setup()
        {
            _webDriver = DriverSingleton.GetDriver();
            DriverSingleton.MaximizeWindow();
        }

        [Test]
        public void CheckLetter()
        {
            string expectedText = letterText + "\n  ";

            var mailRuEmailPage = new MailRuAuthorizationEmailPageObject(_webDriver)
                .InputEmail(mailRuUser.Email)
                .SubmitEmail()
                .InputPassword(mailRuUser.Password)
                .SubmitPassword()
                .CreateLetter()
                .InputRecieverMail(yandexUser.Email)
                .InputLetterTheme(letterTheme)
                .InputLetterText(letterText)
                .SendLetter()
                .CloseConfirmationWindow();

            var actualText = new YandexLoginNickPageObject(_webDriver)
                .InputNick(yandexUser.Email)
                .SubmitNick()
                .InputPassword(yandexUser.Password)
                .SubmitPassword()
                .OpenUserPopUp()
                .GoToInboxPage()
                .OpenSpamTab()
                .OpenNewestUnreadLetter()
                .GetLetterText()
                .Replace("\r", "");
                
            Assert.IsTrue(actualText == expectedText);
        }

        [TearDown]
        public void QuitDriver()
        {
            DriverSingleton.CloseDriver();
        }
    }
}
