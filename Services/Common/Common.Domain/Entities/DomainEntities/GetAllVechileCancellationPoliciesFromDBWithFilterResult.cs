﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Domain.DomainEntities.Entities.DomainEntities
{
    public partial class GetAllVechileCancellationPoliciesFromDBWithFilterResult
    {
        public string insuredIBAN { get; set; }
        public string companyName { get; set; }
        public string insuredId { get; set; }
        public string referenceId { get; set; }
        public string policyNo { get; set; }
        public bool? IsCancelled { get; set; }
    }
}
