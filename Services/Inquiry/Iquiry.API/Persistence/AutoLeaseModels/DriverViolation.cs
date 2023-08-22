﻿using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class DriverViolation
{
    public int Id { get; set; }

    public Guid DriverId { get; set; }

    public int ViolationId { get; set; }

    public int? InsuredId { get; set; }

    public string? Nin { get; set; }

    public virtual Driver Driver { get; set; } = null!;
}