using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


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
