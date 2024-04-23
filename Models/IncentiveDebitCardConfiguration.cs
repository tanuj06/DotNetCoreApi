using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveDebitCardConfiguration
{
    public long IncentiveDebitCardConfigurationId { get; set; }

    public long? IncentiveTemplateDebitCardProductId { get; set; }

    public long? DebitCardTypeId { get; set; }

    public decimal? IncentiveAmount { get; set; }

    public string? DeviceObjId { get; set; }

    public string? CustomerType { get; set; }

    public bool? IsIncentiveApplicable { get; set; }

    public virtual IncentiveTemplateDebitCardProduct? IncentiveTemplateDebitCardProduct { get; set; }
}
