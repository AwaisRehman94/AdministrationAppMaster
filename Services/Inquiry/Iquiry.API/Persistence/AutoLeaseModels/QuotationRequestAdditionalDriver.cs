using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class QuotationRequestAdditionalDriver
{
    public int QuotationRequestId { get; set; }

    public Guid AdditionalDriverId { get; set; }

    public byte? AdditionalDriverRelationShipId { get; set; }

    public virtual Driver AdditionalDriver { get; set; } = null!;

    public virtual QuotationRequest QuotationRequest { get; set; } = null!;
}
