﻿using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class Violation
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string DescriptionAr { get; set; } = null!;

    public string DescriptionEn { get; set; } = null!;
}