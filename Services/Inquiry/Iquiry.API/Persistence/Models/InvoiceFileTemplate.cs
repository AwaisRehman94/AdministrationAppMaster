using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class InvoiceFileTemplate
{
    public int Id { get; set; }

    public string? TemplateFilePath { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public bool? Active { get; set; }
}
