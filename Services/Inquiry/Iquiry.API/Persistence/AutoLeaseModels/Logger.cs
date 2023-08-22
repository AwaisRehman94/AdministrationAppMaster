﻿using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class Logger
{
    public Guid Id { get; set; }

    public string? StackTrace { get; set; }

    public string? Message { get; set; }

    public string? ExceptionAsString { get; set; }

    public DateTime? ExceptionDate { get; set; }

    public string? Key { get; set; }

    public int? Level { get; set; }
}