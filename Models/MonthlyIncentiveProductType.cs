using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class MonthlyIncentiveProductType
{
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public bool IsVisible { get; set; }

    public bool? IsImportEnabled { get; set; }

    public bool? IsHurdleApplicable { get; set; }

    public bool? IsStrategicProduct { get; set; }

    public bool IsIncentiveApplicable { get; set; }

    public int? DisplayOrder { get; set; }
}
