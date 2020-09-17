using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using YMS5175_Core_CRUD.DataAccess.Context;

namespace YMS5175_Core_CRUD.Controllers
{
    public class CategoryController : Controller
    {
        public ProjectContext _projectContext;

        public CategoryController(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}