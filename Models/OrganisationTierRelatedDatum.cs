using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class OrganisationTierRelatedDatum
{
    public long OrganisationTierMappingId { get; set; }

    public string? Name { get; set; }

    public bool IsDefault { get; set; }

    public string? Description { get; set; }

    public int? Frequency { get; set; }

    public string? TierReminderDurationUnit { get; set; }
}
