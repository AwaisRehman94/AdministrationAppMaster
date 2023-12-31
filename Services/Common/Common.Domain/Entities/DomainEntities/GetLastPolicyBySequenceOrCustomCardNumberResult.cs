﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Domain.DomainEntities.Entities.DomainEntities
{
    public partial class GetLastPolicyBySequenceOrCustomCardNumberResult
    {
        public int? Id { get; set; }
        public string PolicyNo { get; set; }
        public DateTime? PolicyIssueDate { get; set; }
        public int InvoiceId { get; set; }
        public int InvoiceNo { get; set; }
        public string CheckOutDetailsId { get; set; }
        public string CheckoutDetailEmail { get; set; }
        public string CheckoutDetailPhone { get; set; }
        public string NIN { get; set; }
        public Guid VehicleID { get; set; }
        public short? CarPlateNumber { get; set; }
        public string CarPlateText1 { get; set; }
        public string CarPlateText2 { get; set; }
        public string CarPlateText3 { get; set; }
        public byte? PlateTypeCode { get; set; }
        public string VehicleMaker { get; set; }
        public short? VehicleMakerCode { get; set; }
        public string VehicleModel { get; set; }
        public long? VehicleModelCode { get; set; }
        public short? ModelYear { get; set; }
        public string SequenceNumber { get; set; }
        public string CustomCardNumber { get; set; }
        public string InsuranceCompanyNameAR { get; set; }
        public string InsuranceCompanyNameEN { get; set; }
    }
}
