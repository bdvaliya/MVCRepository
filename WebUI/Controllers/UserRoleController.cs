using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Infrastructure.UnitOfWork;
using WebUI.Models;
using Infrastructure;

namespace WebUI.Controllers
{
    public class UserRoleController : Controller
    {
        private readonly IUnitOfWork _uOW;
        
        public UserRoleController()
        {
            _uOW = new UnitOfWork();
        }
        // GET: UserRole
        public ActionResult Index()
        {
            var appUserRole = _uOW.appUserRoleRepository.getAll();
            var appUserRoleVM = from a in appUserRole
                                select new UserRoleViewModel()
                                {
                                    Id = a.Id,
                                    RoleName = a.RoleName
                                };
            return View(appUserRoleVM);
        }
    }
}