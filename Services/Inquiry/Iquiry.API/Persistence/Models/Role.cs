using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class Role
{
    public Guid Id { get; set; }

    public Guid RoleTypeId { get; set; }

    public string RoleNameAr { get; set; } = null!;

    public string RoleNameEn { get; set; } = null!;

    public virtual ICollection<AspNetUser> AspNetUsers { get; set; } = new List<AspNetUser>();

    public virtual RoleType RoleType { get; set; } = null!;
}
