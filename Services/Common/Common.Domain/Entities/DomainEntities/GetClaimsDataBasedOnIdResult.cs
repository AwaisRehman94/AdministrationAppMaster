﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Domain.DomainEntities.Entities.DomainEntities
{
    public partial class GetClaimsDataBasedOnIdResult
    {
        public int Id { get; set; }
        public string ReferenceId { get; set; }
        public string PolicyNo { get; set; }
        public string ExternalId { get; set; }
        public string DriverLicenseExpiryDate { get; set; }
        public int? DriverLicenseTypeCode { get; set; }
        public string Iban { get; set; }
        public int ClaimStatusId { get; set; }
        public string ClaimStatusName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}