using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestWEB.Pages
{
    public class SomeRemoteCallsModel : PageModel
    {
        private static readonly HttpClient client = new HttpClient();

        private static string reqUrl = "https://testshopapi.azurewebsites.net/longexecution";
        private static string reqUrl2 = "https://testshopapi.azurewebsites.net/";

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

    }
}
