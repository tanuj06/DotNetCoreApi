using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveUserTemplateCcprimaryLog
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    public long? GranteeTypeId { get; set; }

    public long? CreditCardTypeId { get; set; }

    public decimal? IncentiveAmount { get; set; }

    public bool? IsClawBackApplicable { get; set; }

    public int? ClawBackValueTypeId { get; set; }

    public decimal? ClawBackValue { get; set; }

    public string? DeviceObjId { get; set; }
}
