using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class VwOrgSetting
{
    public long OrganisationId { get; set; }

    public long OrganisationSettingId { get; set; }

    public string SettingsKey { get; set; } = null!;

    public string? SettingsValue { get; set; }
}
