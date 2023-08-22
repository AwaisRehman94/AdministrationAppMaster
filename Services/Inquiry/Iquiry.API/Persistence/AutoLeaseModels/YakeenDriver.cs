using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class YakeenDriver
{
    public Guid? DriverId { get; set; }

    public string? EnglishFirstName { get; set; }

    public string? EnglishLastName { get; set; }

    public string? EnglishSecondName { get; set; }

    public string? EnglishThirdName { get; set; }

    public string? LastName { get; set; }

    public string? SecondName { get; set; }

    public string? FirstName { get; set; }

    public string? ThirdName { get; set; }

    public string? SubtribeName { get; set; }

    public DateTime? DateOfBirthG { get; set; }

    public short? NationalityCode { get; set; }

    public string? DateOfBirthH { get; set; }

    public string? Nin { get; set; }

    public string? IdIssuePlace { get; set; }

    public string? IdExpiryDate { get; set; }

    public string? OccupationCode { get; set; }

    public int? GenderId { get; set; }

    public string? SocialStatus { get; set; }

    public int? LogId { get; set; }

    public string? OccupationDesc { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? LicenseList { get; set; }
}
