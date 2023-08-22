using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class AutoleasingQuotationFormOldHistoryOld
{
    public int Id { get; set; }

    public string? ExternalId { get; set; }

    public string? VehicleId { get; set; }

    public int? DeductableValue { get; set; }

    public bool? AgencyRepair { get; set; }

    public bool IsLocked { get; set; }

    public bool IsDone { get; set; }
}
