using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class PolicyFile
{
    public Guid Id { get; set; }

    public byte[]? PolicyFileByte { get; set; }

    public string? FilePath { get; set; }

    public string? ServerIp { get; set; }

    public virtual ICollection<Policy> Policies { get; set; } = new List<Policy>();
}
