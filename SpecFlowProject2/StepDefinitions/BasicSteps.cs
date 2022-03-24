using APIHelper.Models.Configuration;
using RestSharp;
using System.Net;

namespace SpecFlowProject2.StepDefinitions
{
    public class BasicSteps
    {
        protected JsonConfiguration jsonConfiguration = new ConfigHelper().ReadConfiguration();
        protected IRestResponse restResponse;
        protected HttpStatusCode statusCode;
        protected readonly IDictionary<string, string> headers = new Dictionary<string, string>();
        protected string baseUrl;
        protected string relativeUrl;
    }
}
