using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class UserClaim
{
    public int Id { get; set; }

    public string ReferenceId { get; set; } = null!;

    public string ExternalId { get; set; } = null!;

    public int ClaimRequesterTypeId { get; set; }

    public int ClaimModuleId { get; set; }

    public int ClaimStatusId { get; set; }

    public string ClaimStatusName { get; set; } = null!;

    public string PolicyNo { get; set; } = null!;

    public string AccidentReportNumber { get; set; } = null!;

    public string NationalId { get; set; } = null!;

    public string? MobileNo { get; set; }

    public string Iban { get; set; } = null!;

    public int? InsuredBankCode { get; set; }

    public int? LicenseTypeCode { get; set; }

    public string? LicenseExpiryDate { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }
}
