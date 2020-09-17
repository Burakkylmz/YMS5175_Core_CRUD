using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YMS5175_Core_CRUD.DataAccess.ORM.Entities;

namespace YMS5175_Core_CRUD.DataAccess.Repository.Abstraction
{
    public interface IAppUserRepository
    {
        AppUser GetById(int id);
        void CreateAppUser(AppUser appUser);
        void UpdateAppUser(AppUser appUser);
        void DeleteAppUser(int id);
        List<AppUser> GetAll();
    }
}
