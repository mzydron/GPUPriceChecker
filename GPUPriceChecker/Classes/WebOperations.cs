using System.IO;
using System.Net;

namespace GPUPriceChecker
{
    public class WebOperations
    {
        /* Class which is used to create base of operations for one URL passed in argument
         * some methods will have overrides for easier development in future */

        string webPath { get; }
        public string savedFilePath = "C:\\SavedHtmls\\TempHtml.txt";


        public WebOperations(string webPath = "http://www.google.com/")
        {
            this.webPath = webPath;
        }

        public HttpWebRequest CreateWebRequest()
        {
            return (HttpWebRequest)WebRequest.Create(this.webPath);
        }

        public HttpWebRequest CreateWebRequest(string CustomWebPath)
        {
            return (HttpWebRequest)WebRequest.Create(CustomWebPath);
        }

        
        public HttpWebResponse SendGetRequestAndReturnResponse()
        {
            WebRequest webReq = CreateWebRequest();
            HttpWebResponse webResp = (HttpWebResponse)webReq.GetResponse();
            return webResp;
        }
        
        public void SaveWebPageToFile()
        {
            HttpWebResponse webResp = SendGetRequestAndReturnResponse();
            using (webResp)
            using (Stream webRespStream = webResp.GetResponseStream())
            using (FileStream outputFile = File.OpenWrite(this.savedFilePath))
            {
                byte[] buffer = new byte[8192];
                int bytesRead;
                while ((bytesRead = webRespStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    outputFile.Write(buffer, 0, bytesRead);
                }
            }
            
        }


    }
}