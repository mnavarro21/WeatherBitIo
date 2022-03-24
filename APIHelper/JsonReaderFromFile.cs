using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIHelper
{
    public class JsonReaderFromFile
    {
        readonly string path = Helper.GetCurrentWorkingDirectory();
        public string ReadJsonSettingsFromFile(string fileName)
        {
            JObject jObject;
            using (StreamReader reader = File.OpenText(path + @"\" + fileName))
            {
                jObject = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
            }
            return jObject.ToString();
        }
    }
}
