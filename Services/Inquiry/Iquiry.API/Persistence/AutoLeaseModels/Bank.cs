using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class Bank
{
    public int Id { get; set; }

    public string? NameEn { get; set; }

    public string? NameAr { get; set; }

    public string? Iban { get; set; }

    public string? NationalAddress { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public bool IsAcitveWallet { get; set; }

    public bool HasWallet { get; set; }

    public bool PurchaseByNegative { get; set; }

    public decimal Balance { get; set; }

    public string? BankKey { get; set; }
}
