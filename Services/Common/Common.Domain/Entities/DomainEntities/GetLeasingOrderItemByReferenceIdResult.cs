﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Domain.DomainEntities.Entities.DomainEntities
{
    public partial class GetLeasingOrderItemByReferenceIdResult
    {
        public int Id { get; set; }
        public string ReferenceId { get; set; }
        public Guid ProductId { get; set; }
        public decimal? Price { get; set; }
    }
}
