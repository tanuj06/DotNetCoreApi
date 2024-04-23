using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTransactionsPrepaidCard
{
    public long IncentiveTransactionsPrepaidCardId { get; set; }

    public string? TokenNo { get; set; }

    public string? CardType { get; set; }

    public string? ActivatorBranch { get; set; }

    public string? ActivationDate { get; set; }

    public string? ExpiryDate { get; set; }

    public string? Status { get; set; }

    public string? EmployeeFileNo { get; set; }

    public bool? IsMoved { get; set; }
}
