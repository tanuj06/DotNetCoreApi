﻿using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveUserWiseMonthProRataStat
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public int IncentiveProductTypeId { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    public decimal? Target { get; set; }

    public decimal? Achieved { get; set; }

    public decimal? AchievementPercentage { get; set; }

    public decimal? Weightage { get; set; }

    public decimal? AchievedPercentageAfterWeightage { get; set; }

    public decimal? IncentiveAmount { get; set; }

    public decimal? LoansIncentiveFactor { get; set; }

    public long? OrganisationId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public decimal? SelfAchieved { get; set; }

    public decimal? ReferralAchieved { get; set; }

    public decimal? CompanyAchieved { get; set; }

    public decimal? EmployeeAchieved { get; set; }

    public decimal? CompanyAchievedPercentage { get; set; }

    public decimal? EmployeeAchievedPercentage { get; set; }

    public decimal? CompanyTarget { get; set; }

    public decimal? EmployeeTarget { get; set; }
}
