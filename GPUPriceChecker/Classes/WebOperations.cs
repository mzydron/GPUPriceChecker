using System.IO;
using System.Net;

namespace GPUPriceChecker
{
    public class WebOperations
    {
        
        public HttpWebResponse SendGetRequest(string http = "https://www.google.com/")
        {

            WebRequest webReq = WebRequest.Create(http);
            HttpWebResponse webResp = (HttpWebResponse)webReq.GetResponse();
            return webResp;
        }


    }
}