using System;
using System.Net.Http;

namespace BLLC.Services
{
    class LibrairiService
    {
        private readonly HttpClient _httpClient;
        public LibrairiService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:5001/api/");
        }

        
    }
}
