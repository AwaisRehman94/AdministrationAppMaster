﻿using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class RegisterTokenLog
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? Token { get; set; }

    public int? ErrorCode { get; set; }

    public string? ErrorDescription { get; set; }

    public DateTime CreationDate { get; set; }
}