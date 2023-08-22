using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class NotificationParameter
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;

    public int NotificationId { get; set; }

    public virtual Notification Notification { get; set; } = null!;
}
