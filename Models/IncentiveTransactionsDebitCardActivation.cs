using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTransactionsDebitCardActivation
{
    public long IncentiveTransactionId { get; set; }

    public string? TokenNo { get; set; }

    public string? ActivationDate { get; set; }

    public bool? IsMoved { get; set; }
}
