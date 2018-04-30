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

            //the constructor
        public Linkshorter(string service, string url)
        {
            ArrayList urls = new ArrayList();
            urls.Add(url);

            object[] obj = (object[])urls.ToArray(typeof(object));

            MethodInfo mi = this.GetType().GetMethod(service);

            //Invoke the method
            // (null- no parameter for the method call
            // or you can pass the array of parameters...)
            mi.Invoke(this, obj);
        }
        test error

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


        public void Adfocus(string url)
        {

            string api = "http://adfoc.us/api/?key=66ebaa219a97eac02d8690addc1d8a4e&url=" + url;

            using (var client = new WebClient())
            {
                this.response = client.DownloadString(api);
            }

        }



    }
}
