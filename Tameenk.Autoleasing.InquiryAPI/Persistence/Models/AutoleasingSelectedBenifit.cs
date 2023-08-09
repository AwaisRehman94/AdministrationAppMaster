using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class AutoleasingSelectedBenifit
{
    public int Id { get; set; }

    public Guid ParentRequestId { get; set; }

    public string ExternalId { get; set; } = null!;

    public short BenifitId { get; set; }
}
