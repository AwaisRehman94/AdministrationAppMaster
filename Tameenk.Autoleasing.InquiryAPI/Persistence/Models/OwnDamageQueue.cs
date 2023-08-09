﻿using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class OwnDamageQueue
{
    public int Id { get; set; }

    public string? ExternalId { get; set; }

    public string? PolicyNo { get; set; }

    public int ProcessingTries { get; set; }

    public string? ErrorDescription { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ProcessedOn { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public double? ServiceResponseTimeInSeconds { get; set; }

    public string? ServerIp { get; set; }

    public string? Phone { get; set; }

    public string? Method { get; set; }

    public bool IsLocked { get; set; }

    public int? SelectedLanguage { get; set; }

    public DateTime? PolicyExpiryDate { get; set; }
}
