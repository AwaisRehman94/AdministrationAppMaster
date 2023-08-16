using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class BankInsuranceCompany
{
    public int Id { get; set; }

    public int BankId { get; set; }

    public int CompanyId { get; set; }

    public string CompanyKey { get; set; } = null!;

    public bool? IsActive { get; set; }
}
