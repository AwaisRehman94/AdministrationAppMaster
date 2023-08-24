using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseLogModels.Persistence.AutoLeaseLogModels
{
    public partial class NotPurchasedQuotations
    {
        public string ReferenceId { get; set; }
        public int InsuranceCompanyId { get; set; }
        public DateTime? CreateDateTime { get; set; }
    }
}
