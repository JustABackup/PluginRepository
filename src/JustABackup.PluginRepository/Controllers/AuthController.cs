using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JustABackup.PluginRepository.Controllers
{
    [Authorize]
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return Redirect("/");
        }

        public IActionResult GitHub()
        {
            return Redirect("/");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }
}