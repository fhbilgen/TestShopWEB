using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestWEB.Pages
{
    public class SomeRemoteCallsModel : PageModel
    {
        private static readonly HttpClient client = new HttpClient();

        //private static string reqUrl = "https://testshopapi.azurewebsites.net/api/LongExecution/longexecution";
        //private static string reqUrl2 = "https://testshopapi.azurewebsites.net/api/exception/throwexception";
        //private static string reqUrl3 = "https://testshopapi.azurewebsites.net/api/LongExecution/DoubleHop";
        //private static string reqUrl4 = "https://testshopapi.azurewebsites.net/api/LongExecution/ChattyDoubleHop";

        private static string reqUrl = Environment.GetEnvironmentVariable("TestShopApi_LongExecution"); // ?? "https://testshopapi.azurewebsites.net/api/LongExecution/longexecution";
        private static string reqUrl2 = Environment.GetEnvironmentVariable("TestShopApi_ThrowException"); // ?? "https://testshopapi.azurewebsites.net/api/exception/throwexception";
        private static string reqUrl3 = Environment.GetEnvironmentVariable("TestShopApi_DoubleHop"); // ?? "https://testshopapi.azurewebsites.net/api/LongExecution/DoubleHop";
        private static string reqUrl4 = Environment.GetEnvironmentVariable("TestShopApi_ChattyDoubleHop"); // ?? "https://testshopapi.azurewebsites.net/api/LongExecution/ChattyDoubleHop";

        public void OnGet()
        {
        }
        
        public void OnPostCallALongFunction()
        {
            var result = client.GetStringAsync(reqUrl).Result;
            return;
        }

        public void OnPostCallAnExceptionFunction()
        {
            var result = client.GetStringAsync(reqUrl2).Result;
            return;
        }

        public void OnPostCallaDoubleHopFunction()
        {
            var result = client.GetStringAsync(reqUrl3).Result;
            return;
        }

        public void OnPostCallaChattyFunction()
        {
            var result = client.GetStringAsync(reqUrl4).Result;
            return;
        }


    }
}
