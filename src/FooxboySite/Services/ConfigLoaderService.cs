using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FooxboySite.Models;
using Microsoft.AspNetCore.Components;

namespace FooxboySite.Services
{
    public class ConfigLoaderService
    {
        private HttpClient _client;
        public ConfigLoaderService(HttpClient client)
        {
            _client = client;
        }

        public async Task<ConfigModel> GetConfig(string pathConfig)
        {
            var model = await _client.GetJsonAsync<ConfigModel>(pathConfig);
            return model;
        }
    }
}
