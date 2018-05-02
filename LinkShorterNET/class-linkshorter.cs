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
        public object error;
        public bool hasError;
        private object msg;

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


        public string GetLink()
        {
            return response;
        }

        protected void SetError()
        {
            this.error = msg;
            this.hasError = true;
        }

        protected void Adfly(string url)
        {
            string adflykey = "3f885db2f68d068a6015d4f132bf37b8";
            string adflyuserid = "16175835";

            string api = "http://api.adf.ly/api.php?key=" + adflykey + "&uid=" + adflyuserid + "&url=" + url;

            using (var client = new WebClient())
            {
                this.response = client.DownloadString(api);
            }
        }


        protected void Adfocus(string url)
        {
            string adfockey = "66ebaa219a97eac02d8690addc1d8a4e";

            string api = "http://adfoc.us/api/?key=" + adfockey + "&url=" + url;

            using (var client = new WebClient())
            {
                this.response = client.DownloadString(api);
            }

        }



    }
}
