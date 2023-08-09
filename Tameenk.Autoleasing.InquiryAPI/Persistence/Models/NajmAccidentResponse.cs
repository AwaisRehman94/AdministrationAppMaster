using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class NajmAccidentResponse
{
    public int Id { get; set; }

    public int? NoOfAccident { get; set; }

    public string? ReferenceId { get; set; }

    public string? ReferenceNo { get; set; }

    public string? MessageId { get; set; }

    public string? VehicleId { get; set; }

    public string? DriverNin { get; set; }

    public string? NajmResponse { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string? ExternalId { get; set; }
}
