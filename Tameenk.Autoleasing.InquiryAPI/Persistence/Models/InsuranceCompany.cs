using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class InsuranceCompany
{
    public int InsuranceCompanyId { get; set; }

    public string NameAr { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public string? DescAr { get; set; }

    public string? DescEn { get; set; }

    public DateTime CreatedDate { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public Guid? ModifiedBy { get; set; }

    public int? AddressId { get; set; }

    public int? ContactId { get; set; }

    public string? Temp { get; set; }

    public string? NamespaceTypeName { get; set; }

    public string? ClassTypeName { get; set; }

    public string? ReportTemplateName { get; set; }

    public bool? IsActive { get; set; }

    public string Key { get; set; } = null!;

    public string? PolicyFailureRecipient { get; set; }

    public bool? IsUseNumberOfAccident { get; set; }

    public string? NajmNcdFreeYearsToUseNumberOfAccident { get; set; }

    public bool? AllowAnonymousRequest { get; set; }

    public bool? ShowQuotationToUser { get; set; }

    public bool? HasDiscount { get; set; }

    public string? DiscountText { get; set; }

    public DateTime? DiscountStartDate { get; set; }

    public DateTime? DiscountEndDate { get; set; }

    public bool? IsActiveTpl { get; set; }

    public bool? IsActiveComprehensive { get; set; }

    public bool? IsAddressValidationEnabled { get; set; }

    public string? Vat { get; set; }

    public bool? UsePhoneCamera { get; set; }

    public string? TermsAndConditionsFilePath { get; set; }

    public bool ValidateSaudiPostAddressInQuotation { get; set; }

    public int? Order { get; set; }

    public bool? IsActiveAutoleasing { get; set; }

    public string? TermsAndConditionsFilePathComp { get; set; }

    public string? TermsAndConditionsFilePathSanadPlus { get; set; }

    public string? AutoleaseReportTemplateName { get; set; }

    public int? NajmGrade { get; set; }

    public DateTime? NajmGradeValidFrom { get; set; }

    public DateTime? NajmGradeValidTo { get; set; }

    public bool? ActiveTabbyTpl { get; set; }

    public bool? ActiveTabbyComp { get; set; }

    public bool? ActiveTabbySanadPlus { get; set; }

    public bool? ActiveTabbyWafiSmart { get; set; }

    public virtual Address? Address { get; set; }

    public virtual ICollection<CheckoutDetail> CheckoutDetails { get; set; } = new List<CheckoutDetail>();

    public virtual Contact? Contact { get; set; }

    public virtual ICollection<Deductible> Deductibles { get; set; } = new List<Deductible>();

    public virtual ICollection<InsuaranceCompanyBenefit> InsuaranceCompanyBenefits { get; set; } = new List<InsuaranceCompanyBenefit>();

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual ICollection<Policy> Policies { get; set; } = new List<Policy>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<PromotionProgramCode> PromotionProgramCodes { get; set; } = new List<PromotionProgramCode>();

    public virtual ICollection<QuotationResponseNew> QuotationResponseNews { get; set; } = new List<QuotationResponseNew>();

    public virtual ICollection<QuotationResponse> QuotationResponses { get; set; } = new List<QuotationResponse>();

    public virtual ICollection<UserPurchasedPromotionProgram> UserPurchasedPromotionPrograms { get; set; } = new List<UserPurchasedPromotionProgram>();
}
