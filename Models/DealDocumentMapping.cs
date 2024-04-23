using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DealDocumentMapping
{
    public long DealDocumentMappingId { get; set; }

    public long? DealId { get; set; }

    public long? DocumentId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual Deal? Deal { get; set; }

    public virtual ChecklistDocument? Document { get; set; }
}
