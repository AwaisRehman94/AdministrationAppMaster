using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class PromotionProgramUser
{
    public int Id { get; set; }

    public int? PromotionProgramId { get; set; }

    public string UserId { get; set; } = null!;

    public string Email { get; set; } = null!;

    public bool EmailVerified { get; set; }

    public Guid? ConfirmJoinToken { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? NationalId { get; set; }

    public virtual AspNetUser? CreatedByNavigation { get; set; }

    public virtual AspNetUser? ModifiedByNavigation { get; set; }

    public virtual PromotionProgram? PromotionProgram { get; set; }

    public virtual AspNetUser User { get; set; } = null!;
}
