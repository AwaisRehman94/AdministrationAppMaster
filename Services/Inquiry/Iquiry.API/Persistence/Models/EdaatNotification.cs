using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class EdaatNotification
{
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UserId { get; set; }

    public string? BillNo { get; set; }

    public string? InvoiceNo { get; set; }

    public string? InternalCode { get; set; }

    public string? PaymentDate { get; set; }

    public decimal? PaymentAmount { get; set; }

    public int? EdaatRequestId { get; set; }

    public string? ReferenceId { get; set; }

    public int? ErrorCode { get; set; }

    public string? ErrorDescription { get; set; }

    public string? JsonRequest { get; set; }

    public string? Channel { get; set; }

    public string? ServerIp { get; set; }

    public string? UserIp { get; set; }
}
