using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class UserClaimFile
{
    public int Id { get; set; }

    public int ClaimHistoryId { get; set; }

    public string? ClaimFilePath { get; set; }

    public string? ClaimFileName { get; set; }

    public string? ClaimFileExtension { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedBy { get; set; }
}
