using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class EsalProfitMargin
{
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ReferenceId { get; set; }

    public string? Description { get; set; }

    public bool? Applied { get; set; }

    public string? ProcedureArabic { get; set; }

    public string? ProcedureEnglish { get; set; }
}
