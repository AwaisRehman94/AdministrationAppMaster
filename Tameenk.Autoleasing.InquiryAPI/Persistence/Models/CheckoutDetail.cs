using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class CheckoutDetail
{
    public string ReferenceId { get; set; } = null!;

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Iban { get; set; }

    public int? ImageRightId { get; set; }

    public int? ImageLeftId { get; set; }

    public int? ImageFrontId { get; set; }

    public int? ImageBackId { get; set; }

    public int? ImageBodyId { get; set; }

    public string UserId { get; set; } = null!;

    public Guid VehicleId { get; set; }

    public Guid? MainDriverId { get; set; }

    public int? PolicyStatusId { get; set; }

    public Guid? SelectedProductId { get; set; }

    public short? SelectedInsuranceTypeCode { get; set; }

    public int? BankCodeId { get; set; }

    public int? PaymentMethodId { get; set; }

    public int? SelectedLanguage { get; set; }

    public string? Channel { get; set; }

    public int? InsuranceCompanyId { get; set; }

    public string? InsuranceCompanyName { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public bool? IsCancelled { get; set; }

    public DateTime? CancelationDate { get; set; }

    public string? CancelledBy { get; set; }

    public bool? IsEmailVerified { get; set; }

    public Guid? AdditionalDriverIdOne { get; set; }

    public Guid? AdditionalDriverIdTwo { get; set; }

    public Guid? AdditionalDriverIdThree { get; set; }

    public Guid? AdditionalDriverIdFour { get; set; }

    public int? BankId { get; set; }

    public int? CorporateAccountId { get; set; }

    public Guid? MerchantTransactionId { get; set; }

    public bool? IsAutoleasingWallet { get; set; }

    public string? DiscountCode { get; set; }

    public decimal? DiscountPercentage { get; set; }

    public int? DiscountType { get; set; }

    public decimal? DiscountValue { get; set; }

    public string? Odreference { get; set; }

    public string? MainPolicyReferenceId { get; set; }

    public int? ProviderServiceId { get; set; }

    public bool Isleasing { get; set; }

    public virtual AdditionalInfo? AdditionalInfo { get; set; }

    public virtual ICollection<CheckoutAdditionalDriver> CheckoutAdditionalDrivers { get; set; } = new List<CheckoutAdditionalDriver>();

    public virtual CheckoutCarImage? ImageBack { get; set; }

    public virtual CheckoutCarImage? ImageBody { get; set; }

    public virtual CheckoutCarImage? ImageFront { get; set; }

    public virtual CheckoutCarImage? ImageLeft { get; set; }

    public virtual CheckoutCarImage? ImageRight { get; set; }

    public virtual InsuranceCompany? InsuranceCompany { get; set; }

    public virtual Driver? MainDriver { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual PaymentMethod? PaymentMethod { get; set; }

    public virtual ICollection<Policy> Policies { get; set; } = new List<Policy>();

    public virtual PolicyStatus? PolicyStatus { get; set; }

    public virtual ProductType? SelectedInsuranceTypeCodeNavigation { get; set; }

    public virtual Product? SelectedProduct { get; set; }

    public virtual AspNetUser User { get; set; } = null!;

    public virtual Vehicle Vehicle { get; set; } = null!;

    public virtual ICollection<PayfortPaymentRequest> PayfortPaymentRequests { get; set; } = new List<PayfortPaymentRequest>();

    public virtual ICollection<RiyadBankMigsRequest> RiyadBankMigsRequests { get; set; } = new List<RiyadBankMigsRequest>();
}
