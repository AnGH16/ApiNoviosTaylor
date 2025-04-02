using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using ConsumirApiNoviosTs.Model;

namespace ConsumirApiNoviosTs.Service
{
    internal class NovioService
    {
        private readonly HttpClient _httpClient;
        private string _token = string.Empty;


        public NovioService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://10.0.2.44:7288/");
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            var loginData = new LoginRequest { Username = username, Password = password };
            var json = JsonSerializer.Serialize(loginData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            };

            using var client = new HttpClient(handler);

            // Asegúrate de usar la URL completa
            var response = await client.PostAsync("https://10.0.2.44:7288/api/auth/login", content);

            if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                var auth = JsonSerializer.Deserialize<AuthResponse>(responseBody, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                _token = auth?.Token ?? string.Empty;

                return !string.IsNullOrEmpty(_token);
            }

            return false;
        }


        public async Task<List<Novio>> GetNoviosAsync()
        {
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            };

            using var client = new HttpClient(handler);
            client.BaseAddress = new Uri("https://10.0.2.44:7288/");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            var response = await client.GetAsync("api/tsnovios");

            if (!response.IsSuccessStatusCode)
                return new List<Novio>();

            var content = await response.Content.ReadAsStringAsync();
            var novios = JsonSerializer.Deserialize<List<Novio>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return novios ?? new List<Novio>();
        }


    }
}
