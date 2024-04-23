using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class GameSetupRelatedDatum
{
    public long GameId { get; set; }

    public long? DepartmentId { get; set; }

    public string? GameName { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public int? StatusId { get; set; }

    public string? Status { get; set; }

    public string? Description { get; set; }

    public decimal? ActivitiesPointsCap { get; set; }

    public decimal? PointsPerCallDone { get; set; }

    public decimal? PointsPerMeetingDone { get; set; }

    public decimal? DealsClosedPointsCap { get; set; }

    public decimal? MaximumPointsPerDealClosed { get; set; }

    public decimal? PointsPerDealClosed { get; set; }

    public decimal? PointsPerDealClosedRevenueof1000 { get; set; }

    public decimal? PointsPerDealClosedSizeof1000 { get; set; }

    public decimal? DealsAddedPointsCap { get; set; }

    public decimal? MaximumPointsPerDealAdded { get; set; }

    public decimal? PointsPerDealAdded { get; set; }

    public decimal? PointsPerDealAddedRevenueof1000 { get; set; }

    public decimal? PointsPerDealAddedSizeof1000 { get; set; }

    public decimal? ContactsAddedPointsCap { get; set; }

    public decimal? PointsPerContactAdded { get; set; }

    public decimal? CustomersIgnoredPenalty { get; set; }

    public decimal? DealsOverduePenalty { get; set; }

    public decimal? ActivitiesOverduePenalty { get; set; }

    public decimal? BonusIfDealClosedWasSentInCampaign { get; set; }

    public decimal? BonusForDealsAndActivitiesClosedAboveTarget { get; set; }

    public decimal? DealsWithFocusProductsBonus { get; set; }

    public decimal? StepSize { get; set; }

    public decimal? Delta { get; set; }

    public bool? AutoGameSetup { get; set; }

    public string? UsersNotPlayingThisGame { get; set; }

    public string? TeamsNotPlayingThisGame { get; set; }

    public string? FocusProducts { get; set; }
}
