﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.Entities.LogEntities;

public partial class ProfileRequestsLog
{
    public int Id { get; set; }

    public Guid? UserId { get; set; }

    public string Mobile { get; set; }

    public string Email { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string Channel { get; set; }

    public int? ErrorCode { get; set; }

    public string ErrorDescription { get; set; }

    public string UserIp { get; set; }

    public string UserAgent { get; set; }

    public string Method { get; set; }

    public string ServerIp { get; set; }

    public bool? VehicleAgencyRepair { get; set; }

    public string City { get; set; }
}