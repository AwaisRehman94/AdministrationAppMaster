using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class UserTicketAttachment
{
    public int Id { get; set; }

    public string? AttachmentPath { get; set; }

    public int? TicketId { get; set; }
}
