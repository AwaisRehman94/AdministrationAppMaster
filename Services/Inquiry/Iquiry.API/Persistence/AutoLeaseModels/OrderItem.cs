using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class OrderItem
{
    public int Id { get; set; }

    public string CheckoutDetailReferenceId { get; set; } = null!;

    public Guid ProductId { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual CheckoutDetail CheckoutDetailReference { get; set; } = null!;

    public virtual ICollection<OrderItemBenefit> OrderItemBenefits { get; set; } = new List<OrderItemBenefit>();
}
