using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class PromotionProgramNin
{
    public int Id { get; set; }

    public int? PromotionProgramId { get; set; }

    public string NationalId { get; set; } = null!;

    public string? Email { get; set; }

    public bool? EmailVerified { get; set; }

    public Guid? ConfirmJoinToken { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public bool? IsDeleted { get; set; }
}
