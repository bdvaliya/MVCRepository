using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class AppUserRolesRepository : IRepository<AppUserRole>
    {
        AppUserEntities db;

        public AppUserRolesRepository()
        {
            db = new AppUserEntities();
        }
       public List<AppUserRole> getAll() {
            return db.AppUserRoles.ToList();
        }

       public AppUserRole getById(int id)
        {
            return db.AppUserRoles.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
