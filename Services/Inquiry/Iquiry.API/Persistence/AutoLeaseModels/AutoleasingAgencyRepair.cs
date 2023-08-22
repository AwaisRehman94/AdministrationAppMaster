using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class AutoleasingAgencyRepair
{
    public int Id { get; set; }

    public int? BankId { get; set; }

    public string? FirstYear { get; set; }

    public string? SecondYear { get; set; }

    public string? ThirdYear { get; set; }

    public string? FourthYear { get; set; }

    public string? FifthYear { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }
}
