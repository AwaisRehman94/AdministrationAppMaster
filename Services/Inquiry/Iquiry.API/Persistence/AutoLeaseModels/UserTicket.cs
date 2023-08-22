﻿using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class UserTicket
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? CheckedoutEmail { get; set; }

    public string? CheckedoutPhone { get; set; }

    public int? TicketTypeId { get; set; }

    public string? UserNotes { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? PolicyId { get; set; }

    public string? PolicyNo { get; set; }

    public int? InvoiceId { get; set; }

    public int? InvoiceNo { get; set; }

    public string? ReferenceId { get; set; }

    public string? DriverNin { get; set; }

    public Guid? VehicleId { get; set; }

    public string? SequenceNumber { get; set; }

    public string? CustomCardNumber { get; set; }

    public string? RepliedBy { get; set; }

    public string? UserEmail { get; set; }

    public string? UserPhone { get; set; }

    public int? CurrentTicketStatusId { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? CreatedBy { get; set; }

    public int TicketModuleId { get; set; }

    public int? TicketSubTypeId { get; set; }
}