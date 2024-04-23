using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTemplateInternetBankingProduct
{
    public long IncentiveTemplateInternetBankingProductId { get; set; }

    public long? IncentiveTemplateId { get; set; }

    public long? Target { get; set; }

    public decimal? Weight { get; set; }

    public decimal? Csrtarget { get; set; }

    public decimal? Vipcsrtarget { get; set; }

    public decimal? Rmtarget { get; set; }

    public bool? IsApplicable { get; set; }

    public decimal? IncentiveAmount { get; set; }

    public int? NoOfDaysForValidation { get; set; }

    public virtual IncentiveTemplate? IncentiveTemplate { get; set; }
}
