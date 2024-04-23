using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTransactionsInternetBankingFinal
{
    public long IncentiveTransactionsInternetBankingFinalId { get; set; }

    public string? CustomerNid { get; set; }

    public string? CustomerCif { get; set; }

    public string? BranchCode { get; set; }

    public DateOnly? CifcreationDate { get; set; }

    public string? CsoracleId { get; set; }

    public string? CustomerType { get; set; }

    public DateOnly? InternetBankingFlagDate { get; set; }

    public DateOnly? RegistrationDate { get; set; }

    public DateOnly? RequestDate { get; set; }

    public long? OwnerId { get; set; }
}
