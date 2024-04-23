using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTransactionsPrepaidCardFinal
{
    public long IncentiveTransactionsPrepaidCardFinalId { get; set; }

    public string? TokenNo { get; set; }

    public string? CardType { get; set; }

    public string? ActivatorBranch { get; set; }

    public DateOnly? ActivationDate { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public string? Status { get; set; }

    public string? EmployeeFileNo { get; set; }

    public long? OwnerId { get; set; }
}
