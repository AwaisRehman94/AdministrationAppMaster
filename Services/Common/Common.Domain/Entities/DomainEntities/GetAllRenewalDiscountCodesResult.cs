﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Domain.DomainEntities.Entities.DomainEntities
{
    public partial class GetAllRenewalDiscountCodesResult
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? DiscountType { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Percentage { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int? UserId { get; set; }
        public bool IsActive { get; set; }
        public int? MessageType { get; set; }
        public int CodeType { get; set; }
    }
}
