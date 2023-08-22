using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class ContactU
{
    public int Id { get; set; }

    public string? Createdby { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? ServerIp { get; set; }

    public string? Channel { get; set; }

    public string? UserIp { get; set; }

    public string? UserAgent { get; set; }

    public string? Nin { get; set; }

    public string? Email { get; set; }

    public string? Message { get; set; }
}
