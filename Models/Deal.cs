using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class Deal
{
    public long DealId { get; set; }

    public long? OwnerId { get; set; }

    public long? OwnerOrgId { get; set; }

    public long? CreatorId { get; set; }

    public long? CreatorOrgId { get; set; }

    public long ContactId { get; set; }

    public long ProductId { get; set; }

    public long? DealSourceId { get; set; }

    public long? CampaignReferenceId { get; set; }

    public string? DealSubject { get; set; }

    public DateOnly? ExpectedDealCloseDate { get; set; }

    public DateOnly? ActualDealCloseDate { get; set; }

    public decimal? ExpectedDealSize { get; set; }

    public long? ExpectedDealSizeCurrencyId { get; set; }

    public decimal? ExpectedDealSizeCurrencyConvRate { get; set; }

    public decimal? ExpectedDealSizeConverted { get; set; }

    public decimal? ExpectedDealRevenue { get; set; }

    public long? ExpectedDealRevenueCurrencyId { get; set; }

    public decimal? ExpectedDealRevenueCurrencyConvRate { get; set; }

    public decimal? ExpectedDealRevenueConverted { get; set; }

    public decimal? ActualDealSize { get; set; }

    public long? ActualDealSizeCurrencyId { get; set; }

    public decimal? ActualDealSizeCurrencyConvRate { get; set; }

    public decimal? ActualDealSizeConverted { get; set; }

    public decimal? ActualDealRevenue { get; set; }

    public long? ActualDealRevenueCurrencyId { get; set; }

    public decimal? ActualDealRevenueCurrencyConvRate { get; set; }

    public decimal? ActualDealRevenueConverted { get; set; }

    public long? DealStageId { get; set; }

    public long? RepresentativeId { get; set; }

    public long? EmployerId { get; set; }

    public long? DealCompetitorId { get; set; }

    public bool? IsConfidential { get; set; }

    public bool? IsCampaign { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public string? Crmcode { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsDeleteRequestRaised { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public int? AddedFromSource { get; set; }

    public long? ImportHistoryId { get; set; }

    public string? DeviceId { get; set; }

    public string? LeadReference { get; set; }

    public bool? SyncedInCrm { get; set; }

    public string? CrmsyncErrorCode { get; set; }

    public string? CrmsyncErrorMessage { get; set; }

    public DateOnly? CurrentPhaseEntryDate { get; set; }

    public DateOnly? CurrentStageEntryDate { get; set; }

    public DateOnly? ProductStartDate { get; set; }

    public DateOnly? ProductExpiryDate { get; set; }

    public string? ReferenceNumber { get; set; }

    public DateOnly? DealAlertDate { get; set; }

    public bool? IsStagnant { get; set; }

    public long? NoOfDaysExceededForStagnant { get; set; }

    public bool? IsPipeline { get; set; }

    public long? DealStatusId { get; set; }

    public bool? IncludeDealForGamification { get; set; }

    public long? WorkFlowUserId { get; set; }

    public long? WorkFlowUserGroupId { get; set; }

    public int? DealClosedBy { get; set; }

    public long? DealImportHistoryId { get; set; }

    public DateOnly? CampaignStartDate { get; set; }

    public DateOnly? CampaignEndDate { get; set; }

    public bool? IsNotContacted { get; set; }

    public bool? IsNotProgressed { get; set; }

    public bool? IsInOpportunityStage { get; set; }

    public bool? IsDue { get; set; }

    public bool? IsNotYetDue { get; set; }

    public bool? IsOverdue { get; set; }

    public bool? IsClosed { get; set; }

    public bool? IsLost { get; set; }

    public string? DealOrderNo { get; set; }

    public decimal? Probability { get; set; }

    public int? ReferralType { get; set; }

    public long? ReferredBy { get; set; }

    public string? OtherReferral { get; set; }

    public virtual CampaignReference? CampaignReference { get; set; }

    public virtual Contact Contact { get; set; } = null!;

    public virtual ICollection<DealAssignmentEmailNotificationLog> DealAssignmentEmailNotificationLogs { get; set; } = new List<DealAssignmentEmailNotificationLog>();

    public virtual ICollection<DealAttendee> DealAttendees { get; set; } = new List<DealAttendee>();

    public virtual ICollection<DealChecklistMapping> DealChecklistMappings { get; set; } = new List<DealChecklistMapping>();

    public virtual DealCompetitor? DealCompetitor { get; set; }

    public virtual ICollection<DealDocumentMapping> DealDocumentMappings { get; set; } = new List<DealDocumentMapping>();

    public virtual ICollection<DealDynamicField> DealDynamicFields { get; set; } = new List<DealDynamicField>();

    public virtual ICollection<DealImportAudit> DealImportAudits { get; set; } = new List<DealImportAudit>();

    public virtual DealImportHistory? DealImportHistory { get; set; }

    public virtual ICollection<DealOfflineSyncLog> DealOfflineSyncLogs { get; set; } = new List<DealOfflineSyncLog>();

    public virtual ICollection<DealOwnerHistory> DealOwnerHistories { get; set; } = new List<DealOwnerHistory>();

    public virtual ContactDealSource? DealSource { get; set; }

    public virtual DealStage? DealStage { get; set; }

    public virtual ICollection<DealStageDateCapture> DealStageDateCaptures { get; set; } = new List<DealStageDateCapture>();

    public virtual DealStatus? DealStatus { get; set; }

    public virtual ICollection<DealWorkFlowMemberForwardHistory> DealWorkFlowMemberForwardHistories { get; set; } = new List<DealWorkFlowMemberForwardHistory>();

    public virtual ICollection<DealWorkFlowParticipantHistory> DealWorkFlowParticipantHistories { get; set; } = new List<DealWorkFlowParticipantHistory>();

    public virtual ICollection<DealWorkFlowUserGroupHistory> DealWorkFlowUserGroupHistories { get; set; } = new List<DealWorkFlowUserGroupHistory>();

    public virtual ICollection<ImportHistoryDealsMapping> ImportHistoryDealsMappings { get; set; } = new List<ImportHistoryDealsMapping>();

    public virtual User? Owner { get; set; }

    public virtual Organisation? OwnerOrg { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual BankEmployee? ReferredByNavigation { get; set; }
}
