﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class AutoleasingInitialQuotationCompanies
{
    public int Id { get; set; }

    public string ExternalId { get; set; }

    public int CompanyId { get; set; }

    public int BankId { get; set; }

    public string UserId { get; set; }

    public DateTime? CreatedDate { get; set; }
}