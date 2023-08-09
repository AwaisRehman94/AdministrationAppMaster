using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class Offer
{
    public int Id { get; set; }

    public string? TextAr { get; set; }

    public string? TextEn { get; set; }

    public string? Createdby { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public byte[]? Image { get; set; }
}
