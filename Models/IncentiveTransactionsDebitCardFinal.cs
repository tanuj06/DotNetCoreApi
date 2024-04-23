using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTransactionsDebitCardFinal
{
    public long IncentiveTransactionsDebitCardFinalId { get; set; }

    public string? TokenNo { get; set; }

    public DateOnly? IssuanceDate { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public DateOnly? ActivationDate { get; set; }

    public string? EmployeeOracleNumber { get; set; }

    public string? Nid { get; set; }

    public string? Maker { get; set; }

    public string? CardType { get; set; }

    public string? CustomerTypeIndicator { get; set; }

    public bool? IsPrimary { get; set; }

    public long? OwnerId { get; set; }

    public string? CardTypeDesc { get; set; }

    public string? Branch { get; set; }

    public string? BranchDesc { get; set; }

    public decimal? IncentiveAmount { get; set; }

    public DateOnly? TerminationDate { get; set; }
}
