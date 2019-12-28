using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace UnitConverter.Units.Currency
{
    class Currency : Unit
    {
        public string CurrencyOne { get; set; }
        public string CurrencyTwo { get; set; }
        private double conversionRate;
        public double ConvertedAmount { get; private set; }
        public Currency(double amount = 0.0)
            : base(amount)
        {
        }

        /// <summary>
        ///  No use for async because this is a fairly straightforward call
        /// </summary>
        public void SendAPIRequest()
        {
            // Breaking the string because the coloring annoyed me
            string url = $"https:" + $"//api.exchangeratesapi.io/latest?base={CurrencyOne}&symbols={CurrencyTwo}";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

            WebResponse resp = req.GetResponse();
            using (Stream respStream = resp.GetResponseStream())
            {
                StreamReader reader = new StreamReader(respStream, System.Text.Encoding.UTF8);
                var fullResponse = reader.ReadToEnd();
                // Parsing our response into "JSON" with json.Net
                JObject json = JObject.Parse(fullResponse);
                conversionRate = double.Parse(json["rates"][CurrencyTwo].ToString());
                // Running the conversion
                ConvertedAmount = Amount * conversionRate;
            }

        }

        public override string ToString()
        {
            return $"C1: {CurrencyOne} - C2: {CurrencyTwo} - Amount: {Amount}";
        }
    }
}
