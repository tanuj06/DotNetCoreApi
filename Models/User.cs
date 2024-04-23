using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class User
{
    public long UserId { get; set; }

    public long OrganisationId { get; set; }

    public string UserName { get; set; } = null!;

    public long? ManagerId { get; set; }

    public long? SalutationId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public DateTime? Dob { get; set; }

    public long? DesignationId { get; set; }

    public long? UnitId { get; set; }

    public int? AllowedContactTypes { get; set; }

    public long PrefferedLanguageId { get; set; }

    public string? PasswordSalt { get; set; }

    public byte[]? PasswordHash { get; set; }

    public bool IsActive { get; set; }

    public bool IsLocked { get; set; }

    public bool? IsForceReset { get; set; }

    public int? ResetEmailSendCount { get; set; }

    public DateTime? LastResetEmailDateTime { get; set; }

    public double? Sequence { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public string? OperationsEmail { get; set; }

    public bool IsOrganisationFilterAllowed { get; set; }

    public bool? IsDraft { get; set; }

    public long? TimeZoneId { get; set; }

    public long? CamCardScanCount { get; set; }

    public bool? IsSubscribed { get; set; }

    public string? Comment { get; set; }

    public long? FinalLevel { get; set; }

    public decimal? CummulativePoints { get; set; }

    public string? Crmcode { get; set; }

    public string? AduserPrincipalName { get; set; }

    public string? AduserId { get; set; }

    public string? AduserCn { get; set; }

    public string? Addepartment { get; set; }

    public string? EmployeeId { get; set; }

    public string? EmployeeNumber { get; set; }

    public bool? IsAduser { get; set; }

    public bool? HasFullDataAccessForReport { get; set; }

    public bool? IsBackupAdmin { get; set; }

    public string? DeviceUniqueId { get; set; }

    public bool? AutoContactAllocation { get; set; }

    public DateTime? LastContactAutoAllocationDateTime { get; set; }

    public bool? RestrictOtherContactSearch { get; set; }

    public string? BranchName { get; set; }

    public string? BranchCode { get; set; }

    public string? BranchZone { get; set; }

    public long? SeniorityLevelId { get; set; }

    public bool IsRestrictedFromOwnership { get; set; }

    public long? UserImportHistoryId { get; set; }

    public long? IncentiveTemplateId { get; set; }

    public long? IncentiveBancAssuranceRoleId { get; set; }

    public string? Area { get; set; }

    public int? NoOfCsrreporting { get; set; }

    public int? NoOfVipcsrreporting { get; set; }

    public int? NoOfRmreporting { get; set; }

    public long? BankId { get; set; }

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();

    public virtual ICollection<ActivityUnTaggedHistory> ActivityUnTaggedHistories { get; set; } = new List<ActivityUnTaggedHistory>();

    public virtual ICollection<AduserSyncLog> AduserSyncLogs { get; set; } = new List<AduserSyncLog>();

    public virtual ICollection<Alert> Alerts { get; set; } = new List<Alert>();

    public virtual AllowedContactType? AllowedContactTypesNavigation { get; set; }

    public virtual ICollection<Coaching> Coachings { get; set; } = new List<Coaching>();

    public virtual ICollection<ContactAssignmentEmailNotificationLog> ContactAssignmentEmailNotificationLogCreatedByNavigations { get; set; } = new List<ContactAssignmentEmailNotificationLog>();

    public virtual ICollection<ContactAssignmentEmailNotificationLog> ContactAssignmentEmailNotificationLogOwners { get; set; } = new List<ContactAssignmentEmailNotificationLog>();

    public virtual ICollection<ContactDeletedHistory> ContactDeletedHistories { get; set; } = new List<ContactDeletedHistory>();

    public virtual ICollection<ContactPortfolioTransaction> ContactPortfolioTransactionCurrentOwners { get; set; } = new List<ContactPortfolioTransaction>();

    public virtual ICollection<ContactPortfolioTransaction> ContactPortfolioTransactionPreviousOwners { get; set; } = new List<ContactPortfolioTransaction>();

    public virtual ICollection<ContactPortfolioTransfer> ContactPortfolioTransferCreatedByNavigations { get; set; } = new List<ContactPortfolioTransfer>();

    public virtual ICollection<ContactPortfolioTransfer> ContactPortfolioTransferModifiedByNavigations { get; set; } = new List<ContactPortfolioTransfer>();

    public virtual ICollection<ContactUnTaggedHistory> ContactUnTaggedHistories { get; set; } = new List<ContactUnTaggedHistory>();

    public virtual ICollection<ContactUserMapping> ContactUserMappings { get; set; } = new List<ContactUserMapping>();

    public virtual ICollection<DailyHuddle> DailyHuddleCreatedByNavigations { get; set; } = new List<DailyHuddle>();

    public virtual ICollection<DailyHuddleDefaultTeamMemberMapping> DailyHuddleDefaultTeamMemberMappingHuddleLeads { get; set; } = new List<DailyHuddleDefaultTeamMemberMapping>();

    public virtual ICollection<DailyHuddleDefaultTeamMemberMapping> DailyHuddleDefaultTeamMemberMappingUsers { get; set; } = new List<DailyHuddleDefaultTeamMemberMapping>();

    public virtual ICollection<DailyHuddle> DailyHuddleModifiedByNavigations { get; set; } = new List<DailyHuddle>();

    public virtual ICollection<DailyHuddleUserMapping> DailyHuddleUserMappings { get; set; } = new List<DailyHuddleUserMapping>();

    public virtual ICollection<DashboardCirclesConfiguration> DashboardCirclesConfigurations { get; set; } = new List<DashboardCirclesConfiguration>();

    public virtual ICollection<DealAssignmentEmailNotificationLog> DealAssignmentEmailNotificationLogCreatedByNavigations { get; set; } = new List<DealAssignmentEmailNotificationLog>();

    public virtual ICollection<DealAssignmentEmailNotificationLog> DealAssignmentEmailNotificationLogOwners { get; set; } = new List<DealAssignmentEmailNotificationLog>();

    public virtual ICollection<DealOwnerHistory> DealOwnerHistories { get; set; } = new List<DealOwnerHistory>();

    public virtual ICollection<DealUnTaggedHistory> DealUnTaggedHistories { get; set; } = new List<DealUnTaggedHistory>();

    public virtual ICollection<DealWorkFlowMemberForwardHistory> DealWorkFlowMemberForwardHistories { get; set; } = new List<DealWorkFlowMemberForwardHistory>();

    public virtual ICollection<DealWorkFlowParticipantHistory> DealWorkFlowParticipantHistories { get; set; } = new List<DealWorkFlowParticipantHistory>();

    public virtual ICollection<Deal> Deals { get; set; } = new List<Deal>();

    public virtual ICollection<EmploymentType> EmploymentTypeCreatedByNavigations { get; set; } = new List<EmploymentType>();

    public virtual ICollection<EmploymentType> EmploymentTypeModifiedByNavigations { get; set; } = new List<EmploymentType>();

    public virtual ICollection<GameNote> GameNotes { get; set; } = new List<GameNote>();

    public virtual ICollection<GamePlayerHistory> GamePlayerHistories { get; set; } = new List<GamePlayerHistory>();

    public virtual ICollection<GamePlayerStatistic> GamePlayerStatistics { get; set; } = new List<GamePlayerStatistic>();

    public virtual ICollection<GamePlayerTeamAward> GamePlayerTeamAwards { get; set; } = new List<GamePlayerTeamAward>();

    public virtual ICollection<GamePlayerTeamRanking> GamePlayerTeamRankings { get; set; } = new List<GamePlayerTeamRanking>();

    public virtual ICollection<GamePlayerTeamSetUp> GamePlayerTeamSetUps { get; set; } = new List<GamePlayerTeamSetUp>();

    public virtual ICollection<GamePlayerTeamYearWiseRanking> GamePlayerTeamYearWiseRankings { get; set; } = new List<GamePlayerTeamYearWiseRanking>();

    public virtual ICollection<ImportHistoryActivitiesMapping> ImportHistoryActivitiesMappings { get; set; } = new List<ImportHistoryActivitiesMapping>();

    public virtual ICollection<ImportHistoryContactMapping> ImportHistoryContactMappings { get; set; } = new List<ImportHistoryContactMapping>();

    public virtual ICollection<ImportHistoryDealsMapping> ImportHistoryDealsMappings { get; set; } = new List<ImportHistoryDealsMapping>();

    public virtual IncentiveBancAssuranceRole? IncentiveBancAssuranceRole { get; set; }

    public virtual ICollection<IncentiveCreditCardTierGroup> IncentiveCreditCardTierGroupCreatedByNavigations { get; set; } = new List<IncentiveCreditCardTierGroup>();

    public virtual ICollection<IncentiveCreditCardTierGroup> IncentiveCreditCardTierGroupModifiedByNavigations { get; set; } = new List<IncentiveCreditCardTierGroup>();

    public virtual ICollection<IncentiveDebitCardCustomerType> IncentiveDebitCardCustomerTypeCreatedByNavigations { get; set; } = new List<IncentiveDebitCardCustomerType>();

    public virtual ICollection<IncentiveDebitCardCustomerType> IncentiveDebitCardCustomerTypeModifiedByNavigations { get; set; } = new List<IncentiveDebitCardCustomerType>();

    public virtual ICollection<IncentiveDebitCardType> IncentiveDebitCardTypeCreatedByNavigations { get; set; } = new List<IncentiveDebitCardType>();

    public virtual ICollection<IncentiveDebitCardType> IncentiveDebitCardTypeModifiedByNavigations { get; set; } = new List<IncentiveDebitCardType>();

    public virtual ICollection<IncentiveGranteeIndicatorWording> IncentiveGranteeIndicatorWordingCreatedByNavigations { get; set; } = new List<IncentiveGranteeIndicatorWording>();

    public virtual ICollection<IncentiveGranteeIndicatorWording> IncentiveGranteeIndicatorWordingModifiedByNavigations { get; set; } = new List<IncentiveGranteeIndicatorWording>();

    public virtual ICollection<IncentiveGranteeType> IncentiveGranteeTypeCreatedByNavigations { get; set; } = new List<IncentiveGranteeType>();

    public virtual ICollection<IncentiveGranteeType> IncentiveGranteeTypeModifiedByNavigations { get; set; } = new List<IncentiveGranteeType>();

    public virtual ICollection<IncentivePrepaidCardType> IncentivePrepaidCardTypeCreatedByNavigations { get; set; } = new List<IncentivePrepaidCardType>();

    public virtual ICollection<IncentivePrepaidCardType> IncentivePrepaidCardTypeModifiedByNavigations { get; set; } = new List<IncentivePrepaidCardType>();

    public virtual ICollection<IncentivePrimaryCreditCardType> IncentivePrimaryCreditCardTypeCreatedByNavigations { get; set; } = new List<IncentivePrimaryCreditCardType>();

    public virtual ICollection<IncentivePrimaryCreditCardType> IncentivePrimaryCreditCardTypeModifiedByNavigations { get; set; } = new List<IncentivePrimaryCreditCardType>();

    public virtual ICollection<IncentiveSupplementaryCreditCardType> IncentiveSupplementaryCreditCardTypeCreatedByNavigations { get; set; } = new List<IncentiveSupplementaryCreditCardType>();

    public virtual ICollection<IncentiveSupplementaryCreditCardType> IncentiveSupplementaryCreditCardTypeModifiedByNavigations { get; set; } = new List<IncentiveSupplementaryCreditCardType>();

    public virtual IncentiveTemplate? IncentiveTemplate { get; set; }

    public virtual ICollection<IncentiveTemplateProductUnTaggedHistory> IncentiveTemplateProductUnTaggedHistories { get; set; } = new List<IncentiveTemplateProductUnTaggedHistory>();

    public virtual ICollection<IncentiveTransactionsLoanFinal> IncentiveTransactionsLoanFinalOwners { get; set; } = new List<IncentiveTransactionsLoanFinal>();

    public virtual ICollection<IncentiveTransactionsLoanFinal> IncentiveTransactionsLoanFinalReferrelUsers { get; set; } = new List<IncentiveTransactionsLoanFinal>();

    public virtual ICollection<IncentiveTransactionsLoanReversedFinal> IncentiveTransactionsLoanReversedFinals { get; set; } = new List<IncentiveTransactionsLoanReversedFinal>();

    public virtual ICollection<InternalMessageStatus> InternalMessageStatuses { get; set; } = new List<InternalMessageStatus>();

    public virtual ICollection<InternalMessaging> InternalMessagingSendBies { get; set; } = new List<InternalMessaging>();

    public virtual ICollection<InternalMessaging> InternalMessagingSendTos { get; set; } = new List<InternalMessaging>();

    public virtual ICollection<LicenseReferral> LicenseReferralReferredByUsers { get; set; } = new List<LicenseReferral>();

    public virtual ICollection<LicenseReferral> LicenseReferralReferredToUsers { get; set; } = new List<LicenseReferral>();

    public virtual ICollection<LicenseReferralTransaction> LicenseReferralTransactions { get; set; } = new List<LicenseReferralTransaction>();

    public virtual ICollection<NationalIdType> NationalIdTypeCreatedByNavigations { get; set; } = new List<NationalIdType>();

    public virtual ICollection<NationalIdType> NationalIdTypeModifiedByNavigations { get; set; } = new List<NationalIdType>();

    public virtual ICollection<Nationality> NationalityCreatedByNavigations { get; set; } = new List<Nationality>();

    public virtual ICollection<Nationality> NationalityModifiedByNavigations { get; set; } = new List<Nationality>();

    public virtual Organisation Organisation { get; set; } = null!;

    public virtual ICollection<ProductUnTaggedHistory> ProductUnTaggedHistories { get; set; } = new List<ProductUnTaggedHistory>();

    public virtual ICollection<TempUser> TempUsers { get; set; } = new List<TempUser>();

    public virtual TimeZone? TimeZone { get; set; }

    public virtual ICollection<UserAuditTrail> UserAuditTrails { get; set; } = new List<UserAuditTrail>();

    public virtual ICollection<UserAuthenticationLog> UserAuthenticationLogs { get; set; } = new List<UserAuthenticationLog>();

    public virtual ICollection<UserBranchMappingLog> UserBranchMappingLogs { get; set; } = new List<UserBranchMappingLog>();

    public virtual ICollection<UserDeviceProfile> UserDeviceProfiles { get; set; } = new List<UserDeviceProfile>();

    public virtual ICollection<UserDynamicField> UserDynamicFields { get; set; } = new List<UserDynamicField>();

    public virtual ICollection<UserEmailNotificationConfiguration> UserEmailNotificationConfigurations { get; set; } = new List<UserEmailNotificationConfiguration>();

    public virtual ICollection<UserEmailNotificationSendLog> UserEmailNotificationSendLogs { get; set; } = new List<UserEmailNotificationSendLog>();

    public virtual ICollection<UserExplicitAccessMapping> UserExplicitAccessMappingOtherUsers { get; set; } = new List<UserExplicitAccessMapping>();

    public virtual ICollection<UserExplicitAccessMapping> UserExplicitAccessMappingUsers { get; set; } = new List<UserExplicitAccessMapping>();

    public virtual ICollection<UserGroupMapping> UserGroupMappings { get; set; } = new List<UserGroupMapping>();

    public virtual ICollection<UserImportAudit> UserImportAudits { get; set; } = new List<UserImportAudit>();

    public virtual UserImportHistory? UserImportHistory { get; set; }

    public virtual ICollection<UserIncentiveProductAccessInImport> UserIncentiveProductAccessInImports { get; set; } = new List<UserIncentiveProductAccessInImport>();

    public virtual ICollection<UserIncentiveProductAccessInReport> UserIncentiveProductAccessInReports { get; set; } = new List<UserIncentiveProductAccessInReport>();

    public virtual ICollection<UserIncentiveTemplateMappingLog> UserIncentiveTemplateMappingLogs { get; set; } = new List<UserIncentiveTemplateMappingLog>();

    public virtual ICollection<UserLanguageMapping> UserLanguageMappings { get; set; } = new List<UserLanguageMapping>();

    public virtual ICollection<UserLocationHistory> UserLocationHistories { get; set; } = new List<UserLocationHistory>();

    public virtual ICollection<UserLoginPasswordHistory> UserLoginPasswordHistories { get; set; } = new List<UserLoginPasswordHistory>();

    public virtual ICollection<UserManagerMappingLog> UserManagerMappingLogManagers { get; set; } = new List<UserManagerMappingLog>();

    public virtual ICollection<UserManagerMappingLog> UserManagerMappingLogUsers { get; set; } = new List<UserManagerMappingLog>();

    public virtual ICollection<UserModuleAccessMapping> UserModuleAccessMappingAccessToUsers { get; set; } = new List<UserModuleAccessMapping>();

    public virtual ICollection<UserModuleAccessMapping> UserModuleAccessMappingUsers { get; set; } = new List<UserModuleAccessMapping>();

    public virtual ICollection<UserMonthlyTarget> UserMonthlyTargets { get; set; } = new List<UserMonthlyTarget>();

    public virtual ICollection<UserOtphistory> UserOtphistories { get; set; } = new List<UserOtphistory>();

    public virtual ICollection<UserPinMapping> UserPinMappings { get; set; } = new List<UserPinMapping>();

    public virtual ICollection<UserProductMapping> UserProductMappings { get; set; } = new List<UserProductMapping>();

    public virtual ICollection<UserQuestionAnswerMapping> UserQuestionAnswerMappings { get; set; } = new List<UserQuestionAnswerMapping>();

    public virtual ICollection<UserRoleMapping> UserRoleMappings { get; set; } = new List<UserRoleMapping>();

    public virtual ICollection<UserSegmentMapping> UserSegmentMappings { get; set; } = new List<UserSegmentMapping>();

    public virtual ICollection<UserSettingMapping> UserSettingMappings { get; set; } = new List<UserSettingMapping>();

    public virtual ICollection<UserSuccessfulLogin> UserSuccessfulLogins { get; set; } = new List<UserSuccessfulLogin>();

    public virtual ICollection<UserUnTaggedHistory> UserUnTaggedHistories { get; set; } = new List<UserUnTaggedHistory>();

    public virtual ICollection<UserWorkAddressMapping> UserWorkAddressMappings { get; set; } = new List<UserWorkAddressMapping>();

    public virtual ICollection<ValidateLink> ValidateLinks { get; set; } = new List<ValidateLink>();
}
