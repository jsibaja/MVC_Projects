using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimePro.Models;
using PrimePro.Persistence;
using PrimePro.Repository;

namespace PrimePro.Tasks
{
    public class SalesOrderTasks : ISalesOrderLookupRepository
    {
        private readonly ISalesOrderLookupRepository _salesOrderLookup;

        public SalesOrderTasks(ISalesOrderLookupRepository salesOrderLookup)
        {
            _salesOrderLookup = salesOrderLookup;
        }

        public IList<SalesOrderLookup> GetAllSalesOrderLookup()
        {
            var salesOrderLookup = _salesOrderLookup.GetAllSalesOrdersLookup();
            if (salesOrderLookup == null)
            {
                salesOrderLookup = new List<SalesOrderLookup>();
            }
            return salesOrderLookup;
        }
        public SalesOrderLookup GetSalesOrderLookup(int Id)
        {
            return _salesOrderLookup.GetSalesOrderLookup(Id);
        }
    }
}
