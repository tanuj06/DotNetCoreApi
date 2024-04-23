using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class TiersModel
{
    public long TierId { get; set; }

    public string TierName { get; set; } = null!;

    public int? ReminderDuration { get; set; }

    public int? TierReminderDurationUnitId { get; set; }

    public bool? IsDefault { get; set; }

    public string? Description { get; set; }

    public double? Sequence { get; set; }

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

    public virtual ICollection<OrganisationTierMapping> OrganisationTierMappings { get; set; } = new List<OrganisationTierMapping>();
}
