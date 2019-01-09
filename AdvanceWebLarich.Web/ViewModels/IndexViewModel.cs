using AdvanceWebLarich.Web.Infrastructures.Data.Helpers;
using AdvanceWebLarich.Web.Infrastructures.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceWebLarich.Web.ViewModels
{
    public class IndexViewModel
    {
        public Page<User> Users { get; set; }
    }
}
