﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class EndorsmentBenefits
{
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string ReferenceId { get; set; }

    public int? EndorsmentId { get; set; }

    public string QuotationReferenceId { get; set; }

    public string BenefitId { get; set; }
}