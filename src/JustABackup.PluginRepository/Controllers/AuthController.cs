using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JustABackup.PluginRepository.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {
        public IActionResult GitHub()
        {
            return Redirect("/");
        }
    }
}