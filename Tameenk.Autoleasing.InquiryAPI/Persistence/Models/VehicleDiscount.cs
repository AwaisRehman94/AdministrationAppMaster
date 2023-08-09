using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class VehicleDiscount
{
    public int Id { get; set; }

    public string? Nin { get; set; }

    public Guid? VehicleId { get; set; }

    public string? DiscountCode { get; set; }

    public bool? IsUsed { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? PreviousReferenceId { get; set; }

    public string? ReferenceId { get; set; }

    public string? SequenceNumber { get; set; }

    public string? CustomCardNumber { get; set; }
}
