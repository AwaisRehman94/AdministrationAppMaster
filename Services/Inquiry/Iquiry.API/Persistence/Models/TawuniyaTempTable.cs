using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class TawuniyaTempTable
{
    public int Id { get; set; }

    public string? QtServiceRequestMessage { get; set; }

    public string? PorposalResponse { get; set; }

    public string? ReferenceId { get; set; }
}
