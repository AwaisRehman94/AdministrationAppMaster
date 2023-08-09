using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class DrivingLicenceYear
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string? NameAr { get; set; }

    public string? NameEn { get; set; }
}
