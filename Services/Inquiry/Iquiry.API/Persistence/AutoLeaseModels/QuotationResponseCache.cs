using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class QuotationResponseCache
{
    public int Id { get; set; }

    public int? InsuranceCompanyId { get; set; }

    public string? ExternalId { get; set; }

    public int? InsuranceTypeCode { get; set; }

    public bool? VehicleAgencyRepair { get; set; }

    public int? DeductibleValue { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? QuotationResponse { get; set; }

    public Guid? UserId { get; set; }
}
