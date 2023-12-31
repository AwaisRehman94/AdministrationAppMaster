﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class PolicyModification
{
    public int Id { get; set; }

    public string ReferenceId { get; set; }

    public string PolicyNo { get; set; }

    public int? InsuranceCompanyId { get; set; }

    public int? InsuranceTypeCode { get; set; }

    public string Nin { get; set; }

    public string MethodName { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string CreatedBy { get; set; }

    public string ServerIp { get; set; }

    public string UserIp { get; set; }

    public string UserAgent { get; set; }

    public string Channel { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? TaxableAmount { get; set; }

    public decimal? Vatamount { get; set; }

    public string SequenceNumber { get; set; }

    public string CustomCardNumber { get; set; }

    public Guid? ConvertedVehicleId { get; set; }

    public Guid? VehicleId { get; set; }

    public int? InvoiceNo { get; set; }

    public string QuotationReferenceId { get; set; }

    public Guid? DriverId { get; set; }

    public string CustomCard { get; set; }

    public bool IsLeasing { get; set; }

    public int? ProviderServiceId { get; set; }

    public bool IsCheckedkOut { get; set; }

    public bool IsDeleted { get; set; }
}