using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseLogModels;

public partial class IntegrationTransaction
{
    public int Id { get; set; }

    public string? Message { get; set; }

    public string? InputParams { get; set; }

    public string? OutputParams { get; set; }

    public int? StatusId { get; set; }

    public DateTime? Date { get; set; }

    public string? ReferenceId { get; set; }

    public bool? VehicleAgencyRepair { get; set; }

    public string? City { get; set; }
}
