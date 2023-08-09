using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class Contact
{
    public int Id { get; set; }

    public string? MobileNumber { get; set; }

    public string? HomePhone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<InsuranceCompany> InsuranceCompanies { get; set; } = new List<InsuranceCompany>();
}
