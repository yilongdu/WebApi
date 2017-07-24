using GalaSoft.MvvmLight;
using Newtonsoft.Json;
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
        public static string SendRequest<T>(T model,string url,HttpMethod method) where T: class
        {
            if(method.Equals(HttpMethod.Get))
            {
                string json = JsonConvert.SerializeObject(model);
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
