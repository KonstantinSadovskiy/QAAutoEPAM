using SeleniumWebdriver.Models;

namespace SeleniumWebdriver.Service
{
    public class LetterCreator
    {
        private static string mailRuTheme = "WebDriver - Test";
        private static string mailRuText = "Neutral Milk Hotel — музыкальный коллектив из США, основанный в 1991 году Джеффом Мэнгамом и исполнявший эклектичный lo-fi/психоделический фолк.\n" +
                                    "Группа известна своими экспериментами со звуком, абстрактными поэтичными текстами и широким разнообразием используемых инструментов.";
        private static string mailRuReciever = "testingqano.2@mail.ru";
        private static string yandexReciever = "testNo.3@yandex.by";
        private static string yandexReply = "GHNDKS";

        public static Letter CreateLetterToYandex()
        {
            return new Letter { Reciever = yandexReciever, Theme = mailRuTheme, Text = mailRuText };
        }

        public static Letter CreateReplyToMailRu()
        {
            return new Letter { Reciever = string.Empty, Theme = string.Empty, Text = yandexReply };
        }
    }
}
