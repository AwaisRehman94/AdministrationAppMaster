﻿using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class EsalSupplier
{
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ReferenceId { get; set; }

    public string? SupplierId { get; set; }

    public string? RegionEnglish { get; set; }

    public string? RegionArabic { get; set; }

    public string? CityEnglish { get; set; }

    public string? CityArabic { get; set; }

    public string? LocalityEnglish { get; set; }

    public string? LocalityArabic { get; set; }

    public string? BranchEnglish { get; set; }

    public string? BranchArabic { get; set; }

    public string? PlantEnglish { get; set; }

    public string? PlantArabic { get; set; }

    public string? BankSwiftCode { get; set; }

    public string? Iban { get; set; }
}
