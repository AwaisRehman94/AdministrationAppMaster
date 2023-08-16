using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class SadadRequest
{
    public int Id { get; set; }

    public int BillerId { get; set; }

    public int ExactFlag { get; set; }

    public string CustomerAccountNumber { get; set; } = null!;

    public string CustomerAccountName { get; set; } = null!;

    public decimal BillAmount { get; set; }

    public DateTime BillOpenDate { get; set; }

    public DateTime BillDueDate { get; set; }

    public DateTime BillExpiryDate { get; set; }

    public DateTime BillCloseDate { get; set; }

    public decimal? BillMaxAdvanceAmount { get; set; }

    public decimal? BillMinAdvanceAmount { get; set; }

    public decimal? BillMinPartialAmount { get; set; }

    public bool? IsActive { get; set; }

    public int? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? ReferenceId { get; set; }

    public virtual ICollection<SadadResponse> SadadResponses { get; set; } = new List<SadadResponse>();
}
