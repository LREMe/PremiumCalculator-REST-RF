using Newtonsoft.Json;

namespace PremiumCalculator.MVC.Infraestructure
{
    public static class API
    {
        public static class State
        {
            public static string GetAllStates(string requestUri) => requestUri;
        }
        public static class Plan
        {
            public static string GetAllPlan(string requestUri) => requestUri;
        }
        public static class Period
        {
            public static string GetAllPeriod(string requestUri) => requestUri;
        }


        public static class ApiTools
        {

            /// <summary>
            /// This Function allows to connect and manage the conection to the service, if there is not connection: just send a valid void response to aviod errors on the web application
            /// </summary>
            /// <param name="client"></param>
            /// <param name="serviceName"></param>
            /// <param name="voidid"></param>
            /// <param name="voidvalue"></param>
            /// <returns></returns>
            public static Newtonsoft.Json.Linq.JArray GetListFromWebApi(HttpClient client, string serviceName, ILogger _logger, string voidid, string voidvalue)
            {
                Newtonsoft.Json.Linq.JArray o;
                string voidResponse = "[{\"" + voidid + "\":\" \",\"" + voidvalue + "\":\" \"}]";
                try
                {
                    var responseTask = client.GetAsync(serviceName);
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {

                        var readTask = result.Content.ReadAsStringAsync();
                        readTask.Wait();

                        string strResult = readTask.Result;
                        o = JsonConvert.DeserializeObject<Newtonsoft.Json.Linq.JArray>(strResult);

                        return o;
                    }
                    else
                    {
                        _logger.LogInformation("Cannot connect to WebAPI");
                        o = JsonConvert.DeserializeObject<Newtonsoft.Json.Linq.JArray>(voidResponse);
                        return o;

                    }
                }
                catch (Exception e)
                {
                    _logger.LogInformation("Cannot connect to WebAPI", e);
                    o = JsonConvert.DeserializeObject<Newtonsoft.Json.Linq.JArray>(voidResponse);
                    return o;
                }

            }
        }
    }
}
