using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class CityCenter
{
    public int Id { get; set; }

    public string? CityId { get; set; }

    public string? ArabicName { get; set; }

    public string? EnglishName { get; set; }

    public string? RegionId { get; set; }

    public string? RegionArabicName { get; set; }

    public string? RegionEnglishName { get; set; }

    public string? ElmCode { get; set; }

    public bool? IsActive { get; set; }
}
