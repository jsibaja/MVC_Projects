using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimePro.Persistence;
using PrimePro.Tasks;

namespace PrimePro.Test.Integration
{
    public class DefaultContext
    {
        private static SalesOrderTasks _salesOrderTasks;
        
        public static SalesOrderTasks SalesOrderTasks { get { return _salesOrderTasks ?? (_salesOrderTasks = new SalesOrderTasks()); } }
    }
}
