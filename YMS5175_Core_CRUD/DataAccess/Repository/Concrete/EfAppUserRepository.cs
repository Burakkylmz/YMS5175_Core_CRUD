using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using YMS5175_Core_CRUD.DataAccess.Context;
using YMS5175_Core_CRUD.DataAccess.ORM.Entities;
using YMS5175_Core_CRUD.DataAccess.Repository.Abstraction;

namespace YMS5175_Core_CRUD.DataAccess.Repository.Concrete
{
    public class EfAppUserRepository : IAppUserRepository
    {

        private ProjectContext _context;

        public EfAppUserRepository(ProjectContext projectContext)
        {
            _context = projectContext;
        }

        public void CreateAppUser(AppUser appUser)
        {
            _context.AppUsers.Add(appUser);
            _context.SaveChanges();
        }

        public void DeleteAppUser(int id)
        {
            var appuser = GetById(id);
            if (appuser != null)
            {
                _context.AppUsers.Remove(appuser);
                _context.SaveChanges();
            }
        }

        public List<AppUser> GetAll()
        {
            return _context.AppUsers.Where(x => x.Status != Status.Passive).ToList();
        }

        public AppUser GetById(int id)
        {
            return _context.AppUsers.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateAppUser(AppUser appUser)
        {
            _context.AppUsers.Update(appUser);
            _context.SaveChanges();
        }
    }
}
