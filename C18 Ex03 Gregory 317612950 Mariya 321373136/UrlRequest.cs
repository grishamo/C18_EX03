using System;
using System.IO;
using System.Net;
using System.Text;

namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    public class UrlRequest
    {
        public static string Get(string i_Url = "")
        {
            string returnData = null;

            HttpWebResponse response = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(i_Url);
            request.Method = "GET";

            try
            {
                response = (HttpWebResponse)request.GetResponse();

                //Mapping of status code
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = null;

                    if (response.CharacterSet == "")
                        readStream = new StreamReader(receiveStream);
                    else
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));

                    //Get news data in json string
                    string data = readStream.ReadToEnd();
                    StringReader reader = new StringReader(data);

                    returnData =  reader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                //TODO Handle request exception 
            }

            return returnData;
        }
    }
}
