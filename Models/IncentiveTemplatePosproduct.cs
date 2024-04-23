using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTemplatePosproduct
{
    public long IncentiveTemplatePosproductId { get; set; }

    public long? IncentiveTemplateId { get; set; }

    public long? Target { get; set; }

    public decimal? Weight { get; set; }

    public decimal? Csrtarget { get; set; }

    public decimal? Vipcsrtarget { get; set; }

    public decimal? Rmtarget { get; set; }

    public bool? IsApplicable { get; set; }

    public virtual IncentiveTemplate? IncentiveTemplate { get; set; }
}
