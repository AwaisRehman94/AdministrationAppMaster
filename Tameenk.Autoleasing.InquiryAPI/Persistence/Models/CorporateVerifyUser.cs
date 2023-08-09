﻿using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class CorporateVerifyUser
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? VerificationCode { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsVerified { get; set; }

    public string? MethodName { get; set; }
}
