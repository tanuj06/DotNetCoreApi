using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class HomeDashboardFilterTypeFrequency
{
    public int FrequencyId { get; set; }

    public string? FrequencyName { get; set; }

    public bool? IsDefault { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<HomeDashboardFilterFrequencyMapping> HomeDashboardFilterFrequencyMappings { get; set; } = new List<HomeDashboardFilterFrequencyMapping>();
}
