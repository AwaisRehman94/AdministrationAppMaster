﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Domain.DomainEntities.Entities.DomainEntities
{
    public partial class GetUserInvoiceByInvoiceIdResult
    {
        public int InvoiceNo { get; set; }
        public string ReferenceId { get; set; }
        public string CheckoutDetailsEmail { get; set; }
        public string CheckoutDetailsPhone { get; set; }
        public int InsuranceCompanyID { get; set; }
        public string InsuranceCompanyNameAr { get; set; }
        public string InsuranceCompanyNameEn { get; set; }
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
        public string NIN { get; set; }
    }
}
