﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.Entities.LogEntities;

public partial class InquiryRequestLog
{
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string UserId { get; set; }

    public string UserName { get; set; }

    public string UserIp { get; set; }

    public string UserAgent { get; set; }

    public string ServerIp { get; set; }

    public string Channel { get; set; }

    public int? ErrorCode { get; set; }

    public string ErrorDescription { get; set; }

    public string MethodName { get; set; }

    public Guid? RequestId { get; set; }

    public string Nin { get; set; }

    public string VehicleId { get; set; }

    public int? CityCode { get; set; }

    public string ExternalId { get; set; }

    public DateTime? PolicyEffectiveDate { get; set; }

    public string NajmNcdRefrence { get; set; }

    public int? NajmNcdFreeYears { get; set; }

    public string ServiceRequest { get; set; }

    public string MobileVersion { get; set; }

    public bool? VehicleAgencyRepair { get; set; }

    public string City { get; set; }
}