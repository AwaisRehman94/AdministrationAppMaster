﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Common.Domain.DomainEntities.Entities.DomainEntities;

public partial class QuotationRequest
{
    public int Id { get; set; }

    public string ExternalId { get; set; }

    public Guid MainDriverId { get; set; }

    public long CityCode { get; set; }

    public DateTime? RequestPolicyEffectiveDate { get; set; }

    public Guid VehicleId { get; set; }

    public string UserId { get; set; }

    public string NajmNcdRefrence { get; set; }

    public int? NajmNcdFreeYears { get; set; }

    public bool IsComprehensiveGenerated { get; set; }

    public bool IsComprehensiveRequested { get; set; }

    public int InsuredId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public int? NoOfAccident { get; set; }

    public string NajmResponse { get; set; }

    public bool? ManualEntry { get; set; }

    public bool? IsRenewal { get; set; }

    public string PostCode { get; set; }

    public string PreviousReferenceId { get; set; }

    public Guid? AdditionalDriverIdOne { get; set; }

    public Guid? AdditionalDriverIdTwo { get; set; }

    public Guid? AdditionalDriverIdThree { get; set; }

    public Guid? AdditionalDriverIdFour { get; set; }

    public string MissingFields { get; set; }

    public Guid? TransactionId { get; set; }

    public Guid? AutoleasingTransactionId { get; set; }

    public bool? AutoleasingBulkOption { get; set; }

    public bool? AutoleasingInitialOption { get; set; }

    public int? AutoleasingContractDuration { get; set; }

    public bool? IsConverted { get; set; }

    public bool? ShowInitial { get; set; }

    public string InitialExternalId { get; set; }

    public virtual City CityCodeNavigation { get; set; }

    public virtual Insured Insured { get; set; }

    public virtual Driver MainDriver { get; set; }

    public virtual ICollection<QuotationRequestAdditionalDrivers> QuotationRequestAdditionalDrivers { get; set; } = new List<QuotationRequestAdditionalDrivers>();

    public virtual ICollection<QuotationResponse> QuotationResponse { get; set; } = new List<QuotationResponse>();

    public virtual ICollection<QuotationResponseNew> QuotationResponseNew { get; set; } = new List<QuotationResponseNew>();

    public virtual AspNetUsers User { get; set; }

    public virtual Vehicles Vehicle { get; set; }
}