using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JustABackup.PluginRepository.Controllers
{
    public class DetailsController : Controller
    {
        [Route("/details/{package}")]
        public IActionResult Package(string package, string version = null)
        {
            return View();
        }
    }
}