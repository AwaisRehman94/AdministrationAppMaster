using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class City
{
    public long Code { get; set; }

    public string? EnglishDescription { get; set; }

    public string? ArabicDescription { get; set; }

    public int? RegionId { get; set; }

    public long? YakeenCode { get; set; }

    public virtual ICollection<Driver> DriverCities { get; set; } = new List<Driver>();

    public virtual ICollection<Driver> DriverWorkCities { get; set; } = new List<Driver>();

    public virtual ICollection<Insured> InsuredCities { get; set; } = new List<Insured>();

    public virtual ICollection<Insured> InsuredIdIssueCities { get; set; } = new List<Insured>();

    public virtual ICollection<Insured> InsuredWorkCities { get; set; } = new List<Insured>();

    public virtual ICollection<QuotationRequest> QuotationRequests { get; set; } = new List<QuotationRequest>();

    public virtual Region? Region { get; set; }
}
