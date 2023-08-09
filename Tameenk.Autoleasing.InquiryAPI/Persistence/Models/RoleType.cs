﻿using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class RoleType
{
    public Guid Id { get; set; }

    public string TypeNameAr { get; set; } = null!;

    public string TypeNameEn { get; set; } = null!;

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
}
