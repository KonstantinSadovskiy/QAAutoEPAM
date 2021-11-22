using NUnit.Framework;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Linq;

namespace SeleniumWebdriver.Service
{
    public class TestDataReader
    {
        private static readonly string _filePath = "Resources/";
        private static readonly string _environment = TestContext.Parameters["environment"];

        public static string ReadTestData(string key)
        {
            var text = File.ReadAllText($"{_filePath}{_environment}.json");
            JObject json = JObject.Parse(text);

            return json.Descendants().OfType<JProperty>().Where(x => x.Name == key).First().Value.ToString();
        }
    }
}
