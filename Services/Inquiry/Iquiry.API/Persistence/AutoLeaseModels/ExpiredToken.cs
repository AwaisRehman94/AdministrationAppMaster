using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class ExpiredToken
{
    public int Id { get; set; }

    public string? Key { get; set; }

    public string? UserId { get; set; }

    public DateTime? CreatedDate { get; set; }
}
