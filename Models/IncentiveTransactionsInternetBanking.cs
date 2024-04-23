using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTransactionsInternetBanking
{
    public long IncentiveTransactionsInternetBankingId { get; set; }

    public string? CustomerNid { get; set; }

    public string? CustomerCif { get; set; }

    public string? BranchCode { get; set; }

    public string? CifcreationDate { get; set; }

    public string? CsoracleId { get; set; }

    public string? CustomerType { get; set; }

    public string? InternetBankingFlagDate { get; set; }

    public string? RegistrationDate { get; set; }

    public string? RequestDate { get; set; }

    public bool? IsMoved { get; set; }
}
