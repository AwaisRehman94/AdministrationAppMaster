﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Domain.DomainEntities.Entities.DomainEntities
{
    public partial class GetPolicyStatisticsDataResult
    {
        public DateTime? CreatedDateTime { get; set; }
        public string PolicyNo { get; set; }
        public string InsuredCity { get; set; }
        public short? SelectedInsuranceTypeCode { get; set; }
        public string VehicleBodyType { get; set; }
        public string VehicleMaker { get; set; }
        public string VehicleModel { get; set; }
        public short? ModelYear { get; set; }
        public string InsuredId { get; set; }
        public DateTime InsuredBirthDate { get; set; }
        public string InsuredBirthDateH { get; set; }
        public int? GenderId { get; set; }
        public DateTime? Driver1_DateOfBirthG { get; set; }
        public int? Driver1_GenderCode { get; set; }
        public DateTime? Driver2_DateOfBirthG { get; set; }
        public int? Driver2_GenderCode { get; set; }
        public decimal? PriceTypeCode_7_Value { get; set; }
        public decimal? PriceTypeCode_2_Value { get; set; }
        public decimal? PriceTypeCode_2_Percentage { get; set; }
        public decimal? PriceTypeCode_3_Value { get; set; }
        public decimal? PriceTypeCode_3_Percentage { get; set; }
        public decimal? PriceTypeCode_1_Value { get; set; }
        public decimal? PriceTypeCode_1_Percentage { get; set; }
        public decimal? PriceTypeCode_9_Value { get; set; }
        public decimal? PriceTypeCode_9_Percentage { get; set; }
        public decimal? PriceTypeCode_8_Value { get; set; }
        public decimal? PriceTypeCode_8_Percentage { get; set; }
        public decimal ProductPrice { get; set; }
    }
}