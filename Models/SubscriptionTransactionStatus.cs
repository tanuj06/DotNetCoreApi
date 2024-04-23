using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class SubscriptionTransactionStatus
{
    public long SubscriptionTransactionStatusId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<SubscriptionTransaction> SubscriptionTransactions { get; set; } = new List<SubscriptionTransaction>();
}
