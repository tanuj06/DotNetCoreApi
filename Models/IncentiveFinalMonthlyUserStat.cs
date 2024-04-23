using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveFinalMonthlyUserStat
{
    public int Id { get; set; }

    public long? UserId { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }

    public decimal? IncentiveBeforeHurdle { get; set; }

    public decimal? MonthScorecardPercentage { get; set; }

    public decimal? MtdscorecardPercentage { get; set; }

    public decimal? HurdleDeductionPercentage { get; set; }

    public decimal? HurdleDeduction { get; set; }

    public decimal? HurdleMultiplierPercentage { get; set; }

    public decimal? HurdleMultiplication { get; set; }

    public decimal? StrategicDeductionPercentage { get; set; }

    public decimal? StrategicDeduction { get; set; }

    public decimal? IncentiveAfterHurdle { get; set; }

    public decimal? NonHurdleProductIncentive { get; set; }

    public decimal? IncentiveEarned { get; set; }

    public decimal? FinalIncentiveCap { get; set; }

    public decimal? IncentiveEarnedAfterCap { get; set; }

    public string? BranchCode { get; set; }

    public string? BranchName { get; set; }

    public string? Area { get; set; }
}
