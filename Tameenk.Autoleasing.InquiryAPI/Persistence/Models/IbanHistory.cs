﻿using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class IbanHistory
{
    public int Id { get; set; }

    public string? Iban { get; set; }

    public string? ReferenceId { get; set; }

    public string? Account { get; set; }

    public string? Address { get; set; }

    public string? Bank { get; set; }

    public string? BankCode { get; set; }

    public string? Bic { get; set; }

    public string? Branch { get; set; }

    public string? BranchCode { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? CountryIso { get; set; }

    public string? Email { get; set; }

    public string? Fax { get; set; }

    public string? Phone { get; set; }

    public string? State { get; set; }

    public string? Www { get; set; }

    public string? Zip { get; set; }

    public string? SepaDataB2b { get; set; }

    public string? SepaDataCor1 { get; set; }

    public string? SepaDataScc { get; set; }

    public string? SepaDataSct { get; set; }

    public string? SepaDataSdd { get; set; }

    public string? ResponseJson { get; set; }

    public DateTime? CreatedDate { get; set; }
}
