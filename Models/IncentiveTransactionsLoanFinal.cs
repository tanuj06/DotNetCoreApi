using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTransactionsLoanFinal
{
    public long Id { get; set; }

    public string CustomerId { get; set; } = null!;

    public string? NationalId { get; set; }

    public string? CustomerFullName { get; set; }

    public string NewLoanNo { get; set; } = null!;

    public string? ProductName { get; set; }

    public string? ProductType { get; set; }

    public string? NewBranchCode { get; set; }

    public DateTime? ActualBookingDate { get; set; }

    public decimal? GrossBookingAmount { get; set; }

    public decimal? NetAchievedAmount { get; set; }

    public decimal? InterestRate { get; set; }

    public decimal? LoanTenorPerMonth { get; set; }

    public decimal? ProductDefaultRate { get; set; }

    public decimal? AdminFees { get; set; }

    public decimal? AdminFeesRate { get; set; }

    public bool TopUpFlag { get; set; }

    public bool IsSecured { get; set; }

    public long? ReferrelUserId { get; set; }

    public long? OwnerId { get; set; }

    public string? SellerOracle { get; set; }

    public string? ReferralOracle { get; set; }

    public bool? InterestRateExceptionFlag { get; set; }

    public bool? AdminFeesExceptionFlag { get; set; }

    public string? BuyOutFlagForCashLoan { get; set; }

    public string? CustomerCategory { get; set; }

    public DateOnly? MaturityDate { get; set; }

    public string? TelesalesAchieved { get; set; }

    public string? GrossSalary { get; set; }

    public string? NetSalary { get; set; }

    public string? MobileNumber { get; set; }

    public string? CompanyRank { get; set; }

    public string? CompanySector { get; set; }

    public string? LoanEclappliedRate { get; set; }

    public decimal? IncentiveAmountBeforeCap { get; set; }

    public decimal? IncentiveAmountCap { get; set; }

    public decimal? IncentiveAmount { get; set; }

    public decimal? ReferralIncentiveAmount { get; set; }

    public virtual User? Owner { get; set; }

    public virtual User? ReferrelUser { get; set; }
}
