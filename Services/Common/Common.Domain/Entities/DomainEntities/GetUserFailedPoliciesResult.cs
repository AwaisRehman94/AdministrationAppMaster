﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Domain.DomainEntities.Entities.DomainEntities
{
    public partial class GetUserFailedPoliciesResult
    {
        public string EnglishFirstName { get; set; }
        public string EnglishSecondName { get; set; }
        public string EnglishThirdName { get; set; }
        public string EnglishLastName { get; set; }
        public string QuotationNo { get; set; }
        public DateTime? PolicyEffectiveDate { get; set; }
        public string ReferenceId { get; set; }
        public int InsuranceCompanyID { get; set; }
    }
}
