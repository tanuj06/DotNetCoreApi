using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class FieldCategory
{
    public int FieldCategoryId { get; set; }

    public string? Name { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual ICollection<ActivityFieldSetting> ActivityFieldSettings { get; set; } = new List<ActivityFieldSetting>();

    public virtual ICollection<IncentiveTemplateProductFieldSetting> IncentiveTemplateProductFieldSettings { get; set; } = new List<IncentiveTemplateProductFieldSetting>();
}
