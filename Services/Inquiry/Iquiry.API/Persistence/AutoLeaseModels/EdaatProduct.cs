using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class EdaatProduct
{
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UserId { get; set; }

    public int? ProductId { get; set; }

    public double? Price { get; set; }

    public double? Qty { get; set; }

    public int? EdaatRequestId { get; set; }

    public virtual EdaatRequest? EdaatRequest { get; set; }
}
