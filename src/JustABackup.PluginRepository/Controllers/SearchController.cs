using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JustABackup.PluginRepository.Controllers
{
    [AllowAnonymous]
    public class SearchController : Controller
    {
        public IActionResult Index(string query = null)
        {
            return View();
        }
    }
}