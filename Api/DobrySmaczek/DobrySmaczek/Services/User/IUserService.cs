using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DobrySmaczek.Entities;


namespace DobrySmaczek.Services.User
{
    public interface IUserService
    {
        GlobalServiceModel<AppUser> Authenticate(string UserName, string password);
        GlobalServiceModel<IEnumerable<AppUser>> GetAll();
        GlobalServiceModel<AppUser> GetById(int id);
        GlobalServiceModel <AppUser> Create(AppUser user, string password);
        GlobalServiceModel Update(AppUser user, string password = null);
        GlobalServiceModel Delete(int id);
        GlobalServiceModel Create1(AppUser user, string password);
        GlobalServiceModel Update1(AppUser user, string password);
    }
}
