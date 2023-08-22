using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class ShoppingCartItem
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public Guid ProductId { get; set; }

    public int Quantity { get; set; }

    public string? ReferenceId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
