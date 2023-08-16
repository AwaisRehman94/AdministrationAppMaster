using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class RiyadBankMigsRequest
{
    public int Id { get; set; }

    public string? AccessCode { get; set; }

    public decimal Amount { get; set; }

    public string? Command { get; set; }

    public string? Locale { get; set; }

    public string? MerchTxnRef { get; set; }

    public string? MerchantId { get; set; }

    public string? OrderInfo { get; set; }

    public string? ReturnUrl { get; set; }

    public string? Version { get; set; }

    public string? SecureHash { get; set; }

    public string? SecureHashType { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<RiyadBankMigsResponse> RiyadBankMigsResponses { get; set; } = new List<RiyadBankMigsResponse>();

    public virtual ICollection<CheckoutDetail> Checkoutdetails { get; set; } = new List<CheckoutDetail>();
}
