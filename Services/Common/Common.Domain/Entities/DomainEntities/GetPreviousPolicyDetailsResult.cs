﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Domain.DomainEntities.Entities.DomainEntities
{
    public partial class GetPreviousPolicyDetailsResult
    {
        public string PolicyNo { get; set; }
        public DateTime? PolicyIssueDate { get; set; }
        public DateTime? PolicyEffectiveDate { get; set; }
        public DateTime? PolicyExpiryDate { get; set; }
        public string NajmStatus { get; set; }
        public string ReferenceId { get; set; }
        public string Channel { get; set; }
        public int? InsuranceCompanyId { get; set; }
        public string InsuranceCompanyName { get; set; }
        public string SequenceNumber { get; set; }
        public string NIN { get; set; }
        public short? SelectedInsuranceTypeCode { get; set; }
        public decimal? TotalPrice { get; set; }
        public DateTime? CheckoutCreatedDate { get; set; }
    }
}
