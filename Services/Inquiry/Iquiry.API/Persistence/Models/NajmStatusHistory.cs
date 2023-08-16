using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class NajmStatusHistory
{
    public int Id { get; set; }

    public string ReferenceId { get; set; } = null!;

    public string PolicyNo { get; set; } = null!;

    public int StatusCode { get; set; }

    public string? StatusDescription { get; set; }

    public DateTime? UploadedDate { get; set; }

    public string? UploadedReference { get; set; }
}
