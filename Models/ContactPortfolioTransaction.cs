using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactPortfolioTransaction
{
    public long TransactionId { get; set; }

    public DateTime? TransactionDateTime { get; set; }

    public long TransferRequestId { get; set; }

    public long ModuleId { get; set; }

    public long EntityId { get; set; }

    public long PreviousOwnerId { get; set; }

    public long CurrentOwnerId { get; set; }

    public virtual User CurrentOwner { get; set; } = null!;

    public virtual Module Module { get; set; } = null!;

    public virtual User PreviousOwner { get; set; } = null!;

    public virtual ContactPortfolioTransfer TransferRequest { get; set; } = null!;
}
