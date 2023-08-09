using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class Client
{
    public string Id { get; set; } = null!;

    public string Secret { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int ApplicationType { get; set; }

    public bool Active { get; set; }

    public int RefreshTokenLifeTime { get; set; }

    public string? AllowedOrigin { get; set; }

    public string? AuthServerUrl { get; set; }

    public string? RedirectUrl { get; set; }
}
