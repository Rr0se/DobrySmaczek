using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Services.User
{
    public interface IUserService
    {
        User Authenticate(string UserName, string password);
        IEnumerable<Entities.User> GetAll();
        User GetById(int id);
        User Create(Entities.User user, string password);
        void Update(Entities.User user, string password = null);
        void Delete(int id);
        void Create(User user, string password);
        void Update(User user, string password);
    }
}
