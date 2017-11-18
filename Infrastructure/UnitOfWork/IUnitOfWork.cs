using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Repository;

namespace Infrastructure.UnitOfWork
{
    public  interface IUnitOfWork
    {
        IRepository<AppUser> appUserRepository { get; }
        IRepository<AppUserRole> appUserRoleRepository { get; }
    }

    public class UnitOfWork : IUnitOfWork
    {
        AppUserEntities db;
        private IRepository<AppUser> AppUserRepository;
        private IRepository<AppUserRole> AppUserRoleRepository;
        public UnitOfWork()
        {
            db = new AppUserEntities();
        }
        public IRepository<AppUser> appUserRepository
        {
            get
            {
                if(AppUserRepository == null)
                    AppUserRepository= new Repository<AppUser>(db);

                return AppUserRepository;
            }
        }
        public IRepository<AppUserRole> appUserRoleRepository
        {
            get
            {
                if(AppUserRoleRepository == null)
                    AppUserRoleRepository =  new Repository<AppUserRole>(db);

                return AppUserRoleRepository;
            }
        }
    }

}
