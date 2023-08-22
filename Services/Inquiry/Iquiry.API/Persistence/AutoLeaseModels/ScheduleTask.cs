using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class ScheduleTask
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Seconds { get; set; }

    public string Type { get; set; } = null!;

    public bool Enabled { get; set; }

    public bool StopOnError { get; set; }

    public string? LeasedByMachineName { get; set; }

    public short? MaxTrials { get; set; }

    public string? CommonPolicyFailureRecipient { get; set; }

    public int? SendingThreshold { get; set; }

    public DateTime? LeasedUntil { get; set; }

    public DateTime? LastStart { get; set; }

    public DateTime? LastEnd { get; set; }

    public DateTime? LastSuccess { get; set; }

    public string? ServerIp { get; set; }
}
