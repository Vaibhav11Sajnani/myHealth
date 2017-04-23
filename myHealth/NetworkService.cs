using myHealth.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHealth
{
    class NetworkService
    {
        private static Windows.Web.Http.HttpClient httpClient = new Windows.Web.Http.HttpClient();
        private static Windows.Web.Http.Headers.HttpRequestHeaderCollection headers = httpClient.DefaultRequestHeaders;
        private static Windows.Web.Http.HttpResponseMessage httpResponse = new Windows.Web.Http.HttpResponseMessage();

        public static async Task<Project> GetProject()
        {
            string httpResponseBody = "";
            try
            {

                string url = string.Format("http://blynk-cloud.com/a144a6de427746a1a8f6f7bb66e88233/project");
                httpResponse = await httpClient.GetAsync(new Uri(url));
                httpResponseBody = await httpResponse.Content.ReadAsStringAsync();
                Project _proj = JsonConvert.DeserializeObject<Project>(httpResponseBody);            
                return _proj;

            }

            catch (Exception e)
            {
                var error = new Project();
                error.isActive = false;
                return error;
            }
        }
    }
}
