using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Portal.Models;

namespace Portal.Controllers
{
 
    public class RolesController : Controller
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }
        [HttpGet]
        public ActionResult AssignRoles()
        {                  
            return View(UserManager.Users.Select(f=> new User { Email =f.Email, Name =f.UserName}).ToList());
        }

        // Assign: Roles
        [HttpPost]
        public ActionResult AssignRoles(string userId, Roles role)
        {

          //  var result = UserManager.AddToRoles(userId, new string[] { role.Value });
            return View();
        }
    }
}