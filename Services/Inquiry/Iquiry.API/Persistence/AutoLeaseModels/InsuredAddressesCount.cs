using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class InsuredAddressesCount
{
    public int Id { get; set; }

    public string? NationalId { get; set; }

    public int? YakeenAddressesCount { get; set; }

    public DateTime? CreatedDate { get; set; }
}
