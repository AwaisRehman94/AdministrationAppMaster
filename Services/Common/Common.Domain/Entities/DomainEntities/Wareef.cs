﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class Wareef
{
    public int Id { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string Createdby { get; set; }

    public string NameAr { get; set; }

    public string ImageBytes { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string ModifiedBy { get; set; }

    public int? WareefCategoryId { get; set; }

    public string NameEn { get; set; }

    public string ItemUrl { get; set; }

    public string Wcode { get; set; }
}