using System;
using System.Collections.Generic;
using PrimePro.Models;
using Dormouse.Core.Repository;

namespace PrimePro.Repository
{
    public interface ISalesOrderLookupRepository : IRepositorySearch<SalesOrderLookup> //: IRepositorySearch<SalesOrder>
    {
        IList<SalesOrderLookup> GetAllSalesOrdersLookup();

        SalesOrderLookup GetSalesOrderLookup(int Id);

    }
}
