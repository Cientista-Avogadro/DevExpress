using System;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Threading.Tasks;
using System.Collections.Generic;
using DevExpress.Printing.Core.PdfExport;
using Newtonsoft.Json;

namespace PR.Report
{
   public  class Traduzir
    {

        public async Task<data> TranslateAsync(String word, string fromLanguage, string toLanguage)
        {
            var client = new HttpClient();
            string body = "";
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://systran-systran-platform-for-language-processing-v1.p.rapidapi.com/translation/text/translate?source={fromLanguage}&target={toLanguage}&input={word}"),
                Headers ={{ "x-rapidapi-key", "b2d078e0bemsh69eb1fd58ed53b8p1e87c9jsn2dbb5150482f" },{ "x-rapidapi-host", "systran-systran-platform-for-language-processing-v1.p.rapidapi.com" },},
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                 body = await response.Content.ReadAsStringAsync();
                
            }

            return JsonConvert.DeserializeObject<data>(body);
        }
    }
}
