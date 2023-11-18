namespace UrWave_Web.WebHelper
{
    public static class WebAPICall
    {
        private static readonly IConfiguration _config;
        public static string GetAPICall(APIEnum controllerName)
        {
            //get URL From AppSettings
            var link = string.Concat("https://localhost:44381", "/api/", controllerName);
            return link;
        }
    }
}
