﻿using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class TawuniyaProposal
{
    public int Id { get; set; }

    public string? ProposalNumber { get; set; }

    public string? ReferenceId { get; set; }

    public int? ProposalTypeCode { get; set; }
}
