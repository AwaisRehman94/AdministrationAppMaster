using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class Moidetail
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? Email { get; set; }

    public string? FileName { get; set; }

    public byte[]? FileByteArray { get; set; }

    public string? FileMimeType { get; set; }

    public bool? Approved { get; set; }

    public DateTime? CreatedAt { get; set; }
}
