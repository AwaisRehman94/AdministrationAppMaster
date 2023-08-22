using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class Attachment
{
    public int Id { get; set; }

    public Guid Guid { get; set; }

    public byte[]? AttachmentFile { get; set; }

    public string? AttachmentType { get; set; }

    public string AttachmentName { get; set; } = null!;

    public virtual ICollection<PolicyUpdateRequestAttachment> PolicyUpdateRequestAttachments { get; set; } = new List<PolicyUpdateRequestAttachment>();
}
