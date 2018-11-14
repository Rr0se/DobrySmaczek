using DobrySmaczek.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace DobrySmaczek.Services.Order
{
    interface IOrderService
    {
        IEnumerable<Entities.Order> GetAll();
        Entities.Order GetById(int id);
        Entities.Order Create(Entities.Order Orders, UserType user);
        void Delete(int id);

    }
}
