using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class LicenseReferralPercentage
{
    public long LicenseReferralPercentageId { get; set; }

    public int Level { get; set; }

    public decimal? ReferralPercentage { get; set; }
}
