using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class Occupation
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? NameAr { get; set; }

    public string? NameEn { get; set; }

    public bool? IsCitizen { get; set; }

    public bool? IsMale { get; set; }

    public virtual ICollection<Driver> Drivers { get; set; } = new List<Driver>();

    public virtual ICollection<Insured> Insureds { get; set; } = new List<Insured>();
}
