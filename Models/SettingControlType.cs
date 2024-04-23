using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class SettingControlType
{
    public long SettingControlTypeId { get; set; }

    public string Name { get; set; } = null!;

    public double? Sequence { get; set; }

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

    public virtual ICollection<OrganisationSetting> OrganisationSettings { get; set; } = new List<OrganisationSetting>();

    public virtual ICollection<UserSetting> UserSettings { get; set; } = new List<UserSetting>();
}
