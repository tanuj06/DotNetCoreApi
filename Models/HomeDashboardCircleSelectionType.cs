using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class HomeDashboardCircleSelectionType
{
    public int DashboardCircleSelectionTypeId { get; set; }

    public string DashboardCircleSelectionTypeName { get; set; } = null!;

    public int DashboardCategoryId { get; set; }

    public bool? IsVisible { get; set; }

    public int? Sequence { get; set; }

    public virtual ICollection<DashboardSelectionTypeCircleTypeMapping> DashboardSelectionTypeCircleTypeMappings { get; set; } = new List<DashboardSelectionTypeCircleTypeMapping>();

    public virtual ICollection<HomeDashboardFilterFrequencyMapping> HomeDashboardFilterFrequencyMappings { get; set; } = new List<HomeDashboardFilterFrequencyMapping>();
}
