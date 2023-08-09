using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class EdaatRequest
{
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UserId { get; set; }

    public bool? IsClientEnterpise { get; set; }

    public string? RegistrationNo { get; set; }

    public string? NationalId { get; set; }

    public string? InternalCode { get; set; }

    public DateTime? IssueDate { get; set; }

    public DateTime? DueDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? Conditions { get; set; }

    public string? SubBillerRegistrationNo { get; set; }

    public bool? HasValidityPeriod { get; set; }

    public string? FromDurationTime { get; set; }

    public string? ToDurationTime { get; set; }

    public bool? ExportToSadad { get; set; }

    public int? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string? ReferenceId { get; set; }

    public decimal? SubBillerShareAmount { get; set; }

    public decimal? SubBillerSharePercentage { get; set; }

    public string? InsuredNationalId { get; set; }

    public virtual ICollection<EdaatCompany> EdaatCompanies { get; set; } = new List<EdaatCompany>();

    public virtual ICollection<EdaatCustomer> EdaatCustomers { get; set; } = new List<EdaatCustomer>();

    public virtual ICollection<EdaatProduct> EdaatProducts { get; set; } = new List<EdaatProduct>();

    public virtual ICollection<EdaatResponse> EdaatResponses { get; set; } = new List<EdaatResponse>();
}
