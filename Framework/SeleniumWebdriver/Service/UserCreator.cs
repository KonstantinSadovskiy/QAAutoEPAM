using SeleniumWebdriver.Models;

namespace SeleniumWebdriver.Service
{
    public class UserCreator
    {
        private static string mailRuUserEmail = "testdata.mailRu.user.email";
        private static string mailRuUserPassword = "testdata.mailRu.user.password";
        private static string yandexUserEmail = "testdata.yandex.user.email";
        private static string yandexUserPassword = "testdata.yandex.user.password";
        private static string wrongUserPassword = "testdata.user.fakePassword";
        private static string wrongMailRuUserEmail = "testdata.mailRu.user.fakeEmail";
        private static string wrongYandexUserEmail = "testdata.yandex.user.fakeEmail";

        public static User CreateValidMailRuUser()
        {
            return new User { Email = TestDataReader.ReadTestData(mailRuUserEmail),
                              Password = TestDataReader.ReadTestData(mailRuUserPassword) };
        }
        public static User CreateValidYandexUser()
        {
            return new User { Email = TestDataReader.ReadTestData(yandexUserEmail), 
                              Password = TestDataReader.ReadTestData(yandexUserPassword) };
        }

        public static User CreateWrongPasswordMailRuUser()
        {
            return new User { Email = TestDataReader.ReadTestData(mailRuUserEmail), 
                              Password = TestDataReader.ReadTestData(wrongUserPassword) };
        }

        public static User CreateWrongPasswordYandexUser()
        {
            return new User { Email = TestDataReader.ReadTestData(yandexUserEmail), 
                              Password = TestDataReader.ReadTestData(wrongUserPassword) };
        }

        public static User CreateNotExistingMailRuUser()
        {
            return new User { Email = TestDataReader.ReadTestData(wrongMailRuUserEmail), 
                              Password = TestDataReader.ReadTestData(wrongUserPassword) };
        }

        public static User CreateNotExistingYandexUser()
        {
            return new User { Email = TestDataReader.ReadTestData(wrongYandexUserEmail),
                              Password = TestDataReader.ReadTestData(wrongUserPassword) };
        }

        public static User CreateEmptyPasswordMailRuUser()
        {
            return new User { Email = TestDataReader.ReadTestData(mailRuUserEmail),
                              Password = string.Empty };
        }
        public static User CreateEmptyPasswordYandexUser()
        {
            return new User { Email = TestDataReader.ReadTestData(yandexUserEmail),
                              Password = string.Empty };
        }

        public static User CreateEmptyEmailUser()
        {
            return new User { Email = string.Empty, 
                              Password = TestDataReader.ReadTestData(wrongUserPassword) };
        }

        public static User CreateEmptyUser()
        {
            return new User { Email = string.Empty, Password = string.Empty };
        }
    }
}
