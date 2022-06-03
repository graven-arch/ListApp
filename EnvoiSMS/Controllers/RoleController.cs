using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnvoiSMS.Controllers
{
    public class RoleController : Controller
    {
        private RoleManager<IdentityRole> _roleManger;
        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            _roleManger = roleManager;
        }
        public IActionResult Index()
        {
            var roles = _roleManger.Roles.ToList();
            return View(roles);
        }
    }
}
