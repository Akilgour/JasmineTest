using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Script.Serialization;

namespace EchoSign
{
    class Program
    {
        static void Main(string[] args)
        {
 

            var foo = new Models();
            var bar = foo.GetAgreementCreationObject();

            var javaScriptSerializer = new JavaScriptSerializer();
            var barJSONString = javaScriptSerializer.Serialize(bar);

            var client = new RestClient("https://api.na1.echosign.com/api/rest/v5");
            var request = new RestRequest("agreements", Method.POST);
            //AK  NEVER GOT ROUND TO WORK THIS OUT 
            request.AddHeader("Access-Token", "3AAABLblqZhDxXTL4Uw0448g_-FYBh8ANSPrr8DdOKo4WemlUecNnhgHeTxkzHmVTJk6Nqm3pM3V4CJ0hEy03hCv3Mn36asd_");

            request.RequestFormat = DataFormat.Json;
            request.AddBody(bar);

            IRestResponse response = client.Execute(request);
            var content = response.Content;

        }
    }

   
}



