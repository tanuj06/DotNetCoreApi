using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class HomeDashboardFilterFrequencyMapping
{
    public long FilterFrequencyMappingId { get; set; }

    public int FrequencyId { get; set; }

    public int FilterTypeId { get; set; }

    public bool IsDeleted { get; set; }

    public virtual HomeDashboardCircleSelectionType FilterType { get; set; } = null!;

    public virtual HomeDashboardFilterTypeFrequency Frequency { get; set; } = null!;
}
