﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class OrderItemDriver
{
    public int Id { get; set; }

    public int OrderItemId { get; set; }

    public Guid DriverId { get; set; }

    public decimal Price { get; set; }

    public string DriverExternalId { get; set; }
}