﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class SadadNotificationResponse
{
    public int Id { get; set; }

    public int NotificationMessageId { get; set; }

    public string HeadersReceiver { get; set; }

    public string HeadersSender { get; set; }

    public string HeadersMessageType { get; set; }

    public DateTime? HeadersTimeStamp { get; set; }

    public string Status { get; set; }

    public virtual SadadNotificationMessage NotificationMessage { get; set; }
}