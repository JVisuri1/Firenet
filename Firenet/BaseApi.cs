using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Firenet
{
    public class BaseApi
    {
        private HttpClient apiClient;

        public BaseApi(FirenetConfig config)
        {
            apiClient = new HttpClient();
            apiClient.BaseAddress = new Uri(config.rootPath);
            apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        //public async Task Post()
        //{

        //}

        public async Task Get(string path, object body)
        {

        }
    }
}
