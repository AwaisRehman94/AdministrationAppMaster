using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class AtoleasingTicketType
{
    public int Id { get; set; }

    public string? TicketTypeNameAr { get; set; }

    public string? TicketTypeNameEn { get; set; }

    public int? OrderNumber { get; set; }
}
