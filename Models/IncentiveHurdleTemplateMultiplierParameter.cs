using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveHurdleTemplateMultiplierParameter
{
    public int ParameterId { get; set; }

    public int HurdleTemplateId { get; set; }

    public decimal MinPercentage { get; set; }

    public decimal MaxPercentage { get; set; }

    public decimal? MultiplierPercentage { get; set; }

    public string? DeviceObjId { get; set; }
}
