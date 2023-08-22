using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class AutomatedTestIntegrationTransaction
{
    public int Id { get; set; }

    public string? Message { get; set; }

    public string? InputParams { get; set; }

    public string? OutputParams { get; set; }

    public int? StatusId { get; set; }

    public DateTime? Date { get; set; }

    public bool? Retrieved { get; set; }
}
