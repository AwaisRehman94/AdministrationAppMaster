using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class Endorsment
{
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? ServerIp { get; set; }

    public string? UserIp { get; set; }

    public string? UserAgent { get; set; }

    public string? Channel { get; set; }

    public string? FilePath { get; set; }

    public int? InsurranceCompanyId { get; set; }

    public string? ReferenceId { get; set; }

    public int? PolicyModificationRequestId { get; set; }

    public string? QuotationReferenceId { get; set; }
}
