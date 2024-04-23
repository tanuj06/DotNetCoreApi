using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class LicenseReferralTransactionStatus
{
    public int LicenseReferralTransactionStatusId { get; set; }

    public string ReferralTransactionStatus { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public virtual ICollection<LicenseReferralTransaction> LicenseReferralTransactions { get; set; } = new List<LicenseReferralTransaction>();
}
