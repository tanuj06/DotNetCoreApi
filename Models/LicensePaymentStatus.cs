using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class LicensePaymentStatus
{
    public int LicensePaymentStatusId { get; set; }

    public string PaymentStatusName { get; set; } = null!;
}
