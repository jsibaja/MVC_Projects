using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimePro.Models;
using PrimePro.Repository;
using Dormouse.Core.Repository;

namespace PrimePro.Persistence
{
    public class SalesOrderLookupRepository : RepositorySearch<SalesOrderLookup, int>, ISalesOrderLookupRepository
    {
        public IList<SalesOrderLookup> GetAllSalesOrdersLookup()
        {
            return this.CurrentSession.CreateCriteria<SalesOrderLookup>()
                        .List<SalesOrderLookup>();
        }
        SalesOrderLookup GetSalesOrderLookup(int Id)
        {
            return this.CurrentSession.Get<SalesOrderLookup>(Id);
        }
    }
}
