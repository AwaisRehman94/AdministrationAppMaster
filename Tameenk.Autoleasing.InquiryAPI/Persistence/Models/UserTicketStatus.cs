﻿using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class UserTicketStatus
{
    public int Id { get; set; }

    public string? StatusNameAr { get; set; }

    public string? StatusNameEn { get; set; }
}
