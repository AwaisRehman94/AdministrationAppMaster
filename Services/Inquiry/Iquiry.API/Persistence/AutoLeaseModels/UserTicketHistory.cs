using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class UserTicketHistory
{
    public int Id { get; set; }

    public int? TicketId { get; set; }

    public int? TicketStatusId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? AdminReply { get; set; }

    public string? RepliedBy { get; set; }
}
