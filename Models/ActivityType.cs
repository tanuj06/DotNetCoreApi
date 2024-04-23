using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ActivityType
{
    public long ActivityTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string? TypeDescription { get; set; }

    public double? Sequence { get; set; }

    public long CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();

    public virtual ICollection<ActivityNote> ActivityNotes { get; set; } = new List<ActivityNote>();

    public virtual ICollection<CrmsalesArmactivityTypeMapping> CrmsalesArmactivityTypeMappings { get; set; } = new List<CrmsalesArmactivityTypeMapping>();
}
