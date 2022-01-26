using Microsoft.AspNetCore.Http;

namespace _4.LMS.WebApi.Helper
{
    public static class Extensions
    {
        // add header for http to show error with respons
        public static void AddApplicationError(this HttpResponse response, string Message)
        {
            response.Headers.Add("Selah-EL-Telmeez-Application-Error", Message);
            response.Headers.Add("Access-Control-Expose-Headers", "Selah-EL-Telmeez-Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }
    }
}