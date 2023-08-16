using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class PolicyUpdateRequestAttachment
{
    public int Id { get; set; }

    public int PolicyUpdReqId { get; set; }

    public int AttachmentId { get; set; }

    public int AttachmentTypeId { get; set; }

    public virtual Attachment Attachment { get; set; } = null!;

    public virtual PolicyUpdateRequest PolicyUpdReq { get; set; } = null!;
}
