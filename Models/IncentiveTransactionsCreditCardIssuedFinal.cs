using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTransactionsCreditCardIssuedFinal
{
    public long IncentiveTransactionsCreditCardIssuedFinalId { get; set; }

    public DateOnly? IssuanceDate { get; set; }

    public string? SellerOracleNumber { get; set; }

    public string? CardShadowAccount { get; set; }

    public DateOnly? ShadowAgreementDate { get; set; }

    public DateOnly? ActivationDate { get; set; }

    public bool IsPrimary { get; set; }

    public string? Bin { get; set; }

    public int? GranteeIndicator { get; set; }

    public string? GranteeIndicatorWording { get; set; }

    public string? BranchNumber { get; set; }

    public int UserId { get; set; }

    public string? NationalId { get; set; }

    public string? CustomerSegment { get; set; }
}
