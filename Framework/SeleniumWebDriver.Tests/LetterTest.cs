using NUnit.Framework;
using SeleniumWebdriver.PageObjects.Yandex;
using SeleniumWebdriver.PageObjects.MailRu;
using SeleniumWebdriver.Models;
using SeleniumWebdriver.Service;

namespace SeleniumWebDriver.Tests
{
    class LetterTest : BaseTest
    {
        private User yandexUser = UserCreator.CreateValidYandexUser();
        private User mailRuUser = UserCreator.CreateValidMailRuUser();
        private Letter letterToYandex = LetterCreator.CreateLetterToYandex();

        [Category("All")]
        [Test]
        public void CheckLetter()
        {
            string expectedText = letterToYandex.Text + "\n  ";

            var mailRuEmailPage = new MailRuAuthorizationEmailPageObject(_webDriver)
                .InputEmail(mailRuUser.Email)
                .SubmitEmail()
                .InputPassword(mailRuUser.Password)
                .SubmitPassword()
                .CreateLetter()
                .InputRecieverMail(letterToYandex.Reciever)
                .InputLetterTheme(letterToYandex.Theme)
                .InputLetterText(letterToYandex.Text)
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
    }
}
