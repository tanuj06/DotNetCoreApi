using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentivePrimaryCcperBinconfiguration
{
    public long IncentivePerBinId { get; set; }

    public long? IncentiveTemplateId { get; set; }

    public long? GranteeTypeId { get; set; }

    public long? CreditCardTypeId { get; set; }

    public decimal? IncentiveAmount { get; set; }

    public bool? IsClawBackApplicable { get; set; }

    public int? ClawBackValueTypeId { get; set; }

    public decimal? ClawBackValue { get; set; }

    public string? DeviceObjId { get; set; }

    public bool IsIncentiveEligible { get; set; }

    public virtual IncentiveTemplate? IncentiveTemplate { get; set; }
}
