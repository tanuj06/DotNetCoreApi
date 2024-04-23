using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class AttachmentCategory
{
    public long AttachmentCategoryId { get; set; }

    public string Name { get; set; } = null!;

    public string? Crmcode { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();
}
