using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thinkorswim.Model;
using Thinkorswim.Utils;

namespace Thinkorswim.Service
{
    class SetterBrowser
    {
        static readonly string dataPath = "../../../Resources/Browser.json";

        public static Browser WithCredentialsFromProperty()
        {
            return TestDataParametr<Browser>.GetParametrs(dataPath);
        }
    }
}
