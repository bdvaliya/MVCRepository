using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
   public class AppUserRepository
    {
        AppUserEntities db = null;
        public AppUserRepository()
        {
            db = new AppUserEntities();
        }
        public List<AppUser> getAll()
        {
            return db.AppUsers.ToList();
        }

        public AppUser getById(int id)
        {
            var appUser = db.AppUsers.Where(x => x.Id == id).FirstOrDefault();
            return appUser;
        }
    }
}
