using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class TawuniyaTempTable
{
    public int Id { get; set; }

    public string? QtServiceRequestMessage { get; set; }

    public string? PorposalResponse { get; set; }

    public string? ReferenceId { get; set; }
}
