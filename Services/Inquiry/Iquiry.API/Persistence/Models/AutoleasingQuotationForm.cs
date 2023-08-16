using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class AutoleasingQuotationForm
{
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ExternalId { get; set; }

    public int? BankId { get; set; }

    public string? BankName { get; set; }

    public string? UserId { get; set; }

    public string? UserEmail { get; set; }

    public string? FilePath { get; set; }
}
