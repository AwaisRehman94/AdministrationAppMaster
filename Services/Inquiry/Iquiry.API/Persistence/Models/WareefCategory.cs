using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class WareefCategory
{
    public int Id { get; set; }

    public string? Createdby { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? NameAr { get; set; }

    public string? NameEn { get; set; }

    public string? Icon { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
