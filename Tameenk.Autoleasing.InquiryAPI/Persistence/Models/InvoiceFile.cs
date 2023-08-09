using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class InvoiceFile
{
    public int Id { get; set; }

    public byte[]? InvoiceData { get; set; }

    public string? FilePath { get; set; }

    public string? ServerIp { get; set; }

    public int? TemplateId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? CompanyInvoieFilePath { get; set; }

    public virtual Invoice IdNavigation { get; set; } = null!;
}
