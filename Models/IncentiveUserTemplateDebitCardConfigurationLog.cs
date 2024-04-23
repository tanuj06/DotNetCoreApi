using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveUserTemplateDebitCardConfigurationLog
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    public long? DebitCardTypeId { get; set; }

    public decimal? IncentiveAmount { get; set; }

    public string? DeviceObjId { get; set; }
}
