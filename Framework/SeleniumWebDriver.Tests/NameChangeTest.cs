using NUnit.Framework;
using SeleniumWebdriver.PageObjects.Yandex;
using SeleniumWebdriver.PageObjects.MailRu;
using SeleniumWebdriver.Models;
using SeleniumWebdriver.Service;

namespace SeleniumWebDriver.Tests
{
    class NameChangeTest : BaseTest
    {
        private User yandexUser = UserCreator.CreateValidYandexUser();
        private User mailRuUser = UserCreator.CreateValidMailRuUser();
        private Letter replyToMailRu = LetterCreator.CreateReplyToMailRu();

        [Category("All")]
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
                .InputLetterReply(replyToMailRu.Text)
                .SendReply()
                .ConfirmReplySuccess();

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

            Assert.AreEqual(replyToMailRu.Text, actualName);
        }
    }
}
