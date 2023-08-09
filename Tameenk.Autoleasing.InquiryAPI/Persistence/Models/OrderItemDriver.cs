﻿using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class OrderItemDriver
{
    public int Id { get; set; }

    public int OrderItemId { get; set; }

    public Guid DriverId { get; set; }

    public decimal Price { get; set; }

    public string? DriverExternalId { get; set; }
}
