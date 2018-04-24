using System;
using System.IO;
using System.Net;

namespace LinkShorterNET
{
    public class Linkshorter
    {
        private string response;

        public Linkshorter(string service, string url)
        {
            if (service == "adfly")
            {
                this.adfly(url);
            }

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
