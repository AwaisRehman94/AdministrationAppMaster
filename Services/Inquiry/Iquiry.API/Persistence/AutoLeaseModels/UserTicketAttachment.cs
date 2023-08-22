using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class UserTicketAttachment
{
    public int Id { get; set; }

    public string? AttachmentPath { get; set; }

    public int? TicketId { get; set; }
}
