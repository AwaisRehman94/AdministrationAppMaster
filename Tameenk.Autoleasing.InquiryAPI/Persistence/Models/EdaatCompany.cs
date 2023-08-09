﻿using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class EdaatCompany
{
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UserId { get; set; }

    public string? RegistrationNo { get; set; }

    public string? NameAr { get; set; }

    public string? NameEn { get; set; }

    public string? CommissionerNationalId { get; set; }

    public string? CommissionerName { get; set; }

    public string? CommissionerEmail { get; set; }

    public string? CommissionerMobileNo { get; set; }

    public string? CustomerRefNumber { get; set; }

    public int EdaatRequestId { get; set; }

    public virtual EdaatRequest EdaatRequest { get; set; } = null!;
}
