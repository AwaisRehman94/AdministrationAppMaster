﻿using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class YakeenCityCenter
{
    public int Id { get; set; }

    public int? CityId { get; set; }

    public string? CityName { get; set; }

    public string? EnglishName { get; set; }

    public int? ZipCode { get; set; }

    public int? RegionId { get; set; }

    public string? RegionArabicName { get; set; }

    public string? RegionEnglishName { get; set; }

    public int? ElmCode { get; set; }
}