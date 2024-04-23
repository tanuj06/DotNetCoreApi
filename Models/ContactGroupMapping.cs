using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactGroupMapping
{
    public long ContactGroupMappingId { get; set; }

    public long ContactGroupId { get; set; }

    public long ContactId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Crmcode { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual Contact Contact { get; set; } = null!;

    public virtual ContactGroup ContactGroup { get; set; } = null!;
}
