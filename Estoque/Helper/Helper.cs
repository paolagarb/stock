using System;
using System.Net.Http;

namespace Estoque.Helper
{
    public class EstoqueAPI
    {
        public HttpClient Initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:49721");
            return client;
        }
    }
}
