using System;
using System.Collections.Generic;
using PrimePro.Models;
using Dormouse.Core.Repository;

namespace PrimePro.Persistence
{
    public interface ISalesOrderViewRepository : IRepositorySearch<SalesOrderView> //: IRepositorySearch<SalesOrder>
    {
        IList<SalesOrderView> GetAllSalesOrdersView();

        SalesOrderView GetSalesOrderViewById(int Id);

    }
}
