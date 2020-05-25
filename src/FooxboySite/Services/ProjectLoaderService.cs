using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using FooxboySite.Models;
using Microsoft.AspNetCore.Components;

namespace FooxboySite.Services
{
    public class ProjectLoaderService
    {
        private HttpClient _client;
        public ProjectLoaderService(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<ProjectModel>> GetProjects()
        {
            ProjectsListModel model;
            model = await _client.GetJsonAsync<ProjectsListModel>("/data/projects.json");

            return model.projects;
        }
    }
}
