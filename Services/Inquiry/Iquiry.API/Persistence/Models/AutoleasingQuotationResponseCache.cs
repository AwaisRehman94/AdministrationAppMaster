using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class AutoleasingQuotationResponseCache
{
    public int Id { get; set; }

    public int? InsuranceCompanyId { get; set; }

    public string? ExternalId { get; set; }

    public bool? VehicleAgencyRepair { get; set; }

    public int? DeductibleValue { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? QuotationResponse { get; set; }

    public Guid? UserId { get; set; }
}
