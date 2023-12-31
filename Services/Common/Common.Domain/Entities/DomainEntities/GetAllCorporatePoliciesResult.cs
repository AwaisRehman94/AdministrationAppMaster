﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Domain.DomainEntities.Entities.DomainEntities
{
    public partial class GetAllCorporatePoliciesResult
    {
        public int Id { get; set; }
        public string CheckOutDetailsId { get; set; }
        public int? InsuranceCompanyID { get; set; }
        public DateTime? PolicyEffectiveDate { get; set; }
        public DateTime? PolicyExpiryDate { get; set; }
        public Guid? PolicyFileId { get; set; }
        public DateTime? PolicyIssueDate { get; set; }
        public string PolicyNo { get; set; }
        public byte StatusCode { get; set; }
        public string CheckOutDetailsEmail { get; set; }
        public bool? CheckOutDetailsIsEmailVerified { get; set; }
        public string IBAN { get; set; }
        public string ReferenceId { get; set; }
        public string Phone { get; set; }
        public string NajmStatusNameAr { get; set; }
        public string NajmStatusNameEn { get; set; }
        public string PolicyStatusKey { get; set; }
        public string PolicyStatusNameAr { get; set; }
        public string PolicyStatusNameEn { get; set; }
        public string InsuranceCompanyNameAR { get; set; }
        public string InsuranceCompanyNameEN { get; set; }
        public string ExternalId { get; set; }
        public Guid ID { get; set; }
        public short? VehicleMakerCode { get; set; }
        public string VehicleMaker { get; set; }
        public short? ModelYear { get; set; }
        public string VehicleModel { get; set; }
        public long? VehicleModelCode { get; set; }
        public string RegisterationPlace { get; set; }
        public byte? PlateTypeCode { get; set; }
        public short? CarPlateNumber { get; set; }
        public string CarPlateText1 { get; set; }
        public string CarPlateText2 { get; set; }
        public string CarPlateText3 { get; set; }
        public string insuredFullNameAr { get; set; }
        public string DriverNIN { get; set; }
        public decimal? TotalPremium { get; set; }
        public decimal? QuotationPrice { get; set; }
        public decimal? PolicyPrice { get; set; }
        public decimal? PaidAmount { get; set; }
        public decimal BenfitsPrice { get; set; }
        public string CorporateUserEmail { get; set; }
        public string InsuranceType { get; set; }
        public string Name { get; set; }
    }
}
