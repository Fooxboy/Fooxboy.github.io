using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FooxboySite.Models
{
    public class ConfigModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string LastVersion { get; set; }
        public string ReleaseVersion { get; set; }
        public List<VersionModel> Version { get; set; }
    }

    public class VersionModel
    {
        public string Version { get; set; }
        public string CodeName { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public UrlDescriptionModel UrlDescription { get; set; }

    }

    public class UrlDescriptionModel
    {
        public string Telegram { get; set; }
        public string Vkontankte { get; set; }
    }
}
