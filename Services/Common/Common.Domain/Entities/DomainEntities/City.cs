﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class City
{
    public long Code { get; set; }

    public string EnglishDescription { get; set; }

    public string ArabicDescription { get; set; }

    public int? RegionId { get; set; }

    public long? YakeenCode { get; set; }

    public virtual ICollection<Driver> DriverCity { get; set; } = new List<Driver>();

    public virtual ICollection<Driver> DriverWorkCity { get; set; } = new List<Driver>();

    public virtual ICollection<Insured> InsuredCity { get; set; } = new List<Insured>();

    public virtual ICollection<Insured> InsuredIdIssueCity { get; set; } = new List<Insured>();

    public virtual ICollection<Insured> InsuredWorkCity { get; set; } = new List<Insured>();

    public virtual ICollection<QuotationRequest> QuotationRequest { get; set; } = new List<QuotationRequest>();

    public virtual Region Region { get; set; }
}