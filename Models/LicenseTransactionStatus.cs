using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class LicenseTransactionStatus
{
    public long LicenseTransactionStatusId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<LicenseTransaction> LicenseTransactions { get; set; } = new List<LicenseTransaction>();
}
