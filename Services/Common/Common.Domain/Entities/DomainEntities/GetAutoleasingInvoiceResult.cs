﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Domain.DomainEntities.Entities.DomainEntities
{
    public partial class GetAutoleasingInvoiceResult
    {
        public int Id { get; set; }
        public int InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime InvoiceDueDate { get; set; }
        public string UserId { get; set; }
        public string ReferenceId { get; set; }
        public short? InsuranceTypeCode { get; set; }
        public int? InsuranceCompanyID { get; set; }
        public int? PolicyId { get; set; }
        public decimal? ProductPrice { get; set; }
        public decimal? ExtraPremiumPrice { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Fees { get; set; }
        public decimal? Vat { get; set; }
        public decimal? SubTotalPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public string PolicyNo { get; set; }
        public string InsuranceCompanyNameEN { get; set; }
        public string InsuranceCompanyNameAR { get; set; }
        public string ProductTypeAR { get; set; }
        public string ProductTypeEN { get; set; }
        public string PaymentMethod { get; set; }
    }
}