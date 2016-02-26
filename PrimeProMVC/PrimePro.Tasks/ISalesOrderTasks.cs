using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimePro.Models;
using Dormouse.Core.Search;

namespace PrimePro.Tasks
{
    public interface ISalesOrderTasks
    {
        IList<SalesOrderView> GetAllSalesOrdersView();
        SalesOrderView GetSalesOrderViewById(int Id);
    }
}
