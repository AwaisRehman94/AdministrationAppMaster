using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class ProductDriver
{
    public int Id { get; set; }

    public Guid ProductId { get; set; }

    public Guid DriverId { get; set; }

    public decimal DriverPrice { get; set; }

    public string? DriverExternalId { get; set; }
}
