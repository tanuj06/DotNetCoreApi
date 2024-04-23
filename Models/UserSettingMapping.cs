using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserSettingMapping
{
    public long UserSettingMappingId { get; set; }

    public long UserId { get; set; }

    public long UserSettingId { get; set; }

    public string SettingsValue { get; set; } = null!;

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

    public virtual User User { get; set; } = null!;

    public virtual UserSetting UserSetting { get; set; } = null!;
}
