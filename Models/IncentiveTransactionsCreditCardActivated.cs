using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTransactionsCreditCardActivated
{
    public long IncentiveTransactionsCreditCardActivatedId { get; set; }

    public string? OracleNumber { get; set; }

    public string? ShadowAccountNbr { get; set; }

    public string? IssuerBin { get; set; }

    public string? PrimarySupp { get; set; }

    public DateOnly? AgreementDate { get; set; }

    public DateOnly? ActivationDate { get; set; }

    public string? SecuredUnsecured { get; set; }

    public string? GuaranteeWording { get; set; }

    public string? BranchCode { get; set; }

    public string? NationalId { get; set; }

    public string? CustomerSegment { get; set; }

    public bool? IsMoved { get; set; }
}
