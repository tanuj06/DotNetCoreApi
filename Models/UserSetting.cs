using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserSetting
{
    public long UserSettingId { get; set; }

    public string SettingsKey { get; set; } = null!;

    public string? DefaultValue { get; set; }

    public string DataType { get; set; } = null!;

    public long SettingControlTypeId { get; set; }

    public bool IsVisible { get; set; }

    public bool IsDisable { get; set; }

    public string DisplayName { get; set; } = null!;

    public string? DisplayNameOl1 { get; set; }

    public string? DisplayNameOl2 { get; set; }

    public string? Description { get; set; }

    public string? DescriptionOl1 { get; set; }

    public string? DescriptionOl2 { get; set; }

    public string? AllowedValues { get; set; }

    public string? AllowedRange { get; set; }

    public string? AllowedRegx { get; set; }

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

    public virtual SettingControlType SettingControlType { get; set; } = null!;

    public virtual ICollection<UserSettingMapping> UserSettingMappings { get; set; } = new List<UserSettingMapping>();
}
