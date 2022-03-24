using Newtonsoft.Json;

namespace APIHelper.Models.Configuration
{
	public class ConfigHelper
	{
		readonly JsonReaderFromFile jsonReaderFromFile = new JsonReaderFromFile();
		public JsonConfiguration ReadConfiguration()
		{
			string jsonInput = jsonReaderFromFile.ReadJsonSettingsFromFile("appsettings.json");
			Assert.IsNotNull(jsonInput, "contents of appsettings.json file: " + jsonInput);
			return JsonConvert.DeserializeObject<JsonConfiguration>(jsonInput);
		}
	}
}
