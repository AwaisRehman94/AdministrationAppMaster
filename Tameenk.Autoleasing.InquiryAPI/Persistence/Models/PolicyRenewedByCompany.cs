using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class PolicyRenewedByCompany
{
    public int Id { get; set; }

    public string ReferenceId { get; set; } = null!;

    public string OldPolicyNo { get; set; } = null!;

    public string NewPolicyNo { get; set; } = null!;

    public int ProductTypeCode { get; set; }

    public string RenewalDate { get; set; } = null!;

    public decimal PolicyAmount { get; set; }

    public decimal PolicyVat { get; set; }

    public decimal PolicyTotalAmount { get; set; }

    public decimal PolicyRenewalCommission { get; set; }

    public Guid? VehicleId { get; set; }

    public string? SequanceNo { get; set; }

    public int? InsuranceCompanyId { get; set; }
}
