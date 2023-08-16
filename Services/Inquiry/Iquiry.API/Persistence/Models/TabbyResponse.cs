using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class TabbyResponse
{
    public long Id { get; set; }

    public Guid? TabbyRequestId { get; set; }

    public string? PaymentId { get; set; }

    public string? ReferenceId { get; set; }

    public string? UserId { get; set; }

    public string? Channel { get; set; }

    public double? TotalAmount { get; set; }

    public double? AmountPerInstallment { get; set; }

    public int? InstallmentCount { get; set; }

    public double? AmountRemaining { get; set; }

    public bool? IsWarning { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual TabbyRequest? TabbyRequest { get; set; }

    public virtual ICollection<TabbyResponseDetail> TabbyResponseDetails { get; set; } = new List<TabbyResponseDetail>();
}
