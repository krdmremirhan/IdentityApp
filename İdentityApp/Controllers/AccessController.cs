using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace İdentityAp.Controllers
{
    [Authorize ]
    public class AccessController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Blogger,Pokemon")]
        public IActionResult PokemonAndBloggerAccess()
        {
            return View();
        }
        [Authorize(Policy = "OnlyBloggerChecker")]
        public IActionResult OnlyBloggerAccess()
        {
            return View();
        }
        [Authorize(Policy = "CheckNickNameEmirhan")]
        public IActionResult CheckNickNameEmirhan()
        {
            return View();
        }
    }
}