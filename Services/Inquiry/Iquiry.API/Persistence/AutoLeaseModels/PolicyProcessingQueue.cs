using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class PolicyProcessingQueue
{
    public int Id { get; set; }

    public string ReferenceId { get; set; } = null!;

    public int PriorityId { get; set; }

    public int ProcessingTries { get; set; }

    public string? ErrorDescription { get; set; }

    public string? CompanyName { get; set; }

    public int? CompanyId { get; set; }

    public Guid? RequestId { get; set; }

    public int? InsuranceTypeCode { get; set; }

    public string? DriverNin { get; set; }

    public string? VehicleId { get; set; }

    public string? ServiceRequest { get; set; }

    public string? ServiceResponse { get; set; }

    public string? Chanel { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ProcessedOn { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public double? ServiceResponseTimeInSeconds { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? DontProcessBeforeDate { get; set; }

    public string? UserName { get; set; }

    public bool? IsCancelled { get; set; }

    public DateTime? CancelationDate { get; set; }

    public string? CancelledBy { get; set; }

    public string? ServerIp { get; set; }

    public bool IsLocked { get; set; }

    public int? ErrorCode { get; set; }
}
