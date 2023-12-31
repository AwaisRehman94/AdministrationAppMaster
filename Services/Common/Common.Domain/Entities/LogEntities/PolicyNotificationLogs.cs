﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.Entities.LogEntities;

public partial class PolicyNotificationLogs
{
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string Channel { get; set; }

    public int? CompanyId { get; set; }

    public string CompanyName { get; set; }

    public string MethodName { get; set; }

    public string ServiceRequest { get; set; }

    public string ServerIp { get; set; }

    public string UserAgent { get; set; }

    public string UserIp { get; set; }

    public string ReferenceId { get; set; }

    public string PolicyNo { get; set; }

    public int? StatusCode { get; set; }

    public string StatusDescription { get; set; }

    public DateTime? UploadedDate { get; set; }

    public string UploadedReference { get; set; }

    public string Requester { get; set; }

    public string VehicleId { get; set; }

    public bool? VehicleAgencyRepair { get; set; }

    public string City { get; set; }
}