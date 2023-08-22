using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class WareefDescount
{
    public int Id { get; set; }

    public string? DescountValue { get; set; }

    public bool? IsDeleted { get; set; }

    public int? WareefId { get; set; }

    public string? WdescountCode { get; set; }
}
