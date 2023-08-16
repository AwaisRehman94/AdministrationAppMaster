using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class ProfileNotification
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? DescriptionAr { get; set; }

    public string? DescriptionEn { get; set; }

    public int? TypeId { get; set; }

    public int? ModuleId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? TicketStatusId { get; set; }
}
