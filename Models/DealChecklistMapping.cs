using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DealChecklistMapping
{
    public long DealChecklistMappingId { get; set; }

    public long? DealId { get; set; }

    public long? ProductFamilyId { get; set; }

    public long? ProductId { get; set; }

    public long? ProductTypeId { get; set; }

    public long? ProductSchemeId { get; set; }

    public long? CustomerTypeId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public virtual Deal? Deal { get; set; }
}
