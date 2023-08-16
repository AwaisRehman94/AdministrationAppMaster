using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class CheckoutUser
{
    public int Id { get; set; }

    public string? ReferenceId { get; set; }

    public Guid? UserId { get; set; }

    public string? UserEmail { get; set; }

    public int? VerificationCode { get; set; }

    public bool? IsCodeVerified { get; set; }

    public string? PhoneNumber { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Nin { get; set; }

    public string? CustomCardNumber { get; set; }

    public string? SequenceNumber { get; set; }
}
