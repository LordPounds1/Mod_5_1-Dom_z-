using System;

namespace Mod_5_1_Dom_z_
{

    public class WebRequestHandler
    {
        public void MakeWebRequest(string url)
        {
            try
            {
                throw new Exception("Web resource not found.");
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Web resource not found."))
                {
                    Console.WriteLine("Error: The requested web resource does not exist.");
                }
                else
                {

                }

                Environment.Exit(0);
            }
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            var webRequestHandler = new WebRequestHandler();
            webRequestHandler.MakeWebRequest("https://www.primer.com");
        }
    }
}
