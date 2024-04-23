using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class OrganisationSettingMapping
{
    public long OrganisationSettingsMappingId { get; set; }

    public long OrganisationId { get; set; }

    public long OrganisationSettingId { get; set; }

    public string? SettingsValue { get; set; }

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

    public virtual Organisation Organisation { get; set; } = null!;

    public virtual OrganisationSetting OrganisationSetting { get; set; } = null!;
}
