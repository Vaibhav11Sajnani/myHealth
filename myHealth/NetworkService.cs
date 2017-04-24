using myHealth.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace myHealth
{
    class NetworkService
    {
        private const string BASE_URI_STRING = "http://blynk-cloud.com/a144a6de427746a1a8f6f7bb66e88233/";
        private const string GET_PIN_VALUE = "get/{0}";
        private const string WRITE_PIN_VALUE = "update/{0}?value={1}";
        private const string SET_WIDGET_PROPERTY = "update/{0}?{1}={2}";
        private const string HARDWARE_NETWORK_STATUS = "isHardwareConnected";


        //private static Windows.Web.Http.HttpClient httpClient = new Windows.Web.Http.HttpClient();
        //private static Windows.Web.Http.HttpResponseMessage httpResponse = new Windows.Web.Http.HttpResponseMessage();

        public static async Task<Project> GetProject()
        {
            //HttpClientHandler myHandler = new HttpClientHandler();
            //myHandler.AllowAutoRedirect = false;
            HttpClient httpClient = new HttpClient();
            System.Net.Http.HttpResponseMessage httpResponse = new System.Net.Http.HttpResponseMessage();
            string httpResponseBody = "";
            try
            {

                string url = string.Format("http://blynk-cloud.com/a144a6de427746a1a8f6f7bb66e88233/project");
                //httpResponse = await httpClient.GetAsync(new Uri(url));
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
        public static async Task<List<double>> GetPin (string pin)
        {
            HttpClient httpClient = new HttpClient();
            System.Net.Http.HttpResponseMessage httpResponse = new System.Net.Http.HttpResponseMessage();
            string httpResponseBody;
            List<double> _pins;
            try
            {
                string url = BASE_URI_STRING + string.Format(GET_PIN_VALUE, pin);
                httpResponse = await httpClient.GetAsync(new Uri(url));
                httpResponseBody = await httpResponse.Content.ReadAsStringAsync();
                _pins = JsonConvert.DeserializeObject<List<double>>(httpResponseBody);
                return _pins;
            }

            catch (Exception e)
            {
                //var error = new PinsStorage();
                _pins = null;
                return _pins;
            }
        }

        public static async void WritePin(string pin, double value)
        {
            HttpClient httpClient = new HttpClient();
            System.Net.Http.HttpResponseMessage httpResponse = new System.Net.Http.HttpResponseMessage();
            string httpResponseBody="";
            try
            {
                
                string url = BASE_URI_STRING + string.Format(WRITE_PIN_VALUE, pin, value);
                httpResponse = await httpClient.GetAsync(new Uri(url));
                httpResponseBody = await httpResponse.Content.ReadAsStringAsync();
                //PinsStorage _pin = await GetPin(pin);
                //double _pin = await DataManager.GetPinValue(pin);
                //return _pin;
            }

            catch (Exception e)
            {
                //var error = new PinsStorage();
                //return 0;
            }
        }

    }
}
