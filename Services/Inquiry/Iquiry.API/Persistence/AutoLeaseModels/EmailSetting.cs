using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class EmailSetting
{
    public int Id { get; set; }

    public string? SenderEmailAddress { get; set; }

    public string? Credentials { get; set; }

    public string? Method { get; set; }

    public string? Module { get; set; }

    public int? SmtpPort { get; set; }

    public string? SmtpHost { get; set; }

    public bool? SmtpEnableSsl { get; set; }

    public string? SmtpTimeout { get; set; }

    public string? SmtpDeliveryMethod { get; set; }

    public bool? SmtpUseDefaultCredentials { get; set; }
}
