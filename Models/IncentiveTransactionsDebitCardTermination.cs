using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTransactionsDebitCardTermination
{
    public long IncentiveTransactionId { get; set; }

    public string? TokenNo { get; set; }

    public string? TerminationDate { get; set; }

    public bool? IsMoved { get; set; }
}
