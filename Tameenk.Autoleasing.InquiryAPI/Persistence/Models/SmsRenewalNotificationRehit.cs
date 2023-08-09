using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class SmsRenewalNotificationRehit
{
    public string? Phone { get; set; }

    public int? SelectedLanguage { get; set; }

    public string? SequenceNumber { get; set; }

    public string? CustomCardNumber { get; set; }

    public string VehicleModel { get; set; } = null!;

    public short? CarPlateNumber { get; set; }

    public string? CarPlateText1 { get; set; }

    public string? CarPlateText2 { get; set; }

    public string? CarPlateText3 { get; set; }

    public string? FirstName { get; set; }

    public string ExternalId { get; set; } = null!;

    public string? EnglishFirstName { get; set; }

    public string ReferenceId { get; set; } = null!;

    public DateTime? CreatedDateTime { get; set; }

    public DateTime? PolicyExpiryDate { get; set; }

    public DateTime? PolicyEffectiveDate { get; set; }

    public string? MakerDescAr { get; set; }

    public string? MakerDescEn { get; set; }

    public string? ModelDescAr { get; set; }

    public string? ModelDescEn { get; set; }

    public string UserId { get; set; } = null!;

    public short? ModelYear { get; set; }

    public int? InsuranceCompanyId { get; set; }

    public string? InsuranceCompanyName { get; set; }

    public string? Channel { get; set; }

    public Guid VehicleId { get; set; }

    public string PolicyNo { get; set; } = null!;

    public string? CarOwnerNin { get; set; }

    public bool OwnerTransfer { get; set; }

    public string NationalId { get; set; } = null!;

    public int IsLocked { get; set; }

    public int IsDone { get; set; }
}
