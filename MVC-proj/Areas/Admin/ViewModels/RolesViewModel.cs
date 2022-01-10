using MVC_proj.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_proj.Areas.Admin.ViewModels
{
    public class RolesViewModel
    {
        public string Admin { get; set; }
        public string Moderator { get; set; }
        public string User { get; set; }
    }
}
