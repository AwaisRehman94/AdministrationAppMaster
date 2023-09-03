﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class TabbyRequestDetails
{
    public int Id { get; set; }

    public Guid? TabbyRequestId { get; set; }

    public string Buyer { get; set; }

    public string ShippingAddress { get; set; }

    public string Order { get; set; }

    public string BuyerHistory { get; set; }

    public string OrderHistory { get; set; }

    public string Meta { get; set; }

    public string Attachment { get; set; }

    public string Lang { get; set; }

    public string MerchantCode { get; set; }

    public string MerchantUrl { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual TabbyRequests TabbyRequest { get; set; }
}