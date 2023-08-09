using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class EdaatResponse
{
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UserId { get; set; }

    public string? Message { get; set; }

    public string InvoiceNo { get; set; } = null!;

    public string? InternalCode { get; set; }

    public int? EdaatRequestId { get; set; }

    public string? Code { get; set; }

    public bool? Success { get; set; }

    public string? ReferenceId { get; set; }

    public virtual EdaatRequest? EdaatRequest { get; set; }
}
