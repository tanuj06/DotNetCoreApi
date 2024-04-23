using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTransactionsDebitCardIssuance
{
    public long IncentiveTransactionsDebitCardId { get; set; }

    public string? TokenNo { get; set; }

    public string? IssuanceDate { get; set; }

    public string? ExpiryDate { get; set; }

    public string? EmployeeOracleNumber { get; set; }

    public string? Nid { get; set; }

    public string? Maker { get; set; }

    public string? CardType { get; set; }

    public string? CustomerTypeIndicator { get; set; }

    public string? CardCategory { get; set; }

    public string? CardTypeDesc { get; set; }

    public string? Branch { get; set; }

    public string? BranchDesc { get; set; }

    public bool? IsMoved { get; set; }
}
