using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class Attachment
{
    public long AttachmentId { get; set; }

    public long? ModuleId { get; set; }

    public long? EntityId { get; set; }

    public long? DocumentId { get; set; }

    public string? FileName { get; set; }

    public string? Extension { get; set; }

    public string? MimecontentType { get; set; }

    public string? AttachmentSize { get; set; }

    public long? AttachmentCategoryId { get; set; }

    public string? Contents { get; set; }

    public string? Crmcode { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsShareable { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public int? OrganisationId { get; set; }

    public int? AddedFromSource { get; set; }

    public virtual AttachmentCategory? AttachmentCategory { get; set; }

    public virtual Module? Module { get; set; }
}
