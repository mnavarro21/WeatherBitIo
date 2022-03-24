using Newtonsoft.Json;
using RestSharp;

namespace APIHelper
{
	public class RestSharpActions<T>
	{
		public RestClient restClient;
		public RestRequest restRequest;

		public RestClient setUrl(string baseUrl, string relativeUrl)
		{
			string url = Path.Combine(baseUrl, relativeUrl);
			RestClient restClient = new RestClient(url);
			return restClient;
		}

		public RestRequest CreatePostRequest(IDictionary<string, string> headers, string formatType, string payload)
		{
			RestRequest restRequest = new RestRequest(Method.POST);
			AddHeadersToTheRequest(headers, restRequest);
			restRequest.AddParameter(formatType, payload, ParameterType.RequestBody);
			return restRequest;
		}

		public RestRequest CreateGetRequest(IDictionary<string, string> headers, string formatType)
		{
			RestRequest restRequest = new RestRequest(Method.GET);
			AddHeadersToTheRequest(headers, restRequest);
			restRequest.AddParameter(formatType, ParameterType.RequestBody);
			return restRequest;
		}
		public RestRequest CreatePutRequest(IDictionary<string, string> headers, string formatType)
		{
			RestRequest restRequest = new RestRequest(Method.PUT);
			AddHeadersToTheRequest(headers, restRequest);
			restRequest.AddParameter(formatType, ParameterType.RequestBody);
			return restRequest;
		}
		public RestRequest CreateDeleteRequest(IDictionary<string, string> headers, string formatType, string payload)
		{
			RestRequest restRequest = new RestRequest(Method.DELETE);
			AddHeadersToTheRequest(headers, restRequest);
			restRequest.AddParameter(formatType, payload, ParameterType.RequestBody);
			return restRequest;
		}

		public IRestResponse GetResponse(RestClient client, RestRequest restRequest)
		{
			return client.Execute(restRequest);
		}

		public DTO GetContent<DTO>(IRestResponse response)
		{
			string content = response.Content;
			try
			{
				DTO dtoObject = JsonConvert.DeserializeObject<DTO>(content);
				return dtoObject;
			}
			catch (Exception)
			{
				return default;
			}
		}

		public string Serialize(dynamic content)
		{
			string serializeObject = JsonConvert.SerializeObject(content, Formatting.Indented);
			return serializeObject;
		}

		private static void AddHeadersToTheRequest(IDictionary<string, string> headers, RestRequest restRequest)
		{
			foreach (KeyValuePair<string, string> header in headers)
			{
				restRequest.AddHeader(header.Key, header.Value);
			}
		}
	}
}
