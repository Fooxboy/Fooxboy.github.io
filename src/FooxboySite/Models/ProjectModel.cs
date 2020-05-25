using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FooxboySite.Models
{
    public class ProjectModel
    {
        public string Title { get; set; }
        public string UrlPhotoBackground { get; set; }
        public string UrlPhotoIcon { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
    }

    public class ProjectsListModel
    {
        public List<ProjectModel> projects { get; set; }
    }
}
