using System.IO;
using System.Text.Json;


namespace Thinkorswim.Utils
{
    class TestDataParametr<T>
    {
        public static T GetParametrs(string path = "../../../Resources/User.json")
        {
            return JsonSerializer.Deserialize<T>(File.ReadAllText(path));
        }
    }
}
