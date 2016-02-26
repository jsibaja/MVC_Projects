using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimePro.Models;
using PrimePro.Persistence;
//using PrimePro.Repository;

namespace PrimePro.Tasks
{
    public class SalesOrderTasks : ISalesOrderViewRepository
    {
        private readonly ISalesOrderViewRepository _salesOrderLookup;

        public SalesOrderTasks()
            : this(new SalesOrderViewRepository())
        {

        }
        public SalesOrderTasks(ISalesOrderViewRepository salesOrderLookup)
        {
            _salesOrderLookup = salesOrderLookup;
        }

        public IList<SalesOrderView> GetAllSalesOrdersView()
        {
            var salesOrderLookup = _salesOrderLookup.GetAllSalesOrdersView();
            if (salesOrderLookup == null)
            {
                salesOrderLookup = new List<SalesOrderView>();
            }
            return salesOrderLookup;
        }
        public SalesOrderView GetSalesOrderViewById(int Id)
        {
            return _salesOrderLookup.GetSalesOrderViewById(Id);
        }

        public IList<TSource> Filter<TSource>(TSource filterObj) where TSource : class
        {
            throw new NotImplementedException();
        }

        public IList<SalesOrderView> Filter(SalesOrderView filterObj)
        {
            throw new NotImplementedException();
        }

        public IList<TSource> Search<TSource>(Dormouse.Core.Search.AdvancedSearchCriteria crit) where TSource : class
        {
            throw new NotImplementedException();
        }

        public IList<SalesOrderView> Search(Dormouse.Core.Search.AdvancedSearchCriteria crit)
        {
            throw new NotImplementedException();
        }

        public IList<TSource> Search<TSource>(Dormouse.Core.Search.SearchCriteria crit) where TSource : class
        {
            throw new NotImplementedException();
        }

        public IList<SalesOrderView> Search(Dormouse.Core.Search.SearchCriteria crit)
        {
            throw new NotImplementedException();
        }
    }
}
