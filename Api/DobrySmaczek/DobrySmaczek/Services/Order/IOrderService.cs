using DobrySmaczek.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace DobrySmaczek.Services.Order
{
    interface IOrderService
    {
        IEnumerable<AppOrder> GetAll();
        AppOrder GetById(int id);
        AppOrder Create(AppOrder Orders, UserType user);
        void Delete(int id);

    }
}
