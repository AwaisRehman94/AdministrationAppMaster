using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class InvoiceDriver
{
    public int Id { get; set; }

    public int InvoiceId { get; set; }

    public Guid DriverId { get; set; }

    public decimal DriverPrice { get; set; }
}
