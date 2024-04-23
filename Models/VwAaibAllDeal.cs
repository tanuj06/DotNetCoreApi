using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class VwAaibAllDeal
{
    public long? Id { get; set; }

    public long DealId { get; set; }

    public string? CampaignName { get; set; }

    public string? DealSource { get; set; }

    public string? ContactName { get; set; }

    public string? EmployerName { get; set; }

    public string? RepresentativeName { get; set; }

    public string? ContactSegment { get; set; }

    public string? ContactTier { get; set; }

    public string? CustomerId { get; set; }

    public string? ContactLastContactedDate { get; set; }

    public string? ContactNextContactDate { get; set; }

    public string? DealPhaseName { get; set; }

    public string? DealStage { get; set; }

    public long? NoOfDaysExceededForStagnantDeal { get; set; }

    public string? ExpectedDealCloseDate { get; set; }

    public decimal? ExpectedDealSize { get; set; }

    public decimal? ExpectedDealRevenue { get; set; }

    public string? ActualDealCloseDate { get; set; }

    public decimal? ActualDealSize { get; set; }

    public decimal? ActualDealRevenue { get; set; }

    public string? DealLostDate { get; set; }

    public string? ProductFamilyName { get; set; }

    public string? ProductName { get; set; }

    public string? ProductStartDate { get; set; }

    public string? ProductExpiryDate { get; set; }

    public string? ReferenceNumber { get; set; }

    public string? DealOwnerName { get; set; }

    public string? DealOwnerEmail { get; set; }

    public string? DealOwnerManager { get; set; }

    public string? DealOwnerInternalCode { get; set; }

    public string? DealOwnerBranchName { get; set; }

    public string? DealOwnerBranchCode { get; set; }

    public string? DealOwnerRole { get; set; }

    public string? DealCreatorName { get; set; }

    public string? DealCreatorEmail { get; set; }

    public string? ContactCreatorName { get; set; }

    public string? ContactCreatorEmail { get; set; }

    public string? DealCreatorRole { get; set; }

    public string? CreatorDepartment { get; set; }

    public string? CreatorCountry { get; set; }

    public string? DealCreationDate { get; set; }

    public string? DealCreationTime { get; set; }

    public string? DealLastModifiedBy { get; set; }

    public string? DealLastModifiedByEmail { get; set; }

    public string? DealLastModifiedDate { get; set; }

    public string? DealLastModifiedTime { get; set; }

    public string? ContactOwnerName { get; set; }

    public string? ContactNationalId { get; set; }

    public string? ContactTradeLicenseNumber { get; set; }

    public string? ContactBranchCode { get; set; }

    public string? ContactBranchName { get; set; }

    public string? ProductType { get; set; }

    public string? ProductScheme { get; set; }

    public string? CustomerType { get; set; }

    public string? DealSubject { get; set; }

    public string? ContactCity { get; set; }

    public string? ContactOfficeNumber { get; set; }

    public string? ContactResidenceNumber { get; set; }

    public string? ContactEmail { get; set; }

    public string? RepOfficeNumber { get; set; }

    public string? RepResidenceNumber { get; set; }

    public string? RepEmail { get; set; }

    public string? DealLastNote1 { get; set; }

    public string? DealLastNote2 { get; set; }

    public string? Department { get; set; }

    public string ContactType { get; set; } = null!;

    public long? CampaignId { get; set; }

    public long ContactId { get; set; }

    public long? ProductFamilyId { get; set; }

    public long ProductId { get; set; }

    public long? OwnerUserId { get; set; }

    public long? CreatorUserId { get; set; }
}
