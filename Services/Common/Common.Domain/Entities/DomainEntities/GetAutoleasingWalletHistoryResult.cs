﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Domain.DomainEntities.Entities.DomainEntities
{
    public partial class GetAutoleasingWalletHistoryResult
    {
        public int Id { get; set; }
        public decimal RemainingBalance { get; set; }
        public int? BankId { get; set; }
        public int? CompanyId { get; set; }
        public string ReferenceId { get; set; }
        public decimal? Amount { get; set; }
        public string Method { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string CompanyKey { get; set; }
    }
}
