﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Domain.DomainEntities.Entities.DomainEntities
{
    public partial class GetAutoleasingQuotationFormSettingsResult
    {
        public int Id { get; set; }
        public string ExternalId { get; set; }
        public string VehicleId { get; set; }
        public int? DeductableValue { get; set; }
        public bool? AgencyRepair { get; set; }
        public bool IsLocked { get; set; }
        public bool IsDone { get; set; }
    }
}
