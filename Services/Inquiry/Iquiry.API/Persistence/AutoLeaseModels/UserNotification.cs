using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class UserNotification
{
    public int Id { get; set; }

    public string MessageId { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Body { get; set; } = null!;

    public string? ImageUrl { get; set; }

    public DateTime CreationDate { get; set; }

    public string? UserId { get; set; }

    public string? ReferenceId { get; set; }
}
