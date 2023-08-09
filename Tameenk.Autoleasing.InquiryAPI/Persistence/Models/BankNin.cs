using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class BankNin
{
    public int Id { get; set; }

    public int? BankId { get; set; }

    public string? Nin { get; set; }
}
