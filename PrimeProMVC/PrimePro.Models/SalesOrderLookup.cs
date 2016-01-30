using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PrimePro.Models
{
    public class SalesOrderLookup
    {
        public virtual int? Id { get; set; }
        public int Revision { get; set; }
        public int ContractNo { get; set; }
        public string ContractRev { get; set; }
        public int AgencyId { get; set; }
        [DisplayName("Owner")]
        public string AgencyName { get; set; }
        public int AdvertiserId { get; set; }
        public int ProductId { get; set; }
        public string Status { get; set; }
        public string NAM { get; set; }
        public string ProposalDate { get; set; }
        public string FlighDates { get; set; }
        public DateTime FlightBegin { get; set; }
        public DateTime FlightEnd { get; set; }
        public bool PendingReport { get; set; }
        public string InternalComment { get; set; }
        public string VirtualStatus { get; set; }
        public bool Restricted { get; set; }
        public decimal TotalGross { get; set; }
        public virtual AgencyLookup Agency { get; set; }
    }
}
