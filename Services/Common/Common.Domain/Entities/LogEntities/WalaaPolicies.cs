﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.Entities.LogEntities;

public partial class WalaaPolicies
{
    public int Id { get; set; }

    public string PolicyNo { get; set; }

    public string Referenceid { get; set; }

    public string ReportUrl { get; set; }

    public bool IsSent { get; set; }

    public int ProcessingTries { get; set; }

    public string ErrorDescription { get; set; }

    public DateTime? ProcessedOn { get; set; }

    public double? ServiceResponseTimeInSeconds { get; set; }
}