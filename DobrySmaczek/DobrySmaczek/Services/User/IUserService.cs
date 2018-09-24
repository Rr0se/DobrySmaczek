using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Services.User
{
    public interface IUserService
    {
        Task<string> Register();
    }
}
