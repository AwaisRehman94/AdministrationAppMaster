﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class BankCode
{
    public int Id { get; set; }

    public string EnglishDescription { get; set; }

    public string ArabicDescription { get; set; }

    public int? ValidationCode { get; set; }

    public string Code { get; set; }
}