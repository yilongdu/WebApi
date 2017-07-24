using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApi.Common
{
    public class Fuctions
    {
        public static string SendRequest<T>(string json,string url,HttpMethod method) where T: ViewModelBase
        {
            if(method.Equals(HttpMethod.Get))
            {

            }
            if (method.Equals(HttpMethod.Delete))
            {

            }
            if (method.Equals(HttpMethod.Post))
            {

            }
            if (method.Equals(HttpMethod.Put))
            {

            }
            
            return "";
        }
    }
}
