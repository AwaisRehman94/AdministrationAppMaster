using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class BcareWithdrawalWinner
{
    public int Id { get; set; }

    public string NationalId { get; set; } = null!;

    public string SequenceNumber { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public int WeekNumber { get; set; }

    public int ProductType { get; set; }

    public bool IsDeleted { get; set; }

    public string? ArabicName { get; set; }

    public string? EnglishName { get; set; }

    public string? MobileNumber { get; set; }

    public int PrizeNumber { get; set; }
}
