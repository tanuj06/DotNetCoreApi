using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DashboardSelectionTypeCircleTypeMapping
{
    public long Id { get; set; }

    public int DashboardCircleSelectionTypeId { get; set; }

    public int CircleTypeId { get; set; }

    public bool IsDeleted { get; set; }

    public bool? IsVisible { get; set; }

    public virtual HomeDashboardCircleSelectionType DashboardCircleSelectionType { get; set; } = null!;
}
