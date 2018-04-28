using System;
using System.Collections;
using System.Linq;
using System.Net;
using System.Reflection;

namespace LinkShorterNET
{
    public class Linkshorter
    {
        private string response;

        public Linkshorter(string service, string url)
        {
            
                Type thisType = this.GetType();
                MethodInfo theMethod = thisType.GetMethod(service);
                

            var url1 = ((IEnumerable)url).Cast<object>()
                                   .Select(x => x == null ? x : x.ToString())
                                   .ToArray();

            theMethod.Invoke(this, url1);


        }


        public string GetLink()
        {
            return response;
        }



        private void Adfly(string url)
        {
            string api = "http://api.adf.ly/api.php?key=3f885db2f68d068a6015d4f132bf37b8&uid=16175835&url=" + url;

            using (var client = new WebClient())
            {
                this.response = client.DownloadString(api);
            }
        }


        private void Adfocus(string url)
        {

            string api = "http://adfoc.us/api/?key=66ebaa219a97eac02d8690addc1d8a4e&url=" + url;

            using (var client = new WebClient())
            {
                this.response = client.DownloadString(api);
            }

        }



    }
}
