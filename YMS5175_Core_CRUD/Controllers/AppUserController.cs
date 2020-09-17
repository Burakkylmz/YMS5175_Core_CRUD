using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YMS5175_Core_CRUD.DataAccess.ORM.Entities;
using YMS5175_Core_CRUD.DataAccess.Repository.Abstraction;

namespace YMS5175_Core_CRUD.Controllers
{
    public class AppUserController : Controller
    {

        public IAppUserRepository _repo;

        public AppUserController(IAppUserRepository appUserRepository)
        {
            _repo = appUserRepository;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AppUser appUser)
        {
            _repo.CreateAppUser(appUser);
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            return View(_repo.GetAll());
        }

        public IActionResult Update(int id)
        {
            return View(_repo.GetById(id));
        }

        [HttpPost]
        public IActionResult Update(AppUser appUser)
        {
            _repo.UpdateAppUser(appUser);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            _repo.DeleteAppUser(id);
            return RedirectToAction("List");
        }
    }
}