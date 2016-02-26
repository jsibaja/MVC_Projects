using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimePro.Models;
//using PrimePro.Repository;
using Dormouse.Core;
using Dormouse.Core.Repository;

namespace PrimePro.Persistence
{
    public class SalesOrderViewRepository : RepositorySearch<SalesOrderView, int>, ISalesOrderViewRepository
    {
        public IList<SalesOrderView> GetAllSalesOrdersView()
        {
            return this.CurrentSession.CreateCriteria<SalesOrderView>()
                        .List<SalesOrderView>();
        }
        public SalesOrderView GetSalesOrderViewById(int Id)
        {
            //return this.CurrentSession.Get<SalesOrderView>(Id);
            return GetSalesOrderViewById(Id);
        }
    }
}
