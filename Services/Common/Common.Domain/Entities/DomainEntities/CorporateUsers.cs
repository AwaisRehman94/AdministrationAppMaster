﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class CorporateUsers
{
    public string UserId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string UserName { get; set; }

    public int CorporateAccountId { get; set; }

    public string PasswordHash { get; set; }

    public string PhoneNumber { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsSuperAdmin { get; set; }

    public DateTime? NotificationDate { get; set; }
}