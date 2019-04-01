using System.IO;
using System.Net;

namespace GPUPriceChecker
{
    public class WebOperations
    {
        /* Class which is used to create base of operations for one URL passed in argument
         default value given for easy testing */

        string webPath { get; }
        string savedFilePath = "C:\\SavedHtmls\\TempHtml.txt" ;

        public WebOperations(string webPath = "http://www.google.com/")
        {
            this.webPath = webPath;
        }

        
        public HttpWebResponse SendGetRequestAndReturnResponse()
        {
            WebRequest webReq = WebRequest.Create(this.webPath);
            HttpWebResponse webResp = (HttpWebResponse)webReq.GetResponse();
            return webResp;
        }
        
        public void SaveWebPageToFile()
        {
            /*For now is void as I came to painfull conclusion that SendGetRequestAndReturnResponse 
             * does two things instead of one 
             * breaking the Single Responsability Principle
             * and making it harder to develop program further
             * without rewriting it */
        }


    }
}