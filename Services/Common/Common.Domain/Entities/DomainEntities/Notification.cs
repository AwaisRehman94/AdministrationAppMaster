﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class Notification
{
    public int Id { get; set; }

    public string Group { get; set; }

    public string GroupReferenceId { get; set; }

    public int TypeId { get; set; }

    public int StatusId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<NotificationParameter> NotificationParameter { get; set; } = new List<NotificationParameter>();
}