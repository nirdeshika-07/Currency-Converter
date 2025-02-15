using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Live_Currency_Converter
{
    internal class CurrencyConverter
    {
        Dictionary<string,string> symbols;
        public Dictionary<string,string> GetSymbols()
        {
            if (symbols == null)
            {
                symbols = new Dictionary<string,string>();
                string responseContent = getResponseString("exchangerates_data/symbols");
                Dictionary<string,object> responseDictData =JsonConvert.DeserializeObject<Dictionary<string,object>>(responseContent);
                if ((bool)responseDictData["success"])
                {
                    var tempSymbols=(JObject)responseDictData["symbols"];
                    symbols = tempSymbols.ToObject<Dictionary<string, string>>();
                }
            }
            return symbols;
        }
        public string getResponseString(string relativeURI)
        {
            var client = new RestClient("https://api.apilayer.com/");

            var request = new RestRequest(relativeURI, Method.Get);
            request.AddHeader("apikey","H4d8fEDbmJxI63r5JfVWTbapMkaxmwUA");

            RestResponse response = client.Execute(request);
            return response.Content;
        }
        public double Convert(string from,string to,double amount)
        {
            string apiUrl = $"exchangerates_data/convert?to={to}&from={from}&amount={amount}";
            //MessageBox.Show(apiUrl, "API Request URL");
            string responseContent = getResponseString (apiUrl);
            Console.WriteLine(responseContent, "API Responses");
            Dictionary<string, object> responseDictData = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseContent);
            if ((bool)responseDictData["success"])
            {
                return (double)responseDictData["result"];
            }
            else
            {
                return -1;
            }
        }
    }
}
