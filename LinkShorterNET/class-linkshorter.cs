using System;
using System.Collections;
using System.IO;
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


        private string getLink()
        {
            return response;
        }



        private void adfly(string url)
        {

            string link = "http://api.adf.ly/api.php?key=3f885db2f68d068a6015d4f132bf37b8&uid=16175835&url=" + url;

            WebRequest wrGETURL;  //system dot-net
            wrGETURL = WebRequest.Create(link);

            Stream objStream;  //system io
            objStream = wrGETURL.GetResponse().GetResponseStream();

            StreamReader objReader = new StreamReader(objStream);

            string sLine = "";
            int i = 0;



            while (sLine != null)
            {
                i++;
                sLine = objReader.ReadLine();
                if (sLine != null)
                    this.response = sLine;
            }
        }



    }
}
