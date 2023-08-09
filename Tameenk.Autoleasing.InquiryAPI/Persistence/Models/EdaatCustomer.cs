using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class EdaatCustomer
{
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UserId { get; set; }

    public string? NationalId { get; set; }

    public string? FirstNameAr { get; set; }

    public string? FatherNameAr { get; set; }

    public string? GrandFatherNameAr { get; set; }

    public string? LastNameAr { get; set; }

    public string? FirstNameEn { get; set; }

    public string? FatherNameEn { get; set; }

    public string? GrandFatherNameEn { get; set; }

    public string? LastNameEn { get; set; }

    public string? Email { get; set; }

    public string? MobileNo { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? DateOfBirthHijri { get; set; }

    public string? CustomerRefNumber { get; set; }

    public int? EdaatRequestId { get; set; }

    public virtual EdaatRequest? EdaatRequest { get; set; }
}
