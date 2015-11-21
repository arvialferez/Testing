using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI
{
    class WebAPI
    {
        private RestClient _client = new RestClient();
        private RestRequest _request = new RestRequest();
        

        public RestRequest Request
        {
            get
            {
                return _request;               
            }

            set
            {
                _request = value;
            }
        }

        public RestClient Client
        {
            get
            {
                return _client;
            }

            set
            {
                _client = value;
            }
        }

        public void SendRequest()
        {
           
            Client.Execute(Request);
        }

    }
}
