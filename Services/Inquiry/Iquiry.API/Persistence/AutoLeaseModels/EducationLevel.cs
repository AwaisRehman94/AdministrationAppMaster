using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class EducationLevel
{
    public int Id { get; set; }

    public int? Code { get; set; }

    public string? NameAr { get; set; }

    public string? NameEn { get; set; }
}
