using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class AtoleasingTicketType
{
    public int Id { get; set; }

    public string? TicketTypeNameAr { get; set; }

    public string? TicketTypeNameEn { get; set; }

    public int? OrderNumber { get; set; }
}
