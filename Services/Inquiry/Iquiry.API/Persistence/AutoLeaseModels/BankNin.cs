using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class BankNin
{
    public int Id { get; set; }

    public int? BankId { get; set; }

    public string? Nin { get; set; }
}
