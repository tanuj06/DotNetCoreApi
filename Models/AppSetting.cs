using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class AppSetting
{
    public long AppSettingId { get; set; }

    public long OrganisationSettingId { get; set; }

    public string AppValue { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public virtual OrganisationSetting OrganisationSetting { get; set; } = null!;
}
