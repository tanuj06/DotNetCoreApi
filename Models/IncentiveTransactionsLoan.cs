using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTransactionsLoan
{
    public long Id { get; set; }

    public string CustomerId { get; set; } = null!;

    public string? NationalId { get; set; }

    public string? CustomerFullName { get; set; }

    public string NewLoanNo { get; set; } = null!;

    public string? ProductName { get; set; }

    public string? ProductType { get; set; }

    public string? NewBranch { get; set; }

    public string? ActualBookingDate { get; set; }

    public string? GrossBookingAmount { get; set; }

    public string? NetAchievedAmount { get; set; }

    public string? InterestRate { get; set; }

    public string? LoanTenorPerMonth { get; set; }

    public string? ProductDefaultRate { get; set; }

    public string? AdminFees { get; set; }

    public string? AdminFeesRate { get; set; }

    public string? TopUpFlag { get; set; }

    public string? IncentiveSecured { get; set; }

    public string? SellerOracle { get; set; }

    public string? ReferralOracle { get; set; }

    public string? InterestRateExceptionFlag { get; set; }

    public string? AdminFeesExceptionFlag { get; set; }

    public string? BuyOutFlagForCashLoan { get; set; }

    public string? CustomerCategory { get; set; }

    public string? MaturityDate { get; set; }

    public string? TelesalesAchieved { get; set; }

    public string? GrossSalary { get; set; }

    public string? NetSalary { get; set; }

    public string? MobileNumber { get; set; }

    public string? CompanyRank { get; set; }

    public string? CompanySector { get; set; }

    public string? LoanEclappliedRate { get; set; }

    public bool? IsMoved { get; set; }
}
