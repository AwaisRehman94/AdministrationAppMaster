﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Domain.DomainEntities.Entities.DomainEntities
{
    public partial class GetRequestInfoForApplePayResult
    {
        public string ReferenceId { get; set; }
        public int? InsuranceCompanyId { get; set; }
        public string InsuranceCompanyName { get; set; }
        public bool? IsCancelled { get; set; }
        public int? PolicyStatusId { get; set; }
        public string Channel { get; set; }
        public int? PaymentMethodId { get; set; }
        public string Email { get; set; }
        public bool? IsEmailVerified { get; set; }
        public string Phone { get; set; }
        public string UserId { get; set; }
        public int HyperpayRequestId { get; set; }
        public Guid? SelectedProductId { get; set; }
        public short? SelectedInsuranceTypeCode { get; set; }
        public decimal? TotalBCareFees { get; set; }
        public decimal? TotalBCareCommission { get; set; }
        public decimal? TotalCompanyAmount { get; set; }
        public decimal HyperpayRequestAmount { get; set; }
        public decimal? InvoiceAmount { get; set; }
        public int? ProductInsuranceTypeCode { get; set; }
        public string NameAR { get; set; }
        public string NameEN { get; set; }
        public string ArabicDescription { get; set; }
        public string EnglishDescription { get; set; }
        public decimal? TotalBCareDiscount { get; set; }
        public string DiscountCode { get; set; }
        public Guid VehicleId { get; set; }
        public string ODReference { get; set; }
    }
}
