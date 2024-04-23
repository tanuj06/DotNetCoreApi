using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class LicenseReferralTransaction
{
    public long LicenseReferralTransactionId { get; set; }

    public long? LicenseReferralId { get; set; }

    public long? UserId { get; set; }

    public int EarnedReferralMonthUnits { get; set; }

    public DateTime TransactionDateTime { get; set; }

    public int LicenseReferralTransactionStatusId { get; set; }

    public bool? ReferralEarningType { get; set; }

    public virtual LicenseReferral? LicenseReferral { get; set; }

    public virtual LicenseReferralTransactionStatus LicenseReferralTransactionStatus { get; set; } = null!;

    public virtual User? User { get; set; }
}
