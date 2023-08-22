﻿using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class SendNotificationLog
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? Input { get; set; }

    public int? ErrorCode { get; set; }

    public string? ErrorDescription { get; set; }

    public DateTime CreationDate { get; set; }
}