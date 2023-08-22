using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class Setting
{
    public int Id { get; set; }

    public int? MaxNumberOfPolicies { get; set; }

    public int? MaxNumberOfPromotionCode { get; set; }
}
