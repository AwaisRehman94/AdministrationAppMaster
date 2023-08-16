using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class CorporateWalletHistory
{
    public int Id { get; set; }

    public int? CorporateAccountId { get; set; }

    public string? ReferenceId { get; set; }

    public decimal? Amount { get; set; }

    public string? MethodName { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }
}
