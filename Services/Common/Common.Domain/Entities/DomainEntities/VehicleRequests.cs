﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class VehicleRequests
{
    public int Id { get; set; }

    public string VehicleId { get; set; }

    public string DriverNin { get; set; }

    public DateTime? CreatedDate { get; set; }

    public long? CityId { get; set; }
}