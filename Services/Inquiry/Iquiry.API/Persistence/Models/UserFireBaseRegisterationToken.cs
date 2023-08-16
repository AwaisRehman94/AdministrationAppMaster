using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class UserFireBaseRegisterationToken
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public string RegisterationToken { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }
}
