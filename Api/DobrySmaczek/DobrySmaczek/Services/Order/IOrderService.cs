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
        AppOrder GetById(int Id);
        AppOrder Create(AppOrder Orders, Users user );
        void Delete(int id);

    }
}
