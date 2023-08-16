using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class Notification
{
    public int Id { get; set; }

    public string Group { get; set; } = null!;

    public string? GroupReferenceId { get; set; }

    public int TypeId { get; set; }

    public int StatusId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<NotificationParameter> NotificationParameters { get; set; } = new List<NotificationParameter>();
}
