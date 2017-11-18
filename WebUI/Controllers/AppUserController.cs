using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Infrastructure.Repository;
using WebUI.Models;
using Infrastructure;

namespace WebUI.Controllers
{
    public class AppUserController : Controller
    {
        private readonly IRepository<AppUser> _appUserRepository;

                
        public AppUserController()
        {
            _appUserRepository = new Repository<AppUser>();
        }
        // GET: AppUser
        public ActionResult Index()
        {
            var appUsers = _appUserRepository.getAll();
            var appUserVM = from a in appUsers
                            select new AppUserViewModel {
                               Id = a.Id,
                               Name = a.Name,
                               Gender = a.Gender,
                               Phone = a.Phone,
                               Email = a.Email,
                               DOB = a.DOB,
                               ProfileImage = a.ProfileImage
                            };
            return View(appUserVM);
        }

    }
}