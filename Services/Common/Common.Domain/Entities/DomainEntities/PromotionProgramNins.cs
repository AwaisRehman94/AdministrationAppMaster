﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class PromotionProgramNins
{
    public int Id { get; set; }

    public int? PromotionProgramId { get; set; }

    public string NationalId { get; set; }

    public string Email { get; set; }

    public bool? EmailVerified { get; set; }

    public Guid? ConfirmJoinToken { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public string ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public bool? IsDeleted { get; set; }
}