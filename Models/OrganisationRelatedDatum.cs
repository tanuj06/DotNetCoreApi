using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class OrganisationRelatedDatum
{
    public long OrganisationSettingsMappingId { get; set; }

    public string Name { get; set; } = null!;

    public string? SettingsValue { get; set; }
}
