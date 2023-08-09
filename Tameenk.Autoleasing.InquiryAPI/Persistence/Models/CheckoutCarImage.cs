using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class CheckoutCarImage
{
    public int Id { get; set; }

    public byte[]? ImageData { get; set; }

    public string? ImageUrl { get; set; }

    public virtual ICollection<CheckoutDetail> CheckoutDetailImageBacks { get; set; } = new List<CheckoutDetail>();

    public virtual ICollection<CheckoutDetail> CheckoutDetailImageBodies { get; set; } = new List<CheckoutDetail>();

    public virtual ICollection<CheckoutDetail> CheckoutDetailImageFronts { get; set; } = new List<CheckoutDetail>();

    public virtual ICollection<CheckoutDetail> CheckoutDetailImageLefts { get; set; } = new List<CheckoutDetail>();

    public virtual ICollection<CheckoutDetail> CheckoutDetailImageRights { get; set; } = new List<CheckoutDetail>();
}
