using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ActivityClassification
{
    public long ActivityClassificationId { get; set; }

    public string? Name { get; set; }

    public string? NameOl1 { get; set; }

    public string? NameOl2 { get; set; }

    public long? OrganisationId { get; set; }

    public string? Crmcode { get; set; }

    public double? Sequence { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public int? SyncStatus { get; set; }

    public string? DeviceObjId { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public bool? IsDefault { get; set; }

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();

    public virtual Organisation? Organisation { get; set; }
}
