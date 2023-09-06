﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class TabbyResponses
{
    public long Id { get; set; }

    public Guid? TabbyRequestId { get; set; }

    public string PaymentId { get; set; }

    public string ReferenceId { get; set; }

    public string UserId { get; set; }

    public string Channel { get; set; }

    public double? TotalAmount { get; set; }

    public double? AmountPerInstallment { get; set; }

    public int? InstallmentCount { get; set; }

    public double? AmountRemaining { get; set; }

    public bool? IsWarning { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual TabbyRequests TabbyRequest { get; set; }

    public virtual ICollection<TabbyResponseDetails> TabbyResponseDetails { get; set; } = new List<TabbyResponseDetails>();
}