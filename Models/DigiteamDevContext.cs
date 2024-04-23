using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CGMMiddleWare.Models;

public partial class DigiteamDevContext : DbContext
{
    public DigiteamDevContext()
    {
    }

    public DigiteamDevContext(DbContextOptions<DigiteamDevContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AaibAllActivity> AaibAllActivities { get; set; }

    public virtual DbSet<AaibAllDeal> AaibAllDeals { get; set; }

    public virtual DbSet<AaibLeadActivity> AaibLeadActivities { get; set; }

    public virtual DbSet<AccessCategory> AccessCategories { get; set; }

    public virtual DbSet<Activity> Activities { get; set; }

    public virtual DbSet<ActivityAttendee> ActivityAttendees { get; set; }

    public virtual DbSet<ActivityClassification> ActivityClassifications { get; set; }

    public virtual DbSet<ActivityDealMapping> ActivityDealMappings { get; set; }

    public virtual DbSet<ActivityDuration> ActivityDurations { get; set; }

    public virtual DbSet<ActivityDynamicField> ActivityDynamicFields { get; set; }

    public virtual DbSet<ActivityFieldSetting> ActivityFieldSettings { get; set; }

    public virtual DbSet<ActivityFieldSettingMaster> ActivityFieldSettingMasters { get; set; }

    public virtual DbSet<ActivityImportAudit> ActivityImportAudits { get; set; }

    public virtual DbSet<ActivityImportHistory> ActivityImportHistories { get; set; }

    public virtual DbSet<ActivityImportMapping> ActivityImportMappings { get; set; }

    public virtual DbSet<ActivityMappingHistory> ActivityMappingHistories { get; set; }

    public virtual DbSet<ActivityNote> ActivityNotes { get; set; }

    public virtual DbSet<ActivityOfflineSyncLog> ActivityOfflineSyncLogs { get; set; }

    public virtual DbSet<ActivityPageAuditTrail> ActivityPageAuditTrails { get; set; }

    public virtual DbSet<ActivityPageField> ActivityPageFields { get; set; }

    public virtual DbSet<ActivityPageFieldList> ActivityPageFieldLists { get; set; }

    public virtual DbSet<ActivityReminderDuration> ActivityReminderDurations { get; set; }

    public virtual DbSet<ActivityStage> ActivityStages { get; set; }

    public virtual DbSet<ActivityStatus> ActivityStatuses { get; set; }

    public virtual DbSet<ActivityTime> ActivityTimes { get; set; }

    public virtual DbSet<ActivityType> ActivityTypes { get; set; }

    public virtual DbSet<ActivityUnTaggedHistory> ActivityUnTaggedHistories { get; set; }

    public virtual DbSet<AddedFromSource> AddedFromSources { get; set; }

    public virtual DbSet<AduserSyncLog> AduserSyncLogs { get; set; }

    public virtual DbSet<Alert> Alerts { get; set; }

    public virtual DbSet<AlertCategory> AlertCategories { get; set; }

    public virtual DbSet<AllowedContactType> AllowedContactTypes { get; set; }

    public virtual DbSet<AppLevelEmailNotificationLog> AppLevelEmailNotificationLogs { get; set; }

    public virtual DbSet<AppSetting> AppSettings { get; set; }

    public virtual DbSet<Attachment> Attachments { get; set; }

    public virtual DbSet<AttachmentCategory> AttachmentCategories { get; set; }

    public virtual DbSet<AuditAll> AuditAlls { get; set; }

    public virtual DbSet<AuditConfiguration> AuditConfigurations { get; set; }

    public virtual DbSet<Bank> Banks { get; set; }

    public virtual DbSet<BankEmployee> BankEmployees { get; set; }

    public virtual DbSet<BankEmployeeFieldSetting> BankEmployeeFieldSettings { get; set; }

    public virtual DbSet<BankEmployeeFieldSettingMaster> BankEmployeeFieldSettingMasters { get; set; }

    public virtual DbSet<BankEmployeeImportAudit> BankEmployeeImportAudits { get; set; }

    public virtual DbSet<BankEmployeeImportHistory> BankEmployeeImportHistories { get; set; }

    public virtual DbSet<BankEmployeeImportMapping> BankEmployeeImportMappings { get; set; }

    public virtual DbSet<BankEmployeeRelatedDatum> BankEmployeeRelatedData { get; set; }

    public virtual DbSet<BasicActivityRelatedDatum> BasicActivityRelatedData { get; set; }

    public virtual DbSet<BasicContactRelatedDatum> BasicContactRelatedData { get; set; }

    public virtual DbSet<BasicDealRelatedDatum> BasicDealRelatedData { get; set; }

    public virtual DbSet<BatchFileUploadColumnValidationMapping> BatchFileUploadColumnValidationMappings { get; set; }

    public virtual DbSet<BatchFileUploadConfiguration> BatchFileUploadConfigurations { get; set; }

    public virtual DbSet<BatchFileUploadExcelColumnMapping> BatchFileUploadExcelColumnMappings { get; set; }

    public virtual DbSet<BatchFileUploadFileHistory> BatchFileUploadFileHistories { get; set; }

    public virtual DbSet<BatchFileUploadScheduleTask> BatchFileUploadScheduleTasks { get; set; }

    public virtual DbSet<BatchFileUploadTaskExecutionHistory> BatchFileUploadTaskExecutionHistories { get; set; }

    public virtual DbSet<BatchFileUploadTaskStatus> BatchFileUploadTaskStatuses { get; set; }

    public virtual DbSet<BatchFileUploadValidationRule> BatchFileUploadValidationRules { get; set; }

    public virtual DbSet<CampaignReference> CampaignReferences { get; set; }

    public virtual DbSet<ChecklistDocument> ChecklistDocuments { get; set; }

    public virtual DbSet<ChecklistDocumentGroupMapping> ChecklistDocumentGroupMappings { get; set; }

    public virtual DbSet<ChecklistGroup> ChecklistGroups { get; set; }

    public virtual DbSet<ChecklistManagement> ChecklistManagements { get; set; }

    public virtual DbSet<ChecklistManagementDocumentMapping> ChecklistManagementDocumentMappings { get; set; }

    public virtual DbSet<Coaching> Coachings { get; set; }

    public virtual DbSet<Communication> Communications { get; set; }

    public virtual DbSet<CommunicationCategory> CommunicationCategories { get; set; }

    public virtual DbSet<CommunicationCorrospondenceRelatedDataForCompany> CommunicationCorrospondenceRelatedDataForCompanies { get; set; }

    public virtual DbSet<CommunicationCorrospondenceRelatedDatum> CommunicationCorrospondenceRelatedData { get; set; }

    public virtual DbSet<CommunicationEmailRelatedDataForCompany> CommunicationEmailRelatedDataForCompanies { get; set; }

    public virtual DbSet<CommunicationEmailRelatedDatum> CommunicationEmailRelatedData { get; set; }

    public virtual DbSet<CommunicationPhoneRelatedDataForCompany> CommunicationPhoneRelatedDataForCompanies { get; set; }

    public virtual DbSet<CommunicationPhoneRelatedDatum> CommunicationPhoneRelatedData { get; set; }

    public virtual DbSet<CommunicationRelatedDatum> CommunicationRelatedData { get; set; }

    public virtual DbSet<CommunicationType> CommunicationTypes { get; set; }

    public virtual DbSet<CommunicationTypesRelatedDatum> CommunicationTypesRelatedData { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<ContactAssignmentEmailNotificationLog> ContactAssignmentEmailNotificationLogs { get; set; }

    public virtual DbSet<ContactAutoAllocationFieldSetting> ContactAutoAllocationFieldSettings { get; set; }

    public virtual DbSet<ContactAutoAllocationFieldSettingMaster> ContactAutoAllocationFieldSettingMasters { get; set; }

    public virtual DbSet<ContactCampaignMappingHistory> ContactCampaignMappingHistories { get; set; }

    public virtual DbSet<ContactDealSource> ContactDealSources { get; set; }

    public virtual DbSet<ContactDeletedHistory> ContactDeletedHistories { get; set; }

    public virtual DbSet<ContactDynamicField> ContactDynamicFields { get; set; }

    public virtual DbSet<ContactFieldSetting> ContactFieldSettings { get; set; }

    public virtual DbSet<ContactFieldSettingsMaster> ContactFieldSettingsMasters { get; set; }

    public virtual DbSet<ContactFieldSettingsRelatedDatum> ContactFieldSettingsRelatedData { get; set; }

    public virtual DbSet<ContactGroup> ContactGroups { get; set; }

    public virtual DbSet<ContactGroupMapping> ContactGroupMappings { get; set; }

    public virtual DbSet<ContactImportAudit> ContactImportAudits { get; set; }

    public virtual DbSet<ContactImportHistory> ContactImportHistories { get; set; }

    public virtual DbSet<ContactImportMapping> ContactImportMappings { get; set; }

    public virtual DbSet<ContactKey> ContactKeys { get; set; }

    public virtual DbSet<ContactOfflineSyncLog> ContactOfflineSyncLogs { get; set; }

    public virtual DbSet<ContactPageAuditTrail> ContactPageAuditTrails { get; set; }

    public virtual DbSet<ContactPageField> ContactPageFields { get; set; }

    public virtual DbSet<ContactPageFieldList> ContactPageFieldLists { get; set; }

    public virtual DbSet<ContactPortfolioTransaction> ContactPortfolioTransactions { get; set; }

    public virtual DbSet<ContactPortfolioTransfer> ContactPortfolioTransfers { get; set; }

    public virtual DbSet<ContactProductFieldSetting> ContactProductFieldSettings { get; set; }

    public virtual DbSet<ContactProductFieldSettingsMaster> ContactProductFieldSettingsMasters { get; set; }

    public virtual DbSet<ContactProductImportAudit> ContactProductImportAudits { get; set; }

    public virtual DbSet<ContactProductImportHistory> ContactProductImportHistories { get; set; }

    public virtual DbSet<ContactProductImportMapping> ContactProductImportMappings { get; set; }

    public virtual DbSet<ContactProductMappingHistory> ContactProductMappingHistories { get; set; }

    public virtual DbSet<ContactRelationRelatedDatum> ContactRelationRelatedData { get; set; }

    public virtual DbSet<ContactRelationshipMapping> ContactRelationshipMappings { get; set; }

    public virtual DbSet<ContactRelationshipType> ContactRelationshipTypes { get; set; }

    public virtual DbSet<ContactRelationshipTypeInverseMapping> ContactRelationshipTypeInverseMappings { get; set; }

    public virtual DbSet<ContactRelationshipTypesRelatedDatum> ContactRelationshipTypesRelatedData { get; set; }

    public virtual DbSet<ContactSegment> ContactSegments { get; set; }

    public virtual DbSet<ContactStatus> ContactStatuses { get; set; }

    public virtual DbSet<ContactType> ContactTypes { get; set; }

    public virtual DbSet<ContactUnTaggedHistory> ContactUnTaggedHistories { get; set; }

    public virtual DbSet<ContactUniquenessMessage> ContactUniquenessMessages { get; set; }

    public virtual DbSet<ContactUserMapping> ContactUserMappings { get; set; }

    public virtual DbSet<ContactsInitialBm> ContactsInitialBms { get; set; }

    public virtual DbSet<Correspondence> Correspondences { get; set; }

    public virtual DbSet<CorrospondanceType> CorrospondanceTypes { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<CountryTimeZoneMapping> CountryTimeZoneMappings { get; set; }

    public virtual DbSet<CrmaccessToken> CrmaccessTokens { get; set; }

    public virtual DbSet<CrmaccessTokensV2> CrmaccessTokensV2s { get; set; }

    public virtual DbSet<CrmapiCallLog> CrmapiCallLogs { get; set; }

    public virtual DbSet<CrmapicallLogsV2> CrmapicallLogsV2s { get; set; }

    public virtual DbSet<CrmmethodSyncTimeStamp> CrmmethodSyncTimeStamps { get; set; }

    public virtual DbSet<CrmprospectCustomerMapping> CrmprospectCustomerMappings { get; set; }

    public virtual DbSet<CrmsalesArmactivityStageMapping> CrmsalesArmactivityStageMappings { get; set; }

    public virtual DbSet<CrmsalesArmactivityTypeMapping> CrmsalesArmactivityTypeMappings { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<CustomerType> CustomerTypes { get; set; }

    public virtual DbSet<DailyHuddle> DailyHuddles { get; set; }

    public virtual DbSet<DailyHuddleDefaultTeamMemberMapping> DailyHuddleDefaultTeamMemberMappings { get; set; }

    public virtual DbSet<DailyHuddleRelatedDatum> DailyHuddleRelatedData { get; set; }

    public virtual DbSet<DailyHuddleType> DailyHuddleTypes { get; set; }

    public virtual DbSet<DailyHuddleUserMapping> DailyHuddleUserMappings { get; set; }

    public virtual DbSet<DashboardCirclesConfiguration> DashboardCirclesConfigurations { get; set; }

    public virtual DbSet<DashboardSelectionTypeCircleTypeMapping> DashboardSelectionTypeCircleTypeMappings { get; set; }

    public virtual DbSet<DbscriptVersion> DbscriptVersions { get; set; }

    public virtual DbSet<Deal> Deals { get; set; }

    public virtual DbSet<DealAssignmentEmailNotificationLog> DealAssignmentEmailNotificationLogs { get; set; }

    public virtual DbSet<DealAttendee> DealAttendees { get; set; }

    public virtual DbSet<DealChecklistMapping> DealChecklistMappings { get; set; }

    public virtual DbSet<DealCompetitor> DealCompetitors { get; set; }

    public virtual DbSet<DealDocumentMapping> DealDocumentMappings { get; set; }

    public virtual DbSet<DealDynamicField> DealDynamicFields { get; set; }

    public virtual DbSet<DealFieldSetting> DealFieldSettings { get; set; }

    public virtual DbSet<DealFieldSettingMaster> DealFieldSettingMasters { get; set; }

    public virtual DbSet<DealImportAudit> DealImportAudits { get; set; }

    public virtual DbSet<DealImportHistory> DealImportHistories { get; set; }

    public virtual DbSet<DealImportMapping> DealImportMappings { get; set; }

    public virtual DbSet<DealOfflineSyncLog> DealOfflineSyncLogs { get; set; }

    public virtual DbSet<DealOwnerHistory> DealOwnerHistories { get; set; }

    public virtual DbSet<DealPageAuditTrail> DealPageAuditTrails { get; set; }

    public virtual DbSet<DealPageField> DealPageFields { get; set; }

    public virtual DbSet<DealPageFieldList> DealPageFieldLists { get; set; }

    public virtual DbSet<DealStage> DealStages { get; set; }

    public virtual DbSet<DealStageAccessRightsGroupMapping> DealStageAccessRightsGroupMappings { get; set; }

    public virtual DbSet<DealStageAvailableWithGroupMapping> DealStageAvailableWithGroupMappings { get; set; }

    public virtual DbSet<DealStageDateCapture> DealStageDateCaptures { get; set; }

    public virtual DbSet<DealStageModel> DealStageModels { get; set; }

    public virtual DbSet<DealStagesRelatedDatum> DealStagesRelatedData { get; set; }

    public virtual DbSet<DealStatus> DealStatuses { get; set; }

    public virtual DbSet<DealUnTaggedHistory> DealUnTaggedHistories { get; set; }

    public virtual DbSet<DealUniquenessMessage> DealUniquenessMessages { get; set; }

    public virtual DbSet<DealWorkFlowMemberForwardHistory> DealWorkFlowMemberForwardHistories { get; set; }

    public virtual DbSet<DealWorkFlowParticipantHistory> DealWorkFlowParticipantHistories { get; set; }

    public virtual DbSet<DealWorkFlowUserGroupHistory> DealWorkFlowUserGroupHistories { get; set; }

    public virtual DbSet<DefaultFacebookLeadOwnerAudit> DefaultFacebookLeadOwnerAudits { get; set; }

    public virtual DbSet<DefaultWebsiteContactAudit> DefaultWebsiteContactAudits { get; set; }

    public virtual DbSet<DefaultWebsiteExistingLeadOwnerAudit> DefaultWebsiteExistingLeadOwnerAudits { get; set; }

    public virtual DbSet<DeletedUser> DeletedUsers { get; set; }

    public virtual DbSet<Designation> Designations { get; set; }

    public virtual DbSet<DesignationRelatedDatum> DesignationRelatedData { get; set; }

    public virtual DbSet<DocumentGroupRelatedDatum> DocumentGroupRelatedData { get; set; }

    public virtual DbSet<EmailFrequency> EmailFrequencies { get; set; }

    public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }

    public virtual DbSet<EmployeeLeaveRequest> EmployeeLeaveRequests { get; set; }

    public virtual DbSet<EmployeeLeaveRequestRelatedDatum> EmployeeLeaveRequestRelatedData { get; set; }

    public virtual DbSet<EmploymentType> EmploymentTypes { get; set; }

    public virtual DbSet<ErrorLog> ErrorLogs { get; set; }

    public virtual DbSet<ExternalApiaccessToken> ExternalApiaccessTokens { get; set; }

    public virtual DbSet<ExternalApiclientSecretKeyStore> ExternalApiclientSecretKeyStores { get; set; }

    public virtual DbSet<ExternalApirequestLogging> ExternalApirequestLoggings { get; set; }

    public virtual DbSet<ExternalProductMapping> ExternalProductMappings { get; set; }

    public virtual DbSet<FbaccessToken> FbaccessTokens { get; set; }

    public virtual DbSet<FbapiCallLog> FbapiCallLogs { get; set; }

    public virtual DbSet<FbdigiteamFieldMapping> FbdigiteamFieldMappings { get; set; }

    public virtual DbSet<FbleadFormProductMapping> FbleadFormProductMappings { get; set; }

    public virtual DbSet<FbleadRetrievalLog> FbleadRetrievalLogs { get; set; }

    public virtual DbSet<FieldCategory> FieldCategories { get; set; }

    public virtual DbSet<FieldList> FieldLists { get; set; }

    public virtual DbSet<FullActivityRelatedDatum> FullActivityRelatedData { get; set; }

    public virtual DbSet<FullContactRelatedDatum> FullContactRelatedData { get; set; }

    public virtual DbSet<FullDealRelatedDatum> FullDealRelatedData { get; set; }

    public virtual DbSet<Game> Games { get; set; }

    public virtual DbSet<GameAward> GameAwards { get; set; }

    public virtual DbSet<GameAwardCategory> GameAwardCategories { get; set; }

    public virtual DbSet<GameAwardsRelatedDatum> GameAwardsRelatedData { get; set; }

    public virtual DbSet<GameBonusPenality> GameBonusPenalities { get; set; }

    public virtual DbSet<GameDepartmentAwardMapping> GameDepartmentAwardMappings { get; set; }

    public virtual DbSet<GameLevelSetup> GameLevelSetups { get; set; }

    public virtual DbSet<GameNote> GameNotes { get; set; }

    public virtual DbSet<GameParameter> GameParameters { get; set; }

    public virtual DbSet<GamePlayerHistory> GamePlayerHistories { get; set; }

    public virtual DbSet<GamePlayerStatistic> GamePlayerStatistics { get; set; }

    public virtual DbSet<GamePlayerTeamAward> GamePlayerTeamAwards { get; set; }

    public virtual DbSet<GamePlayerTeamRanking> GamePlayerTeamRankings { get; set; }

    public virtual DbSet<GamePlayerTeamSetUp> GamePlayerTeamSetUps { get; set; }

    public virtual DbSet<GamePlayerTeamYearWiseRanking> GamePlayerTeamYearWiseRankings { get; set; }

    public virtual DbSet<GameProductMapping> GameProductMappings { get; set; }

    public virtual DbSet<GameSetting> GameSettings { get; set; }

    public virtual DbSet<GameSetupPageField> GameSetupPageFields { get; set; }

    public virtual DbSet<GameSetupPageFieldList> GameSetupPageFieldLists { get; set; }

    public virtual DbSet<GameSetupRelatedDatum> GameSetupRelatedData { get; set; }

    public virtual DbSet<GameStatus> GameStatuses { get; set; }

    public virtual DbSet<HomeDashboardCircleSelectionType> HomeDashboardCircleSelectionTypes { get; set; }

    public virtual DbSet<HomeDashboardFilterFrequencyMapping> HomeDashboardFilterFrequencyMappings { get; set; }

    public virtual DbSet<HomeDashboardFilterTypeFrequency> HomeDashboardFilterTypeFrequencies { get; set; }

    public virtual DbSet<HubSpotTranscation> HubSpotTranscations { get; set; }

    public virtual DbSet<HubspotUserInitiated> HubspotUserInitiateds { get; set; }

    public virtual DbSet<ImportHistoryActivitiesMapping> ImportHistoryActivitiesMappings { get; set; }

    public virtual DbSet<ImportHistoryContactMapping> ImportHistoryContactMappings { get; set; }

    public virtual DbSet<ImportHistoryDealsMapping> ImportHistoryDealsMappings { get; set; }

    public virtual DbSet<IncentiveBancAssuranceRole> IncentiveBancAssuranceRoles { get; set; }

    public virtual DbSet<IncentiveBranchCategory> IncentiveBranchCategories { get; set; }

    public virtual DbSet<IncentiveBranchCategoryFieldSetting> IncentiveBranchCategoryFieldSettings { get; set; }

    public virtual DbSet<IncentiveBranchCategoryFieldSettingMaster> IncentiveBranchCategoryFieldSettingMasters { get; set; }

    public virtual DbSet<IncentiveBranchCategoryImportAudit> IncentiveBranchCategoryImportAudits { get; set; }

    public virtual DbSet<IncentiveBranchCategoryImportHistory> IncentiveBranchCategoryImportHistories { get; set; }

    public virtual DbSet<IncentiveBranchCategoryImportMapping> IncentiveBranchCategoryImportMappings { get; set; }

    public virtual DbSet<IncentiveCategoryRoleTemplateMapping> IncentiveCategoryRoleTemplateMappings { get; set; }

    public virtual DbSet<IncentiveCategoryRoleTemplateMappingFieldSetting> IncentiveCategoryRoleTemplateMappingFieldSettings { get; set; }

    public virtual DbSet<IncentiveCategoryRoleTemplateMappingFieldSettingMaster> IncentiveCategoryRoleTemplateMappingFieldSettingMasters { get; set; }

    public virtual DbSet<IncentiveCategoryRoleTemplateMappingImportAudit> IncentiveCategoryRoleTemplateMappingImportAudits { get; set; }

    public virtual DbSet<IncentiveCategoryRoleTemplateMappingImportHistory> IncentiveCategoryRoleTemplateMappingImportHistories { get; set; }

    public virtual DbSet<IncentiveCategoryRoleTemplateMappingImportMapping> IncentiveCategoryRoleTemplateMappingImportMappings { get; set; }

    public virtual DbSet<IncentiveCategoryRoleTemplateMappingRelatedDatum> IncentiveCategoryRoleTemplateMappingRelatedData { get; set; }

    public virtual DbSet<IncentiveCreditCardTier> IncentiveCreditCardTiers { get; set; }

    public virtual DbSet<IncentiveCreditCardTierGroup> IncentiveCreditCardTierGroups { get; set; }

    public virtual DbSet<IncentiveDebitCardConfiguration> IncentiveDebitCardConfigurations { get; set; }

    public virtual DbSet<IncentiveDebitCardCustomerType> IncentiveDebitCardCustomerTypes { get; set; }

    public virtual DbSet<IncentiveDebitCardType> IncentiveDebitCardTypes { get; set; }

    public virtual DbSet<IncentiveFinalMonthlyUserStat> IncentiveFinalMonthlyUserStats { get; set; }

    public virtual DbSet<IncentiveGranteeIndicatorWording> IncentiveGranteeIndicatorWordings { get; set; }

    public virtual DbSet<IncentiveGranteeType> IncentiveGranteeTypes { get; set; }

    public virtual DbSet<IncentiveHurdleTemplate> IncentiveHurdleTemplates { get; set; }

    public virtual DbSet<IncentiveHurdleTemplateDeductionParameter> IncentiveHurdleTemplateDeductionParameters { get; set; }

    public virtual DbSet<IncentiveHurdleTemplateMultiplierParameter> IncentiveHurdleTemplateMultiplierParameters { get; set; }

    public virtual DbSet<IncentivePayrollTarget> IncentivePayrollTargets { get; set; }

    public virtual DbSet<IncentivePayrollTargetImportAudit> IncentivePayrollTargetImportAudits { get; set; }

    public virtual DbSet<IncentivePayrollTargetImportFieldSetting> IncentivePayrollTargetImportFieldSettings { get; set; }

    public virtual DbSet<IncentivePayrollTargetImportFieldSettingMaster> IncentivePayrollTargetImportFieldSettingMasters { get; set; }

    public virtual DbSet<IncentivePayrollTargetImportHistory> IncentivePayrollTargetImportHistories { get; set; }

    public virtual DbSet<IncentivePayrollTargetImportMapping> IncentivePayrollTargetImportMappings { get; set; }

    public virtual DbSet<IncentivePrepaidCardType> IncentivePrepaidCardTypes { get; set; }

    public virtual DbSet<IncentivePrimaryCcperBinconfiguration> IncentivePrimaryCcperBinconfigurations { get; set; }

    public virtual DbSet<IncentivePrimaryCreditCardType> IncentivePrimaryCreditCardTypes { get; set; }

    public virtual DbSet<IncentiveProductType> IncentiveProductTypes { get; set; }

    public virtual DbSet<IncentiveRoleShareTemplate> IncentiveRoleShareTemplates { get; set; }

    public virtual DbSet<IncentiveSupplementaryCcperBinconfiguration> IncentiveSupplementaryCcperBinconfigurations { get; set; }

    public virtual DbSet<IncentiveSupplementaryCreditCardType> IncentiveSupplementaryCreditCardTypes { get; set; }

    public virtual DbSet<IncentiveTemplate> IncentiveTemplates { get; set; }

    public virtual DbSet<IncentiveTemplateBancAssuranceProductParameter> IncentiveTemplateBancAssuranceProductParameters { get; set; }

    public virtual DbSet<IncentiveTemplateCreditCardProduct> IncentiveTemplateCreditCardProducts { get; set; }

    public virtual DbSet<IncentiveTemplateDebitCardProduct> IncentiveTemplateDebitCardProducts { get; set; }

    public virtual DbSet<IncentiveTemplateInternetBankingProduct> IncentiveTemplateInternetBankingProducts { get; set; }

    public virtual DbSet<IncentiveTemplateLoanProductParameter> IncentiveTemplateLoanProductParameters { get; set; }

    public virtual DbSet<IncentiveTemplatePayrollProduct> IncentiveTemplatePayrollProducts { get; set; }

    public virtual DbSet<IncentiveTemplatePosproduct> IncentiveTemplatePosproducts { get; set; }

    public virtual DbSet<IncentiveTemplatePrepaidCardProduct> IncentiveTemplatePrepaidCardProducts { get; set; }

    public virtual DbSet<IncentiveTemplateProductFieldSetting> IncentiveTemplateProductFieldSettings { get; set; }

    public virtual DbSet<IncentiveTemplateProductFieldSettingMaster> IncentiveTemplateProductFieldSettingMasters { get; set; }

    public virtual DbSet<IncentiveTemplateProductImportAudit> IncentiveTemplateProductImportAudits { get; set; }

    public virtual DbSet<IncentiveTemplateProductImportHistory> IncentiveTemplateProductImportHistories { get; set; }

    public virtual DbSet<IncentiveTemplateProductImportMapping> IncentiveTemplateProductImportMappings { get; set; }

    public virtual DbSet<IncentiveTemplateProductMappingHistory> IncentiveTemplateProductMappingHistories { get; set; }

    public virtual DbSet<IncentiveTemplateProductUnTaggedHistory> IncentiveTemplateProductUnTaggedHistories { get; set; }

    public virtual DbSet<IncentiveTransactionsBancAssuranceConventional> IncentiveTransactionsBancAssuranceConventionals { get; set; }

    public virtual DbSet<IncentiveTransactionsBancAssuranceConventionalFinal> IncentiveTransactionsBancAssuranceConventionalFinals { get; set; }

    public virtual DbSet<IncentiveTransactionsBancAssuranceIslamic> IncentiveTransactionsBancAssuranceIslamics { get; set; }

    public virtual DbSet<IncentiveTransactionsBancAssuranceIslamicFinal> IncentiveTransactionsBancAssuranceIslamicFinals { get; set; }

    public virtual DbSet<IncentiveTransactionsBancAssuranceIslamicReversed> IncentiveTransactionsBancAssuranceIslamicReverseds { get; set; }

    public virtual DbSet<IncentiveTransactionsBancAssuranceIslamicReversedFinal> IncentiveTransactionsBancAssuranceIslamicReversedFinals { get; set; }

    public virtual DbSet<IncentiveTransactionsCreditCardActivated> IncentiveTransactionsCreditCardActivateds { get; set; }

    public virtual DbSet<IncentiveTransactionsCreditCardActivatedFinal> IncentiveTransactionsCreditCardActivatedFinals { get; set; }

    public virtual DbSet<IncentiveTransactionsCreditCardIssued> IncentiveTransactionsCreditCardIssueds { get; set; }

    public virtual DbSet<IncentiveTransactionsCreditCardIssuedFinal> IncentiveTransactionsCreditCardIssuedFinals { get; set; }

    public virtual DbSet<IncentiveTransactionsDebitCardActivation> IncentiveTransactionsDebitCardActivations { get; set; }

    public virtual DbSet<IncentiveTransactionsDebitCardFinal> IncentiveTransactionsDebitCardFinals { get; set; }

    public virtual DbSet<IncentiveTransactionsDebitCardIssuance> IncentiveTransactionsDebitCardIssuances { get; set; }

    public virtual DbSet<IncentiveTransactionsDebitCardTermination> IncentiveTransactionsDebitCardTerminations { get; set; }

    public virtual DbSet<IncentiveTransactionsFinanceBranchIncentive> IncentiveTransactionsFinanceBranchIncentives { get; set; }

    public virtual DbSet<IncentiveTransactionsInternetBanking> IncentiveTransactionsInternetBankings { get; set; }

    public virtual DbSet<IncentiveTransactionsInternetBankingFinal> IncentiveTransactionsInternetBankingFinals { get; set; }

    public virtual DbSet<IncentiveTransactionsLoan> IncentiveTransactionsLoans { get; set; }

    public virtual DbSet<IncentiveTransactionsLoanFinal> IncentiveTransactionsLoanFinals { get; set; }

    public virtual DbSet<IncentiveTransactionsLoanReversed> IncentiveTransactionsLoanReverseds { get; set; }

    public virtual DbSet<IncentiveTransactionsLoanReversedFinal> IncentiveTransactionsLoanReversedFinals { get; set; }

    public virtual DbSet<IncentiveTransactionsNonSalesShareBranchIncentive> IncentiveTransactionsNonSalesShareBranchIncentives { get; set; }

    public virtual DbSet<IncentiveTransactionsNonSalesShareCreditCardBranchIncentive> IncentiveTransactionsNonSalesShareCreditCardBranchIncentives { get; set; }

    public virtual DbSet<IncentiveTransactionsNonSalesShareDebitCardBranchIncentive> IncentiveTransactionsNonSalesShareDebitCardBranchIncentives { get; set; }

    public virtual DbSet<IncentiveTransactionsNonSalesShareLoanBranchIncentive> IncentiveTransactionsNonSalesShareLoanBranchIncentives { get; set; }

    public virtual DbSet<IncentiveTransactionsPayroll> IncentiveTransactionsPayrolls { get; set; }

    public virtual DbSet<IncentiveTransactionsPayrollFinal> IncentiveTransactionsPayrollFinals { get; set; }

    public virtual DbSet<IncentiveTransactionsPrepaidCard> IncentiveTransactionsPrepaidCards { get; set; }

    public virtual DbSet<IncentiveTransactionsPrepaidCardFinal> IncentiveTransactionsPrepaidCardFinals { get; set; }

    public virtual DbSet<IncentiveTransactionsReferral> IncentiveTransactionsReferrals { get; set; }

    public virtual DbSet<IncentiveUserTemplateCcprimaryLog> IncentiveUserTemplateCcprimaryLogs { get; set; }

    public virtual DbSet<IncentiveUserTemplateCcsupplementaryLog> IncentiveUserTemplateCcsupplementaryLogs { get; set; }

    public virtual DbSet<IncentiveUserTemplateDebitCardConfigurationLog> IncentiveUserTemplateDebitCardConfigurationLogs { get; set; }

    public virtual DbSet<IncentiveUserTemplateLog> IncentiveUserTemplateLogs { get; set; }

    public virtual DbSet<IncentiveUserWiseMonthProRataStat> IncentiveUserWiseMonthProRataStats { get; set; }

    public virtual DbSet<IncentiveUserWiseMonthlyStat> IncentiveUserWiseMonthlyStats { get; set; }

    public virtual DbSet<IncentiveUserWiseNonMonthlyProductStat> IncentiveUserWiseNonMonthlyProductStats { get; set; }

    public virtual DbSet<InternalMessageStatus> InternalMessageStatuses { get; set; }

    public virtual DbSet<InternalMessaging> InternalMessagings { get; set; }

    public virtual DbSet<JobTitleParentJobTitleMapping> JobTitleParentJobTitleMappings { get; set; }

    public virtual DbSet<JobTitleParentJobTitleMappingImportFieldSetting> JobTitleParentJobTitleMappingImportFieldSettings { get; set; }

    public virtual DbSet<JobTitleParentJobTitleMappingImportFieldSettingMaster> JobTitleParentJobTitleMappingImportFieldSettingMasters { get; set; }

    public virtual DbSet<JobTitleParentJobTitleMappingImportHistory> JobTitleParentJobTitleMappingImportHistories { get; set; }

    public virtual DbSet<JobTitleParentJobTitleMappingImportMapping> JobTitleParentJobTitleMappingImportMappings { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<LanguageSpeak> LanguageSpeaks { get; set; }

    public virtual DbSet<LanguageSpeakRelatedDatum> LanguageSpeakRelatedData { get; set; }

    public virtual DbSet<LicensePaymentStatus> LicensePaymentStatuses { get; set; }

    public virtual DbSet<LicenseReferral> LicenseReferrals { get; set; }

    public virtual DbSet<LicenseReferralPercentage> LicenseReferralPercentages { get; set; }

    public virtual DbSet<LicenseReferralTransaction> LicenseReferralTransactions { get; set; }

    public virtual DbSet<LicenseReferralTransactionStatus> LicenseReferralTransactionStatuses { get; set; }

    public virtual DbSet<LicenseTransaction> LicenseTransactions { get; set; }

    public virtual DbSet<LicenseTransactionStatus> LicenseTransactionStatuses { get; set; }

    public virtual DbSet<LicenseVoucherCode> LicenseVoucherCodes { get; set; }

    public virtual DbSet<MasterPage> MasterPages { get; set; }

    public virtual DbSet<MasterPageAuditTrail> MasterPageAuditTrails { get; set; }

    public virtual DbSet<MasterPageField> MasterPageFields { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MenuAction> MenuActions { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<MonthlyIncentiveProductType> MonthlyIncentiveProductTypes { get; set; }

    public virtual DbSet<NationalIdType> NationalIdTypes { get; set; }

    public virtual DbSet<Nationality> Nationalities { get; set; }

    public virtual DbSet<Note> Notes { get; set; }

    public virtual DbSet<Organisation> Organisations { get; set; }

    public virtual DbSet<OrganisationAdgroupMapping> OrganisationAdgroupMappings { get; set; }

    public virtual DbSet<OrganisationCurrencyMapping> OrganisationCurrencyMappings { get; set; }

    public virtual DbSet<OrganisationIndustry> OrganisationIndustries { get; set; }

    public virtual DbSet<OrganisationModulePermission> OrganisationModulePermissions { get; set; }

    public virtual DbSet<OrganisationProductFamilyMapping> OrganisationProductFamilyMappings { get; set; }

    public virtual DbSet<OrganisationRelatedDatum> OrganisationRelatedData { get; set; }

    public virtual DbSet<OrganisationSetting> OrganisationSettings { get; set; }

    public virtual DbSet<OrganisationSettingMapping> OrganisationSettingMappings { get; set; }

    public virtual DbSet<OrganisationSource> OrganisationSources { get; set; }

    public virtual DbSet<OrganisationTierMapping> OrganisationTierMappings { get; set; }

    public virtual DbSet<OrganisationTierRelatedDatum> OrganisationTierRelatedData { get; set; }

    public virtual DbSet<OrganisationType> OrganisationTypes { get; set; }

    public virtual DbSet<PortfolioTransferStatus> PortfolioTransferStatuses { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductDynamicField> ProductDynamicFields { get; set; }

    public virtual DbSet<ProductFamily> ProductFamilies { get; set; }

    public virtual DbSet<ProductFamilyRelatedDatum> ProductFamilyRelatedData { get; set; }

    public virtual DbSet<ProductListRelatedDatum> ProductListRelatedData { get; set; }

    public virtual DbSet<ProductScheme> ProductSchemes { get; set; }

    public virtual DbSet<ProductSchemeRelatedDatum> ProductSchemeRelatedData { get; set; }

    public virtual DbSet<ProductType> ProductTypes { get; set; }

    public virtual DbSet<ProductTypeRelatedDatum> ProductTypeRelatedData { get; set; }

    public virtual DbSet<ProductUnTaggedHistory> ProductUnTaggedHistories { get; set; }

    public virtual DbSet<RefreshingFetchCount> RefreshingFetchCounts { get; set; }

    public virtual DbSet<ReportName> ReportNames { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleDesignationMapping> RoleDesignationMappings { get; set; }

    public virtual DbSet<RoleDesignationMappingImportAudit> RoleDesignationMappingImportAudits { get; set; }

    public virtual DbSet<RoleDesignationMappingImportFieldSetting> RoleDesignationMappingImportFieldSettings { get; set; }

    public virtual DbSet<RoleDesignationMappingImportFieldSettingMaster> RoleDesignationMappingImportFieldSettingMasters { get; set; }

    public virtual DbSet<RoleDesignationMappingImportHistory> RoleDesignationMappingImportHistories { get; set; }

    public virtual DbSet<RoleDesignationMappingImportMapping> RoleDesignationMappingImportMappings { get; set; }

    public virtual DbSet<RoleDesignationMappingRelatedDatum> RoleDesignationMappingRelatedData { get; set; }

    public virtual DbSet<RoleListRelatedDatum> RoleListRelatedData { get; set; }

    public virtual DbSet<RoleMenuMapping> RoleMenuMappings { get; set; }

    public virtual DbSet<RoleMenuMappingMakerChecker> RoleMenuMappingMakerCheckers { get; set; }

    public virtual DbSet<RoleProductMapping> RoleProductMappings { get; set; }

    public virtual DbSet<RolesMakerChecker> RolesMakerCheckers { get; set; }

    public virtual DbSet<SalesMethod> SalesMethods { get; set; }

    public virtual DbSet<Salutation> Salutations { get; set; }

    public virtual DbSet<SecurityQuestion> SecurityQuestions { get; set; }

    public virtual DbSet<SeniorityLevel> SeniorityLevels { get; set; }

    public virtual DbSet<SettingControlType> SettingControlTypes { get; set; }

    public virtual DbSet<StageHistoryRelatedDatum> StageHistoryRelatedData { get; set; }

    public virtual DbSet<SubscriptionCustomerMapping> SubscriptionCustomerMappings { get; set; }

    public virtual DbSet<SubscriptionOrganisationMapping> SubscriptionOrganisationMappings { get; set; }

    public virtual DbSet<SubscriptionRedemption> SubscriptionRedemptions { get; set; }

    public virtual DbSet<SubscriptionTransaction> SubscriptionTransactions { get; set; }

    public virtual DbSet<SubscriptionTransactionStatus> SubscriptionTransactionStatuses { get; set; }

    public virtual DbSet<SubscriptionType> SubscriptionTypes { get; set; }

    public virtual DbSet<TempOrganisationAdgroupMapping> TempOrganisationAdgroupMappings { get; set; }

    public virtual DbSet<TempRoleProductMapping> TempRoleProductMappings { get; set; }

    public virtual DbSet<TempUser> TempUsers { get; set; }

    public virtual DbSet<TempUserDynamicField> TempUserDynamicFields { get; set; }

    public virtual DbSet<TempUserExplicitAccessMapping> TempUserExplicitAccessMappings { get; set; }

    public virtual DbSet<TempUserGroupMapping> TempUserGroupMappings { get; set; }

    public virtual DbSet<TempUserImportHistory> TempUserImportHistories { get; set; }

    public virtual DbSet<TempUserImportMapping> TempUserImportMappings { get; set; }

    public virtual DbSet<TempUserIncentiveProductAccessInImport> TempUserIncentiveProductAccessInImports { get; set; }

    public virtual DbSet<TempUserIncentiveProductAccessInReport> TempUserIncentiveProductAccessInReports { get; set; }

    public virtual DbSet<TempUserLanguageMapping> TempUserLanguageMappings { get; set; }

    public virtual DbSet<TempUserProductMapping> TempUserProductMappings { get; set; }

    public virtual DbSet<TempUserRoleMapping> TempUserRoleMappings { get; set; }

    public virtual DbSet<TempUserSegmentMapping> TempUserSegmentMappings { get; set; }

    public virtual DbSet<TempUserWorkAddressMapping> TempUserWorkAddressMappings { get; set; }

    public virtual DbSet<TierReminderDurationUnit> TierReminderDurationUnits { get; set; }

    public virtual DbSet<TiersModel> TiersModels { get; set; }

    public virtual DbSet<TimeZone> TimeZones { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserAuditTrail> UserAuditTrails { get; set; }

    public virtual DbSet<UserAuthenticationLog> UserAuthenticationLogs { get; set; }

    public virtual DbSet<UserBranchMappingLog> UserBranchMappingLogs { get; set; }

    public virtual DbSet<UserDeviceProfile> UserDeviceProfiles { get; set; }

    public virtual DbSet<UserDynamicField> UserDynamicFields { get; set; }

    public virtual DbSet<UserEmailNotificationConfiguration> UserEmailNotificationConfigurations { get; set; }

    public virtual DbSet<UserEmailNotificationConfigurationRelatedDatum> UserEmailNotificationConfigurationRelatedData { get; set; }

    public virtual DbSet<UserEmailNotificationSendLog> UserEmailNotificationSendLogs { get; set; }

    public virtual DbSet<UserExplicitAccessMapping> UserExplicitAccessMappings { get; set; }

    public virtual DbSet<UserExplicitAccessMappingAudit> UserExplicitAccessMappingAudits { get; set; }

    public virtual DbSet<UserFieldSetting> UserFieldSettings { get; set; }

    public virtual DbSet<UserFieldSettingMaster> UserFieldSettingMasters { get; set; }

    public virtual DbSet<UserGroup> UserGroups { get; set; }

    public virtual DbSet<UserGroupMapping> UserGroupMappings { get; set; }

    public virtual DbSet<UserGroupRelatedDatum> UserGroupRelatedData { get; set; }

    public virtual DbSet<UserImportAudit> UserImportAudits { get; set; }

    public virtual DbSet<UserImportHistory> UserImportHistories { get; set; }

    public virtual DbSet<UserImportMapping> UserImportMappings { get; set; }

    public virtual DbSet<UserIncentiveProductAccessInImport> UserIncentiveProductAccessInImports { get; set; }

    public virtual DbSet<UserIncentiveProductAccessInReport> UserIncentiveProductAccessInReports { get; set; }

    public virtual DbSet<UserIncentiveTemplateMappingLog> UserIncentiveTemplateMappingLogs { get; set; }

    public virtual DbSet<UserLanguageMapping> UserLanguageMappings { get; set; }

    public virtual DbSet<UserLocationHistory> UserLocationHistories { get; set; }

    public virtual DbSet<UserLoginPasswordHistory> UserLoginPasswordHistories { get; set; }

    public virtual DbSet<UserManagerMappingLog> UserManagerMappingLogs { get; set; }

    public virtual DbSet<UserModuleAccessMapping> UserModuleAccessMappings { get; set; }

    public virtual DbSet<UserMonthlyTarget> UserMonthlyTargets { get; set; }

    public virtual DbSet<UserOtphistory> UserOtphistories { get; set; }

    public virtual DbSet<UserPinMapping> UserPinMappings { get; set; }

    public virtual DbSet<UserProductMapping> UserProductMappings { get; set; }

    public virtual DbSet<UserQuestionAnswerMapping> UserQuestionAnswerMappings { get; set; }

    public virtual DbSet<UserRoleMapping> UserRoleMappings { get; set; }

    public virtual DbSet<UserSegmentMapping> UserSegmentMappings { get; set; }

    public virtual DbSet<UserSessionTokenHistory> UserSessionTokenHistories { get; set; }

    public virtual DbSet<UserSetting> UserSettings { get; set; }

    public virtual DbSet<UserSettingMapping> UserSettingMappings { get; set; }

    public virtual DbSet<UserSuccessfulLogin> UserSuccessfulLogins { get; set; }

    public virtual DbSet<UserUnTaggedHistory> UserUnTaggedHistories { get; set; }

    public virtual DbSet<UserWorkAddressMapping> UserWorkAddressMappings { get; set; }

    public virtual DbSet<ValidateLink> ValidateLinks { get; set; }

    public virtual DbSet<VwAaibAllActivity> VwAaibAllActivities { get; set; }

    public virtual DbSet<VwAaibAllDeal> VwAaibAllDeals { get; set; }

    public virtual DbSet<VwMenuTree> VwMenuTrees { get; set; }

    public virtual DbSet<VwOrgSetting> VwOrgSettings { get; set; }

    public virtual DbSet<VwOrganisationTree> VwOrganisationTrees { get; set; }

    public virtual DbSet<VwRoleMenuMapping> VwRoleMenuMappings { get; set; }

    public virtual DbSet<WindowsSchedulerSetting> WindowsSchedulerSettings { get; set; }

    public virtual DbSet<WorkAddress> WorkAddresses { get; set; }

    public virtual DbSet<WorkflowGroupHistoryRelatedDatum> WorkflowGroupHistoryRelatedData { get; set; }

    public virtual DbSet<WorkflowUserHistoryRelatedDatum> WorkflowUserHistoryRelatedData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {

        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AaibAllActivity>(entity =>
        {
            entity.ToTable("AAIB_AllActivities");

            entity.HasIndex(e => e.ScheduledDate, "IX_AAIB_AllActivities_ScheduledDate");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActivityDoneTime).HasMaxLength(50);
            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.ActivityOwnerOrgId).HasColumnName("ActivityOwnerOrgID");
            entity.Property(e => e.ActivityStatus).HasMaxLength(100);
            entity.Property(e => e.ActivityType).HasMaxLength(100);
            entity.Property(e => e.CustomerId)
                .HasMaxLength(100)
                .HasColumnName("CustomerID");
            entity.Property(e => e.DealId).HasColumnName("DealID");
            entity.Property(e => e.ScheduledTime).HasMaxLength(50);
        });

        modelBuilder.Entity<AaibAllDeal>(entity =>
        {
            entity.ToTable("AAIB_AllDeals");

            entity.HasIndex(e => e.ActualDealCloseDate, "IX_AAIB_AllDeals_ActualDealCloseDate");

            entity.HasIndex(e => e.DealCreationDate, "IX_AAIB_AllDeals_DealCreationDate");

            entity.HasIndex(e => e.DealLastModifiedDate, "IX_AAIB_AllDeals_DealLastModifiedDate");

            entity.HasIndex(e => e.ExpectedDealCloseDate, "IX_AAIB_AllDeals_ExpectedDealCloseDate");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CampaignId).HasColumnName("CampaignID");
            entity.Property(e => e.ContactBranchCode).HasMaxLength(300);
            entity.Property(e => e.ContactBranchName).HasMaxLength(300);
            entity.Property(e => e.ContactCity)
                .HasMaxLength(300)
                .HasColumnName("Contact_City");
            entity.Property(e => e.ContactCreatorEmail).HasMaxLength(300);
            entity.Property(e => e.ContactCreatorName).HasMaxLength(300);
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(300)
                .HasColumnName("Contact_Email");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.ContactName).HasMaxLength(300);
            entity.Property(e => e.ContactNationalId)
                .HasMaxLength(300)
                .HasColumnName("ContactNationalID");
            entity.Property(e => e.ContactOfficeNumber)
                .HasMaxLength(300)
                .HasColumnName("Contact_OfficeNumber");
            entity.Property(e => e.ContactOwnerName).HasMaxLength(300);
            entity.Property(e => e.ContactResidenceNumber)
                .HasMaxLength(300)
                .HasColumnName("Contact_ResidenceNumber");
            entity.Property(e => e.ContactSegment).HasMaxLength(300);
            entity.Property(e => e.ContactTier).HasMaxLength(300);
            entity.Property(e => e.ContactType).HasMaxLength(300);
            entity.Property(e => e.CreatorCountry).HasMaxLength(300);
            entity.Property(e => e.CreatorDepartment).HasMaxLength(300);
            entity.Property(e => e.CreatorUserId).HasColumnName("Creator_UserID");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(100)
                .HasColumnName("CustomerID");
            entity.Property(e => e.CustomerType).HasMaxLength(300);
            entity.Property(e => e.DealCreationTime).HasMaxLength(50);
            entity.Property(e => e.DealCreatorEmail).HasMaxLength(300);
            entity.Property(e => e.DealCreatorName).HasMaxLength(300);
            entity.Property(e => e.DealCreatorRole).HasMaxLength(300);
            entity.Property(e => e.DealId).HasColumnName("DealID");
            entity.Property(e => e.DealLastModifiedTime).HasMaxLength(50);
            entity.Property(e => e.DealOwnerEmail).HasMaxLength(300);
            entity.Property(e => e.DealOwnerInternalCode).HasMaxLength(300);
            entity.Property(e => e.DealOwnerManager).HasMaxLength(300);
            entity.Property(e => e.DealOwnerName).HasMaxLength(300);
            entity.Property(e => e.DealOwnerRole).HasMaxLength(300);
            entity.Property(e => e.DealPhaseName).HasMaxLength(300);
            entity.Property(e => e.DealSource).HasMaxLength(300);
            entity.Property(e => e.DealStage).HasMaxLength(300);
            entity.Property(e => e.Department).HasMaxLength(300);
            entity.Property(e => e.EmployerName).HasMaxLength(300);
            entity.Property(e => e.OwnerUserId).HasColumnName("Owner_UserID");
            entity.Property(e => e.ProductFamilyId).HasColumnName("ProductFamilyID");
            entity.Property(e => e.ProductFamilyName).HasMaxLength(300);
            entity.Property(e => e.ProductName).HasMaxLength(300);
            entity.Property(e => e.ProductScheme).HasMaxLength(300);
            entity.Property(e => e.ProductType).HasMaxLength(300);
            entity.Property(e => e.ReferenceNumber).HasMaxLength(300);
            entity.Property(e => e.RepEmail)
                .HasMaxLength(300)
                .HasColumnName("Rep_Email");
            entity.Property(e => e.RepOfficeNumber)
                .HasMaxLength(300)
                .HasColumnName("Rep_OfficeNumber");
            entity.Property(e => e.RepResidenceNumber)
                .HasMaxLength(300)
                .HasColumnName("Rep_ResidenceNumber");
            entity.Property(e => e.RepresentativeName).HasMaxLength(300);
        });

        modelBuilder.Entity<AaibLeadActivity>(entity =>
        {
            entity.ToTable("AAIB_Lead_Activity");

            entity.HasIndex(e => e.ScheduledDate, "IX_AAIB_Lead_Activity_ScheduledDate");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActivityCreatorEmail).HasMaxLength(200);
            entity.Property(e => e.ActivityCreatorName).HasMaxLength(200);
            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.ActivityOwnerId).HasColumnName("ActivityOwnerID");
            entity.Property(e => e.ActivityStage).HasMaxLength(100);
            entity.Property(e => e.ActivityType).HasMaxLength(100);
            entity.Property(e => e.BranchCode).HasMaxLength(100);
            entity.Property(e => e.BranchName).HasMaxLength(100);
            entity.Property(e => e.ContactOfficeNumber)
                .HasMaxLength(50)
                .HasColumnName("Contact_OfficeNumber");
            entity.Property(e => e.ContactResidenceNumber).HasColumnName("Contact_ResidenceNumber");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(100)
                .HasColumnName("CustomerID");
            entity.Property(e => e.ScheduledTime).HasMaxLength(50);
        });

        modelBuilder.Entity<AccessCategory>(entity =>
        {
            entity.ToTable("AccessCategory");

            entity.Property(e => e.AccessCategoryId).HasColumnName("AccessCategoryID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Activity>(entity =>
        {
            entity.ToTable("Activity");

            entity.HasIndex(e => e.ActivityDate, "IX_Activity_ActivityDate");

            entity.HasIndex(e => new { e.OwnerOrgId, e.IsDeleted }, "IX_Activity_ActivityOwnerCreator");

            entity.HasIndex(e => e.ActivityStageId, "IX_Activity_ActivityStageID");

            entity.HasIndex(e => e.ActivityStatusId, "IX_Activity_ActivityStatusID");

            entity.HasIndex(e => e.ActivitySubject, "IX_Activity_ActivitySubject");

            entity.HasIndex(e => e.ContactId, "IX_Activity_ContactID");

            entity.HasIndex(e => e.CreatorId, "IX_Activity_CreatorID");

            entity.HasIndex(e => e.EmployerId, "IX_Activity_EmployerID");

            entity.HasIndex(e => e.IsOverdue, "IX_Activity_IsCancelled");

            entity.HasIndex(e => e.IsConfidential, "IX_Activity_IsConfidential");

            entity.HasIndex(e => e.IsDeleteRequestRaised, "IX_Activity_IsDeleteRequestRaised");

            entity.HasIndex(e => e.IsDeleted, "IX_Activity_IsDeleted");

            entity.HasIndex(e => e.IsDone, "IX_Activity_IsDone");

            entity.HasIndex(e => e.IsDue, "IX_Activity_IsDue");

            entity.HasIndex(e => e.IsNotYetDue, "IX_Activity_IsNotYetDue");

            entity.HasIndex(e => e.IsOverdue, "IX_Activity_IsOverdue");

            entity.HasIndex(e => e.IsPlanned, "IX_Activity_IsPlanned");

            entity.HasIndex(e => e.OwnerId, "IX_Activity_OwnerID");

            entity.HasIndex(e => e.OwnerOrgId, "IX_Activity_OwnerOrgID");

            entity.HasIndex(e => e.RepresentativeId, "IX_Activity_RepresentativeID");

            entity.HasIndex(e => e.ServerDateTime, "IX_Activity_ServerDateTime");

            entity.HasIndex(e => e.SyncedInCrm, "IX_Activity_SyncedInCRM");

            entity.HasIndex(e => e.ActivityTypeId, "Idx_Activity_ActivityTypeID");

            entity.HasIndex(e => e.CreatedOn, "Idx_Activity_CreatedOn");

            entity.HasIndex(e => e.ModifiedOn, "Idx_Activity_ModifiedOn");

            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.ActivityActualDuration).HasMaxLength(10);
            entity.Property(e => e.ActivityCallTypeId).HasColumnName("ActivityCallTypeID");
            entity.Property(e => e.ActivityClassificationId).HasColumnName("ActivityClassificationID");
            entity.Property(e => e.ActivityDuration).HasMaxLength(10);
            entity.Property(e => e.ActivityImportHistoryId).HasColumnName("ActivityImportHistoryID");
            entity.Property(e => e.ActivityNoteId).HasColumnName("ActivityNoteID");
            entity.Property(e => e.ActivityReminderInterval).HasMaxLength(10);
            entity.Property(e => e.ActivityStageId).HasColumnName("ActivityStageID");
            entity.Property(e => e.ActivityStatusId).HasColumnName("ActivityStatusID");
            entity.Property(e => e.ActivitySubject).HasMaxLength(500);
            entity.Property(e => e.ActivityTime).HasMaxLength(20);
            entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreatorId).HasColumnName("CreatorID");
            entity.Property(e => e.CreatorOrgId).HasColumnName("CreatorOrgID");
            entity.Property(e => e.Crmcode).HasColumnName("CRMCode");
            entity.Property(e => e.CrmsyncErrorCode)
                .HasMaxLength(50)
                .HasColumnName("CRMSyncErrorCode");
            entity.Property(e => e.CrmsyncErrorMessage).HasColumnName("CRMSyncErrorMessage");
            entity.Property(e => e.DeviceId).HasColumnName("DeviceID");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.EmployerId).HasColumnName("EmployerID");
            entity.Property(e => e.IsActivityEvent).HasDefaultValue(false);
            entity.Property(e => e.IsCancelled).HasDefaultValue(false);
            entity.Property(e => e.IsConfidential).HasDefaultValue(false);
            entity.Property(e => e.IsDeleteRequestRaised).HasDefaultValue(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsDone).HasDefaultValue(false);
            entity.Property(e => e.IsDue).HasDefaultValue(false);
            entity.Property(e => e.IsEventSent).HasDefaultValue(false);
            entity.Property(e => e.IsNotYetDue).HasDefaultValue(false);
            entity.Property(e => e.IsOverdue).HasDefaultValue(false);
            entity.Property(e => e.IsPlanned).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            entity.Property(e => e.OwnerOrgId).HasColumnName("OwnerOrgID");
            entity.Property(e => e.RepresentativeId).HasColumnName("RepresentativeID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SyncStatus).HasDefaultValue(0);
            entity.Property(e => e.SyncedInCrm)
                .HasDefaultValue(false)
                .HasColumnName("SyncedInCRM");

            entity.HasOne(d => d.ActivityClassification).WithMany(p => p.Activities)
                .HasForeignKey(d => d.ActivityClassificationId)
                .HasConstraintName("FK_Activity_ActivityClassifications");

            entity.HasOne(d => d.ActivityImportHistory).WithMany(p => p.Activities)
                .HasForeignKey(d => d.ActivityImportHistoryId)
                .HasConstraintName("FK_Activity_ActivityImportHistory");

            entity.HasOne(d => d.ActivityStage).WithMany(p => p.Activities)
                .HasForeignKey(d => d.ActivityStageId)
                .HasConstraintName("FK_Activity_ActivityStages");

            entity.HasOne(d => d.ActivityStatus).WithMany(p => p.Activities)
                .HasForeignKey(d => d.ActivityStatusId)
                .HasConstraintName("FK_Activity_ActivityStatus");

            entity.HasOne(d => d.ActivityType).WithMany(p => p.Activities)
                .HasForeignKey(d => d.ActivityTypeId)
                .HasConstraintName("FK_Activity_ActivityTypes");

            entity.HasOne(d => d.Contact).WithMany(p => p.Activities)
                .HasForeignKey(d => d.ContactId)
                .HasConstraintName("FK_Activity_Contacts");

            entity.HasOne(d => d.Owner).WithMany(p => p.Activities)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK_Activity_Users");
        });

        modelBuilder.Entity<ActivityAttendee>(entity =>
        {
            entity.HasIndex(e => e.ActivityId, "IX_ActivityAttendees_ActivityID");

            entity.HasIndex(e => e.IsContact, "IX_ActivityAttendees_IsContact");

            entity.HasIndex(e => e.IsDeleted, "IX_ActivityAttendees_IsDeleted");

            entity.Property(e => e.ActivityAttendeeId).HasColumnName("ActivityAttendeeID");
            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.AttendeeId).HasColumnName("AttendeeID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Activity).WithMany(p => p.ActivityAttendees)
                .HasForeignKey(d => d.ActivityId)
                .HasConstraintName("FK_ActivityAttendees_Activity");
        });

        modelBuilder.Entity<ActivityClassification>(entity =>
        {
            entity.HasKey(e => e.ActivityClassificationId).HasName("PK_ActivityClassifactions");

            entity.Property(e => e.ActivityClassificationId).HasColumnName("ActivityClassificationID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(200)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.NameOl1)
                .HasMaxLength(200)
                .HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2)
                .HasMaxLength(200)
                .HasColumnName("Name_OL2");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.ActivityClassifications)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_ActivityClassifications_Organisations");
        });

        modelBuilder.Entity<ActivityDealMapping>(entity =>
        {
            entity.ToTable("ActivityDealMapping");

            entity.HasIndex(e => e.ActivityId, "IX_ActivityDealMapping_ActivityID");

            entity.HasIndex(e => e.DeviceObjId, "IX_ActivityDealMapping_DeviceObjID");

            entity.Property(e => e.ActivityDealMappingId).HasColumnName("ActivityDealMappingID");
            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DealId).HasColumnName("DealID");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ActivityDuration>(entity =>
        {
            entity.HasKey(e => e.ActivityDurationId).HasName("PK_Durations");

            entity.Property(e => e.ActivityDurationId).HasColumnName("ActivityDurationID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.Duration).HasMaxLength(200);
            entity.Property(e => e.DurationUnit).HasMaxLength(200);
            entity.Property(e => e.IsDefault).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.ActivityDurations)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_ActivityDurations_Organisations");
        });

        modelBuilder.Entity<ActivityDynamicField>(entity =>
        {
            entity.HasIndex(e => e.ActivityId, "IX_ActivityDynamicFields_ActivityID");

            entity.Property(e => e.ActivityDynamicFieldId).HasColumnName("ActivityDynamicFieldID");
            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

            entity.HasOne(d => d.Activity).WithMany(p => p.ActivityDynamicFields)
                .HasForeignKey(d => d.ActivityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActivityDynamicFields_Activity");
        });

        modelBuilder.Entity<ActivityFieldSetting>(entity =>
        {
            entity.Property(e => e.ActivityFieldSettingId).HasColumnName("ActivityFieldSettingID");
            entity.Property(e => e.ActivityFieldCategoryId)
                .HasDefaultValue(1)
                .HasColumnName("ActivityFieldCategoryID");
            entity.Property(e => e.CanEditedOnDevice).HasDefaultValue(true);
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.Expression).HasMaxLength(100);
            entity.Property(e => e.FieldDataType).HasMaxLength(50);
            entity.Property(e => e.FieldLabel).HasMaxLength(100);
            entity.Property(e => e.FieldName).HasMaxLength(100);
            entity.Property(e => e.IsConfidential).HasDefaultValue(false);
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.OverwriteAlways).HasDefaultValue(true);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.ActivityFieldCategory).WithMany(p => p.ActivityFieldSettings)
                .HasForeignKey(d => d.ActivityFieldCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActivityFieldSettings_FieldCategories");

            entity.HasOne(d => d.Organisation).WithMany(p => p.ActivityFieldSettings)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActivityFieldSettings_Organisations");
        });

        modelBuilder.Entity<ActivityFieldSettingMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ActivityFieldSettingsMaster");

            entity.ToTable("ActivityFieldSettingMaster");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FieldDataType).HasMaxLength(100);
            entity.Property(e => e.FieldLabel).HasMaxLength(200);
            entity.Property(e => e.FieldName).HasMaxLength(200);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsMandatory).HasDefaultValue(false);
            entity.Property(e => e.IsStaticField).HasDefaultValue(true);
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ActivityImportAudit>(entity =>
        {
            entity.HasKey(e => e.ActivityImportAuditId).HasName("PK__Activity__75FA9D060FCCD6F0");

            entity.ToTable("ActivityImportAudit");

            entity.Property(e => e.ActivityImportAuditId).HasColumnName("ActivityImportAuditID");
            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.ColumnName).HasMaxLength(100);
            entity.Property(e => e.NewImportHistoryId).HasColumnName("NewImportHistoryID");
            entity.Property(e => e.OldImportHistoryId).HasColumnName("OldImportHistoryID");

            entity.HasOne(d => d.Activity).WithMany(p => p.ActivityImportAudits)
                .HasForeignKey(d => d.ActivityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ActivityI__Activ__1980B20F");

            entity.HasOne(d => d.NewImportHistory).WithMany(p => p.ActivityImportAuditNewImportHistories)
                .HasForeignKey(d => d.NewImportHistoryId)
                .HasConstraintName("FK__ActivityI__NewIm__1A74D648");

            entity.HasOne(d => d.OldImportHistory).WithMany(p => p.ActivityImportAuditOldImportHistories)
                .HasForeignKey(d => d.OldImportHistoryId)
                .HasConstraintName("FK__ActivityI__OldIm__1B68FA81");
        });

        modelBuilder.Entity<ActivityImportHistory>(entity =>
        {
            entity.HasKey(e => e.ActivityImportHistoryId).HasName("PK__Activity__CE13D036B65D91B5");

            entity.ToTable("ActivityImportHistory");

            entity.Property(e => e.ActivityImportHistoryId).HasColumnName("ActivityImportHistoryID");
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.ImportTimeStamp).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsReverted).HasDefaultValue(false);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.UploadedAt).HasMaxLength(200);
            entity.Property(e => e.UploadedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.ActivityImportHistories)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK__ActivityI__Organ__1C5D1EBA");
        });

        modelBuilder.Entity<ActivityImportMapping>(entity =>
        {
            entity.HasKey(e => e.ActivityImportMappingId).HasName("PK__Activity__0C684E7223339258");

            entity.ToTable("ActivityImportMapping");

            entity.Property(e => e.ActivityImportMappingId).HasColumnName("ActivityImportMappingID");
            entity.Property(e => e.ActivityFieldSettingId).HasColumnName("ActivityFieldSettingID");
            entity.Property(e => e.ImportFieldNameFromFile).HasMaxLength(100);
            entity.Property(e => e.ImportHistoryId).HasColumnName("ImportHistoryID");

            entity.HasOne(d => d.ImportHistory).WithMany(p => p.ActivityImportMappings)
                .HasForeignKey(d => d.ImportHistoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ActivityImportMapping__ImportHistoryID");
        });

        modelBuilder.Entity<ActivityMappingHistory>(entity =>
        {
            entity.HasKey(e => e.HistoryId).HasName("PK__Activity__4D7B4ADD0DB60E29");

            entity.ToTable("ActivityMappingHistory");

            entity.Property(e => e.HistoryId).HasColumnName("HistoryID");
            entity.Property(e => e.ActivityCallTypeId).HasColumnName("ActivityCallTypeID");
            entity.Property(e => e.ActivityClassificationId).HasColumnName("ActivityClassificationID");
            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.ActivityImportHistoryId).HasColumnName("ActivityImportHistoryID");
            entity.Property(e => e.ActivityStatusId).HasColumnName("ActivityStatusID");
            entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.ActivityImportHistory).WithMany(p => p.ActivityMappingHistories)
                .HasForeignKey(d => d.ActivityImportHistoryId)
                .HasConstraintName("FK__ActivityM__Activ__1E45672C");

            entity.HasOne(d => d.Contact).WithMany(p => p.ActivityMappingHistories)
                .HasForeignKey(d => d.ContactId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ActivityM__Conta__1F398B65");
        });

        modelBuilder.Entity<ActivityNote>(entity =>
        {
            entity.HasKey(e => e.ActivityNoteId).HasName("PK_ActivityNote");

            entity.Property(e => e.ActivityNoteId).HasColumnName("ActivityNoteID");
            entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IsDefault).HasDefaultValue(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NameOl1).HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2).HasColumnName("Name_OL2");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.ActivityType).WithMany(p => p.ActivityNotes)
                .HasForeignKey(d => d.ActivityTypeId)
                .HasConstraintName("FK_ActivityNotes_ActivityTypes");

            entity.HasOne(d => d.Organisation).WithMany(p => p.ActivityNotes)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_ActivityNote_Organisations");
        });

        modelBuilder.Entity<ActivityOfflineSyncLog>(entity =>
        {
            entity.ToTable("ActivityOfflineSyncLog");

            entity.Property(e => e.ActivityOfflineSyncLogId).HasColumnName("ActivityOfflineSyncLogID");
            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.StatusCode).HasMaxLength(200);

            entity.HasOne(d => d.Activity).WithMany(p => p.ActivityOfflineSyncLogs)
                .HasForeignKey(d => d.ActivityId)
                .HasConstraintName("FK_ActivityOfflineSyncLog_Activity");
        });

        modelBuilder.Entity<ActivityPageAuditTrail>(entity =>
        {
            entity.HasKey(e => e.AuditId).HasName("PK__Activity__A17F23B8678B276E");

            entity.ToTable("ActivityPageAuditTrail");

            entity.Property(e => e.AuditId).HasColumnName("AuditID");
            entity.Property(e => e.ActionType).HasMaxLength(250);
            entity.Property(e => e.ActionedOn).HasMaxLength(250);
            entity.Property(e => e.ActivityPageName).HasMaxLength(250);
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
        });

        modelBuilder.Entity<ActivityPageField>(entity =>
        {
            entity.HasKey(e => e.ActivityPageFieldId).HasName("PK__Activity__0243034FA9EE600A");

            entity.Property(e => e.ActivityPageFieldId).HasColumnName("ActivityPageFieldID");
            entity.Property(e => e.ColumnTextField).HasMaxLength(500);
            entity.Property(e => e.FieldName).HasMaxLength(250);
            entity.Property(e => e.MappingTableName).HasMaxLength(250);
            entity.Property(e => e.RelatedField).HasMaxLength(250);
        });

        modelBuilder.Entity<ActivityPageFieldList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ActivityPageFieldList");

            entity.Property(e => e.FieldName).HasMaxLength(250);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PageCode).HasMaxLength(250);
        });

        modelBuilder.Entity<ActivityReminderDuration>(entity =>
        {
            entity.Property(e => e.ActivityReminderDurationId).HasColumnName("ActivityReminderDurationID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.Duration).HasMaxLength(200);
            entity.Property(e => e.DurationUnit).HasMaxLength(200);
            entity.Property(e => e.IsDefault).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.ActivityReminderDurations)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_ActivityReminderDurations_Organisations");
        });

        modelBuilder.Entity<ActivityStage>(entity =>
        {
            entity.Property(e => e.ActivityStageId).HasColumnName("ActivityStageID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.NameOl1)
                .HasMaxLength(200)
                .HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2)
                .HasMaxLength(200)
                .HasColumnName("Name_OL2");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.StageName).HasMaxLength(200);
        });

        modelBuilder.Entity<ActivityStatus>(entity =>
        {
            entity.ToTable("ActivityStatus");

            entity.Property(e => e.ActivityStatusId)
                .ValueGeneratedNever()
                .HasColumnName("ActivityStatusID");
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<ActivityTime>(entity =>
        {
            entity.HasKey(e => e.ActivityTimeId).HasName("PK_Times");

            entity.Property(e => e.ActivityTimeId).HasColumnName("ActivityTimeID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IsDefault).HasDefaultValue(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Time).HasMaxLength(50);

            entity.HasOne(d => d.Organisation).WithMany(p => p.ActivityTimes)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_ActivityTimes_Organisations");
        });

        modelBuilder.Entity<ActivityType>(entity =>
        {
            entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TypeDescription).HasMaxLength(100);
        });

        modelBuilder.Entity<ActivityUnTaggedHistory>(entity =>
        {
            entity.ToTable("ActivityUnTaggedHistory");

            entity.HasIndex(e => e.UserId, "Idx_ActivityUntaggedHistory_UserID");

            entity.Property(e => e.ActivityUnTaggedHistoryId).HasColumnName("ActivityUnTaggedHistoryID");
            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.UnTaggedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.ActivityUnTaggedHistories)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_ActivityUnTaggedHistory_Users");
        });

        modelBuilder.Entity<AddedFromSource>(entity =>
        {
            entity.ToTable("AddedFromSource");

            entity.Property(e => e.AddedFromSourceId).HasColumnName("AddedFromSourceID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SourceName).HasMaxLength(50);
        });

        modelBuilder.Entity<AduserSyncLog>(entity =>
        {
            entity.ToTable("ADUserSyncLogs");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastSyncDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RootOrgId).HasColumnName("RootOrgID");
            entity.Property(e => e.UserAdgroup)
                .HasMaxLength(500)
                .HasColumnName("UserADGroup");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.RootOrg).WithMany(p => p.AduserSyncLogs)
                .HasForeignKey(d => d.RootOrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADUserSyncLogs_Organisations");

            entity.HasOne(d => d.User).WithMany(p => p.AduserSyncLogs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADUserSyncLogs_Users");
        });

        modelBuilder.Entity<Alert>(entity =>
        {
            entity.HasIndex(e => e.AlertDate, "IX_Alerts_AlertDate");

            entity.HasIndex(e => e.AlertCategoryId, "IX_Alerts_Category");

            entity.HasIndex(e => e.Description, "IX_Alerts_Description");

            entity.HasIndex(e => e.IsReadInPortal, "IX_Alerts_IsReadInPortal");

            entity.HasIndex(e => new { e.ModuleId, e.EntityId }, "IX_Alerts_ModuleID_EntityID");

            entity.HasIndex(e => e.UserId, "IX_Alerts_UserID");

            entity.Property(e => e.AlertId).HasColumnName("AlertID");
            entity.Property(e => e.AlertCategoryId).HasColumnName("AlertCategoryID");
            entity.Property(e => e.AlertReadDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.EntityId).HasColumnName("EntityID");
            entity.Property(e => e.IsAlert).HasDefaultValue(true);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsDueAlertSent).HasDefaultValue(false);
            entity.Property(e => e.IsNotification).HasDefaultValue(false);
            entity.Property(e => e.IsReadInPortal).HasDefaultValue(false);
            entity.Property(e => e.IsUploaded).HasDefaultValue(false);
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.NotificationSentDateTime).HasColumnType("datetime");
            entity.Property(e => e.PortalAlertReadDateTime).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.AlertCategory).WithMany(p => p.Alerts)
                .HasForeignKey(d => d.AlertCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Alerts_AlertCategory");

            entity.HasOne(d => d.User).WithMany(p => p.Alerts)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Alerts_Users");
        });

        modelBuilder.Entity<AlertCategory>(entity =>
        {
            entity.ToTable("AlertCategory");

            entity.Property(e => e.AlertCategoryId).HasColumnName("AlertCategoryID");
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<AllowedContactType>(entity =>
        {
            entity.ToTable("AllowedContactType");

            entity.Property(e => e.AllowedContactTypeId).HasColumnName("AllowedContactTypeID");
            entity.Property(e => e.ContactTypeName).HasMaxLength(50);
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<AppLevelEmailNotificationLog>(entity =>
        {
            entity.ToTable("AppLevelEmailNotificationLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EmailTemplateKey).HasMaxLength(50);
            entity.Property(e => e.LogDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AppSetting>(entity =>
        {
            entity.HasIndex(e => e.OrganisationSettingId, "IX_AppSettings_OrganisationSettingID");

            entity.Property(e => e.AppSettingId).HasColumnName("AppSettingID");
            entity.Property(e => e.OrganisationSettingId).HasColumnName("OrganisationSettingID");

            entity.HasOne(d => d.OrganisationSetting).WithMany(p => p.AppSettings)
                .HasForeignKey(d => d.OrganisationSettingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AppSettings_OrganisationSettings");
        });

        modelBuilder.Entity<Attachment>(entity =>
        {
            entity.HasIndex(e => e.AttachmentCategoryId, "IX_Attachments_AttachmentCategoryID");

            entity.HasIndex(e => e.EntityId, "IX_Attachments_EntityID");

            entity.HasIndex(e => e.IsDeleted, "IX_Attachments_IsDeleted");

            entity.HasIndex(e => e.ModuleId, "IX_Attachments_ModuleID");

            entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");
            entity.Property(e => e.AttachmentCategoryId).HasColumnName("AttachmentCategoryID");
            entity.Property(e => e.AttachmentSize).HasMaxLength(500);
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceObjId).HasColumnName("DeviceObjID");
            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.EntityId).HasColumnName("EntityID");
            entity.Property(e => e.Extension).HasMaxLength(100);
            entity.Property(e => e.FileName).HasMaxLength(100);
            entity.Property(e => e.MimecontentType)
                .HasMaxLength(100)
                .HasColumnName("MIMEContentType");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.AttachmentCategory).WithMany(p => p.Attachments)
                .HasForeignKey(d => d.AttachmentCategoryId)
                .HasConstraintName("FK_Attachments_AttachmentCategories");

            entity.HasOne(d => d.Module).WithMany(p => p.Attachments)
                .HasForeignKey(d => d.ModuleId)
                .HasConstraintName("FK_Attachments_Modules");
        });

        modelBuilder.Entity<AttachmentCategory>(entity =>
        {
            entity.Property(e => e.AttachmentCategoryId).HasColumnName("AttachmentCategoryID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<AuditAll>(entity =>
        {
            entity.HasKey(e => e.AuditId);

            entity.ToTable("Audit_All");

            entity.Property(e => e.AuditId).HasColumnName("AuditID");
            entity.Property(e => e.Description)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.FieldName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModuleName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NewValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Pkid).HasColumnName("PKID");
            entity.Property(e => e.Pkvalue)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("PKValue");
            entity.Property(e => e.ReferrelTableDataColumnName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReferrelTableName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReferrelTablePkfield)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ReferrelTablePKField");
            entity.Property(e => e.TableName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AuditConfiguration>(entity =>
        {
            entity.HasKey(e => e.ConfigurationId);

            entity.ToTable("Audit_Configuration");

            entity.Property(e => e.ConfigurationId).HasColumnName("ConfigurationID");
            entity.Property(e => e.FieldName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Pkfield)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PKField");
            entity.Property(e => e.ReferrelTableDataColumnName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReferrelTableName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReferrelTablePkfield)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ReferrelTablePKField");
            entity.Property(e => e.TableName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Bank>(entity =>
        {
            entity.ToTable("Bank");

            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BankName).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.Banks)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK__Bank__Organisati__00C0BC94");
        });

        modelBuilder.Entity<BankEmployee>(entity =>
        {
            entity.ToTable("BankEmployee");

            entity.Property(e => e.BankEmployeeId).HasColumnName("BankEmployeeID");
            entity.Property(e => e.BankEmployeeImportHistoryId).HasColumnName("BankEmployeeImportHistoryID");
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BranchCode).HasMaxLength(200);
            entity.Property(e => e.BranchName).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EmployeeName).HasMaxLength(200);
            entity.Property(e => e.EmployeeNumber).HasMaxLength(200);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Bank).WithMany(p => p.BankEmployees)
                .HasForeignKey(d => d.BankId)
                .HasConstraintName("FK__BankEmplo__BankI__4E7F558A");

            entity.HasOne(d => d.Organisation).WithMany(p => p.BankEmployees)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK__BankEmplo__Organ__4D8B3151");
        });

        modelBuilder.Entity<BankEmployeeFieldSetting>(entity =>
        {
            entity.Property(e => e.BankEmployeeFieldSettingId).HasColumnName("BankEmployeeFieldSettingID");
            entity.Property(e => e.BankEmployeeFieldCategoryId)
                .HasDefaultValue(1)
                .HasColumnName("BankEmployeeFieldCategoryID");
            entity.Property(e => e.CanEditedOnDevice).HasDefaultValue(true);
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.Expression).HasMaxLength(100);
            entity.Property(e => e.FieldDataType).HasMaxLength(50);
            entity.Property(e => e.FieldLabel).HasMaxLength(100);
            entity.Property(e => e.FieldName).HasMaxLength(100);
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.OverwriteAlways).HasDefaultValue(true);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.BankEmployeeFieldSettings)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BankEmployeeFieldSettings_BankEmployeeFieldSettings");
        });

        modelBuilder.Entity<BankEmployeeFieldSettingMaster>(entity =>
        {
            entity.ToTable("BankEmployeeFieldSettingMaster");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FieldDataType).HasMaxLength(100);
            entity.Property(e => e.FieldLabel).HasMaxLength(200);
            entity.Property(e => e.FieldName).HasMaxLength(200);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsMandatory).HasDefaultValue(false);
            entity.Property(e => e.IsStaticField).HasDefaultValue(true);
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<BankEmployeeImportAudit>(entity =>
        {
            entity.HasKey(e => e.BankEmployeeImportAuditId).HasName("PK__BankEmpl__26B417C312FE2D1D");

            entity.ToTable("BankEmployeeImportAudit");

            entity.Property(e => e.BankEmployeeImportAuditId).HasColumnName("BankEmployeeImportAuditID");
            entity.Property(e => e.BankEmployeeImportId).HasColumnName("BankEmployeeImportID");
            entity.Property(e => e.ColumnName).HasMaxLength(100);
            entity.Property(e => e.NewImportHistoryId).HasColumnName("NewImportHistoryID");
            entity.Property(e => e.OldImportHistoryId).HasColumnName("OldImportHistoryID");

            entity.HasOne(d => d.NewImportHistory).WithMany(p => p.BankEmployeeImportAuditNewImportHistories)
                .HasForeignKey(d => d.NewImportHistoryId)
                .HasConstraintName("FK__BankEmplo__NewIm__593CDB1F");

            entity.HasOne(d => d.OldImportHistory).WithMany(p => p.BankEmployeeImportAuditOldImportHistories)
                .HasForeignKey(d => d.OldImportHistoryId)
                .HasConstraintName("FK__BankEmplo__OldIm__5A30FF58");
        });

        modelBuilder.Entity<BankEmployeeImportHistory>(entity =>
        {
            entity.HasKey(e => e.BankEmployeeImportHistoryId).HasName("PK__BankEmpl__91F91FE5D02B6905");

            entity.ToTable("BankEmployeeImportHistory");

            entity.Property(e => e.BankEmployeeImportHistoryId).HasColumnName("BankEmployeeImportHistoryID");
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.ImportTimeStamp).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsReverted).HasDefaultValue(false);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.UploadedAt).HasMaxLength(200);
            entity.Property(e => e.UploadedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.BankEmployeeImportHistories)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK__BankEmplo__Organ__5B252391");
        });

        modelBuilder.Entity<BankEmployeeImportMapping>(entity =>
        {
            entity.HasKey(e => e.BankEmployeeImportMappingId).HasName("PK__BankEmpl__BAE63ECDCF0BD83C");

            entity.ToTable("BankEmployeeImportMapping");

            entity.Property(e => e.BankEmployeeImportMappingId).HasColumnName("BankEmployeeImportMappingID");
            entity.Property(e => e.BankEmployeeFieldSettingId).HasColumnName("BankEmployeeFieldSettingID");
            entity.Property(e => e.ImportFieldNameFromFile).HasMaxLength(100);
            entity.Property(e => e.ImportHistoryId).HasColumnName("ImportHistoryID");

            entity.HasOne(d => d.ImportHistory).WithMany(p => p.BankEmployeeImportMappings)
                .HasForeignKey(d => d.ImportHistoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BankEmployeeImportMapping_ImportHistoryID");
        });

        modelBuilder.Entity<BankEmployeeRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BankEmployeeRelatedData");

            entity.Property(e => e.BankEmployeeId).HasColumnName("BankEmployeeID");
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BankName).HasMaxLength(200);
            entity.Property(e => e.BranchCode).HasMaxLength(200);
            entity.Property(e => e.BranchName).HasMaxLength(200);
            entity.Property(e => e.EmployeeName).HasMaxLength(200);
            entity.Property(e => e.EmployeeNumber).HasMaxLength(200);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
        });

        modelBuilder.Entity<BasicActivityRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BasicActivityRelatedData");

            entity.Property(e => e.ActivityDateTime).HasMaxLength(221);
            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.ActivityStatusId).HasColumnName("ActivityStatusID");
            entity.Property(e => e.ActivitySubject).HasMaxLength(500);
            entity.Property(e => e.ActivityType).HasMaxLength(50);
            entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.ContactName).HasMaxLength(500);
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<BasicContactRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BasicContactRelatedData");

            entity.Property(e => e.CompanyName).HasMaxLength(300);
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.ContactSegmentId).HasColumnName("ContactSegmentID");
            entity.Property(e => e.ContactType).HasMaxLength(200);
            entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(100)
                .HasColumnName("CustomerID");
            entity.Property(e => e.FirstName).HasMaxLength(300);
            entity.Property(e => e.LastName).HasMaxLength(200);
            entity.Property(e => e.MiddleName).HasMaxLength(300);
            entity.Property(e => e.NationalId)
                .HasMaxLength(100)
                .HasColumnName("NationalID");
            entity.Property(e => e.OrganisationTierMappingId).HasColumnName("OrganisationTierMappingID");
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            entity.Property(e => e.PrimaryPhoneNumber).HasMaxLength(100);
            entity.Property(e => e.Segment).HasMaxLength(500);
            entity.Property(e => e.Tier).HasMaxLength(500);
            entity.Property(e => e.TradeLicenseNumber).HasMaxLength(100);
        });

        modelBuilder.Entity<BasicDealRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BasicDealRelatedData");

            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.ContactName).HasMaxLength(501);
            entity.Property(e => e.DealId).HasColumnName("DealID");
            entity.Property(e => e.DealSourceId).HasColumnName("DealSourceID");
            entity.Property(e => e.DealSourceName).HasMaxLength(256);
            entity.Property(e => e.DealStage).HasMaxLength(200);
            entity.Property(e => e.DealStageId).HasColumnName("DealStageID");
            entity.Property(e => e.DealSubject).HasMaxLength(500);
            entity.Property(e => e.ExpectedDealSize).HasColumnType("money");
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            entity.Property(e => e.OwnerName).HasMaxLength(256);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductName).HasMaxLength(256);
        });

        modelBuilder.Entity<BatchFileUploadColumnValidationMapping>(entity =>
        {
            entity.HasKey(e => e.MappingId).HasName("PK__BatchFil__8B5781BDC7D3F7B5");

            entity.ToTable("BatchFileUploadColumnValidationMapping");

            entity.Property(e => e.MappingId).HasColumnName("MappingID");
            entity.Property(e => e.ConfigurationId).HasColumnName("ConfigurationID");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.FieldId).HasColumnName("FieldID");
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
        });

        modelBuilder.Entity<BatchFileUploadConfiguration>(entity =>
        {
            entity.HasKey(e => e.ConfigurationId);

            entity.ToTable("BatchFileUploadConfiguration");

            entity.Property(e => e.ConfigurationId).HasColumnName("ConfigurationID");
            entity.Property(e => e.CompletedFolderPath).HasMaxLength(1000);
            entity.Property(e => e.ConfigurationName).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ErrorNotificationEmail).HasMaxLength(200);
            entity.Property(e => e.InputFolderPath).HasMaxLength(1000);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.PartiallyCompletedFolderPath).HasMaxLength(1000);
            entity.Property(e => e.ProcessingErrorFolderPath).HasMaxLength(1000);
        });

        modelBuilder.Entity<BatchFileUploadExcelColumnMapping>(entity =>
        {
            entity.HasKey(e => e.MappingId).HasName("PK__BatchFil__8B5781BDAF553299");

            entity.ToTable("BatchFileUploadExcelColumnMapping");

            entity.Property(e => e.MappingId).HasColumnName("MappingID");
            entity.Property(e => e.ConfigurationId).HasColumnName("ConfigurationID");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.FieldSettingId).HasColumnName("FieldSettingID");
            entity.Property(e => e.ImportFieldNameFromFile).HasMaxLength(100);
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.RegularExpression).HasMaxLength(1000);
            entity.Property(e => e.ValidationId).HasColumnName("ValidationID");
        });

        modelBuilder.Entity<BatchFileUploadFileHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BatchFileUploadFileHistory");

            entity.Property(e => e.EndDateTime).HasColumnType("datetime");
            entity.Property(e => e.FileHistoryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("FileHistoryID");
            entity.Property(e => e.FileName).HasMaxLength(200);
            entity.Property(e => e.StartDateTime).HasColumnType("datetime");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.TaskHistoryId).HasColumnName("TaskHistoryID");
        });

        modelBuilder.Entity<BatchFileUploadScheduleTask>(entity =>
        {
            entity.HasKey(e => e.ScheduleTaskId);

            entity.ToTable("BatchFileUploadScheduleTask");

            entity.Property(e => e.ScheduleTaskId).HasColumnName("ScheduleTaskID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FrequencyId).HasColumnName("FrequencyID");
            entity.Property(e => e.LastExecutedDateTime).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ScheduledDateTime).HasColumnType("datetime");
            entity.Property(e => e.SelectedIntervalTime).HasColumnType("datetime");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
        });

        modelBuilder.Entity<BatchFileUploadTaskExecutionHistory>(entity =>
        {
            entity.HasKey(e => e.TaskHistoryId);

            entity.ToTable("BatchFileUploadTaskExecutionHistory");

            entity.Property(e => e.TaskHistoryId).HasColumnName("TaskHistoryID");
            entity.Property(e => e.EndDateTime).HasColumnType("datetime");
            entity.Property(e => e.ScheduleTaskId).HasColumnName("ScheduleTaskID");
            entity.Property(e => e.StartDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.ScheduleTask).WithMany(p => p.BatchFileUploadTaskExecutionHistories)
                .HasForeignKey(d => d.ScheduleTaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BatchFileUploadTaskExecutionHistory_BatchFileUploadScheduleTask");
        });

        modelBuilder.Entity<BatchFileUploadTaskStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BatchFileUploadTaskStatus");

            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.StatusId)
                .ValueGeneratedOnAdd()
                .HasColumnName("StatusID");
        });

        modelBuilder.Entity<BatchFileUploadValidationRule>(entity =>
        {
            entity.HasKey(e => e.ValidationId).HasName("PK__BatchFil__FA0B50E56C6CC91D");

            entity.ToTable("BatchFileUploadValidationRule");

            entity.Property(e => e.ValidationId).HasColumnName("ValidationID");
            entity.Property(e => e.RuleName).HasMaxLength(500);
        });

        modelBuilder.Entity<CampaignReference>(entity =>
        {
            entity.Property(e => e.CampaignReferenceId).HasColumnName("CampaignReferenceID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode).HasColumnName("CRMCode");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsDynamic).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.CampaignReferences)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_CampaignReferences_Organisations");
        });

        modelBuilder.Entity<ChecklistDocument>(entity =>
        {
            entity.Property(e => e.ChecklistDocumentId).HasColumnName("ChecklistDocumentID");
            entity.Property(e => e.CreatedAt).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.DocumentName).HasMaxLength(500);
            entity.Property(e => e.DocumentNameOl1)
                .HasMaxLength(500)
                .HasColumnName("DocumentName_OL1");
            entity.Property(e => e.DocumentNameOl2)
                .HasMaxLength(500)
                .HasColumnName("DocumentName_OL2");
            entity.Property(e => e.ModifiedAt).HasMaxLength(100);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.ChecklistDocuments)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_ChecklistDocuments_Organisations");
        });

        modelBuilder.Entity<ChecklistDocumentGroupMapping>(entity =>
        {
            entity.ToTable("ChecklistDocumentGroupMapping");

            entity.Property(e => e.ChecklistDocumentGroupMappingId).HasColumnName("ChecklistDocumentGroupMappingID");
            entity.Property(e => e.CreatedAt).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(100);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Document).WithMany(p => p.ChecklistDocumentGroupMappings)
                .HasForeignKey(d => d.DocumentId)
                .HasConstraintName("FK_ChecklistDocumentGroupMapping_ChecklistDocuments");

            entity.HasOne(d => d.Group).WithMany(p => p.ChecklistDocumentGroupMappings)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK_ChecklistDocumentGroupMapping_ChecklistGroup");
        });

        modelBuilder.Entity<ChecklistGroup>(entity =>
        {
            entity.HasKey(e => e.ChecklistGroupId).HasName("PK_ChecklistDocumentGroup");

            entity.ToTable("ChecklistGroup");

            entity.Property(e => e.ChecklistGroupId).HasColumnName("ChecklistGroupID");
            entity.Property(e => e.CreatedAt).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(200)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.GroupName).HasMaxLength(500);
            entity.Property(e => e.GroupNameOl1)
                .HasMaxLength(500)
                .HasColumnName("GroupName_OL1");
            entity.Property(e => e.GroupNameOl2)
                .HasMaxLength(500)
                .HasColumnName("GroupName_OL2");
            entity.Property(e => e.ModifiedAt).HasMaxLength(100);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.ChecklistGroups)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_ChecklistDocumentGroup_Organisations");
        });

        modelBuilder.Entity<ChecklistManagement>(entity =>
        {
            entity.ToTable("ChecklistManagement");

            entity.Property(e => e.ChecklistManagementId).HasColumnName("ChecklistManagementID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerTypeId).HasColumnName("CustomerTypeID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ProductFamilyId).HasColumnName("ProductFamilyID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductSchemeId).HasColumnName("ProductSchemeID");
            entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.ChecklistManagements)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_ChecklistManagement_Organisations");

            entity.HasOne(d => d.ProductFamily).WithMany(p => p.ChecklistManagements)
                .HasForeignKey(d => d.ProductFamilyId)
                .HasConstraintName("FK_ChecklistManagement_ProductFamily");

            entity.HasOne(d => d.Product).WithMany(p => p.ChecklistManagements)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ChecklistManagement_Products");
        });

        modelBuilder.Entity<ChecklistManagementDocumentMapping>(entity =>
        {
            entity.HasKey(e => e.ChecklistManagementDocumentMappingId).HasName("PK_ChecklistDocumentMapping");

            entity.ToTable("ChecklistManagementDocumentMapping");

            entity.Property(e => e.ChecklistManagementDocumentMappingId).HasColumnName("ChecklistManagementDocumentMappingID");
            entity.Property(e => e.ChecklistManagementId).HasColumnName("ChecklistManagementID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.ChecklistManagement).WithMany(p => p.ChecklistManagementDocumentMappings)
                .HasForeignKey(d => d.ChecklistManagementId)
                .HasConstraintName("FK_ChecklistDocumentMapping_ChecklistManagement");

            entity.HasOne(d => d.Document).WithMany(p => p.ChecklistManagementDocumentMappings)
                .HasForeignKey(d => d.DocumentId)
                .HasConstraintName("FK_ChecklistDocumentMapping_ChecklistDocuments");

            entity.HasOne(d => d.Group).WithMany(p => p.ChecklistManagementDocumentMappings)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK_ChecklistDocumentMapping_ChecklistDocumentGroup");
        });

        modelBuilder.Entity<Coaching>(entity =>
        {
            entity.HasIndex(e => e.CoachingDate, "IX_Coachings_CoachingDate");

            entity.HasIndex(e => e.CreatedBy, "IX_Coachings_CreatedBy");

            entity.HasIndex(e => e.IsDeleted, "IX_Coachings_IsDeleted");

            entity.HasIndex(e => e.UserId, "IX_Coachings_UserID");

            entity.Property(e => e.CoachingId).HasColumnName("CoachingID");
            entity.Property(e => e.CoacheeNoteDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.Coachings)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Coachings_Users");
        });

        modelBuilder.Entity<Communication>(entity =>
        {
            entity.HasKey(e => e.CommunicationId).HasName("PK_Communication");

            entity.HasIndex(e => e.CommunicationData, "IX_Communication_CommunicationData");

            entity.HasIndex(e => e.EntityId, "IX_Communication_EntityID");

            entity.HasIndex(e => e.CommunicationTypeId, "Ix_Communication_CommunicationTypeID");

            entity.HasIndex(e => e.IsDefault, "Ix_Communication_IsDefault");

            entity.HasIndex(e => e.IsDeleted, "Ix_Communication_IsDeleted");

            entity.HasIndex(e => e.IsPrimary, "Ix_Communication_IsPrimary");

            entity.Property(e => e.CommunicationId).HasColumnName("CommunicationID");
            entity.Property(e => e.CommunicationData).HasMaxLength(500);
            entity.Property(e => e.CommunicationTypeId).HasColumnName("CommunicationTypeID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.EntityId).HasColumnName("EntityID");
            entity.Property(e => e.ImportHistoryId).HasColumnName("ImportHistoryID");
            entity.Property(e => e.IsMandatory).HasDefaultValue(false);
            entity.Property(e => e.IsPrimary).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.CommunicationType).WithMany(p => p.Communications)
                .HasForeignKey(d => d.CommunicationTypeId)
                .HasConstraintName("FK_Communications_CommunicationTypes");

            entity.HasOne(d => d.Module).WithMany(p => p.Communications)
                .HasForeignKey(d => d.ModuleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Communications_Modules");
        });

        modelBuilder.Entity<CommunicationCategory>(entity =>
        {
            entity.HasKey(e => e.CommunicationCategoryId).HasName("PK_CommunicationCategory");

            entity.Property(e => e.CommunicationCategoryId).HasColumnName("CommunicationCategoryID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.NameOl1)
                .HasMaxLength(500)
                .HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2)
                .HasMaxLength(500)
                .HasColumnName("Name_OL2");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<CommunicationCorrospondenceRelatedDataForCompany>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CommunicationCorrospondenceRelatedDataForCompany");

            entity.Property(e => e.Address).HasMaxLength(4000);
            entity.Property(e => e.City).HasMaxLength(2000);
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.CorrespondenceTypeId).HasColumnName("CorrespondenceTypeID");
            entity.Property(e => e.Country).HasMaxLength(2000);
            entity.Property(e => e.State).HasMaxLength(2000);
            entity.Property(e => e.Type).HasMaxLength(500);
            entity.Property(e => e.ZipCode).HasMaxLength(50);
        });

        modelBuilder.Entity<CommunicationCorrospondenceRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CommunicationCorrospondenceRelatedData");

            entity.Property(e => e.Address).HasMaxLength(4000);
            entity.Property(e => e.City).HasMaxLength(2000);
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.CorrespondenceTypeId).HasColumnName("CorrespondenceTypeID");
            entity.Property(e => e.Country).HasMaxLength(2000);
            entity.Property(e => e.State).HasMaxLength(2000);
            entity.Property(e => e.Type).HasMaxLength(500);
            entity.Property(e => e.ZipCode).HasMaxLength(50);
        });

        modelBuilder.Entity<CommunicationEmailRelatedDataForCompany>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CommunicationEmailRelatedDataForCompany");

            entity.Property(e => e.CommunicationTypeId).HasColumnName("CommunicationTypeID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.IsDefault)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Type).HasMaxLength(500);
        });

        modelBuilder.Entity<CommunicationEmailRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CommunicationEmailRelatedData");

            entity.Property(e => e.CommunicationTypeId).HasColumnName("CommunicationTypeID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.IsDefault)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Type).HasMaxLength(500);
        });

        modelBuilder.Entity<CommunicationPhoneRelatedDataForCompany>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CommunicationPhoneRelatedDataForCompany");

            entity.Property(e => e.CommunicationTypeId).HasColumnName("CommunicationTypeID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.IsDefault)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNo).HasMaxLength(500);
            entity.Property(e => e.Type).HasMaxLength(500);
        });

        modelBuilder.Entity<CommunicationPhoneRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CommunicationPhoneRelatedData");

            entity.Property(e => e.CommunicationTypeId).HasColumnName("CommunicationTypeID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.IsDefault)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNo).HasMaxLength(500);
            entity.Property(e => e.Type).HasMaxLength(500);
        });

        modelBuilder.Entity<CommunicationRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CommunicationRelatedData");

            entity.Property(e => e.CommunicationTypeId).HasColumnName("CommunicationTypeID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.Type).HasMaxLength(500);
        });

        modelBuilder.Entity<CommunicationType>(entity =>
        {
            entity.HasKey(e => e.CommunicationTypeId).HasName("PK_CommunicationType");

            entity.Property(e => e.CommunicationTypeId).HasColumnName("CommunicationTypeID");
            entity.Property(e => e.CommunicationCategoryId).HasColumnName("CommunicationCategoryID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.NameOl1)
                .HasMaxLength(500)
                .HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2)
                .HasMaxLength(500)
                .HasColumnName("Name_OL2");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.CommunicationTypes)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunicationTypes_Organisations");
        });

        modelBuilder.Entity<CommunicationTypesRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CommunicationTypesRelatedData");

            entity.Property(e => e.CategoryName).HasMaxLength(500);
            entity.Property(e => e.CommunicationCategoryId).HasColumnName("CommunicationCategoryID");
            entity.Property(e => e.CommunicationTypeId).HasColumnName("CommunicationTypeID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasIndex(e => e.BranchCode, "IX_Contacts_BranchCode").HasFilter("([BranchCode] IS NOT NULL)");

            entity.HasIndex(e => e.CampaignReferenceId, "IX_Contacts_CampaignReferenceID").HasFilter("([CampaignReferenceID] IS NOT NULL)");

            entity.HasIndex(e => e.CompanyName, "IX_Contacts_CompanyName").HasFilter("([CompanyName] IS NOT NULL)");

            entity.HasIndex(e => e.ContactSegmentId, "IX_Contacts_ContactSegmentID");

            entity.HasIndex(e => e.ContactSourceId, "IX_Contacts_ContactSourceID");

            entity.HasIndex(e => e.ContactStatusId, "IX_Contacts_ContactStatusID");

            entity.HasIndex(e => e.ContactTypeId, "IX_Contacts_ContactTypeID");

            entity.HasIndex(e => e.CustomerId, "IX_Contacts_CustomerID");

            entity.HasIndex(e => e.EmploymentTypeId, "IX_Contacts_EmploymentType").HasFilter("([EmploymentTypeID] IS NOT NULL)");

            entity.HasIndex(e => new { e.FirstName, e.MiddleName, e.LastName }, "IX_Contacts_FirstName_Middle_LastName");

            entity.HasIndex(e => e.HasClosedDeal, "IX_Contacts_HasClosedDeal");

            entity.HasIndex(e => e.HasOverdueDeal, "IX_Contacts_HasOverdueDeal");

            entity.HasIndex(e => e.HasPipelineDeal, "IX_Contacts_HasPipelineDeal");

            entity.HasIndex(e => e.HasPlannedActivity, "IX_Contacts_HasPlannedActivity");

            entity.HasIndex(e => e.ImportHistoryId, "IX_Contacts_ImportHistoryID");

            entity.HasIndex(e => e.IncludeContactForGamification, "IX_Contacts_IncludeContactForGamification").HasFilter("([IncludeContactForGamification]=(1))");

            entity.HasIndex(e => e.IsContacted, "IX_Contacts_IsContacted");

            entity.HasIndex(e => e.IsDeleteRequestRaised, "IX_Contacts_IsDeleteRequestRaised");

            entity.HasIndex(e => new { e.IsActive, e.IsDeleted }, "IX_Contacts_IsDeleted_IsActive");

            entity.HasIndex(e => e.IsDueToContact, "IX_Contacts_IsDueToContact");

            entity.HasIndex(e => e.IsEmployer, "IX_Contacts_IsEmployer");

            entity.HasIndex(e => e.IsNeverContacted, "IX_Contacts_IsNeverContacted");

            entity.HasIndex(e => e.IsNotYetDueToContact, "IX_Contacts_IsNotYetDueToContact");

            entity.HasIndex(e => e.IsOverdueToContact, "IX_Contacts_IsOverdueToContact");

            entity.HasIndex(e => e.IsRepresentative, "IX_Contacts_IsRepresentative");

            entity.HasIndex(e => new { e.IsActive, e.IsDeleted }, "IX_Contacts_Isactive_Deleted_In_tier_Cust");

            entity.HasIndex(e => e.NationalId, "IX_Contacts_NationalID").HasFilter("([NationalID] IS NOT NULL)");

            entity.HasIndex(e => e.NationalityId, "IX_Contacts_Nationality").HasFilter("([NationalityID] IS NOT NULL)");

            entity.HasIndex(e => e.OrganisationId, "IX_Contacts_OrgID_DealListing");

            entity.HasIndex(e => e.OrganisationId, "IX_Contacts_OrganisationID");

            entity.HasIndex(e => e.OrganisationTierMappingId, "IX_Contacts_OrganisationTierMappingID");

            entity.HasIndex(e => e.PoboxNumber, "IX_Contacts_POBoxNumber").HasFilter("([POBoxNumber] IS NOT NULL)");

            entity.HasIndex(e => e.PrimaryEmailAddress, "IX_Contacts_PrimaryEmail");

            entity.HasIndex(e => e.PrimaryPhoneNumber, "IX_Contacts_PrimaryPhoneNo");

            entity.HasIndex(e => e.SalutationId, "IX_Contacts_SalutationID");

            entity.HasIndex(e => e.ServerDateTime, "IX_Contacts_ServerDateTime");

            entity.HasIndex(e => e.SyncedInCrm, "IX_Contacts_SyncedInCRM");

            entity.HasIndex(e => e.TradeLicenseNumber, "IX_Contacts_TradeLicenseNumber").HasFilter("([TradeLicenseNumber] IS NOT NULL)");

            entity.HasIndex(e => e.CreatedOn, "Idx_Contacts_CreatedOn");

            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.BranchCode).HasMaxLength(100);
            entity.Property(e => e.BranchName).HasMaxLength(200);
            entity.Property(e => e.CampaignReferenceId).HasColumnName("CampaignReferenceID");
            entity.Property(e => e.CompanyName).HasMaxLength(300);
            entity.Property(e => e.CompanyWebsite).HasMaxLength(200);
            entity.Property(e => e.ContactSegmentId).HasColumnName("ContactSegmentID");
            entity.Property(e => e.ContactSourceId).HasColumnName("ContactSourceID");
            entity.Property(e => e.ContactStatusId).HasColumnName("ContactStatusID");
            entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreatorId).HasColumnName("CreatorID");
            entity.Property(e => e.CreatorOrgId).HasColumnName("CreatorOrgID");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.CrmsyncErrorCode)
                .HasMaxLength(50)
                .HasColumnName("CRMSyncErrorCode");
            entity.Property(e => e.CrmsyncErrorMessage).HasColumnName("CRMSyncErrorMessage");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(100)
                .HasColumnName("CustomerID");
            entity.Property(e => e.DeviceId).HasColumnName("DeviceID");
            entity.Property(e => e.DeviceObjId).HasColumnName("DeviceObjID");
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.EmploymentTypeId).HasColumnName("EmploymentTypeID");
            entity.Property(e => e.FirstName).HasMaxLength(300);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.HasClosedDeal).HasDefaultValue(false);
            entity.Property(e => e.HasOverdueDeal).HasDefaultValue(false);
            entity.Property(e => e.HasPipelineDeal).HasDefaultValue(false);
            entity.Property(e => e.HasPlannedActivity).HasDefaultValue(false);
            entity.Property(e => e.ImportHistoryId).HasColumnName("ImportHistoryID");
            entity.Property(e => e.IncludeContactForGamification).HasDefaultValue(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsConfidential).HasDefaultValue(false);
            entity.Property(e => e.IsContacted).HasDefaultValue(false);
            entity.Property(e => e.IsDeleteRequestRaised).HasDefaultValue(false);
            entity.Property(e => e.IsDueToContact).HasDefaultValue(false);
            entity.Property(e => e.IsEdited).HasDefaultValue(false);
            entity.Property(e => e.IsEmployer).HasDefaultValue(false);
            entity.Property(e => e.IsFavourite).HasDefaultValue(false);
            entity.Property(e => e.IsNeverContacted).HasDefaultValue(false);
            entity.Property(e => e.IsNotYetDueToContact).HasDefaultValue(false);
            entity.Property(e => e.IsOverdueToContact).HasDefaultValue(false);
            entity.Property(e => e.IsRepresentative).HasDefaultValue(false);
            entity.Property(e => e.IsUploaded).HasDefaultValue(false);
            entity.Property(e => e.LanguageSpeakId).HasColumnName("LanguageSpeakID");
            entity.Property(e => e.LastName).HasMaxLength(200);
            entity.Property(e => e.LeadId).HasColumnName("LeadID");
            entity.Property(e => e.MiddleName).HasMaxLength(300);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.MonthlySalary).HasColumnType("money");
            entity.Property(e => e.NationalId)
                .HasMaxLength(100)
                .HasColumnName("NationalID");
            entity.Property(e => e.NationalIdTypeId).HasColumnName("NationalIdTypeID");
            entity.Property(e => e.NationalityId).HasColumnName("NationalityID");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.OrganisationTierMappingId).HasColumnName("OrganisationTierMappingID");
            entity.Property(e => e.OtherReferral).HasMaxLength(500);
            entity.Property(e => e.PoboxNumber)
                .HasMaxLength(100)
                .HasColumnName("POBoxNumber");
            entity.Property(e => e.PrimaryEmailAddress).HasMaxLength(100);
            entity.Property(e => e.PrimaryPhoneNumber).HasMaxLength(100);
            entity.Property(e => e.ProfileImageId).HasColumnName("ProfileImageID");
            entity.Property(e => e.SalutationId).HasColumnName("SalutationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SyncedInCrm)
                .HasDefaultValue(false)
                .HasColumnName("SyncedInCRM");
            entity.Property(e => e.TradeLicenseNumber).HasMaxLength(100);

            entity.HasOne(d => d.CampaignReference).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.CampaignReferenceId)
                .HasConstraintName("FK_Contacts_CampaignReference");

            entity.HasOne(d => d.ContactSegment).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.ContactSegmentId)
                .HasConstraintName("FK_Contacts_ContactSegments");

            entity.HasOne(d => d.ContactSource).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.ContactSourceId)
                .HasConstraintName("FK_Contacts_ContactSources");

            entity.HasOne(d => d.ContactStatus).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.ContactStatusId)
                .HasConstraintName("FK_Contacts_ContactStatus");

            entity.HasOne(d => d.ContactType).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.ContactTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contacts_ContactTypes");

            entity.HasOne(d => d.EmploymentType).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.EmploymentTypeId)
                .HasConstraintName("FK_Contacts_EmploymentTypes");

            entity.HasOne(d => d.ImportHistory).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.ImportHistoryId)
                .HasConstraintName("FK_Contacts_ImportHistory");

            entity.HasOne(d => d.LanguageSpeak).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.LanguageSpeakId)
                .HasConstraintName("FK_Contacts_LanguageSpeak");

            entity.HasOne(d => d.NationalIdType).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.NationalIdTypeId)
                .HasConstraintName("FK_Contacts_NationalIdTypes");

            entity.HasOne(d => d.Nationality).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.NationalityId)
                .HasConstraintName("FK_Contacts_Nationality");

            entity.HasOne(d => d.Organisation).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_Contacts_Organisations");

            entity.HasOne(d => d.OrganisationTierMapping).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.OrganisationTierMappingId)
                .HasConstraintName("FK_Contacts_OrganisationTierMapping");

            entity.HasOne(d => d.ReferredByNavigation).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.ReferredBy)
                .HasConstraintName("FK_Contacts_BankEmployee");

            entity.HasOne(d => d.Salutation).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.SalutationId)
                .HasConstraintName("FK_Contacts_Salutations");
        });

        modelBuilder.Entity<ContactAssignmentEmailNotificationLog>(entity =>
        {
            entity.ToTable("ContactAssignmentEmailNotificationLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.ContactImportHistoryId).HasColumnName("ContactImportHistoryID");
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

            entity.HasOne(d => d.Contact).WithMany(p => p.ContactAssignmentEmailNotificationLogs)
                .HasForeignKey(d => d.ContactId)
                .HasConstraintName("FK_ContactAssignmentEmailNotificationLog_Contacts");

            entity.HasOne(d => d.ContactImportHistory).WithMany(p => p.ContactAssignmentEmailNotificationLogs)
                .HasForeignKey(d => d.ContactImportHistoryId)
                .HasConstraintName("FK_ContactAssignmentEmailNotificationLog_ContactImportHistory");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ContactAssignmentEmailNotificationLogCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContactAssignmentEmailNotificationLog_Users1");

            entity.HasOne(d => d.Owner).WithMany(p => p.ContactAssignmentEmailNotificationLogOwners)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContactAssignmentEmailNotificationLog_Users");
        });

        modelBuilder.Entity<ContactAutoAllocationFieldSetting>(entity =>
        {
            entity.HasKey(e => e.ContactAutoAllocationFieldSettingId).HasName("PK__ContactA__F24D3284F8B320D7");

            entity.Property(e => e.ContactAutoAllocationFieldSettingId).HasColumnName("ContactAutoAllocationFieldSettingID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FieldName).HasMaxLength(200);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.ContactAutoAllocationFieldSettings)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContactAutoAllocationFieldSettings_Organisations");
        });

        modelBuilder.Entity<ContactAutoAllocationFieldSettingMaster>(entity =>
        {
            entity.ToTable("ContactAutoAllocationFieldSettingMaster");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FieldName).HasMaxLength(200);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsMandatory).HasDefaultValue(false);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ContactCampaignMappingHistory>(entity =>
        {
            entity.HasKey(e => e.ContactCampaignMappingHistoryId).HasName("PK_ContactCampaignMapping");

            entity.ToTable("ContactCampaignMappingHistory");

            entity.Property(e => e.ContactCampaignMappingHistoryId).HasColumnName("ContactCampaignMappingHistoryID");
            entity.Property(e => e.CampaignReferenceId).HasColumnName("CampaignReferenceID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.CampaignReference).WithMany(p => p.ContactCampaignMappingHistories)
                .HasForeignKey(d => d.CampaignReferenceId)
                .HasConstraintName("FK_ContactCampaignMapping_CampaignReferences");

            entity.HasOne(d => d.Contact).WithMany(p => p.ContactCampaignMappingHistories)
                .HasForeignKey(d => d.ContactId)
                .HasConstraintName("FK_ContactCampaignMapping_Contacts");
        });

        modelBuilder.Entity<ContactDealSource>(entity =>
        {
            entity.HasKey(e => e.ContactDealSourceId).HasName("PK_ContactSources");

            entity.Property(e => e.ContactDealSourceId).HasColumnName("ContactDealSourceID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(200)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IsDefault).HasDefaultValue(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.NameOl1)
                .HasMaxLength(200)
                .HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2)
                .HasMaxLength(200)
                .HasColumnName("Name_OL2");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.ContactDealSources)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_ContactDealSources_Organisations");
        });

        modelBuilder.Entity<ContactDeletedHistory>(entity =>
        {
            entity.ToTable("ContactDeletedHistory");

            entity.Property(e => e.ContactDeletedHistoryId).HasColumnName("ContactDeletedHistoryID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.ContactDeletedHistories)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_ContactDeletedHistory_Users");
        });

        modelBuilder.Entity<ContactDynamicField>(entity =>
        {
            entity.HasIndex(e => e.ContactId, "IX_ContactDynamicFields_ContactID");

            entity.Property(e => e.ContactDynamicFieldId).HasColumnName("ContactDynamicFieldID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.CreatedAt).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedAt).HasMaxLength(100);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Contact).WithMany(p => p.ContactDynamicFields)
                .HasForeignKey(d => d.ContactId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContactDynamicFields_Contacts");
        });

        modelBuilder.Entity<ContactFieldSetting>(entity =>
        {
            entity.HasIndex(e => new { e.OrganisationId, e.IsStaticField, e.IsVisible }, "IX_ContactFieldSettings_Settings");

            entity.Property(e => e.ContactFieldSettingId).HasColumnName("ContactFieldSettingID");
            entity.Property(e => e.CanEditedOnDevice).HasDefaultValue(true);
            entity.Property(e => e.ContactFieldCategoryId).HasColumnName("ContactFieldCategoryID");
            entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.Expression).HasMaxLength(100);
            entity.Property(e => e.FieldDataType).HasMaxLength(50);
            entity.Property(e => e.FieldLabel).HasMaxLength(100);
            entity.Property(e => e.FieldName).HasMaxLength(100);
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.OverwriteAlways).HasDefaultValue(true);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.ContactType).WithMany(p => p.ContactFieldSettings)
                .HasForeignKey(d => d.ContactTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContactFieldSettings_ContactTypes");

            entity.HasOne(d => d.Organisation).WithMany(p => p.ContactFieldSettings)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContactFieldSettings_Organisations");
        });

        modelBuilder.Entity<ContactFieldSettingsMaster>(entity =>
        {
            entity.ToTable("ContactFieldSettingsMaster");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CanEditedOnDevice).HasDefaultValue(true);
            entity.Property(e => e.ContactFieldCategoryId).HasColumnName("ContactFieldCategoryID");
            entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");
            entity.Property(e => e.Expression).HasMaxLength(100);
            entity.Property(e => e.FieldDataType).HasMaxLength(50);
            entity.Property(e => e.FieldLabel).HasMaxLength(100);
            entity.Property(e => e.FieldName).HasMaxLength(100);
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.OverwriteAlways).HasDefaultValue(true);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ContactFieldSettingsRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ContactFieldSettingsRelatedData");

            entity.Property(e => e.ContactFieldCategory).HasMaxLength(200);
            entity.Property(e => e.ContactFieldCategoryId).HasColumnName("ContactFieldCategoryID");
            entity.Property(e => e.ContactFieldSettingId).HasColumnName("ContactFieldSettingID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FieldLabel).HasMaxLength(100);
            entity.Property(e => e.FieldName).HasMaxLength(100);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
        });

        modelBuilder.Entity<ContactGroup>(entity =>
        {
            entity.Property(e => e.ContactGroupId).HasColumnName("ContactGroupID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceObjId).HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.NameOl1)
                .HasMaxLength(500)
                .HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2)
                .HasMaxLength(500)
                .HasColumnName("Name_OL2");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.ContactGroups)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContactGroups_Organisations");
        });

        modelBuilder.Entity<ContactGroupMapping>(entity =>
        {
            entity.ToTable("ContactGroupMapping");

            entity.Property(e => e.ContactGroupMappingId).HasColumnName("ContactGroupMappingID");
            entity.Property(e => e.ContactGroupId).HasColumnName("ContactGroupID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceObjId).HasColumnName("DeviceObjID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.ContactGroup).WithMany(p => p.ContactGroupMappings)
                .HasForeignKey(d => d.ContactGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContactGroupMapping_ContactGroups");

            entity.HasOne(d => d.Contact).WithMany(p => p.ContactGroupMappings)
                .HasForeignKey(d => d.ContactId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContactGroupMapping_Contacts");
        });

        modelBuilder.Entity<ContactImportAudit>(entity =>
        {
            entity.ToTable("ContactImportAudit");

            entity.Property(e => e.ContactImportAuditId).HasColumnName("ContactImportAuditID");
            entity.Property(e => e.ColumnName).HasMaxLength(100);
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.NewImportHistoryId).HasColumnName("NewImportHistoryID");
            entity.Property(e => e.OldImportHistoryId).HasColumnName("OldImportHistoryID");

            entity.HasOne(d => d.Contact).WithMany(p => p.ContactImportAudits)
                .HasForeignKey(d => d.ContactId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContactImportAudit_Contacts");

            entity.HasOne(d => d.NewImportHistory).WithMany(p => p.ContactImportAuditNewImportHistories)
                .HasForeignKey(d => d.NewImportHistoryId)
                .HasConstraintName("FK_ContactImportAudit_ImportHistory_New");

            entity.HasOne(d => d.OldImportHistory).WithMany(p => p.ContactImportAuditOldImportHistories)
                .HasForeignKey(d => d.OldImportHistoryId)
                .HasConstraintName("FK_ContactImportAudit_ImportHistory_Old");
        });

        modelBuilder.Entity<ContactImportHistory>(entity =>
        {
            entity.HasKey(e => e.ContactImportHistoryId).HasName("PK_ImportHistories");

            entity.ToTable("ContactImportHistory");

            entity.Property(e => e.ContactImportHistoryId).HasColumnName("ContactImportHistoryID");
            entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");
            entity.Property(e => e.Extension).HasMaxLength(100);
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.ImportTimeStamp).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsReverted).HasDefaultValue(false);
            entity.Property(e => e.MimecontentType)
                .HasMaxLength(100)
                .HasColumnName("MIMEContentType");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.UploadedAt).HasMaxLength(200);
            entity.Property(e => e.UploadedOn).HasColumnType("datetime");

            entity.HasOne(d => d.ContactType).WithMany(p => p.ContactImportHistories)
                .HasForeignKey(d => d.ContactTypeId)
                .HasConstraintName("FK_ImportHistory_ContactTypes");

            entity.HasOne(d => d.Organisation).WithMany(p => p.ContactImportHistories)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_ContactImportHistory_Organisations");
        });

        modelBuilder.Entity<ContactImportMapping>(entity =>
        {
            entity.HasKey(e => e.ContactImportMappingId).HasName("PK_Table_1");

            entity.ToTable("ContactImportMapping");

            entity.HasIndex(e => e.ImportHistoryId, "IX_ContactImportMapping_ImportHistoryID");

            entity.Property(e => e.ContactImportMappingId).HasColumnName("ContactImportMappingID");
            entity.Property(e => e.ContactFieldSettingId).HasColumnName("ContactFieldSettingID");
            entity.Property(e => e.ImportFieldNameFromFile).HasMaxLength(100);
            entity.Property(e => e.ImportHistoryId).HasColumnName("ImportHistoryID");

            entity.HasOne(d => d.ContactFieldSetting).WithMany(p => p.ContactImportMappings)
                .HasForeignKey(d => d.ContactFieldSettingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContactImportMapping_ContactFieldSettings");

            entity.HasOne(d => d.ImportHistory).WithMany(p => p.ContactImportMappings)
                .HasForeignKey(d => d.ImportHistoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImportMapping_ImportHistory");
        });

        modelBuilder.Entity<ContactKey>(entity =>
        {
            entity.Property(e => e.ContactKeyId).HasColumnName("ContactKeyID");
            entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");

            entity.HasOne(d => d.ContactType).WithMany(p => p.ContactKeys)
                .HasForeignKey(d => d.ContactTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContactKeys_ContactTypes");
        });

        modelBuilder.Entity<ContactOfflineSyncLog>(entity =>
        {
            entity.ToTable("ContactOfflineSyncLog");

            entity.Property(e => e.ContactOfflineSyncLogId).HasColumnName("ContactOfflineSyncLogID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.StatusCode).HasMaxLength(200);

            entity.HasOne(d => d.Contact).WithMany(p => p.ContactOfflineSyncLogs)
                .HasForeignKey(d => d.ContactId)
                .HasConstraintName("FK_ContactOfflineSyncLog_Contacts");
        });

        modelBuilder.Entity<ContactPageAuditTrail>(entity =>
        {
            entity.HasKey(e => e.AuditId).HasName("PK__ContactP__A17F23B88075B9AF");

            entity.ToTable("ContactPageAuditTrail");

            entity.Property(e => e.AuditId).HasColumnName("AuditID");
            entity.Property(e => e.ActionType).HasMaxLength(250);
            entity.Property(e => e.ActionedOn).HasMaxLength(250);
            entity.Property(e => e.ContactPageName).HasMaxLength(250);
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
        });

        modelBuilder.Entity<ContactPageField>(entity =>
        {
            entity.HasKey(e => e.ContactPageFieldId).HasName("PK__ContactP__A12E7BE5B9276FAD");

            entity.Property(e => e.ContactPageFieldId).HasColumnName("ContactPageFieldID");
            entity.Property(e => e.ColumnTextField).HasMaxLength(500);
            entity.Property(e => e.FieldName).HasMaxLength(250);
            entity.Property(e => e.MappingTableName).HasMaxLength(250);
            entity.Property(e => e.RelatedField).HasMaxLength(250);
        });

        modelBuilder.Entity<ContactPageFieldList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ContactPageFieldList");

            entity.Property(e => e.FieldName).HasMaxLength(250);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PageCode).HasMaxLength(250);
        });

        modelBuilder.Entity<ContactPortfolioTransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId);

            entity.ToTable("ContactPortfolioTransaction");

            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            entity.Property(e => e.CurrentOwnerId).HasColumnName("CurrentOwnerID");
            entity.Property(e => e.EntityId).HasColumnName("EntityID");
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.PreviousOwnerId).HasColumnName("PreviousOwnerID");
            entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");
            entity.Property(e => e.TransferRequestId).HasColumnName("TransferRequestID");

            entity.HasOne(d => d.CurrentOwner).WithMany(p => p.ContactPortfolioTransactionCurrentOwners)
                .HasForeignKey(d => d.CurrentOwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContactPortfolioTransaction_Users1");

            entity.HasOne(d => d.Module).WithMany(p => p.ContactPortfolioTransactions)
                .HasForeignKey(d => d.ModuleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContactPortfolioTransaction_Modules");

            entity.HasOne(d => d.PreviousOwner).WithMany(p => p.ContactPortfolioTransactionPreviousOwners)
                .HasForeignKey(d => d.PreviousOwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContactPortfolioTransaction_Users");

            entity.HasOne(d => d.TransferRequest).WithMany(p => p.ContactPortfolioTransactions)
                .HasForeignKey(d => d.TransferRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContactPortfolioTransaction_ContactPortfolioTransfer");
        });

        modelBuilder.Entity<ContactPortfolioTransfer>(entity =>
        {
            entity.HasKey(e => e.TransferRequestId).HasName("PK_Table_1_1");

            entity.ToTable("ContactPortfolioTransfer");

            entity.Property(e => e.TransferRequestId).HasColumnName("TransferRequestID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ExecutionEndDateTime).HasColumnType("datetime");
            entity.Property(e => e.ExecutionStartDateTime).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.PortfolioTransferStatusId).HasColumnName("PortfolioTransferStatusID");
            entity.Property(e => e.TransferRequestDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ContactPortfolioTransferCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContactPortfolioTransfer_Users1");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.ContactPortfolioTransferModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_ContactPortfolioTransfer_Users2");

            entity.HasOne(d => d.PortfolioTransferStatus).WithMany(p => p.ContactPortfolioTransfers)
                .HasForeignKey(d => d.PortfolioTransferStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContactPortfolioTransfer_PortfolioTransferStatus");
        });

        modelBuilder.Entity<ContactProductFieldSetting>(entity =>
        {
            entity.HasKey(e => e.ContactProductFieldSettingId).HasName("PK__ContactP__7FA6DEDD44F4FD3E");

            entity.Property(e => e.ContactProductFieldSettingId).HasColumnName("ContactProductFieldSettingID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FieldDataType).HasMaxLength(50);
            entity.Property(e => e.FieldLabel).HasMaxLength(100);
            entity.Property(e => e.FieldName).HasMaxLength(100);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasDefaultValue(0);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.ContactProductFieldSettings)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContactPr__Organ__4FDCC2C0");
        });

        modelBuilder.Entity<ContactProductFieldSettingsMaster>(entity =>
        {
            entity.ToTable("ContactProductFieldSettingsMaster");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FieldDataType).HasMaxLength(100);
            entity.Property(e => e.FieldLabel).HasMaxLength(200);
            entity.Property(e => e.FieldName).HasMaxLength(200);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsMandatory).HasDefaultValue(false);
            entity.Property(e => e.IsStaticField).HasDefaultValue(true);
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ContactProductImportAudit>(entity =>
        {
            entity.HasKey(e => e.ContactProductImportAuditId).HasName("PK__ContactP__70A795793A189317");

            entity.ToTable("ContactProductImportAudit");

            entity.Property(e => e.ContactProductImportAuditId).HasColumnName("ContactProductImportAuditID");
            entity.Property(e => e.ColumnName).HasMaxLength(100);
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.NewImportHistoryId).HasColumnName("NewImportHistoryID");
            entity.Property(e => e.OldImportHistoryId).HasColumnName("OldImportHistoryID");

            entity.HasOne(d => d.Contact).WithMany(p => p.ContactProductImportAudits)
                .HasForeignKey(d => d.ContactId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContactPr__Conta__50D0E6F9");

            entity.HasOne(d => d.NewImportHistory).WithMany(p => p.ContactProductImportAuditNewImportHistories)
                .HasForeignKey(d => d.NewImportHistoryId)
                .HasConstraintName("FK__ContactPr__NewIm__51C50B32");

            entity.HasOne(d => d.OldImportHistory).WithMany(p => p.ContactProductImportAuditOldImportHistories)
                .HasForeignKey(d => d.OldImportHistoryId)
                .HasConstraintName("FK__ContactPr__OldIm__52B92F6B");
        });

        modelBuilder.Entity<ContactProductImportHistory>(entity =>
        {
            entity.HasKey(e => e.ContactProductImportHistoryId).HasName("PK__ContactP__B0DF03C126E82FC4");

            entity.ToTable("ContactProductImportHistory");

            entity.Property(e => e.ContactProductImportHistoryId).HasColumnName("ContactProductImportHistoryID");
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.ImportTimeStamp).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsReverted).HasDefaultValue(false);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.UploadedAt).HasMaxLength(200);
            entity.Property(e => e.UploadedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.ContactProductImportHistories)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK__ContactPr__Organ__53AD53A4");
        });

        modelBuilder.Entity<ContactProductImportMapping>(entity =>
        {
            entity.HasKey(e => e.ContactProductImportMappingId).HasName("PK__ContactP__DE8D97D66AF5EF55");

            entity.ToTable("ContactProductImportMapping");

            entity.Property(e => e.ContactProductImportMappingId).HasColumnName("ContactProductImportMappingID");
            entity.Property(e => e.ContactFieldSettingId).HasColumnName("ContactFieldSettingID");
            entity.Property(e => e.ImportFieldNameFromFile).HasMaxLength(100);
            entity.Property(e => e.ImportHistoryId).HasColumnName("ImportHistoryID");

            entity.HasOne(d => d.ContactFieldSetting).WithMany(p => p.ContactProductImportMappings)
                .HasForeignKey(d => d.ContactFieldSettingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_ContactProductImportMapping_ContactFieldSettingID");

            entity.HasOne(d => d.ImportHistory).WithMany(p => p.ContactProductImportMappings)
                .HasForeignKey(d => d.ImportHistoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContactPr__Impor__2D58FB4A");
        });

        modelBuilder.Entity<ContactProductMappingHistory>(entity =>
        {
            entity.HasKey(e => e.HistoryId).HasName("PK__ContactP__4D7B4ADD9024A294");

            entity.ToTable("ContactProductMappingHistory");

            entity.Property(e => e.HistoryId).HasColumnName("HistoryID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.ContactProductImportHistoryId).HasColumnName("ContactProductImportHistoryID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Contact).WithMany(p => p.ContactProductMappingHistories)
                .HasForeignKey(d => d.ContactId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ContactPr__Conta__5689C04F");

            entity.HasOne(d => d.ContactProductImportHistory).WithMany(p => p.ContactProductMappingHistories)
                .HasForeignKey(d => d.ContactProductImportHistoryId)
                .HasConstraintName("FK__ContactPr__Conta__577DE488");
        });

        modelBuilder.Entity<ContactRelationRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ContactRelationRelatedData");

            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.ContactName).HasMaxLength(501);
            entity.Property(e => e.ContactRelationshipTypeId).HasColumnName("ContactRelationshipTypeID");
            entity.Property(e => e.RelationshipWithContactId).HasColumnName("RelationshipWithContactID");
            entity.Property(e => e.Type).HasMaxLength(500);
        });

        modelBuilder.Entity<ContactRelationshipMapping>(entity =>
        {
            entity.ToTable("ContactRelationshipMapping");

            entity.HasIndex(e => e.ContactId, "IX_ContactRelationshipMapping_ContactID");

            entity.HasIndex(e => e.ContactRelationshipTypeId, "IX_ContactRelationshipMapping_ContactRelationshipTypeID");

            entity.HasIndex(e => e.IsDeleted, "IX_ContactRelationshipMapping_IsDeleted");

            entity.HasIndex(e => e.RelationshipWithContactId, "IX_ContactRelationshipMapping_RelationshipWithContactID");

            entity.Property(e => e.ContactRelationshipMappingId).HasColumnName("ContactRelationshipMappingID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.ContactRelationshipTypeId).HasColumnName("ContactRelationshipTypeID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId).HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.RelationshipWithContactId).HasColumnName("RelationshipWithContactID");
            entity.Property(e => e.RelationshipWithContactObjId).HasColumnName("RelationshipWithContactObjID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Contact).WithMany(p => p.ContactRelationshipMappingContacts)
                .HasForeignKey(d => d.ContactId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContactRelationshipMapping_Contacts");

            entity.HasOne(d => d.ContactRelationshipType).WithMany(p => p.ContactRelationshipMappings)
                .HasForeignKey(d => d.ContactRelationshipTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContactRelationshipMapping_ContactRelationshipTypes");

            entity.HasOne(d => d.Organisation).WithMany(p => p.ContactRelationshipMappings)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_ContactRelationshipMapping_Organisations");

            entity.HasOne(d => d.RelationshipWithContact).WithMany(p => p.ContactRelationshipMappingRelationshipWithContacts)
                .HasForeignKey(d => d.RelationshipWithContactId)
                .HasConstraintName("FK_ContactRelationshipMapping_Contacts_WithID");
        });

        modelBuilder.Entity<ContactRelationshipType>(entity =>
        {
            entity.Property(e => e.ContactRelationshipTypeId).HasColumnName("ContactRelationshipTypeID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.DeviceObjId).HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.NameOl1)
                .HasMaxLength(500)
                .HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2)
                .HasMaxLength(500)
                .HasColumnName("Name_OL2");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.ContactRelationshipTypes)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_ContactRelationshipTypes_Organisations");
        });

        modelBuilder.Entity<ContactRelationshipTypeInverseMapping>(entity =>
        {
            entity.HasKey(e => e.ContactRelationshipTypeInverseMappingId).HasName("PK_RelationshipInverseMapping");

            entity.ToTable("ContactRelationshipTypeInverseMapping");

            entity.HasIndex(e => e.ContactTypeId, "IX_ContactRelationshipTypeInverseMapping_ContactTypeID");

            entity.HasIndex(e => e.OrganisationId, "IX_ContactRelationshipTypeInverseMapping_OrganisationID");

            entity.HasIndex(e => e.RelationshipTypeId, "IX_ContactRelationshipTypeInverseMapping_RelationshipTypeID");

            entity.Property(e => e.ContactRelationshipTypeInverseMappingId).HasColumnName("ContactRelationshipTypeInverseMappingID");
            entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");
            entity.Property(e => e.CreatedAt).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.InverseRelationshipTypeId).HasColumnName("InverseRelationshipTypeID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.RelationshipTypeId).HasColumnName("RelationshipTypeID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.ContactType).WithMany(p => p.ContactRelationshipTypeInverseMappings)
                .HasForeignKey(d => d.ContactTypeId)
                .HasConstraintName("FK_RelationshipInverseMapping_ContactTypes");

            entity.HasOne(d => d.InverseRelationshipType).WithMany(p => p.ContactRelationshipTypeInverseMappingInverseRelationshipTypes)
                .HasForeignKey(d => d.InverseRelationshipTypeId)
                .HasConstraintName("FK_RelationshipInverseMapping_ContactRelationshipTypes1");

            entity.HasOne(d => d.Organisation).WithMany(p => p.ContactRelationshipTypeInverseMappings)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_ContactRelationshipTypeInverseMapping_Organisations");

            entity.HasOne(d => d.RelationshipType).WithMany(p => p.ContactRelationshipTypeInverseMappingRelationshipTypes)
                .HasForeignKey(d => d.RelationshipTypeId)
                .HasConstraintName("FK_RelationshipInverseMapping_ContactRelationshipTypes");
        });

        modelBuilder.Entity<ContactRelationshipTypesRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ContactRelationshipTypesRelatedData");

            entity.Property(e => e.ContactRelationshipTypeId).HasColumnName("ContactRelationshipTypeID");
            entity.Property(e => e.ContactType).HasMaxLength(200);
            entity.Property(e => e.InverseName).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(500);
        });

        modelBuilder.Entity<ContactSegment>(entity =>
        {
            entity.Property(e => e.ContactSegmentId).HasColumnName("ContactSegmentID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.NameOl1)
                .HasMaxLength(500)
                .HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2)
                .HasMaxLength(500)
                .HasColumnName("Name_OL2");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.ContactSegments)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContactSegments_Organisations");
        });

        modelBuilder.Entity<ContactStatus>(entity =>
        {
            entity.ToTable("ContactStatus");

            entity.Property(e => e.ContactStatusId)
                .ValueGeneratedNever()
                .HasColumnName("ContactStatusID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<ContactType>(entity =>
        {
            entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceObjId).HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ContactUnTaggedHistory>(entity =>
        {
            entity.ToTable("ContactUnTaggedHistory");

            entity.HasIndex(e => e.UserId, "Idx_ContactUntaggedHistory_UserID");

            entity.Property(e => e.ContactUnTaggedHistoryId).HasColumnName("ContactUnTaggedHistoryID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.DeviceObjectId).HasColumnName("DeviceObjectID");
            entity.Property(e => e.UnTaggedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.ContactUnTaggedHistories)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_ContactUnTaggedHistory_Users");
        });

        modelBuilder.Entity<ContactUniquenessMessage>(entity =>
        {
            entity.Property(e => e.ContactUniquenessMessageId).HasColumnName("ContactUniquenessMessageID");
        });

        modelBuilder.Entity<ContactUserMapping>(entity =>
        {
            entity.HasKey(e => e.ContactUserMappingId).HasName("PK_UserContactMapping");

            entity.ToTable("ContactUserMapping");

            entity.HasIndex(e => e.AccessCategoryId, "IX_ContactUserMapping_AccessCategoryID");

            entity.HasIndex(e => e.ContactId, "IX_ContactUserMapping_ContactID");

            entity.HasIndex(e => new { e.UserId, e.IsDeleted }, "IX_ContactUserMapping_ContactID_IsDeleted");

            entity.HasIndex(e => new { e.EndDate, e.IsDeleted }, "IX_ContactUserMapping_EndDate_IsDeleted");

            entity.HasIndex(e => e.IsDeleted, "IX_ContactUserMapping_IsDeleted");

            entity.HasIndex(e => e.StartDate, "IX_ContactUserMapping_StartDate");

            entity.HasIndex(e => e.UserId, "IX_ContactUserMapping_UserID");

            entity.Property(e => e.ContactUserMappingId).HasColumnName("ContactUserMappingID");
            entity.Property(e => e.AccessCategoryId).HasColumnName("AccessCategoryID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId).HasColumnName("DeviceObjID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.AccessCategory).WithMany(p => p.ContactUserMappings)
                .HasForeignKey(d => d.AccessCategoryId)
                .HasConstraintName("FK_UserContactMapping_AccessCategory");

            entity.HasOne(d => d.Contact).WithMany(p => p.ContactUserMappings)
                .HasForeignKey(d => d.ContactId)
                .HasConstraintName("FK_UserContactMapping_Contacts");

            entity.HasOne(d => d.User).WithMany(p => p.ContactUserMappings)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserContactMapping_Users");
        });

        modelBuilder.Entity<ContactsInitialBm>(entity =>
        {
            entity.HasKey(e => e.InitialContactId).HasName("PK_Contacts_Initial");

            entity.ToTable("Contacts_Initial_BM");

            entity.Property(e => e.InitialContactId).HasColumnName("InitialContactID");
            entity.Property(e => e.Age)
                .HasMaxLength(200)
                .HasColumnName("AGE");
            entity.Property(e => e.BranchCode)
                .HasMaxLength(200)
                .HasColumnName("BRANCH_CODE");
            entity.Property(e => e.BranchName)
                .HasMaxLength(200)
                .HasColumnName("BRANCH_NAME");
            entity.Property(e => e.Cd)
                .HasMaxLength(200)
                .HasColumnName("CD");
            entity.Property(e => e.CreditCard)
                .HasMaxLength(200)
                .HasColumnName("CREDIT_CARD");
            entity.Property(e => e.Current)
                .HasMaxLength(200)
                .HasColumnName("CURRENT");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(200)
                .HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(200)
                .HasColumnName("CUSTOMER_NAME");
            entity.Property(e => e.DebitCard)
                .HasMaxLength(200)
                .HasColumnName("DEBIT_CARD");
            entity.Property(e => e.Gender)
                .HasMaxLength(200)
                .HasColumnName("GENDER");
            entity.Property(e => e.IdNumber)
                .HasMaxLength(200)
                .HasColumnName("ID_NUMBER");
            entity.Property(e => e.InternetBanking)
                .HasMaxLength(200)
                .HasColumnName("INTERNET_BANKING");
            entity.Property(e => e.IsMoved).HasDefaultValue(false);
            entity.Property(e => e.LastExecutionDateTime).HasColumnType("datetime");
            entity.Property(e => e.Minor)
                .HasMaxLength(200)
                .HasColumnName("MINOR");
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(200)
                .HasColumnName("MOBILE_NUMBER");
            entity.Property(e => e.Owner)
                .HasMaxLength(200)
                .HasColumnName("OWNER");
            entity.Property(e => e.Payroll)
                .HasMaxLength(200)
                .HasColumnName("PAYROLL");
            entity.Property(e => e.Saving)
                .HasMaxLength(200)
                .HasColumnName("SAVING");
            entity.Property(e => e.SecuredLoan)
                .HasMaxLength(200)
                .HasColumnName("SECURED_LOAN");
            entity.Property(e => e.Segment)
                .HasMaxLength(200)
                .HasColumnName("SEGMENT");
            entity.Property(e => e.Td)
                .HasMaxLength(200)
                .HasColumnName("TD");
            entity.Property(e => e.UnsecuredLoan)
                .HasMaxLength(200)
                .HasColumnName("UNSECURED_LOAN");
        });

        modelBuilder.Entity<Correspondence>(entity =>
        {
            entity.HasKey(e => e.CorresspondenceId).HasName("PK_Correspondence");

            entity.HasIndex(e => new { e.Address, e.CityName, e.CountryName, e.StateName, e.Zip }, "IX_Correspondences_Details");

            entity.HasIndex(e => e.EntityId, "IX_Correspondences_EntityID");

            entity.HasIndex(e => e.IsDefault, "IX_Correspondences_IsDefault");

            entity.HasIndex(e => e.IsDeleted, "IX_Correspondences_IsDeleted");

            entity.HasIndex(e => e.IsMandatory, "IX_Correspondences_IsMandatory");

            entity.HasIndex(e => e.IsPrimary, "IX_Correspondences_IsPrimary");

            entity.HasIndex(e => e.ModuleId, "IX_Correspondences_ModuleID");

            entity.Property(e => e.CorresspondenceId).HasColumnName("CorresspondenceID");
            entity.Property(e => e.Address).HasMaxLength(4000);
            entity.Property(e => e.CityName).HasMaxLength(2000);
            entity.Property(e => e.CorrespondenceTypeId).HasColumnName("CorrespondenceTypeID");
            entity.Property(e => e.CountryName).HasMaxLength(2000);
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.EntityId).HasColumnName("EntityID");
            entity.Property(e => e.GoogleLat).HasMaxLength(50);
            entity.Property(e => e.GoogleLong).HasMaxLength(50);
            entity.Property(e => e.ImportHistoryId).HasColumnName("ImportHistoryID");
            entity.Property(e => e.IsMandatory).HasDefaultValue(false);
            entity.Property(e => e.IsPrimary).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.Region).HasMaxLength(200);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.StateName).HasMaxLength(2000);
            entity.Property(e => e.SyncStatus).HasDefaultValue(false);
            entity.Property(e => e.Zip).HasMaxLength(50);

            entity.HasOne(d => d.CorrespondenceType).WithMany(p => p.Correspondences)
                .HasForeignKey(d => d.CorrespondenceTypeId)
                .HasConstraintName("FK_Correspondences_CorrospondanceTypes");

            entity.HasOne(d => d.Module).WithMany(p => p.Correspondences)
                .HasForeignKey(d => d.ModuleId)
                .HasConstraintName("FK_Correspondences_Modules");
        });

        modelBuilder.Entity<CorrospondanceType>(entity =>
        {
            entity.HasKey(e => e.CorrospondanceTypeId).HasName("PK_CorrospondanceType");

            entity.Property(e => e.CorrospondanceTypeId).HasColumnName("CorrospondanceTypeID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.NameOl1)
                .HasMaxLength(500)
                .HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2)
                .HasMaxLength(500)
                .HasColumnName("Name_OL2");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.CorrospondanceTypes)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CorrospondanceTypes_Organisations");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CountryName).HasMaxLength(4000);
            entity.Property(e => e.Cssclass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSSClass");
            entity.Property(e => e.DialCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sequence).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.TimeZoneId).HasColumnName("TimeZoneID");

            entity.HasOne(d => d.TimeZone).WithMany(p => p.Countries)
                .HasForeignKey(d => d.TimeZoneId)
                .HasConstraintName("FK_Countries_TimeZones");
        });

        modelBuilder.Entity<CountryTimeZoneMapping>(entity =>
        {
            entity.ToTable("CountryTimeZoneMapping");

            entity.Property(e => e.CountryTimeZoneMappingId).HasColumnName("CountryTimeZoneMappingID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.TimeZoneId).HasColumnName("TimeZoneID");

            entity.HasOne(d => d.Country).WithMany(p => p.CountryTimeZoneMappings)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_CountryTimeZoneMapping_CountryTimeZoneMapping");

            entity.HasOne(d => d.TimeZone).WithMany(p => p.CountryTimeZoneMappings)
                .HasForeignKey(d => d.TimeZoneId)
                .HasConstraintName("FK_CountryTimeZoneMapping_TimeZones");
        });

        modelBuilder.Entity<CrmaccessToken>(entity =>
        {
            entity.HasKey(e => e.CrmaccessTokenId).HasName("PK_CRMTokens");

            entity.ToTable("CRMAccessTokens");

            entity.Property(e => e.CrmaccessTokenId).HasColumnName("CRMAccessTokenID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IssuedAt).HasColumnType("datetime");
            entity.Property(e => e.Status).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<CrmaccessTokensV2>(entity =>
        {
            entity.HasKey(e => e.CrmaccessTokenId);

            entity.ToTable("CRMAccessTokens_V2");

            entity.Property(e => e.CrmaccessTokenId).HasColumnName("CRMAccessTokenID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IssuedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<CrmapiCallLog>(entity =>
        {
            entity.HasKey(e => e.CrmrequestLogId).HasName("PK_CRMTokenRequest");

            entity.ToTable("CRMApiCallLog");

            entity.Property(e => e.CrmrequestLogId).HasColumnName("CRMRequestLogID");
            entity.Property(e => e.ErrorCode).HasMaxLength(50);
            entity.Property(e => e.HttpErrorCode).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<CrmapicallLogsV2>(entity =>
        {
            entity.HasKey(e => e.CrmrequestLogId).HasName("PK_CRMAPICallLog_V2");

            entity.ToTable("CRMAPICallLogs_V2");

            entity.Property(e => e.CrmrequestLogId).HasColumnName("CRMRequestLogID");
            entity.Property(e => e.ChannelId).HasColumnName("ChannelID");
            entity.Property(e => e.ClientIpaddress).HasColumnName("ClientIPAddress");
            entity.Property(e => e.FinancialId).HasColumnName("FinancialID");
            entity.Property(e => e.HttpErrorCode).HasMaxLength(50);
            entity.Property(e => e.RequestTimeStamp).HasColumnType("datetime");
            entity.Property(e => e.ResponseTimeStamp).HasColumnType("datetime");
            entity.Property(e => e.Url).HasColumnName("URL");
        });

        modelBuilder.Entity<CrmmethodSyncTimeStamp>(entity =>
        {
            entity.ToTable("CRMMethodSyncTimeStamp");

            entity.Property(e => e.LastSyncDateTime).HasColumnType("datetime");
            entity.Property(e => e.MethodName).HasMaxLength(200);
        });

        modelBuilder.Entity<CrmprospectCustomerMapping>(entity =>
        {
            entity.ToTable("CRMProspectCustomerMapping");

            entity.Property(e => e.CrmprospectCustomerMappingId).HasColumnName("CRMProspectCustomerMappingID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.CustomerCrmcode).HasColumnName("CustomerCRMCode");
            entity.Property(e => e.ProspectCrmcode).HasColumnName("ProspectCRMCode");
        });

        modelBuilder.Entity<CrmsalesArmactivityStageMapping>(entity =>
        {
            entity.HasKey(e => e.ActivityStageMappingId);

            entity.ToTable("CRMSalesARMActivityStageMapping");

            entity.Property(e => e.CrmactivityStage).HasColumnName("CRMActivityStage");
            entity.Property(e => e.IsDefault).HasDefaultValue(false);
            entity.Property(e => e.SalesArmactivityStageId).HasColumnName("SalesARMActivityStageId");

            entity.HasOne(d => d.SalesArmactivityStage).WithMany(p => p.CrmsalesArmactivityStageMappings)
                .HasForeignKey(d => d.SalesArmactivityStageId)
                .HasConstraintName("FK_CRMSalesARMActivityStageMapping_ActivityStages");
        });

        modelBuilder.Entity<CrmsalesArmactivityTypeMapping>(entity =>
        {
            entity.HasKey(e => e.ActivityTypeMappingId);

            entity.ToTable("CRMSalesARMActivityTypeMapping");

            entity.Property(e => e.CrmactivityType).HasColumnName("CRMActivityType");
            entity.Property(e => e.IsDefault).HasDefaultValue(false);
            entity.Property(e => e.SalesArmactivityTypeId).HasColumnName("SalesARMActivityTypeId");

            entity.HasOne(d => d.SalesArmactivityType).WithMany(p => p.CrmsalesArmactivityTypeMappings)
                .HasForeignKey(d => d.SalesArmactivityTypeId)
                .HasConstraintName("FK_CRMSalesARMActivityTypeMapping_ActivityTypes");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.CountryTerritory)
                .HasMaxLength(500)
                .HasColumnName("Country_Territory");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.CurrencyCode).HasMaxLength(50);
            entity.Property(e => e.CurrencyName).HasMaxLength(500);
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(500)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.Currencies)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_Currencies_Organisations");
        });

        modelBuilder.Entity<CustomerType>(entity =>
        {
            entity.Property(e => e.CustomerTypeId).HasColumnName("CustomerTypeID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(200)
                .HasColumnName("CRMCode");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.NameOl1)
                .HasMaxLength(200)
                .HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2)
                .HasMaxLength(200)
                .HasColumnName("Name_OL2");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.CustomerTypes)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_CustomerTypes_Organisations");
        });

        modelBuilder.Entity<DailyHuddle>(entity =>
        {
            entity.HasKey(e => e.HuddleId).HasName("PK_DailyHuddle");

            entity.HasIndex(e => e.CreatedBy, "IX_DailyHuddles_CreatedBy");

            entity.HasIndex(e => e.CreatedOn, "IX_DailyHuddles_CreatedOn");

            entity.HasIndex(e => e.HuddleDate, "IX_DailyHuddles_HuddleDate");

            entity.HasIndex(e => e.IsDeleted, "IX_DailyHuddles_IsDeleted");

            entity.Property(e => e.HuddleId).HasColumnName("HuddleID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.HuddleNote).HasColumnType("ntext");
            entity.Property(e => e.HuddleTypeId).HasColumnName("HuddleTypeID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.DailyHuddleCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_DailyHuddles_Users");

            entity.HasOne(d => d.HuddleType).WithMany(p => p.DailyHuddles)
                .HasForeignKey(d => d.HuddleTypeId)
                .HasConstraintName("FK_DailyHuddles_DailyHuddleTypes");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.DailyHuddleModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_DailyHuddles_Users1");
        });

        modelBuilder.Entity<DailyHuddleDefaultTeamMemberMapping>(entity =>
        {
            entity.HasKey(e => e.HuddleDefaultTeamMemberMappingId);

            entity.ToTable("DailyHuddleDefaultTeamMemberMapping");

            entity.Property(e => e.HuddleDefaultTeamMemberMappingId).HasColumnName("HuddleDefaultTeamMemberMappingID");
            entity.Property(e => e.HuddleLeadId).HasColumnName("HuddleLeadID");
            entity.Property(e => e.IsPresent).HasDefaultValue(true);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.HuddleLead).WithMany(p => p.DailyHuddleDefaultTeamMemberMappingHuddleLeads)
                .HasForeignKey(d => d.HuddleLeadId)
                .HasConstraintName("FK_DailyHuddleDefaultTeamMemberMapping_Users1");

            entity.HasOne(d => d.User).WithMany(p => p.DailyHuddleDefaultTeamMemberMappingUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_DailyHuddleDefaultTeamMemberMapping_Users");
        });

        modelBuilder.Entity<DailyHuddleRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DailyHuddleRelatedData");

            entity.Property(e => e.HuddleId).HasColumnName("HuddleID");
            entity.Property(e => e.HuddleName).HasMaxLength(359);
            entity.Property(e => e.HuddleNote).HasColumnType("ntext");
            entity.Property(e => e.HuddleType).HasMaxLength(100);
        });

        modelBuilder.Entity<DailyHuddleType>(entity =>
        {
            entity.HasKey(e => e.HuddleTypeId);

            entity.Property(e => e.HuddleTypeId).HasColumnName("HuddleTypeID");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<DailyHuddleUserMapping>(entity =>
        {
            entity.ToTable("DailyHuddleUserMapping");

            entity.Property(e => e.DailyHuddleUserMappingId).HasColumnName("DailyHuddleUserMappingID");
            entity.Property(e => e.HuddleId).HasColumnName("HuddleID");
            entity.Property(e => e.IsMember).HasDefaultValue(true);
            entity.Property(e => e.IsPresent).HasDefaultValue(true);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Huddle).WithMany(p => p.DailyHuddleUserMappings)
                .HasForeignKey(d => d.HuddleId)
                .HasConstraintName("FK_DailyHuddleUserMapping_DailyHuddles");

            entity.HasOne(d => d.User).WithMany(p => p.DailyHuddleUserMappings)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_DailyHuddleUserMapping_Users");
        });

        modelBuilder.Entity<DashboardCirclesConfiguration>(entity =>
        {
            entity.HasKey(e => e.CircleConfigurationId).HasName("PK_CirclesConfiguration");

            entity.ToTable("DashboardCirclesConfiguration");

            entity.Property(e => e.CircleConfigurationId).HasColumnName("CircleConfigurationID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.FrequencyId).HasColumnName("FrequencyID");
            entity.Property(e => e.ProductFamilyId).HasColumnName("ProductFamilyID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.TypeId).HasColumnName("TypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Dept).WithMany(p => p.DashboardCirclesConfigurations)
                .HasForeignKey(d => d.DeptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CirclesConfiguration_Organisations");

            entity.HasOne(d => d.User).WithMany(p => p.DashboardCirclesConfigurations)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CirclesConfiguration_Users");
        });

        modelBuilder.Entity<DashboardSelectionTypeCircleTypeMapping>(entity =>
        {
            entity.ToTable("DashboardSelectionTypeCircleTypeMapping");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CircleTypeId).HasColumnName("CircleTypeID");
            entity.Property(e => e.DashboardCircleSelectionTypeId).HasColumnName("DashboardCircleSelectionTypeID");
            entity.Property(e => e.IsVisible).HasDefaultValue(true);

            entity.HasOne(d => d.DashboardCircleSelectionType).WithMany(p => p.DashboardSelectionTypeCircleTypeMappings)
                .HasForeignKey(d => d.DashboardCircleSelectionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DashboardSelectionTypeCircleTypeMapping_HomeDashboardCircleSelectionType");
        });

        modelBuilder.Entity<DbscriptVersion>(entity =>
        {
            entity.HasKey(e => e.DbscriptVersionId).HasName("PK_DBScriptVersionID");

            entity.ToTable("DBScriptVersion");

            entity.Property(e => e.DbscriptVersionId).HasColumnName("DBScriptVersionID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ExecutedOn).HasColumnType("datetime");
            entity.Property(e => e.VersionDesc).HasMaxLength(2000);
            entity.Property(e => e.VersionNo).HasMaxLength(2000);
        });

        modelBuilder.Entity<Deal>(entity =>
        {
            entity.HasIndex(e => e.ActualDealCloseDate, "IX_Deals_ActualDealCloseDate");

            entity.HasIndex(e => e.CampaignReferenceId, "IX_Deals_CampaignReferenceID");

            entity.HasIndex(e => e.ContactId, "IX_Deals_ContactID");

            entity.HasIndex(e => e.CreatorId, "IX_Deals_CreatorID");

            entity.HasIndex(e => e.DealStageId, "IX_Deals_DealStageID");

            entity.HasIndex(e => e.DealStatusId, "IX_Deals_DealStatusID");

            entity.HasIndex(e => e.DeviceObjId, "IX_Deals_DeviceObjID");

            entity.HasIndex(e => e.EmployerId, "IX_Deals_EmployerID");

            entity.HasIndex(e => e.ExpectedDealCloseDate, "IX_Deals_ExpectedDealCloseDate");

            entity.HasIndex(e => e.ImportHistoryId, "IX_Deals_ImportHistoryID");

            entity.HasIndex(e => e.IncludeDealForGamification, "IX_Deals_IncludeDealForGamification").HasFilter("([IncludeDealForGamification]=(1))");

            entity.HasIndex(e => e.IsClosed, "IX_Deals_IsClosed");

            entity.HasIndex(e => e.IsConfidential, "IX_Deals_IsConfidential");

            entity.HasIndex(e => e.IsDeleteRequestRaised, "IX_Deals_IsDeleteRequestRaised");

            entity.HasIndex(e => e.IsDeleted, "IX_Deals_IsDeleted");

            entity.HasIndex(e => e.IsDeleted, "IX_Deals_IsDeleted_Web");

            entity.HasIndex(e => e.IsDue, "IX_Deals_IsDue");

            entity.HasIndex(e => e.IsInOpportunityStage, "IX_Deals_IsInOpportunityStage");

            entity.HasIndex(e => e.IsLost, "IX_Deals_IsLost");

            entity.HasIndex(e => e.IsNotContacted, "IX_Deals_IsNotContacted");

            entity.HasIndex(e => e.IsNotProgressed, "IX_Deals_IsNotProgressed");

            entity.HasIndex(e => e.IsNotYetDue, "IX_Deals_IsNotYetDue");

            entity.HasIndex(e => e.IsOverdue, "IX_Deals_IsOverdue");

            entity.HasIndex(e => e.IsPipeline, "IX_Deals_IsPipeline");

            entity.HasIndex(e => e.IsStagnant, "IX_Deals_IsStagnant");

            entity.HasIndex(e => new { e.IsDeleted, e.IsDeleteRequestRaised }, "IX_Deals_MultiCol");

            entity.HasIndex(e => e.OwnerId, "IX_Deals_OwnerID");

            entity.HasIndex(e => new { e.OwnerOrgId, e.IsDeleted }, "IX_Deals_OwnerOrgID_DealListing");

            entity.HasIndex(e => e.ProductExpiryDate, "IX_Deals_ProductExpirtDate").HasFilter("([ProductExpiryDate] IS NOT NULL)");

            entity.HasIndex(e => e.RepresentativeId, "IX_Deals_RepresentativeID");

            entity.HasIndex(e => e.ServerDateTime, "IX_Deals_ServerDateTime");

            entity.HasIndex(e => e.SyncedInCrm, "IX_Deals_SyncedInCRM");

            entity.HasIndex(e => e.CreatedOn, "Idx_Deals_CreatedOn");

            entity.HasIndex(e => e.ModifiedOn, "Idx_Deals_ModifiedOn");

            entity.Property(e => e.DealId).HasColumnName("DealID");
            entity.Property(e => e.ActualDealRevenue).HasColumnType("money");
            entity.Property(e => e.ActualDealRevenueConverted).HasColumnType("money");
            entity.Property(e => e.ActualDealRevenueCurrencyConvRate).HasColumnType("money");
            entity.Property(e => e.ActualDealRevenueCurrencyId).HasColumnName("ActualDealRevenueCurrencyID");
            entity.Property(e => e.ActualDealSize).HasColumnType("money");
            entity.Property(e => e.ActualDealSizeConverted).HasColumnType("money");
            entity.Property(e => e.ActualDealSizeCurrencyConvRate).HasColumnType("money");
            entity.Property(e => e.ActualDealSizeCurrencyId).HasColumnName("ActualDealSizeCurrencyID");
            entity.Property(e => e.CampaignReferenceId).HasColumnName("CampaignReferenceID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.CreatedAt).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreatorId).HasColumnName("CreatorID");
            entity.Property(e => e.CreatorOrgId).HasColumnName("CreatorOrgID");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(200)
                .HasColumnName("CRMCode");
            entity.Property(e => e.CrmsyncErrorCode)
                .HasMaxLength(50)
                .HasColumnName("CRMSyncErrorCode");
            entity.Property(e => e.CrmsyncErrorMessage).HasColumnName("CRMSyncErrorMessage");
            entity.Property(e => e.DealCompetitorId).HasColumnName("DealCompetitorID");
            entity.Property(e => e.DealImportHistoryId).HasColumnName("DealImportHistoryID");
            entity.Property(e => e.DealOrderNo).HasMaxLength(10);
            entity.Property(e => e.DealSourceId).HasColumnName("DealSourceID");
            entity.Property(e => e.DealStageId).HasColumnName("DealStageID");
            entity.Property(e => e.DealStatusId).HasColumnName("DealStatusID");
            entity.Property(e => e.DealSubject).HasMaxLength(500);
            entity.Property(e => e.DeviceId).HasColumnName("DeviceID");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.EmployerId).HasColumnName("EmployerID");
            entity.Property(e => e.ExpectedDealRevenue).HasColumnType("money");
            entity.Property(e => e.ExpectedDealRevenueConverted).HasColumnType("money");
            entity.Property(e => e.ExpectedDealRevenueCurrencyConvRate).HasColumnType("money");
            entity.Property(e => e.ExpectedDealRevenueCurrencyId).HasColumnName("ExpectedDealRevenueCurrencyID");
            entity.Property(e => e.ExpectedDealSize).HasColumnType("money");
            entity.Property(e => e.ExpectedDealSizeConverted).HasColumnType("money");
            entity.Property(e => e.ExpectedDealSizeCurrencyConvRate).HasColumnType("money");
            entity.Property(e => e.ExpectedDealSizeCurrencyId).HasColumnName("ExpectedDealSizeCurrencyID");
            entity.Property(e => e.ImportHistoryId).HasColumnName("ImportHistoryID");
            entity.Property(e => e.IncludeDealForGamification).HasDefaultValue(false);
            entity.Property(e => e.IsCampaign).HasDefaultValue(false);
            entity.Property(e => e.IsClosed).HasDefaultValue(false);
            entity.Property(e => e.IsConfidential).HasDefaultValue(false);
            entity.Property(e => e.IsDeleteRequestRaised).HasDefaultValue(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsDue).HasDefaultValue(false);
            entity.Property(e => e.IsInOpportunityStage).HasDefaultValue(false);
            entity.Property(e => e.IsLost).HasDefaultValue(false);
            entity.Property(e => e.IsNotContacted).HasDefaultValue(false);
            entity.Property(e => e.IsNotProgressed).HasDefaultValue(false);
            entity.Property(e => e.IsNotYetDue).HasDefaultValue(false);
            entity.Property(e => e.IsOverdue).HasDefaultValue(false);
            entity.Property(e => e.IsPipeline).HasDefaultValue(false);
            entity.Property(e => e.IsStagnant).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(100);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OtherReferral).HasMaxLength(500);
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            entity.Property(e => e.OwnerOrgId).HasColumnName("OwnerOrgID");
            entity.Property(e => e.Probability).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ReferenceNumber).HasMaxLength(100);
            entity.Property(e => e.RepresentativeId).HasColumnName("RepresentativeID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SyncedInCrm)
                .HasDefaultValue(false)
                .HasColumnName("SyncedInCRM");
            entity.Property(e => e.WorkFlowUserGroupId).HasColumnName("WorkFlowUserGroupID");
            entity.Property(e => e.WorkFlowUserId).HasColumnName("WorkFlowUserID");

            entity.HasOne(d => d.CampaignReference).WithMany(p => p.Deals)
                .HasForeignKey(d => d.CampaignReferenceId)
                .HasConstraintName("FK_Deals_CampaignReferences");

            entity.HasOne(d => d.Contact).WithMany(p => p.Deals)
                .HasForeignKey(d => d.ContactId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Deals_Contacts");

            entity.HasOne(d => d.DealCompetitor).WithMany(p => p.Deals)
                .HasForeignKey(d => d.DealCompetitorId)
                .HasConstraintName("FK_Deals_DealCompetitors");

            entity.HasOne(d => d.DealImportHistory).WithMany(p => p.Deals)
                .HasForeignKey(d => d.DealImportHistoryId)
                .HasConstraintName("FK_Deals_DealImportHistoryID");

            entity.HasOne(d => d.DealSource).WithMany(p => p.Deals)
                .HasForeignKey(d => d.DealSourceId)
                .HasConstraintName("FK_Deals_ContactDealSources");

            entity.HasOne(d => d.DealStage).WithMany(p => p.Deals)
                .HasForeignKey(d => d.DealStageId)
                .HasConstraintName("FK_Deals_DealStages");

            entity.HasOne(d => d.DealStatus).WithMany(p => p.Deals)
                .HasForeignKey(d => d.DealStatusId)
                .HasConstraintName("FK_Deals_DealStatus");

            entity.HasOne(d => d.Owner).WithMany(p => p.Deals)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK_Deals_Users");

            entity.HasOne(d => d.OwnerOrg).WithMany(p => p.Deals)
                .HasForeignKey(d => d.OwnerOrgId)
                .HasConstraintName("FK_Deals_Organisations");

            entity.HasOne(d => d.Product).WithMany(p => p.Deals)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Deals_Products");

            entity.HasOne(d => d.ReferredByNavigation).WithMany(p => p.Deals)
                .HasForeignKey(d => d.ReferredBy)
                .HasConstraintName("FK_Deals_BankEmployee");
        });

        modelBuilder.Entity<DealAssignmentEmailNotificationLog>(entity =>
        {
            entity.ToTable("DealAssignmentEmailNotificationLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ContactImportHistoryId).HasColumnName("ContactImportHistoryID");
            entity.Property(e => e.DealId).HasColumnName("DealID");
            entity.Property(e => e.DealImportHistoryId).HasColumnName("DealImportHistoryID");
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

            entity.HasOne(d => d.ContactImportHistory).WithMany(p => p.DealAssignmentEmailNotificationLogs)
                .HasForeignKey(d => d.ContactImportHistoryId)
                .HasConstraintName("FK_DealAssignmentEmailNotificationLog_ContactImportHistory");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.DealAssignmentEmailNotificationLogCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealAssignmentEmailNotificationLog_Users1");

            entity.HasOne(d => d.Deal).WithMany(p => p.DealAssignmentEmailNotificationLogs)
                .HasForeignKey(d => d.DealId)
                .HasConstraintName("FK_DealAssignmentEmailNotificationLog_Deals");

            entity.HasOne(d => d.DealImportHistory).WithMany(p => p.DealAssignmentEmailNotificationLogs)
                .HasForeignKey(d => d.DealImportHistoryId)
                .HasConstraintName("FK_DealAssignmentEmailNotificationLog_DealImportHistory");

            entity.HasOne(d => d.Owner).WithMany(p => p.DealAssignmentEmailNotificationLogOwners)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealAssignmentEmailNotificationLog_Users");
        });

        modelBuilder.Entity<DealAttendee>(entity =>
        {
            entity.HasIndex(e => e.AttendeeId, "IX_DealAttendees_AttendeeID");

            entity.HasIndex(e => e.DealId, "IX_DealAttendees_DealID");

            entity.HasIndex(e => e.IsContact, "IX_DealAttendees_IsContact");

            entity.HasIndex(e => e.IsDeleted, "IX_DealAttendees_IsDeleted");

            entity.Property(e => e.DealAttendeeId).HasColumnName("DealAttendeeID");
            entity.Property(e => e.AttendeeId).HasColumnName("AttendeeID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DealId).HasColumnName("DealID");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IsContact).HasDefaultValue(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Deal).WithMany(p => p.DealAttendees)
                .HasForeignKey(d => d.DealId)
                .HasConstraintName("FK_DealAttendees_Deals");
        });

        modelBuilder.Entity<DealChecklistMapping>(entity =>
        {
            entity.ToTable("DealChecklistMapping");

            entity.HasIndex(e => e.DealId, "IX_DealChecklistMapping_DealID");

            entity.Property(e => e.DealChecklistMappingId).HasColumnName("DealChecklistMappingID");
            entity.Property(e => e.CreatedAt).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerTypeId).HasColumnName("CustomerTypeID");
            entity.Property(e => e.DealId).HasColumnName("DealID");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(100);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ProductFamilyId).HasColumnName("ProductFamilyID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductSchemeId).HasColumnName("ProductSchemeID");
            entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");

            entity.HasOne(d => d.Deal).WithMany(p => p.DealChecklistMappings)
                .HasForeignKey(d => d.DealId)
                .HasConstraintName("FK_DealChecklistMapping_DealChecklistMapping");
        });

        modelBuilder.Entity<DealCompetitor>(entity =>
        {
            entity.Property(e => e.DealCompetitorId).HasColumnName("DealCompetitorID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IsDefault).HasDefaultValue(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.NameOl1)
                .HasMaxLength(200)
                .HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2)
                .HasMaxLength(200)
                .HasColumnName("Name_OL2");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.DealCompetitors)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_DealCompetitors_Organisations");
        });

        modelBuilder.Entity<DealDocumentMapping>(entity =>
        {
            entity.HasKey(e => e.DealDocumentMappingId).HasName("PK_DealDocumentMapping_1");

            entity.ToTable("DealDocumentMapping");

            entity.Property(e => e.DealDocumentMappingId).HasColumnName("DealDocumentMappingID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DealId).HasColumnName("DealID");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Deal).WithMany(p => p.DealDocumentMappings)
                .HasForeignKey(d => d.DealId)
                .HasConstraintName("FK_DealDocumentMapping_Deals");

            entity.HasOne(d => d.Document).WithMany(p => p.DealDocumentMappings)
                .HasForeignKey(d => d.DocumentId)
                .HasConstraintName("FK_DealDocumentMapping_ChecklistDocuments1");
        });

        modelBuilder.Entity<DealDynamicField>(entity =>
        {
            entity.HasIndex(e => e.DealId, "IX_DealDynamicFields_DealID");

            entity.Property(e => e.DealDynamicFieldId).HasColumnName("DealDynamicFieldID");
            entity.Property(e => e.DealId).HasColumnName("DealID");

            entity.HasOne(d => d.Deal).WithMany(p => p.DealDynamicFields)
                .HasForeignKey(d => d.DealId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealDynamicFields_Deals");
        });

        modelBuilder.Entity<DealFieldSetting>(entity =>
        {
            entity.Property(e => e.DealFieldSettingId).HasColumnName("DealFieldSettingID");
            entity.Property(e => e.CanEditedOnDevice).HasDefaultValue(true);
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DealFieldCategoryId)
                .HasDefaultValue(1)
                .HasColumnName("DealFieldCategoryID");
            entity.Property(e => e.Expression).HasMaxLength(100);
            entity.Property(e => e.FieldDataType).HasMaxLength(50);
            entity.Property(e => e.FieldLabel).HasMaxLength(100);
            entity.Property(e => e.FieldName).HasMaxLength(100);
            entity.Property(e => e.IsBasicInfo).HasDefaultValue(false);
            entity.Property(e => e.IsMandatoryForAddEdit).HasDefaultValue(false);
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.DealFieldSettings)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealFieldSettings_DealFieldSettings");
        });

        modelBuilder.Entity<DealFieldSettingMaster>(entity =>
        {
            entity.ToTable("DealFieldSettingMaster");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FieldDataType).HasMaxLength(100);
            entity.Property(e => e.FieldLabel).HasMaxLength(200);
            entity.Property(e => e.FieldName).HasMaxLength(200);
            entity.Property(e => e.IsBasicInfo).HasDefaultValue(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsMandatory).HasDefaultValue(false);
            entity.Property(e => e.IsMandatoryForAddEdit).HasDefaultValue(false);
            entity.Property(e => e.IsStaticField).HasDefaultValue(true);
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<DealImportAudit>(entity =>
        {
            entity.HasKey(e => e.DealImportAuditId).HasName("PK__DealImpo__AD7CADAAEB5C6598");

            entity.ToTable("DealImportAudit");

            entity.Property(e => e.DealImportAuditId).HasColumnName("DealImportAuditID");
            entity.Property(e => e.ColumnName).HasMaxLength(100);
            entity.Property(e => e.DealId).HasColumnName("DealID");
            entity.Property(e => e.NewImportHistoryId).HasColumnName("NewImportHistoryID");
            entity.Property(e => e.OldImportHistoryId).HasColumnName("OldImportHistoryID");

            entity.HasOne(d => d.Deal).WithMany(p => p.DealImportAudits)
                .HasForeignKey(d => d.DealId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DealImpor__DealI__7579271A");

            entity.HasOne(d => d.NewImportHistory).WithMany(p => p.DealImportAuditNewImportHistories)
                .HasForeignKey(d => d.NewImportHistoryId)
                .HasConstraintName("FK__DealImpor__NewIm__129EAA56");

            entity.HasOne(d => d.OldImportHistory).WithMany(p => p.DealImportAuditOldImportHistories)
                .HasForeignKey(d => d.OldImportHistoryId)
                .HasConstraintName("FK__DealImpor__OldIm__1392CE8F");
        });

        modelBuilder.Entity<DealImportHistory>(entity =>
        {
            entity.HasKey(e => e.DealImportHistoryId).HasName("PK__DealImpo__49B3EC0E7A24857C");

            entity.ToTable("DealImportHistory");

            entity.Property(e => e.DealImportHistoryId).HasColumnName("DealImportHistoryID");
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.ImportTimeStamp).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsReverted).HasDefaultValue(false);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.UploadedAt).HasMaxLength(200);
            entity.Property(e => e.UploadedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.DealImportHistories)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK__DealImpor__Organ__1486F2C8");
        });

        modelBuilder.Entity<DealImportMapping>(entity =>
        {
            entity.HasKey(e => e.DealImportMappingId).HasName("PK__DealImpo__A19D74F4235D7E86");

            entity.ToTable("DealImportMapping");

            entity.Property(e => e.DealImportMappingId).HasColumnName("DealImportMappingID");
            entity.Property(e => e.DealFieldSettingId).HasColumnName("DealFieldSettingID");
            entity.Property(e => e.ImportFieldNameFromFile).HasMaxLength(100);
            entity.Property(e => e.ImportHistoryId).HasColumnName("ImportHistoryID");

            entity.HasOne(d => d.ImportHistory).WithMany(p => p.DealImportMappings)
                .HasForeignKey(d => d.ImportHistoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DealImportMapping__ImportHistoryID");
        });

        modelBuilder.Entity<DealOfflineSyncLog>(entity =>
        {
            entity.ToTable("DealOfflineSyncLog");

            entity.Property(e => e.DealOfflineSyncLogId).HasColumnName("DealOfflineSyncLogID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DealId).HasColumnName("DealID");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.StatusCode).HasMaxLength(200);

            entity.HasOne(d => d.Deal).WithMany(p => p.DealOfflineSyncLogs)
                .HasForeignKey(d => d.DealId)
                .HasConstraintName("FK_DealOfflineSyncLog_Deals");
        });

        modelBuilder.Entity<DealOwnerHistory>(entity =>
        {
            entity.ToTable("DealOwnerHistory");

            entity.Property(e => e.DealOwnerHistoryId).HasColumnName("DealOwnerHistoryID");
            entity.Property(e => e.AssignedOn).HasColumnType("datetime");
            entity.Property(e => e.DealId).HasColumnName("DealID");
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

            entity.HasOne(d => d.Deal).WithMany(p => p.DealOwnerHistories)
                .HasForeignKey(d => d.DealId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealOwnerHistory_Deals");

            entity.HasOne(d => d.Owner).WithMany(p => p.DealOwnerHistories)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealOwnerHistory_Users");
        });

        modelBuilder.Entity<DealPageAuditTrail>(entity =>
        {
            entity.HasKey(e => e.AuditId).HasName("PK__DealPage__A17F23B81EC70D73");

            entity.ToTable("DealPageAuditTrail");

            entity.Property(e => e.AuditId).HasColumnName("AuditID");
            entity.Property(e => e.ActionType).HasMaxLength(250);
            entity.Property(e => e.ActionedOn).HasMaxLength(250);
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.DealPageName).HasMaxLength(250);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
        });

        modelBuilder.Entity<DealPageField>(entity =>
        {
            entity.HasKey(e => e.DealPageFieldId).HasName("PK__DealPage__81E81B73BC388C1F");

            entity.Property(e => e.DealPageFieldId).HasColumnName("DealPageFieldID");
            entity.Property(e => e.ColumnTextField).HasMaxLength(500);
            entity.Property(e => e.FieldName).HasMaxLength(250);
            entity.Property(e => e.MappingTableName).HasMaxLength(250);
            entity.Property(e => e.RelatedField).HasMaxLength(250);
        });

        modelBuilder.Entity<DealPageFieldList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DealPageFieldList");

            entity.Property(e => e.FieldName).HasMaxLength(250);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PageCode).HasMaxLength(250);
        });

        modelBuilder.Entity<DealStage>(entity =>
        {
            entity.HasIndex(e => e.DealStageModelId, "IX_DealStages_DealStageModelID");

            entity.Property(e => e.DealStageId).HasColumnName("DealStageID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DealStageCode).HasMaxLength(50);
            entity.Property(e => e.DealStageModelId).HasColumnName("DealStageModelID");
            entity.Property(e => e.DefaultAvailableWithGroupId).HasColumnName("DefaultAvailableWithGroupID");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsApprovalRequired).HasDefaultValue(false);
            entity.Property(e => e.IsDefaultUploadStage).HasDefaultValue(false);
            entity.Property(e => e.IsVisibleForRm)
                .HasDefaultValue(true)
                .HasColumnName("IsVisibleForRM");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.NameOl1)
                .HasMaxLength(200)
                .HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2)
                .HasMaxLength(200)
                .HasColumnName("Name_OL2");
            entity.Property(e => e.OrderingNo).HasMaxLength(10);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ParentDealStageId).HasColumnName("ParentDealStageID");
            entity.Property(e => e.Probability).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SalesMethodId).HasColumnName("SalesMethodID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.StagnantPeriodInDays).HasDefaultValue(0);
            entity.Property(e => e.SystemControlledStage).HasDefaultValue(false);

            entity.HasOne(d => d.DealStageModel).WithMany(p => p.DealStages)
                .HasForeignKey(d => d.DealStageModelId)
                .HasConstraintName("FK_DealStages_DealStageModel");

            entity.HasOne(d => d.Organisation).WithMany(p => p.DealStages)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_DealStages_Organisations");
        });

        modelBuilder.Entity<DealStageAccessRightsGroupMapping>(entity =>
        {
            entity.HasKey(e => e.AccessRightGroupMappingId);

            entity.ToTable("DealStageAccessRightsGroupMapping");

            entity.Property(e => e.AccessRightGroupMappingId).HasColumnName("AccessRightGroupMappingID");
            entity.Property(e => e.DealStageId).HasColumnName("DealStageID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.WorkflowGroupId).HasColumnName("WorkflowGroupID");

            entity.HasOne(d => d.DealStage).WithMany(p => p.DealStageAccessRightsGroupMappings)
                .HasForeignKey(d => d.DealStageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealStageAccessRightsGroupMapping_DealStages");

            entity.HasOne(d => d.WorkflowGroup).WithMany(p => p.DealStageAccessRightsGroupMappings)
                .HasForeignKey(d => d.WorkflowGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealStageAccessRightsGroupMapping_UserGroups");
        });

        modelBuilder.Entity<DealStageAvailableWithGroupMapping>(entity =>
        {
            entity.HasKey(e => e.AvailableWithGroupMappingId);

            entity.ToTable("DealStageAvailableWithGroupMapping");

            entity.Property(e => e.AvailableWithGroupMappingId).HasColumnName("AvailableWithGroupMappingID");
            entity.Property(e => e.DealStageId).HasColumnName("DealStageID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.WorkflowGroupId).HasColumnName("WorkflowGroupID");

            entity.HasOne(d => d.DealStage).WithMany(p => p.DealStageAvailableWithGroupMappings)
                .HasForeignKey(d => d.DealStageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealStageAvailableWithGroupMapping_DealStages");

            entity.HasOne(d => d.WorkflowGroup).WithMany(p => p.DealStageAvailableWithGroupMappings)
                .HasForeignKey(d => d.WorkflowGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealStageAvailableWithGroupMapping_UserGroups");
        });

        modelBuilder.Entity<DealStageDateCapture>(entity =>
        {
            entity.ToTable("DealStageDateCapture");

            entity.HasIndex(e => e.DealId, "IX_DealStageDateCapture_DealID");

            entity.HasIndex(e => e.DealStageId, "IX_DealStageDateCapture_DealStageID");

            entity.Property(e => e.DealStageDateCaptureId).HasColumnName("DealStageDateCaptureID");
            entity.Property(e => e.CreatedAt).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DealId).HasColumnName("DealID");
            entity.Property(e => e.DealOrderNo).HasMaxLength(20);
            entity.Property(e => e.DealStageExitDate).HasColumnType("datetime");
            entity.Property(e => e.DealStageId).HasColumnName("DealStageID");
            entity.Property(e => e.DealStageUpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(100);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Deal).WithMany(p => p.DealStageDateCaptures)
                .HasForeignKey(d => d.DealId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealStageDateCapture_Deals");

            entity.HasOne(d => d.DealStage).WithMany(p => p.DealStageDateCaptures)
                .HasForeignKey(d => d.DealStageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealStageDateCapture_DealStageDateCapture");
        });

        modelBuilder.Entity<DealStageModel>(entity =>
        {
            entity.HasKey(e => e.DealStageModelId).HasName("PK_DealCategories");

            entity.ToTable("DealStageModel");

            entity.Property(e => e.DealStageModelId).HasColumnName("DealStageModelID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.IsDefault).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<DealStagesRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DealStagesRelatedData");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DealStageCode).HasMaxLength(50);
            entity.Property(e => e.DealStageId).HasColumnName("DealStageID");
            entity.Property(e => e.DefaultAvailableWithGroupId).HasColumnName("DefaultAvailableWithGroupID");
            entity.Property(e => e.IsVisibleForRm).HasColumnName("IsVisibleForRM");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
        });

        modelBuilder.Entity<DealStatus>(entity =>
        {
            entity.ToTable("DealStatus");

            entity.Property(e => e.DealStatusId)
                .ValueGeneratedNever()
                .HasColumnName("DealStatusID");
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<DealUnTaggedHistory>(entity =>
        {
            entity.ToTable("DealUnTaggedHistory");

            entity.HasIndex(e => e.UserId, "Idx_DealUntaggedHistory_UserID");

            entity.Property(e => e.DealUnTaggedHistoryId).HasColumnName("DealUnTaggedHistoryID");
            entity.Property(e => e.DealId).HasColumnName("DealID");
            entity.Property(e => e.DeviceObjectId).HasColumnName("DeviceObjectID");
            entity.Property(e => e.UnTaggedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.DealUnTaggedHistories)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_DealUnTaggedHistory_Users");
        });

        modelBuilder.Entity<DealUniquenessMessage>(entity =>
        {
            entity.Property(e => e.DealUniquenessMessageId).HasColumnName("DealUniquenessMessageID");
        });

        modelBuilder.Entity<DealWorkFlowMemberForwardHistory>(entity =>
        {
            entity.HasKey(e => e.HistoryId).HasName("PK_DealWorkflowUserForwardHistory");

            entity.ToTable("DealWorkFlowMemberForwardHistory");

            entity.Property(e => e.HistoryId).HasColumnName("HistoryID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DealId).HasColumnName("DealID");
            entity.Property(e => e.DealOrderNo).HasMaxLength(50);
            entity.Property(e => e.DealStageId).HasColumnName("DealStageID");
            entity.Property(e => e.UserGroupId).HasColumnName("UserGroupID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Deal).WithMany(p => p.DealWorkFlowMemberForwardHistories)
                .HasForeignKey(d => d.DealId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealWorkflowUserForwardHistory_Deals");

            entity.HasOne(d => d.DealStage).WithMany(p => p.DealWorkFlowMemberForwardHistories)
                .HasForeignKey(d => d.DealStageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealWorkflowUserForwardHistory_DealStages");

            entity.HasOne(d => d.UserGroup).WithMany(p => p.DealWorkFlowMemberForwardHistories)
                .HasForeignKey(d => d.UserGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealWorkFlowMemberForwardHistory_UserGroups");

            entity.HasOne(d => d.User).WithMany(p => p.DealWorkFlowMemberForwardHistories)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealWorkflowUserForwardHistory_Users");
        });

        modelBuilder.Entity<DealWorkFlowParticipantHistory>(entity =>
        {
            entity.HasKey(e => e.ParticipantHistoryId);

            entity.ToTable("DealWorkFlowParticipantHistory");

            entity.HasIndex(e => e.DealId, "IX_DealWorkFlowParticipantHistory_DealID");

            entity.HasIndex(e => e.DealStageId, "IX_DealWorkFlowParticipantHistory_DealStageID");

            entity.HasIndex(e => e.UserGroupId, "IX_DealWorkFlowParticipantHistory_UserGroupID");

            entity.HasIndex(e => e.WorkFlowUserId, "IX_DealWorkFlowParticipantHistory_WorkFlowUserID");

            entity.Property(e => e.ParticipantHistoryId).HasColumnName("ParticipantHistoryID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DealId).HasColumnName("DealID");
            entity.Property(e => e.DealOrderNo).HasMaxLength(20);
            entity.Property(e => e.DealStageId).HasColumnName("DealStageID");
            entity.Property(e => e.IsCurrentParticipant).HasDefaultValue(true);
            entity.Property(e => e.IsDealWorkflowMember).HasDefaultValue(true);
            entity.Property(e => e.UserGroupId).HasColumnName("UserGroupID");
            entity.Property(e => e.WorkFlowUserId).HasColumnName("WorkFlowUserID");

            entity.HasOne(d => d.Deal).WithMany(p => p.DealWorkFlowParticipantHistories)
                .HasForeignKey(d => d.DealId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealWorkFlowParticipantHistory_Deals");

            entity.HasOne(d => d.DealStage).WithMany(p => p.DealWorkFlowParticipantHistories)
                .HasForeignKey(d => d.DealStageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealWorkFlowParticipantHistory_DealStages");

            entity.HasOne(d => d.WorkFlowUser).WithMany(p => p.DealWorkFlowParticipantHistories)
                .HasForeignKey(d => d.WorkFlowUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealWorkFlowParticipantHistory_Users");
        });

        modelBuilder.Entity<DealWorkFlowUserGroupHistory>(entity =>
        {
            entity.HasKey(e => e.GroupHistoryId);

            entity.ToTable("DealWorkFlowUserGroupHistory");

            entity.HasIndex(e => e.DealId, "IX_DealWorkFlowUserGroupHistory_DealID");

            entity.HasIndex(e => e.DealStageId, "IX_DealWorkFlowUserGroupHistory_DealStageID");

            entity.HasIndex(e => e.WorkFlowUserGroupId, "IX_DealWorkFlowUserGroupHistory_WorkFlowUserGroupID");

            entity.Property(e => e.GroupHistoryId).HasColumnName("GroupHistoryID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DealId).HasColumnName("DealID");
            entity.Property(e => e.DealOrderNo).HasMaxLength(20);
            entity.Property(e => e.DealStageId).HasColumnName("DealStageID");
            entity.Property(e => e.WorkFlowUserGroupId).HasColumnName("WorkFlowUserGroupID");

            entity.HasOne(d => d.Deal).WithMany(p => p.DealWorkFlowUserGroupHistories)
                .HasForeignKey(d => d.DealId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealWorkFlowUserGroupHistory_Deals");

            entity.HasOne(d => d.DealStage).WithMany(p => p.DealWorkFlowUserGroupHistories)
                .HasForeignKey(d => d.DealStageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealWorkFlowUserGroupHistory_DealStages");

            entity.HasOne(d => d.WorkFlowUserGroup).WithMany(p => p.DealWorkFlowUserGroupHistories)
                .HasForeignKey(d => d.WorkFlowUserGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealWorkFlowUserGroupHistory_Users");
        });

        modelBuilder.Entity<DefaultFacebookLeadOwnerAudit>(entity =>
        {
            entity.HasKey(e => e.AuditId).HasName("PK__DefaultF__A17F23B81B832557");

            entity.ToTable("DefaultFacebookLeadOwnerAudit");

            entity.Property(e => e.AuditId).HasColumnName("AuditID");
            entity.Property(e => e.NewUserId).HasColumnName("NewUserID");
            entity.Property(e => e.OldUserId).HasColumnName("OldUserID");
        });

        modelBuilder.Entity<DefaultWebsiteContactAudit>(entity =>
        {
            entity.HasKey(e => e.AuditId).HasName("PK__DefaultW__A17F23B8A4060F21");

            entity.ToTable("DefaultWebsiteContactAudit");

            entity.Property(e => e.AuditId).HasColumnName("AuditID");
            entity.Property(e => e.NewUserId).HasColumnName("NewUserID");
            entity.Property(e => e.OldUserId).HasColumnName("OldUserID");
        });

        modelBuilder.Entity<DefaultWebsiteExistingLeadOwnerAudit>(entity =>
        {
            entity.HasKey(e => e.AuditId);

            entity.ToTable("DefaultWebsiteExistingLeadOwnerAudit");

            entity.Property(e => e.AuditId).HasColumnName("AuditID");
            entity.Property(e => e.NewUserId).HasColumnName("NewUserID");
            entity.Property(e => e.OldUserId).HasColumnName("OldUserID");
        });

        modelBuilder.Entity<DeletedUser>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.Remark).HasMaxLength(50);
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<Designation>(entity =>
        {
            entity.HasKey(e => e.DesignationId).HasName("PK_Designation");

            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NameOl1).HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2).HasColumnName("Name_OL2");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ReportingToRoleId).HasColumnName("ReportingToRoleID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.Designations)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Designations_Organisations");
        });

        modelBuilder.Entity<DesignationRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DesignationRelatedData");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
        });

        modelBuilder.Entity<DocumentGroupRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DocumentGroupRelatedData");

            entity.Property(e => e.ChecklistGroupId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ChecklistGroupID");
            entity.Property(e => e.GroupName).HasMaxLength(500);
        });

        modelBuilder.Entity<EmailFrequency>(entity =>
        {
            entity.ToTable("EmailFrequency");

            entity.Property(e => e.EmailFrequencyId).HasColumnName("EmailFrequencyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EmailFrequencyName).HasMaxLength(500);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmailTemplate>(entity =>
        {
            entity.HasKey(e => e.EmailTemplateId).HasName("PK_EmailTemplate");

            entity.Property(e => e.EmailTemplateId).HasColumnName("EmailTemplateID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(500)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.EmailTemplateKey).HasMaxLength(100);
            entity.Property(e => e.FooterTemplateName)
                .HasMaxLength(500)
                .HasDefaultValue("EMAIL_FOOTER");
            entity.Property(e => e.HeaderTemplateName)
                .HasMaxLength(500)
                .HasDefaultValue("EMAIL_HEADER");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SyncStatus).HasDefaultValue(0);
        });

        modelBuilder.Entity<EmployeeLeaveRequest>(entity =>
        {
            entity.ToTable("EmployeeLeaveRequest");

            entity.Property(e => e.EmployeeLeaveRequestId).HasColumnName("EmployeeLeaveRequestID");
            entity.Property(e => e.ActivityAccessToUserIds).HasColumnName("ActivityAccessToUserIDs");
            entity.Property(e => e.ActivityStatusIds).HasColumnName("ActivityStatusIDs");
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.CanAutoAllocationHappen).HasDefaultValue(false);
            entity.Property(e => e.ContactAccessToUserIds).HasColumnName("ContactAccessToUserIDs");
            entity.Property(e => e.DealAccessToUserIds).HasColumnName("DealAccessToUserIDs");
            entity.Property(e => e.DealStatusIds).HasColumnName("DealStatusIDs");
            entity.Property(e => e.DefaultFacebookLeadOwnerId).HasColumnName("DefaultFacebookLeadOwnerID");
            entity.Property(e => e.DefaultWebsiteContactId).HasColumnName("DefaultWebsiteContactID");
            entity.Property(e => e.DefaultWebsiteExistingLeadOwnerId).HasColumnName("DefaultWebsiteExistingLeadOwnerID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.ExistingPortfoliosAccessToUserIds).HasColumnName("ExistingPortfoliosAccessToUserIDs");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RejectedDate).HasColumnType("datetime");
            entity.Property(e => e.RequestDate).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmployeeLeaveRequestRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EmployeeLeaveRequestRelatedData");

            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.DefaultFacebookLeadOwnerId).HasColumnName("DefaultFacebookLeadOwnerID");
            entity.Property(e => e.DefaultWebsiteContactId).HasColumnName("DefaultWebsiteContactID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EmployeeLeaveRequestId).HasColumnName("EmployeeLeaveRequestID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.ExistingPortfoliosAccessToUserIds).HasColumnName("ExistingPortfoliosAccessToUserIDs");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RejectedDate).HasColumnType("datetime");
            entity.Property(e => e.RequestDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmploymentType>(entity =>
        {
            entity.Property(e => e.EmploymentTypeId).HasColumnName("EmploymentTypeID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsDefault).HasDefaultValue(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.EmploymentTypeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_EmploymentTypes_CreatedBy_Users");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.EmploymentTypeModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_EmploymentTypes_ModifiedBy_Users");

            entity.HasOne(d => d.Organisation).WithMany(p => p.EmploymentTypes)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_EmploymentTypes_Organisations");
        });

        modelBuilder.Entity<ErrorLog>(entity =>
        {
            entity.HasKey(e => e.ErrorLogId).HasName("PK__ErrorLog__D65247E2B07A7B3D");

            entity.ToTable("ErrorLog");

            entity.Property(e => e.ErrorLogId).HasColumnName("ErrorLogID");
            entity.Property(e => e.LogDateTime).HasColumnType("datetime");
            entity.Property(e => e.Spname)
                .HasMaxLength(300)
                .HasColumnName("SPName");
        });

        modelBuilder.Entity<ExternalApiaccessToken>(entity =>
        {
            entity.HasKey(e => e.TokenId);

            entity.ToTable("ExternalAPIAccessToken");

            entity.Property(e => e.TokenId).HasColumnName("TokenID");
            entity.Property(e => e.IssuedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<ExternalApiclientSecretKeyStore>(entity =>
        {
            entity.HasKey(e => e.ClientIdsecretKeyStoreId).HasName("PK_ClientSecretKeyStore");

            entity.ToTable("ExternalAPIClientSecretKeyStore");

            entity.Property(e => e.ClientIdsecretKeyStoreId).HasColumnName("ClientIDSecretKeyStoreID");
            entity.Property(e => e.ClientId).HasColumnName("ClientID");
        });

        modelBuilder.Entity<ExternalApirequestLogging>(entity =>
        {
            entity.HasKey(e => e.ExternalApilogId);

            entity.ToTable("ExternalAPIRequestLogging");

            entity.Property(e => e.ExternalApilogId).HasColumnName("ExternalAPILogID");
            entity.Property(e => e.Apiname).HasColumnName("APIName");
            entity.Property(e => e.LogDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ExternalProductMapping>(entity =>
        {
            entity.ToTable("ExternalProductMapping");

            entity.Property(e => e.ExternalProductMappingId).HasColumnName("ExternalProductMappingID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Product).WithMany(p => p.ExternalProductMappings)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ExternalProductMapping_Products");
        });

        modelBuilder.Entity<FbaccessToken>(entity =>
        {
            entity.ToTable("FBAccessToken");

            entity.Property(e => e.FbaccessTokenId).HasColumnName("FBAccessTokenID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IssuedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<FbapiCallLog>(entity =>
        {
            entity.HasKey(e => e.FbrequestLogId);

            entity.ToTable("FBApiCallLog");

            entity.Property(e => e.FbrequestLogId).HasColumnName("FBRequestLogID");
            entity.Property(e => e.ErrorCode).HasMaxLength(50);
            entity.Property(e => e.Fbtimestamp).HasColumnName("FBTimestamp");
            entity.Property(e => e.HttpErrorCode).HasMaxLength(50);
            entity.Property(e => e.ResponseBody).HasColumnType("ntext");
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<FbdigiteamFieldMapping>(entity =>
        {
            entity.HasKey(e => e.MappingId);

            entity.ToTable("FBDigiteamFieldMapping");

            entity.Property(e => e.MappingId).HasColumnName("MappingID");
            entity.Property(e => e.FbfieldName).HasColumnName("FBFieldName");
        });

        modelBuilder.Entity<FbleadFormProductMapping>(entity =>
        {
            entity.HasKey(e => e.LeadId);

            entity.ToTable("FBLeadFormProductMapping");

            entity.Property(e => e.LeadId).HasColumnName("LeadID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FbleadFormId)
                .HasMaxLength(500)
                .HasColumnName("FBLeadFormID");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Organisation).WithMany(p => p.FbleadFormProductMappings)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FBLeadFormProductMapping_Organisations");

            entity.HasOne(d => d.Product).WithMany(p => p.FbleadFormProductMappings)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FBLeadFormProductMapping_Products");
        });

        modelBuilder.Entity<FbleadRetrievalLog>(entity =>
        {
            entity.HasKey(e => e.LeadRetrievalRequestId);

            entity.ToTable("FBLeadRetrievalLog");

            entity.Property(e => e.LeadRetrievalRequestId).HasColumnName("LeadRetrievalRequestID");
            entity.Property(e => e.RequestDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<FieldCategory>(entity =>
        {
            entity.HasKey(e => e.FieldCategoryId).HasName("PK_ContactFieldCategories");

            entity.Property(e => e.FieldCategoryId).HasColumnName("FieldCategoryID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<FieldList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FieldList");

            entity.Property(e => e.FieldName).HasMaxLength(250);
            entity.Property(e => e.FieldValue).HasColumnName("fieldValue");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PageCode).HasMaxLength(250);
        });

        modelBuilder.Entity<FullActivityRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FullActivityRelatedData");

            entity.Property(e => e.ActivityClassificationId).HasColumnName("ActivityClassificationID");
            entity.Property(e => e.ActivityClassificationName).HasMaxLength(256);
            entity.Property(e => e.ActivityDateTime).HasMaxLength(221);
            entity.Property(e => e.ActivityDuration).HasMaxLength(10);
            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.ActivityReminder).HasMaxLength(10);
            entity.Property(e => e.ActivityStatusId).HasColumnName("ActivityStatusID");
            entity.Property(e => e.ActivitySubject).HasMaxLength(500);
            entity.Property(e => e.ActivityType).HasMaxLength(50);
            entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.ContactName).HasMaxLength(500);
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<FullContactRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FullContactRelatedData");

            entity.Property(e => e.CompanyName).HasMaxLength(300);
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.ContactSegmentId).HasColumnName("ContactSegmentID");
            entity.Property(e => e.ContactType).HasMaxLength(200);
            entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(100)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.FirstName).HasMaxLength(300);
            entity.Property(e => e.LastName).HasMaxLength(200);
            entity.Property(e => e.MiddleName).HasMaxLength(300);
            entity.Property(e => e.MonthlySalary).HasColumnType("money");
            entity.Property(e => e.NationalId)
                .HasMaxLength(100)
                .HasColumnName("NationalID");
            entity.Property(e => e.OrganisationTierMappingId).HasColumnName("OrganisationTierMappingID");
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            entity.Property(e => e.PrimaryPhoneNumber).HasMaxLength(100);
            entity.Property(e => e.ReferralType)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ReferredBy).HasMaxLength(500);
            entity.Property(e => e.Segment).HasMaxLength(500);
            entity.Property(e => e.Tier).HasMaxLength(500);
            entity.Property(e => e.TradeLicenseNumber).HasMaxLength(100);
        });

        modelBuilder.Entity<FullDealRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FullDealRelatedData");

            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.ContactName).HasMaxLength(501);
            entity.Property(e => e.DealId).HasColumnName("DealID");
            entity.Property(e => e.DealSourceId).HasColumnName("DealSourceID");
            entity.Property(e => e.DealSourceName).HasMaxLength(256);
            entity.Property(e => e.DealStage).HasMaxLength(200);
            entity.Property(e => e.DealStageId).HasColumnName("DealStageID");
            entity.Property(e => e.DealSubject).HasMaxLength(500);
            entity.Property(e => e.ExpectedDealSize).HasColumnType("money");
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            entity.Property(e => e.OwnerName).HasMaxLength(256);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductName).HasMaxLength(256);
            entity.Property(e => e.ReferralType)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ReferredBy).HasMaxLength(500);
        });

        modelBuilder.Entity<Game>(entity =>
        {
            entity.HasIndex(e => e.DepartmentId, "Idx_Games_DepartmentID");

            entity.Property(e => e.GameId).HasColumnName("GameID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");

            entity.HasOne(d => d.Department).WithMany(p => p.Games)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_Games_Organisations");

            entity.HasOne(d => d.Status).WithMany(p => p.Games)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK_Games_GameStatus");
        });

        modelBuilder.Entity<GameAward>(entity =>
        {
            entity.HasKey(e => e.AwardId).HasName("PK_Awards");

            entity.Property(e => e.AwardId).HasColumnName("AwardID");
            entity.Property(e => e.AwardCategoryId).HasColumnName("AwardCategoryID");
            entity.Property(e => e.IsForTeam).HasDefaultValue(false);
            entity.Property(e => e.Name).HasMaxLength(200);

            entity.HasOne(d => d.AwardCategory).WithMany(p => p.GameAwards)
                .HasForeignKey(d => d.AwardCategoryId)
                .HasConstraintName("FK_Awards_AwardCategories");
        });

        modelBuilder.Entity<GameAwardCategory>(entity =>
        {
            entity.HasKey(e => e.AwardCategoryId).HasName("PK_AwardCategories");

            entity.Property(e => e.AwardCategoryId).HasColumnName("AwardCategoryID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<GameAwardsRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GameAwardsRelatedData");

            entity.Property(e => e.AwardId).HasColumnName("AwardID");
            entity.Property(e => e.AwardName).HasMaxLength(253);
            entity.Property(e => e.DepartmentAwardMappingId).HasColumnName("DepartmentAwardMappingID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
        });

        modelBuilder.Entity<GameBonusPenality>(entity =>
        {
            entity.HasKey(e => e.GameBonusPenalitiesId);

            entity.HasIndex(e => e.GameId, "Idx_GameBonusPenalities_GameID");

            entity.Property(e => e.GameBonusPenalitiesId).HasColumnName("GameBonusPenalitiesID");
            entity.Property(e => e.CampaignPct).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.GameId).HasColumnName("GameID");
            entity.Property(e => e.IgnoreCustomerPct).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.OnePtEquivalentAmount).HasColumnType("money");
            entity.Property(e => e.OverdueActivityPct).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.OverdueDealPct).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.ProductBonusPct).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.TargetBonusPct).HasColumnType("numeric(5, 2)");

            entity.HasOne(d => d.Game).WithMany(p => p.GameBonusPenalities)
                .HasForeignKey(d => d.GameId)
                .HasConstraintName("FK_GameBonusPenalities_Games");
        });

        modelBuilder.Entity<GameDepartmentAwardMapping>(entity =>
        {
            entity.HasKey(e => e.DepartmentAwardMappingId).HasName("PK_DepartmentAwardMapping");

            entity.ToTable("GameDepartmentAwardMapping");

            entity.HasIndex(e => e.AwardId, "Idx_GameDepartmentAwardMapping_AwardID");

            entity.HasIndex(e => e.DepartmentId, "Idx_GameDepartmentAwardMapping_DepartmentID");

            entity.Property(e => e.DepartmentAwardMappingId).HasColumnName("DepartmentAwardMappingID");
            entity.Property(e => e.AwardId).HasColumnName("AwardID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Award).WithMany(p => p.GameDepartmentAwardMappings)
                .HasForeignKey(d => d.AwardId)
                .HasConstraintName("FK_DepartmentAwardMapping_Awards");

            entity.HasOne(d => d.Department).WithMany(p => p.GameDepartmentAwardMappings)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_DepartmentAwardMapping_Organisations");
        });

        modelBuilder.Entity<GameLevelSetup>(entity =>
        {
            entity.ToTable("GameLevelSetup");

            entity.HasIndex(e => e.DepartmentId, "Idx_GameLevelSetup_DepartmentID");

            entity.HasIndex(e => e.EndPoints, "Idx_GameLevelSetup_EndPoints");

            entity.HasIndex(e => e.StartPoints, "Idx_GameLevelSetup_StartPoints");

            entity.Property(e => e.GameLevelSetupId).HasColumnName("GameLevelSetupID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EndPoints).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.LevelName).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.StartPoints).HasColumnType("numeric(18, 2)");

            entity.HasOne(d => d.Department).WithMany(p => p.GameLevelSetups)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_GameLevelSetup_Organisations");
        });

        modelBuilder.Entity<GameNote>(entity =>
        {
            entity.HasIndex(e => e.GameId, "Idx_GameNotes_GameID");

            entity.HasIndex(e => e.UserId, "Idx_GameNotes_UserID");

            entity.Property(e => e.GameNoteId).HasColumnName("GameNoteID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.GameId).HasColumnName("GameID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Game).WithMany(p => p.GameNotes)
                .HasForeignKey(d => d.GameId)
                .HasConstraintName("FK_GameNotes_Games");

            entity.HasOne(d => d.User).WithMany(p => p.GameNotes)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_GameNotes_Users");
        });

        modelBuilder.Entity<GameParameter>(entity =>
        {
            entity.HasIndex(e => e.GameId, "Idx_GameParameters_GameID");

            entity.Property(e => e.GameParameterId).HasColumnName("GameParameterID");
            entity.Property(e => e.ActivityDoneCap).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.AddedContactCap).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.AddedDealCap).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.ClosedDealCap).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.GameId).HasColumnName("GameID");
            entity.Property(e => e.MaximumPerAddedDealPts).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.MaximumPerClosedDealPts).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PtsPerAddedContact).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PtsPerAddedDealCnt).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PtsPerAddedDealRevenue).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PtsPerAddedDealSize).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PtsPerClosedDealCnt).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PtsPerClosedDealRevenue).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PtsPerClosedDealSize).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PtsPerDoneCall).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PtsPerDoneMeeting).HasColumnType("numeric(5, 1)");

            entity.HasOne(d => d.Game).WithMany(p => p.GameParameters)
                .HasForeignKey(d => d.GameId)
                .HasConstraintName("FK_GameParameters_Games");
        });

        modelBuilder.Entity<GamePlayerHistory>(entity =>
        {
            entity.HasKey(e => e.GamePlayerTransactionHistoryId);

            entity.HasIndex(e => e.EndDate, "Idx_GamePlayerHistories_EndDate");

            entity.HasIndex(e => e.StartDate, "Idx_GamePlayerHistories_StartDate");

            entity.HasIndex(e => e.UserId, "Idx_GamePlayerHistories_UserID");

            entity.Property(e => e.GamePlayerTransactionHistoryId).HasColumnName("GamePlayerTransactionHistoryID");
            entity.Property(e => e.AddedDealRevenue).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.AddedDealSize).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CampClosedDealRevenue).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CampClosedDealSize).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ClosedDealRevenue).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ClosedDealSize).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.NonCampClosedDealRevenue).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.NonCampClosedDealSize).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.OverdueActivityCnt).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.GamePlayerHistories)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_GamePlayerTransactionHistories_Users");
        });

        modelBuilder.Entity<GamePlayerStatistic>(entity =>
        {
            entity.HasKey(e => e.GamePlayerCurrentTransactionId);

            entity.HasIndex(e => e.GameId, "Idx_GamePlayerStatistics_GameID");

            entity.HasIndex(e => e.TransactionDate, "Idx_GamePlayerStatistics_TransactionDate");

            entity.HasIndex(e => e.UserId, "Idx_GamePlayerStatistics_UserID");

            entity.Property(e => e.GamePlayerCurrentTransactionId).HasColumnName("GamePlayerCurrentTransactionID");
            entity.Property(e => e.ActivityDoneCap).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.AddedContactCap).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.AddedDealCap).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.AddedDealRevenue).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.AddedDealSize).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CampClosedDealRevenue).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CampClosedDealSize).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CampaignPct).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.ClosedDealCap).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.ClosedDealRevenue).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ClosedDealSize).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.GameId).HasColumnName("GameID");
            entity.Property(e => e.IgnoreCustomerPct).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.IgnoreCustomerPenaltyPct).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.MaximumPerAddedDealPts).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.MaximumPerClosedDealPts).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NoOfRminTeam).HasColumnName("NoOfRMInTeam");
            entity.Property(e => e.NonCampClosedDealRevenue).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.NonCampClosedDealSize).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.OverdueActivityPct).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.OverdueActivityPenaltyPct).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.OverdueDealPct).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.OverdueDealPenaltyPct).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.ProductBonusPct).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.PtsPerAddedContact).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PtsPerAddedDealCnt).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PtsPerAddedDealRevenue).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PtsPerAddedDealSize).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PtsPerClosedDealCnt).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PtsPerClosedDealRevenue).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PtsPerClosedDealSize).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PtsPerDoneCall).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PtsPerDoneMeeting).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.TargetBonusPct).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.TotalActivityPtsAfterCap).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalActivityPtsBeforeCap).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalAddedContactPts).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalAddedContactPtsAfterCap).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalAddedContactPtsBeforeCap).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalAddedDealCntPts).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalAddedDealPtsAfterCap).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalAddedDealPtsBeforeCap).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalAddedDealRevenuePts).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalAddedDealSizePts).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalClosedDealCntPts).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalClosedDealPtsAfterCap).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalClosedDealPtsBeforeCap).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalClosedDealRevenuePts).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalClosedDealSizePts).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalDoneCallPts).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalDoneMeetingPts).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalPtsAfterOverallCap).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalPtsBeforeOverallCap).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Game).WithMany(p => p.GamePlayerStatistics)
                .HasForeignKey(d => d.GameId)
                .HasConstraintName("FK_GamePlayerCurrentTransactions_Games");

            entity.HasOne(d => d.User).WithMany(p => p.GamePlayerStatistics)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_GamePlayerCurrentTransactions_Users");
        });

        modelBuilder.Entity<GamePlayerTeamAward>(entity =>
        {
            entity.HasKey(e => e.GameAwardId).HasName("PK_GamePlayerAward");

            entity.ToTable("GamePlayer&TeamAward");

            entity.HasIndex(e => e.AwardId, "Idx_GamePlayer&TeamAward_AwardID");

            entity.HasIndex(e => e.GameId, "Idx_GamePlayer&TeamAward_GameID");

            entity.HasIndex(e => e.UserId, "Idx_GamePlayer&TeamAward_UserID");

            entity.Property(e => e.GameAwardId).HasColumnName("GameAwardID");
            entity.Property(e => e.AwardId).HasColumnName("AwardID");
            entity.Property(e => e.GameId).HasColumnName("GameID");
            entity.Property(e => e.IsAnIndividualPlayer).HasDefaultValue(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Award).WithMany(p => p.GamePlayerTeamAwards)
                .HasForeignKey(d => d.AwardId)
                .HasConstraintName("FK_GamePlayer&TeamAward_Awards");

            entity.HasOne(d => d.Game).WithMany(p => p.GamePlayerTeamAwards)
                .HasForeignKey(d => d.GameId)
                .HasConstraintName("FK_GamePlayer&TeamAward_Games");

            entity.HasOne(d => d.User).WithMany(p => p.GamePlayerTeamAwards)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_GamePlayer&TeamAward_Users");
        });

        modelBuilder.Entity<GamePlayerTeamRanking>(entity =>
        {
            entity.HasKey(e => e.GameRankingId).HasName("PK_GameCurrentRanking");

            entity.ToTable("GamePlayer&TeamRanking");

            entity.HasIndex(e => e.GameId, "Idx_GamePlayer&TeamRanking_GameID");

            entity.HasIndex(e => e.UserId, "Idx_GamePlayer&TeamRanking_UserID");

            entity.Property(e => e.GameRankingId).HasColumnName("GameRankingID");
            entity.Property(e => e.GameId).HasColumnName("GameID");
            entity.Property(e => e.IsAnIndividualPlayer).HasDefaultValue(true);
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.TotalPoints).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Game).WithMany(p => p.GamePlayerTeamRankings)
                .HasForeignKey(d => d.GameId)
                .HasConstraintName("FK_GamePlayer&TeamRanking_Games");

            entity.HasOne(d => d.User).WithMany(p => p.GamePlayerTeamRankings)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_GamePlayer&TeamRanking_Users");
        });

        modelBuilder.Entity<GamePlayerTeamSetUp>(entity =>
        {
            entity.HasKey(e => e.SetUpId);

            entity.ToTable("GamePlayer&TeamSetUp");

            entity.HasIndex(e => e.GameId, "Idx_GamePlayer&TeamSetUp_GameID");

            entity.HasIndex(e => e.UserId, "Idx_GamePlayer&TeamSetUp_UserID");

            entity.Property(e => e.SetUpId).HasColumnName("SetUpID");
            entity.Property(e => e.GameId).HasColumnName("GameID");
            entity.Property(e => e.IsAnIndividualPlayer).HasDefaultValue(true);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Game).WithMany(p => p.GamePlayerTeamSetUps)
                .HasForeignKey(d => d.GameId)
                .HasConstraintName("FK_GamePlayer&TeamSetUp_Games");

            entity.HasOne(d => d.User).WithMany(p => p.GamePlayerTeamSetUps)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_GamePlayer&TeamSetUp_Users");
        });

        modelBuilder.Entity<GamePlayerTeamYearWiseRanking>(entity =>
        {
            entity.HasKey(e => e.GameRankingId).HasName("PK_GamePlayerTeamMonthWiseRanking");

            entity.ToTable("GamePlayer&TeamYearWiseRanking");

            entity.Property(e => e.GameRankingId).HasColumnName("GameRankingID");
            entity.Property(e => e.TotalPoints).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.GamePlayerTeamYearWiseRankings)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_GamePlayerTeamMonthWiseRanking_Users");
        });

        modelBuilder.Entity<GameProductMapping>(entity =>
        {
            entity.ToTable("GameProductMapping");

            entity.HasIndex(e => e.GameId, "Idx_GameProductMapping_GameID");

            entity.Property(e => e.GameProductMappingId).HasColumnName("GameProductMappingID");
            entity.Property(e => e.GameId).HasColumnName("GameID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Game).WithMany(p => p.GameProductMappings)
                .HasForeignKey(d => d.GameId)
                .HasConstraintName("FK_GameProductMapping_Games");

            entity.HasOne(d => d.Product).WithMany(p => p.GameProductMappings)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_GameProductMapping_Products");
        });

        modelBuilder.Entity<GameSetting>(entity =>
        {
            entity.HasIndex(e => e.DepartmentId, "Idx_GameSettings_DepartmentID");

            entity.Property(e => e.GameSettingId).HasColumnName("GameSettingID");
            entity.Property(e => e.Delta).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.StepSize).HasColumnType("numeric(18, 2)");

            entity.HasOne(d => d.Department).WithMany(p => p.GameSettings)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_GameSettings_GameSettings");
        });

        modelBuilder.Entity<GameSetupPageField>(entity =>
        {
            entity.HasKey(e => e.GameSetupPageFieldId).HasName("PK__GameSetu__BDBB35B9C30895E8");

            entity.Property(e => e.GameSetupPageFieldId).HasColumnName("GameSetupPageFieldID");
            entity.Property(e => e.ColumnTextField).HasMaxLength(500);
            entity.Property(e => e.FieldName).HasMaxLength(250);
            entity.Property(e => e.RelatedField).HasMaxLength(250);
        });

        modelBuilder.Entity<GameSetupPageFieldList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GameSetupPageFieldList");

            entity.Property(e => e.FieldName).HasMaxLength(250);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PageCode).HasMaxLength(250);
        });

        modelBuilder.Entity<GameSetupRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GameSetupRelatedData");

            entity.Property(e => e.ActivitiesOverduePenalty).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.ActivitiesPointsCap).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.BonusForDealsAndActivitiesClosedAboveTarget).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.BonusIfDealClosedWasSentInCampaign).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.ContactsAddedPointsCap).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.CustomersIgnoredPenalty).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.DealsAddedPointsCap).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.DealsClosedPointsCap).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.DealsOverduePenalty).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.DealsWithFocusProductsBonus).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.Delta).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.GameId).HasColumnName("GameID");
            entity.Property(e => e.MaximumPointsPerDealAdded).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.MaximumPointsPerDealClosed).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PointsPerCallDone).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PointsPerContactAdded).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PointsPerDealAdded).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PointsPerDealAddedRevenueof1000).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PointsPerDealAddedSizeof1000).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PointsPerDealClosed).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PointsPerDealClosedRevenueof1000).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PointsPerDealClosedSizeof1000).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.PointsPerMeetingDone).HasColumnType("numeric(5, 1)");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.StepSize).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<GameStatus>(entity =>
        {
            entity.ToTable("GameStatus");

            entity.Property(e => e.GameStatusId).HasColumnName("GameStatusID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<HomeDashboardCircleSelectionType>(entity =>
        {
            entity.HasKey(e => e.DashboardCircleSelectionTypeId).HasName("PK_DashboardCircleSelectionType");

            entity.ToTable("HomeDashboardCircleSelectionType");

            entity.Property(e => e.DashboardCircleSelectionTypeId).HasColumnName("DashboardCircleSelectionTypeID");
            entity.Property(e => e.DashboardCategoryId)
                .HasDefaultValue(1)
                .HasColumnName("DashboardCategoryID");
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
        });

        modelBuilder.Entity<HomeDashboardFilterFrequencyMapping>(entity =>
        {
            entity.HasKey(e => e.FilterFrequencyMappingId);

            entity.ToTable("HomeDashboardFilterFrequencyMapping");

            entity.Property(e => e.FilterFrequencyMappingId).HasColumnName("FilterFrequencyMappingID");
            entity.Property(e => e.FilterTypeId).HasColumnName("FilterTypeID");
            entity.Property(e => e.FrequencyId).HasColumnName("FrequencyID");

            entity.HasOne(d => d.FilterType).WithMany(p => p.HomeDashboardFilterFrequencyMappings)
                .HasForeignKey(d => d.FilterTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HomeDashboardFilterFrequencyMapping_HomeDashboardCircleSelectionType");

            entity.HasOne(d => d.Frequency).WithMany(p => p.HomeDashboardFilterFrequencyMappings)
                .HasForeignKey(d => d.FrequencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HomeDashboardFilterFrequencyMapping_HomeDashboardFilterTypeFrequency");
        });

        modelBuilder.Entity<HomeDashboardFilterTypeFrequency>(entity =>
        {
            entity.HasKey(e => e.FrequencyId).HasName("PK_HomeDashboardFilterTypeFrequencyMapping");

            entity.ToTable("HomeDashboardFilterTypeFrequency");

            entity.Property(e => e.FrequencyId).HasColumnName("FrequencyID");
            entity.Property(e => e.IsDefault).HasDefaultValue(false);
        });

        modelBuilder.Entity<HubSpotTranscation>(entity =>
        {
            entity.HasKey(e => e.HubSpotId);

            entity.ToTable("HubSpotTranscation");

            entity.Property(e => e.HubSpotId).HasColumnName("HubSpotID");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SaAddeduser).HasColumnName("sa_addeduser");
            entity.Property(e => e.SaAddeduserOn)
                .HasColumnType("datetime")
                .HasColumnName("sa_addeduser_on");
            entity.Property(e => e.SaDownloaded).HasColumnName("sa_downloaded");
            entity.Property(e => e.SaDownloadedOn)
                .HasColumnType("datetime")
                .HasColumnName("sa_downloaded_on");
            entity.Property(e => e.SaEngage).HasColumnName("sa_engage");
            entity.Property(e => e.SaEngageOn)
                .HasColumnType("datetime")
                .HasColumnName("sa_engage_on");
            entity.Property(e => e.SaInactive14).HasColumnName("sa_inactive_14");
            entity.Property(e => e.SaInactive14On)
                .HasColumnType("datetime")
                .HasColumnName("sa_inactive_14_on");
            entity.Property(e => e.SaInactive21).HasColumnName("sa_inactive_21");
            entity.Property(e => e.SaInactive21On)
                .HasColumnType("datetime")
                .HasColumnName("sa_inactive_21_on");
            entity.Property(e => e.SaInactive7).HasColumnName("sa_inactive_7");
            entity.Property(e => e.SaInactive7On)
                .HasColumnType("datetime")
                .HasColumnName("sa_inactive_7_on");
            entity.Property(e => e.SaOverdue).HasColumnName("sa_overdue");
            entity.Property(e => e.SaOverdueOn)
                .HasColumnType("datetime")
                .HasColumnName("sa_overdue_on");
            entity.Property(e => e.SaSignup).HasColumnName("sa_signup");
            entity.Property(e => e.SaSignupOn)
                .HasColumnType("datetime")
                .HasColumnName("sa_signup_on");
            entity.Property(e => e.SaSubscribeOn)
                .HasColumnType("datetime")
                .HasColumnName("sa_subscribe_on");
            entity.Property(e => e.SaSubscribePay).HasColumnName("sa_subscribe_pay");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<HubspotUserInitiated>(entity =>
        {
            entity.ToTable("HubspotUserInitiated");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsSyncWithHs)
                .HasDefaultValue(false)
                .HasColumnName("IsSyncWithHS");
        });

        modelBuilder.Entity<ImportHistoryActivitiesMapping>(entity =>
        {
            entity.ToTable("ImportHistoryActivitiesMapping");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.ActivityImportHistoryId).HasColumnName("ActivityImportHistoryID");
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

            entity.HasOne(d => d.Activity).WithMany(p => p.ImportHistoryActivitiesMappings)
                .HasForeignKey(d => d.ActivityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImportHistoryActivitiesMapping_Activity");

            entity.HasOne(d => d.ActivityImportHistory).WithMany(p => p.ImportHistoryActivitiesMappings)
                .HasForeignKey(d => d.ActivityImportHistoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImportHistoryActivitiesMapping_ActivityImportHistory");

            entity.HasOne(d => d.Owner).WithMany(p => p.ImportHistoryActivitiesMappings)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImportHistoryActivitiesMapping_Users");
        });

        modelBuilder.Entity<ImportHistoryContactMapping>(entity =>
        {
            entity.ToTable("ImportHistoryContactMapping");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.ContactImportHistoryId).HasColumnName("ContactImportHistoryID");
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

            entity.HasOne(d => d.Contact).WithMany(p => p.ImportHistoryContactMappings)
                .HasForeignKey(d => d.ContactId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImportHistoryContactMapping_Contacts");

            entity.HasOne(d => d.ContactImportHistory).WithMany(p => p.ImportHistoryContactMappings)
                .HasForeignKey(d => d.ContactImportHistoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImportHistoryContactMapping_ContactImportHistory");

            entity.HasOne(d => d.Owner).WithMany(p => p.ImportHistoryContactMappings)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImportHistoryContactMapping_Users");
        });

        modelBuilder.Entity<ImportHistoryDealsMapping>(entity =>
        {
            entity.ToTable("ImportHistoryDealsMapping");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DealId).HasColumnName("DealID");
            entity.Property(e => e.DealImportHistoryId).HasColumnName("DealImportHistoryID");
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

            entity.HasOne(d => d.Deal).WithMany(p => p.ImportHistoryDealsMappings)
                .HasForeignKey(d => d.DealId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImportHistoryDealsMapping_Deals");

            entity.HasOne(d => d.DealImportHistory).WithMany(p => p.ImportHistoryDealsMappings)
                .HasForeignKey(d => d.DealImportHistoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImportHistoryDealsMapping_DealImportHistory");

            entity.HasOne(d => d.Owner).WithMany(p => p.ImportHistoryDealsMappings)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImportHistoryDealsMapping_Users");
        });

        modelBuilder.Entity<IncentiveBancAssuranceRole>(entity =>
        {
            entity.ToTable("IncentiveBancAssuranceRole");

            entity.Property(e => e.IncentiveBancAssuranceRoleId).HasColumnName("IncentiveBancAssuranceRoleID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.PercentageShare).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<IncentiveBranchCategory>(entity =>
        {
            entity.ToTable("IncentiveBranchCategory");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BranchCode).HasMaxLength(300);
            entity.Property(e => e.BranchName).HasMaxLength(300);
            entity.Property(e => e.Category).HasMaxLength(300);
            entity.Property(e => e.CreatedAt).HasMaxLength(300);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IncentiveBranchCategoryImportHistoryId).HasColumnName("IncentiveBranchCategoryImportHistoryID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(300);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<IncentiveBranchCategoryFieldSetting>(entity =>
        {
            entity.Property(e => e.IncentiveBranchCategoryFieldSettingId).HasColumnName("IncentiveBranchCategoryFieldSettingID");
            entity.Property(e => e.CanEditedOnDevice).HasDefaultValue(true);
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.Expression).HasMaxLength(100);
            entity.Property(e => e.FieldDataType).HasMaxLength(50);
            entity.Property(e => e.FieldLabel).HasMaxLength(100);
            entity.Property(e => e.FieldName).HasMaxLength(100);
            entity.Property(e => e.IncentiveBranchCategoryFieldCategoryId)
                .HasDefaultValue(1)
                .HasColumnName("IncentiveBranchCategoryFieldCategoryID");
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.OverwriteAlways).HasDefaultValue(true);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.IncentiveBranchCategoryFieldSettings)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncentiveBranchCategoryFieldSettings_IncentiveBranchCategoryFieldSettings");
        });

        modelBuilder.Entity<IncentiveBranchCategoryFieldSettingMaster>(entity =>
        {
            entity.ToTable("IncentiveBranchCategoryFieldSettingMaster");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FieldDataType).HasMaxLength(100);
            entity.Property(e => e.FieldLabel).HasMaxLength(200);
            entity.Property(e => e.FieldName).HasMaxLength(200);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsMandatory).HasDefaultValue(false);
            entity.Property(e => e.IsStaticField).HasDefaultValue(true);
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<IncentiveBranchCategoryImportAudit>(entity =>
        {
            entity.HasKey(e => e.IncentiveBranchCategoryImportAuditId).HasName("PK__Incentiv__E32900790B9D0D37");

            entity.ToTable("IncentiveBranchCategoryImportAudit");

            entity.Property(e => e.IncentiveBranchCategoryImportAuditId).HasColumnName("IncentiveBranchCategoryImportAuditID");
            entity.Property(e => e.ColumnName).HasMaxLength(100);
            entity.Property(e => e.IncentiveBranchCategoryImportId).HasColumnName("IncentiveBranchCategoryImportID");
            entity.Property(e => e.NewImportHistoryId).HasColumnName("NewImportHistoryID");
            entity.Property(e => e.OldImportHistoryId).HasColumnName("OldImportHistoryID");

            entity.HasOne(d => d.IncentiveBranchCategoryImport).WithMany(p => p.IncentiveBranchCategoryImportAudits)
                .HasForeignKey(d => d.IncentiveBranchCategoryImportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncentiveBranchCategory_IncentiveBranchCategoryImportID");

            entity.HasOne(d => d.NewImportHistory).WithMany(p => p.IncentiveBranchCategoryImportAuditNewImportHistories)
                .HasForeignKey(d => d.NewImportHistoryId)
                .HasConstraintName("FK__Incentive__NewIm__51900108");

            entity.HasOne(d => d.OldImportHistory).WithMany(p => p.IncentiveBranchCategoryImportAuditOldImportHistories)
                .HasForeignKey(d => d.OldImportHistoryId)
                .HasConstraintName("FK__Incentive__OldIm__52842541");
        });

        modelBuilder.Entity<IncentiveBranchCategoryImportHistory>(entity =>
        {
            entity.HasKey(e => e.IncentiveBranchCategoryImportHistoryId).HasName("PK__Incentiv__87A1F7C02D2E1B47");

            entity.ToTable("IncentiveBranchCategoryImportHistory");

            entity.Property(e => e.IncentiveBranchCategoryImportHistoryId).HasColumnName("IncentiveBranchCategoryImportHistoryID");
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.ImportTimeStamp).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsReverted).HasDefaultValue(false);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.UploadedAt).HasMaxLength(200);
            entity.Property(e => e.UploadedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.IncentiveBranchCategoryImportHistories)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK__Incentive__Organ__546C6DB3");
        });

        modelBuilder.Entity<IncentiveBranchCategoryImportMapping>(entity =>
        {
            entity.HasKey(e => e.IncentiveBranchCategoryImportMappingId).HasName("PK__Incentiv__C976EAEDC8B26135");

            entity.ToTable("IncentiveBranchCategoryImportMapping");

            entity.Property(e => e.IncentiveBranchCategoryImportMappingId).HasColumnName("IncentiveBranchCategoryImportMappingID");
            entity.Property(e => e.ImportFieldNameFromFile).HasMaxLength(100);
            entity.Property(e => e.ImportHistoryId).HasColumnName("ImportHistoryID");
            entity.Property(e => e.IncentiveBranchCategoryFieldSettingId).HasColumnName("IncentiveBranchCategoryFieldSettingID");

            entity.HasOne(d => d.ImportHistory).WithMany(p => p.IncentiveBranchCategoryImportMappings)
                .HasForeignKey(d => d.ImportHistoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IncentiveBranchCategoryImportMapping__ImportHistoryID");
        });

        modelBuilder.Entity<IncentiveCategoryRoleTemplateMapping>(entity =>
        {
            entity.ToTable("IncentiveCategoryRoleTemplateMapping");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Category).HasMaxLength(300);
            entity.Property(e => e.CreatedAt).HasMaxLength(300);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IncentiveCategoryRoleTemplateMappingImportHistoryId).HasColumnName("IncentiveCategoryRoleTemplateMappingImportHistoryID");
            entity.Property(e => e.IncentiveTemplateId).HasColumnName("IncentiveTemplateID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(300);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.Role).HasMaxLength(300);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.IncentiveTemplate).WithMany(p => p.IncentiveCategoryRoleTemplateMappings)
                .HasForeignKey(d => d.IncentiveTemplateId)
                .HasConstraintName("FK_IncentiveCategoryRoleTemplateMapping_IncentiveTemplateID");
        });

        modelBuilder.Entity<IncentiveCategoryRoleTemplateMappingFieldSetting>(entity =>
        {
            entity.Property(e => e.IncentiveCategoryRoleTemplateMappingFieldSettingId).HasColumnName("IncentiveCategoryRoleTemplateMappingFieldSettingID");
            entity.Property(e => e.CanEditedOnDevice).HasDefaultValue(true);
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.Expression).HasMaxLength(100);
            entity.Property(e => e.FieldDataType).HasMaxLength(50);
            entity.Property(e => e.FieldLabel).HasMaxLength(100);
            entity.Property(e => e.FieldName).HasMaxLength(100);
            entity.Property(e => e.IncentiveCategoryRoleTemplateMappingFieldCategoryId)
                .HasDefaultValue(1)
                .HasColumnName("IncentiveCategoryRoleTemplateMappingFieldCategoryID");
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.OverwriteAlways).HasDefaultValue(true);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.IncentiveCategoryRoleTemplateMappingFieldSettings)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncentiveCategoryRoleTemplateMappingFieldSettings_IncentiveCategoryRoleTemplateMappingFieldSettings");
        });

        modelBuilder.Entity<IncentiveCategoryRoleTemplateMappingFieldSettingMaster>(entity =>
        {
            entity.ToTable("IncentiveCategoryRoleTemplateMappingFieldSettingMaster");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FieldDataType).HasMaxLength(100);
            entity.Property(e => e.FieldLabel).HasMaxLength(200);
            entity.Property(e => e.FieldName).HasMaxLength(200);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsMandatory).HasDefaultValue(false);
            entity.Property(e => e.IsStaticField).HasDefaultValue(true);
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<IncentiveCategoryRoleTemplateMappingImportAudit>(entity =>
        {
            entity.HasKey(e => e.IncentiveCategoryRoleTemplateMappingImportAuditId).HasName("PK__Incentiv__87CAA42E70288CF4");

            entity.ToTable("IncentiveCategoryRoleTemplateMappingImportAudit");

            entity.Property(e => e.IncentiveCategoryRoleTemplateMappingImportAuditId).HasColumnName("IncentiveCategoryRoleTemplateMappingImportAuditID");
            entity.Property(e => e.ColumnName).HasMaxLength(100);
            entity.Property(e => e.IncentiveCategoryRoleTemplateMappingImportId).HasColumnName("IncentiveCategoryRoleTemplateMappingImportID");
            entity.Property(e => e.NewImportHistoryId).HasColumnName("NewImportHistoryID");
            entity.Property(e => e.OldImportHistoryId).HasColumnName("OldImportHistoryID");

            entity.HasOne(d => d.IncentiveCategoryRoleTemplateMappingImport).WithMany(p => p.IncentiveCategoryRoleTemplateMappingImportAudits)
                .HasForeignKey(d => d.IncentiveCategoryRoleTemplateMappingImportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncentiveCategoryRoleTemplateMapping_IncentiveCategoryRoleTemplateMappingImportID");

            entity.HasOne(d => d.NewImportHistory).WithMany(p => p.IncentiveCategoryRoleTemplateMappingImportAuditNewImportHistories)
                .HasForeignKey(d => d.NewImportHistoryId)
                .HasConstraintName("FK__Incentive__NewIm__583CFE97");

            entity.HasOne(d => d.OldImportHistory).WithMany(p => p.IncentiveCategoryRoleTemplateMappingImportAuditOldImportHistories)
                .HasForeignKey(d => d.OldImportHistoryId)
                .HasConstraintName("FK__Incentive__OldIm__593122D0");
        });

        modelBuilder.Entity<IncentiveCategoryRoleTemplateMappingImportHistory>(entity =>
        {
            entity.HasKey(e => e.IncentiveCategoryRoleTemplateMappingImportHistoryId).HasName("PK__Incentiv__6087484C17722E36");

            entity.ToTable("IncentiveCategoryRoleTemplateMappingImportHistory");

            entity.Property(e => e.IncentiveCategoryRoleTemplateMappingImportHistoryId).HasColumnName("IncentiveCategoryRoleTemplateMappingImportHistoryID");
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.ImportTimeStamp).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsReverted).HasDefaultValue(false);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.UploadedAt).HasMaxLength(200);
            entity.Property(e => e.UploadedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.IncentiveCategoryRoleTemplateMappingImportHistories)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK__Incentive__Organ__5B196B42");
        });

        modelBuilder.Entity<IncentiveCategoryRoleTemplateMappingImportMapping>(entity =>
        {
            entity.HasKey(e => e.IncentiveCategoryRoleTemplateMappingImportMappingId).HasName("PK__Incentiv__792A104116EA5A71");

            entity.ToTable("IncentiveCategoryRoleTemplateMappingImportMapping");

            entity.Property(e => e.IncentiveCategoryRoleTemplateMappingImportMappingId).HasColumnName("IncentiveCategoryRoleTemplateMappingImportMappingID");
            entity.Property(e => e.ImportFieldNameFromFile).HasMaxLength(100);
            entity.Property(e => e.ImportHistoryId).HasColumnName("ImportHistoryID");
            entity.Property(e => e.IncentiveCategoryRoleTemplateMappingFieldSettingId).HasColumnName("IncentiveCategoryRoleTemplateMappingFieldSettingID");

            entity.HasOne(d => d.ImportHistory).WithMany(p => p.IncentiveCategoryRoleTemplateMappingImportMappings)
                .HasForeignKey(d => d.ImportHistoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IncentiveCategoryRoleTemplateMappingImportMapping__ImportHistoryID");
        });

        modelBuilder.Entity<IncentiveCategoryRoleTemplateMappingRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("IncentiveCategoryRoleTemplateMappingRelatedData");

            entity.Property(e => e.Category).HasMaxLength(300);
            entity.Property(e => e.CompensationTemplate).HasMaxLength(500);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IncentiveTemplateId).HasColumnName("IncentiveTemplateID");
            entity.Property(e => e.Role).HasMaxLength(300);
        });

        modelBuilder.Entity<IncentiveCreditCardTier>(entity =>
        {
            entity.HasKey(e => e.CreditCardTierId);

            entity.Property(e => e.CreditCardTierId).HasColumnName("CreditCardTierID");
            entity.Property(e => e.CreatedAt).HasMaxLength(300);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IncentiveCreditCardTierGroupId).HasColumnName("IncentiveCreditCardTierGroupID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(300);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(300);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TierPercentage).HasColumnType("numeric(7, 2)");

            entity.HasOne(d => d.IncentiveCreditCardTierGroup).WithMany(p => p.IncentiveCreditCardTiers)
                .HasForeignKey(d => d.IncentiveCreditCardTierGroupId)
                .HasConstraintName("FK_IncentiveCreditCardTiers_IncentiveCreditCardTierGroup");

            entity.HasOne(d => d.Organisation).WithMany(p => p.IncentiveCreditCardTiers)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_IncentiveCreditCardTiers_Organisations");
        });

        modelBuilder.Entity<IncentiveCreditCardTierGroup>(entity =>
        {
            entity.HasKey(e => e.CreditCardTierGroupId);

            entity.ToTable("IncentiveCreditCardTierGroup");

            entity.Property(e => e.CreditCardTierGroupId).HasColumnName("CreditCardTierGroupID");
            entity.Property(e => e.CreatedAt).HasMaxLength(300);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(300);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(300);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.IncentiveCreditCardTierGroupCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_IncentiveCreditCardTierGroup_CreatedBy_Users");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.IncentiveCreditCardTierGroupModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_IncentiveCreditCardTierGroup_ModifiedBy_Users");

            entity.HasOne(d => d.Organisation).WithMany(p => p.IncentiveCreditCardTierGroups)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_IncentiveCreditCardTierGroup_Organisations");
        });

        modelBuilder.Entity<IncentiveDebitCardConfiguration>(entity =>
        {
            entity.ToTable("IncentiveDebitCardConfiguration");

            entity.Property(e => e.IncentiveDebitCardConfigurationId).HasColumnName("IncentiveDebitCardConfigurationID");
            entity.Property(e => e.CustomerType).HasMaxLength(10);
            entity.Property(e => e.DebitCardTypeId).HasColumnName("DebitCardTypeID");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IncentiveAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.IncentiveTemplateDebitCardProductId).HasColumnName("IncentiveTemplateDebitCardProductID");

            entity.HasOne(d => d.IncentiveTemplateDebitCardProduct).WithMany(p => p.IncentiveDebitCardConfigurations)
                .HasForeignKey(d => d.IncentiveTemplateDebitCardProductId)
                .HasConstraintName("FK_IncentiveDebitCardConfiguration_IncentiveTemplateDebitCardProductID");
        });

        modelBuilder.Entity<IncentiveDebitCardCustomerType>(entity =>
        {
            entity.ToTable("IncentiveDebitCardCustomerType");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code).HasMaxLength(300);
            entity.Property(e => e.CreatedAt).HasMaxLength(300);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedAt).HasMaxLength(300);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(300);
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.IncentiveDebitCardCustomerTypeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_IncentiveDebitCardCustomerType_Users");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.IncentiveDebitCardCustomerTypeModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_IncentiveDebitCardCustomerType_Users1");
        });

        modelBuilder.Entity<IncentiveDebitCardType>(entity =>
        {
            entity.ToTable("IncentiveDebitCardType");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CardName).HasMaxLength(300);
            entity.Property(e => e.CardType).HasMaxLength(300);
            entity.Property(e => e.CreatedAt).HasMaxLength(300);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(300);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.IncentiveDebitCardTypeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_IncentiveDebitCardType_CreatedBy_Users");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.IncentiveDebitCardTypeModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_IncentiveDebitCardType_ModifiedBy_Users");

            entity.HasOne(d => d.Organisation).WithMany(p => p.IncentiveDebitCardTypes)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_IncentiveDebitCardType_Organisations");
        });

        modelBuilder.Entity<IncentiveFinalMonthlyUserStat>(entity =>
        {
            entity.HasIndex(e => e.Month, "IX_IncentiveFinalMonthlyUserStats_Month");

            entity.HasIndex(e => e.UserId, "IX_IncentiveFinalMonthlyUserStats_UserID");

            entity.HasIndex(e => e.Year, "IX_IncentiveFinalMonthlyUserStats_Year");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Area).HasMaxLength(400);
            entity.Property(e => e.BranchCode).HasMaxLength(400);
            entity.Property(e => e.BranchName).HasMaxLength(400);
            entity.Property(e => e.FinalIncentiveCap).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HurdleDeduction).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HurdleDeductionPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HurdleMultiplication).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HurdleMultiplierPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IncentiveAfterHurdle).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IncentiveBeforeHurdle).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IncentiveEarned).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IncentiveEarnedAfterCap).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MonthScorecardPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MtdscorecardPercentage)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MTDScorecardPercentage");
            entity.Property(e => e.NonHurdleProductIncentive).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.StrategicDeduction).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.StrategicDeductionPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<IncentiveGranteeIndicatorWording>(entity =>
        {
            entity.HasKey(e => e.GranteeIndicatorWordingId);

            entity.ToTable("IncentiveGranteeIndicatorWording");

            entity.Property(e => e.GranteeIndicatorWordingId).HasColumnName("GranteeIndicatorWordingID");
            entity.Property(e => e.CreatedAt).HasMaxLength(300);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(300);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(300);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.IncentiveGranteeIndicatorWordingCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_IncentiveGranteeIndicatorWording_CreatedBy_Users");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.IncentiveGranteeIndicatorWordingModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_IncentiveGranteeIndicatorWording_ModifiedBy_Users");

            entity.HasOne(d => d.Organisation).WithMany(p => p.IncentiveGranteeIndicatorWordings)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_IncentiveGranteeIndicatorWording_Organisations");
        });

        modelBuilder.Entity<IncentiveGranteeType>(entity =>
        {
            entity.HasKey(e => e.GranteeTypeId);

            entity.Property(e => e.GranteeTypeId).HasColumnName("GranteeTypeID");
            entity.Property(e => e.CreatedAt).HasMaxLength(300);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(300);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(300);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.IncentiveGranteeTypeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_IncentiveGranteeTypes_CreatedBy_Users");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.IncentiveGranteeTypeModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_IncentiveGranteeTypes_ModifiedBy_Users");

            entity.HasOne(d => d.Organisation).WithMany(p => p.IncentiveGranteeTypes)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_IncentiveGranteeTypes_Organisations");
        });

        modelBuilder.Entity<IncentiveHurdleTemplate>(entity =>
        {
            entity.HasKey(e => e.HurdleTemplateId);

            entity.ToTable("IncentiveHurdleTemplate");

            entity.Property(e => e.HurdleTemplateId).HasColumnName("HurdleTemplateID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CreatedAt).HasMaxLength(600);
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DeductionPercentage).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.MinScorecardPercentageEligibleForIncentive).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.MinimumAchievedPercentage).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ModifiedAt).HasMaxLength(600);
            entity.Property(e => e.ModifiedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.WeightedScoreCardCap).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<IncentiveHurdleTemplateDeductionParameter>(entity =>
        {
            entity.HasKey(e => e.ParameterId);

            entity.Property(e => e.ParameterId).HasColumnName("ParameterID");
            entity.Property(e => e.DeductionPercentage).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.HurdleTemplateId).HasColumnName("HurdleTemplateID");
            entity.Property(e => e.MaxPercentage).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.MinPercentage).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<IncentiveHurdleTemplateMultiplierParameter>(entity =>
        {
            entity.HasKey(e => e.ParameterId);

            entity.Property(e => e.ParameterId).HasColumnName("ParameterID");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.HurdleTemplateId).HasColumnName("HurdleTemplateID");
            entity.Property(e => e.MaxPercentage).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.MinPercentage).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.MultiplierPercentage).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<IncentivePayrollTarget>(entity =>
        {
            entity.HasKey(e => e.IncentivePayrollProductConfigurationId).HasName("PK_IncentiveTemplatePayrollProductConfiguration");

            entity.ToTable("IncentivePayrollTarget");

            entity.Property(e => e.IncentivePayrollProductConfigurationId).HasColumnName("IncentivePayrollProductConfigurationID");
            entity.Property(e => e.Area).HasMaxLength(300);
            entity.Property(e => e.BranchName).HasMaxLength(300);
            entity.Property(e => e.BranchNumber).HasMaxLength(300);
            entity.Property(e => e.CreatedAt).HasMaxLength(300);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(300);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.PayrollTargetImportHistoryId).HasColumnName("PayrollTargetImportHistoryID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.PayrollTargetImportHistory).WithMany(p => p.IncentivePayrollTargets)
                .HasForeignKey(d => d.PayrollTargetImportHistoryId)
                .HasConstraintName("FK_IncentiveTemplatePayrollProductConfiguration_PayrollTargetImportHistoryID");
        });

        modelBuilder.Entity<IncentivePayrollTargetImportAudit>(entity =>
        {
            entity.HasKey(e => e.PayrollTargetImportAuditId).HasName("PK__Incentiv__ADE7434AA45D6E0E");

            entity.ToTable("IncentivePayrollTargetImportAudit");

            entity.Property(e => e.PayrollTargetImportAuditId).HasColumnName("PayrollTargetImportAuditID");
            entity.Property(e => e.ColumnName).HasMaxLength(100);
            entity.Property(e => e.IncentivePayrollProductConfigurationId).HasColumnName("IncentivePayrollProductConfigurationID");
            entity.Property(e => e.NewImportHistoryId).HasColumnName("NewImportHistoryID");
            entity.Property(e => e.OldImportHistoryId).HasColumnName("OldImportHistoryID");

            entity.HasOne(d => d.IncentivePayrollProductConfiguration).WithMany(p => p.IncentivePayrollTargetImportAudits)
                .HasForeignKey(d => d.IncentivePayrollProductConfigurationId)
                .HasConstraintName("FK_PayrollTargetImportAudit_IncentivePayrollProductConfigurationID");

            entity.HasOne(d => d.NewImportHistory).WithMany(p => p.IncentivePayrollTargetImportAuditNewImportHistories)
                .HasForeignKey(d => d.NewImportHistoryId)
                .HasConstraintName("FK__Incentive__NewIm__6C43F744");

            entity.HasOne(d => d.OldImportHistory).WithMany(p => p.IncentivePayrollTargetImportAuditOldImportHistories)
                .HasForeignKey(d => d.OldImportHistoryId)
                .HasConstraintName("FK__Incentive__OldIm__6D381B7D");
        });

        modelBuilder.Entity<IncentivePayrollTargetImportFieldSetting>(entity =>
        {
            entity.HasKey(e => e.PayrollTargetFieldSettingId).HasName("PK_PayrollTargetFieldSettings");

            entity.Property(e => e.PayrollTargetFieldSettingId).HasColumnName("PayrollTargetFieldSettingID");
            entity.Property(e => e.CanEditedOnDevice).HasDefaultValue(true);
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.Expression).HasMaxLength(100);
            entity.Property(e => e.FieldDataType).HasMaxLength(50);
            entity.Property(e => e.FieldLabel).HasMaxLength(100);
            entity.Property(e => e.FieldName).HasMaxLength(100);
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.OverwriteAlways).HasDefaultValue(true);
            entity.Property(e => e.PayrollTargetFieldCategoryId)
                .HasDefaultValue(1)
                .HasColumnName("PayrollTargetFieldCategoryID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.IncentivePayrollTargetImportFieldSettings)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollTargetFieldSettings_PayrollTargetFieldSettings");
        });

        modelBuilder.Entity<IncentivePayrollTargetImportFieldSettingMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PayrollTargetSettingMaster");

            entity.ToTable("IncentivePayrollTargetImportFieldSettingMaster");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FieldDataType).HasMaxLength(100);
            entity.Property(e => e.FieldLabel).HasMaxLength(200);
            entity.Property(e => e.FieldName).HasMaxLength(200);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsMandatory).HasDefaultValue(false);
            entity.Property(e => e.IsStaticField).HasDefaultValue(true);
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<IncentivePayrollTargetImportHistory>(entity =>
        {
            entity.HasKey(e => e.PayrollTargetImportHistoryId).HasName("PK__Incentiv__4101027239D6F448");

            entity.ToTable("IncentivePayrollTargetImportHistory");

            entity.Property(e => e.PayrollTargetImportHistoryId).HasColumnName("PayrollTargetImportHistoryID");
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.ImportTimeStamp).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsReverted).HasDefaultValue(false);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.UploadedAt).HasMaxLength(200);
            entity.Property(e => e.UploadedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.IncentivePayrollTargetImportHistories)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK__Incentive__Organ__70148828");
        });

        modelBuilder.Entity<IncentivePayrollTargetImportMapping>(entity =>
        {
            entity.HasKey(e => e.PayrollTargetImportMappingId).HasName("PK__Incentiv__13B5765391C49E86");

            entity.ToTable("IncentivePayrollTargetImportMapping");

            entity.Property(e => e.PayrollTargetImportMappingId).HasColumnName("PayrollTargetImportMappingID");
            entity.Property(e => e.ImportFieldNameFromFile).HasMaxLength(100);
            entity.Property(e => e.ImportHistoryId).HasColumnName("ImportHistoryID");
            entity.Property(e => e.PayrollTargetFieldSettingId).HasColumnName("PayrollTargetFieldSettingID");

            entity.HasOne(d => d.ImportHistory).WithMany(p => p.IncentivePayrollTargetImportMappings)
                .HasForeignKey(d => d.ImportHistoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PayrollTargetImportMapping__ImportHistoryID");
        });

        modelBuilder.Entity<IncentivePrepaidCardType>(entity =>
        {
            entity.ToTable("IncentivePrepaidCardType");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CardName).HasMaxLength(300);
            entity.Property(e => e.CardType).HasMaxLength(300);
            entity.Property(e => e.CreatedAt).HasMaxLength(300);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(300);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.IncentivePrepaidCardTypeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_IncentivePrepaidCardType_CreatedBy_Users");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.IncentivePrepaidCardTypeModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_IncentivePrepaidCardType_ModifiedBy_Users");

            entity.HasOne(d => d.Organisation).WithMany(p => p.IncentivePrepaidCardTypes)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_IncentivePrepaidCardType_Organisations");
        });

        modelBuilder.Entity<IncentivePrimaryCcperBinconfiguration>(entity =>
        {
            entity.HasKey(e => e.IncentivePerBinId);

            entity.ToTable("IncentivePrimaryCCPerBINConfiguration");

            entity.Property(e => e.IncentivePerBinId).HasColumnName("IncentivePerBin_ID");
            entity.Property(e => e.ClawBackValue).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ClawBackValueTypeId).HasColumnName("ClawBackValueTypeID");
            entity.Property(e => e.CreditCardTypeId).HasColumnName("CreditCardTypeID");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.GranteeTypeId).HasColumnName("GranteeTypeID");
            entity.Property(e => e.IncentiveAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.IncentiveTemplateId).HasColumnName("IncentiveTemplateID");
            entity.Property(e => e.IsClawBackApplicable).HasDefaultValue(false);

            entity.HasOne(d => d.IncentiveTemplate).WithMany(p => p.IncentivePrimaryCcperBinconfigurations)
                .HasForeignKey(d => d.IncentiveTemplateId)
                .HasConstraintName("FK_IncentivePrimaryCCPerBINConfiguration_IncentiveTemplateCreditCardProductID");
        });

        modelBuilder.Entity<IncentivePrimaryCreditCardType>(entity =>
        {
            entity.ToTable("IncentivePrimaryCreditCardType");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bin)
                .HasMaxLength(300)
                .HasColumnName("BIN");
            entity.Property(e => e.CreatedAt).HasMaxLength(300);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreditCardType).HasMaxLength(300);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(300);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.IncentivePrimaryCreditCardTypeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_IncentivePrimaryCreditCardType_CreatedBy_Users");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.IncentivePrimaryCreditCardTypeModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_IncentivePrimaryCreditCardType_ModifiedBy_Users");

            entity.HasOne(d => d.Organisation).WithMany(p => p.IncentivePrimaryCreditCardTypes)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_IncentivePrimaryCreditCardType_Organisations");
        });

        modelBuilder.Entity<IncentiveProductType>(entity =>
        {
            entity.ToTable("IncentiveProductType");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.IsHurdleApplicable).HasDefaultValue(false);
            entity.Property(e => e.IsImportEnabled).HasDefaultValue(false);
            entity.Property(e => e.IsIncentiveApplicable).HasDefaultValue(true);
            entity.Property(e => e.IsPreviousMonthCalculationEnabled).HasDefaultValue(true);
            entity.Property(e => e.ProductName).HasMaxLength(200);
        });

        modelBuilder.Entity<IncentiveRoleShareTemplate>(entity =>
        {
            entity.ToTable("IncentiveRoleShareTemplate");

            entity.Property(e => e.IncentiveRoleShareTemplateId).HasColumnName("IncentiveRoleShareTemplateID");
            entity.Property(e => e.BranchShare).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ReferralShare).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.SalesNonSalesRoleShare).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<IncentiveSupplementaryCcperBinconfiguration>(entity =>
        {
            entity.HasKey(e => e.IncentivePerBinId);

            entity.ToTable("IncentiveSupplementaryCCPerBINConfiguration");

            entity.Property(e => e.IncentivePerBinId).HasColumnName("IncentivePerBin_ID");
            entity.Property(e => e.ClawBackValue).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ClawBackValueTypeId).HasColumnName("ClawBackValueTypeID");
            entity.Property(e => e.CreditCardTypeId).HasColumnName("CreditCardTypeID");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.GranteeTypeId).HasColumnName("GranteeTypeID");
            entity.Property(e => e.IncentiveAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.IncentiveTemplateId).HasColumnName("IncentiveTemplateID");
            entity.Property(e => e.IsClawBackApplicable).HasDefaultValue(false);

            entity.HasOne(d => d.IncentiveTemplate).WithMany(p => p.IncentiveSupplementaryCcperBinconfigurations)
                .HasForeignKey(d => d.IncentiveTemplateId)
                .HasConstraintName("FK_IncentiveSupplementaryCCPerBINConfiguration_IncentiveTemplateCreditCardProductID");
        });

        modelBuilder.Entity<IncentiveSupplementaryCreditCardType>(entity =>
        {
            entity.ToTable("IncentiveSupplementaryCreditCardType");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bin)
                .HasMaxLength(300)
                .HasColumnName("BIN");
            entity.Property(e => e.CreatedAt).HasMaxLength(300);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreditCardType).HasMaxLength(300);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(300);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.IncentiveSupplementaryCreditCardTypeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_IncentiveSupplementaryCreditCardType_CreatedBy_Users");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.IncentiveSupplementaryCreditCardTypeModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_IncentiveSupplementaryCreditCardType_ModifiedBy_Users");

            entity.HasOne(d => d.Organisation).WithMany(p => p.IncentiveSupplementaryCreditCardTypes)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_IncentiveSupplementaryCreditCardType_Organisations");
        });

        modelBuilder.Entity<IncentiveTemplate>(entity =>
        {
            entity.ToTable("IncentiveTemplate");

            entity.Property(e => e.IncentiveTemplateId).HasColumnName("IncentiveTemplateID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FinalIncentiveCap).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HurdleTemplateId).HasColumnName("HurdleTemplateID");
            entity.Property(e => e.IncentiveRoleShareTemplateId).HasColumnName("IncentiveRoleShareTemplateID");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

            entity.HasOne(d => d.IncentiveRoleShareTemplate).WithMany(p => p.IncentiveTemplates)
                .HasForeignKey(d => d.IncentiveRoleShareTemplateId)
                .HasConstraintName("FK__Incentive__Incen__799DF262");
        });

        modelBuilder.Entity<IncentiveTemplateBancAssuranceProductParameter>(entity =>
        {
            entity.Property(e => e.IncentiveTemplateBancAssuranceProductParameterId).HasColumnName("IncentiveTemplateBancAssuranceProductParameterID");
            entity.Property(e => e.BranchShare).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IncentiveTemplateId).HasColumnName("IncentiveTemplateID");
            entity.Property(e => e.IsApplicable).HasDefaultValue(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ReferralShare).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Rmtarget)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("RMTarget");
            entity.Property(e => e.SalesNonSalesRoleShare).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Target).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Vipcsrtarget)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VIPCSRTarget");
            entity.Property(e => e.Weight).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.IncentiveTemplate).WithMany(p => p.IncentiveTemplateBancAssuranceProductParameters)
                .HasForeignKey(d => d.IncentiveTemplateId)
                .HasConstraintName("FK__Incentive__Incen__44474D9A");
        });

        modelBuilder.Entity<IncentiveTemplateCreditCardProduct>(entity =>
        {
            entity.ToTable("IncentiveTemplateCreditCardProduct");

            entity.Property(e => e.IncentiveTemplateCreditCardProductId).HasColumnName("IncentiveTemplateCreditCardProductID");
            entity.Property(e => e.BeforeClawbackCap).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.BranchShare).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ClawbackCap).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.CreditCardTierGroupId).HasColumnName("CreditCardTierGroupID");
            entity.Property(e => e.IncentiveTemplateId).HasColumnName("IncentiveTemplateID");
            entity.Property(e => e.IsApplicable).HasDefaultValue(false);
            entity.Property(e => e.NetIncentiveCap).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.ReferralShare).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Rmtarget)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("RMTarget");
            entity.Property(e => e.SalesNonSalesRoleShare).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Target).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Vipcsrtarget)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VIPCSRTarget");
            entity.Property(e => e.Weightage).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.IncentiveTemplate).WithMany(p => p.IncentiveTemplateCreditCardProducts)
                .HasForeignKey(d => d.IncentiveTemplateId)
                .HasConstraintName("FK_IncentiveTemplateCreditCardProduct_IncentiveTemplateID");
        });

        modelBuilder.Entity<IncentiveTemplateDebitCardProduct>(entity =>
        {
            entity.ToTable("IncentiveTemplateDebitCardProduct");

            entity.Property(e => e.IncentiveTemplateDebitCardProductId).HasColumnName("IncentiveTemplateDebitCardProductID");
            entity.Property(e => e.Csrtarget)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CSRTarget");
            entity.Property(e => e.IncentiveTemplateId).HasColumnName("IncentiveTemplateID");
            entity.Property(e => e.IsApplicable).HasDefaultValue(false);
            entity.Property(e => e.NetIncentiveCap).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.Rmtarget)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RMTarget");
            entity.Property(e => e.Vipcsrtarget)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VIPCSRTarget");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.IncentiveTemplate).WithMany(p => p.IncentiveTemplateDebitCardProducts)
                .HasForeignKey(d => d.IncentiveTemplateId)
                .HasConstraintName("FK_IncentiveTemplateDebitCardProduct_IncentiveTemplateID");
        });

        modelBuilder.Entity<IncentiveTemplateInternetBankingProduct>(entity =>
        {
            entity.ToTable("IncentiveTemplateInternetBankingProduct");

            entity.Property(e => e.IncentiveTemplateInternetBankingProductId).HasColumnName("IncentiveTemplateInternetBankingProductID");
            entity.Property(e => e.Csrtarget)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CSRTarget");
            entity.Property(e => e.IncentiveAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IncentiveTemplateId).HasColumnName("IncentiveTemplateID");
            entity.Property(e => e.IsApplicable).HasDefaultValue(false);
            entity.Property(e => e.Rmtarget)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RMTarget");
            entity.Property(e => e.Vipcsrtarget)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VIPCSRTarget");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.IncentiveTemplate).WithMany(p => p.IncentiveTemplateInternetBankingProducts)
                .HasForeignKey(d => d.IncentiveTemplateId)
                .HasConstraintName("FK_IncentiveTemplateInternetBankingProduct_IncentiveTemplateID");
        });

        modelBuilder.Entity<IncentiveTemplateLoanProductParameter>(entity =>
        {
            entity.Property(e => e.IncentiveTemplateLoanProductParameterId).HasColumnName("IncentiveTemplateLoanProductParameterID");
            entity.Property(e => e.BranchShare).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IncentiveAmountCap).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.IncentiveTemplateId).HasColumnName("IncentiveTemplateID");
            entity.Property(e => e.IsApplicable).HasDefaultValue(false);
            entity.Property(e => e.LoansIncentiveFactor).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.MinLoanAmountEligibleForIncentive).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ReferralShare).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Rmtarget)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("RMTarget");
            entity.Property(e => e.SalesNonSalesRoleShare).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Target).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Vipcsrtarget)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VIPCSRTarget");
            entity.Property(e => e.Weight).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.IncentiveTemplate).WithMany(p => p.IncentiveTemplateLoanProductParameters)
                .HasForeignKey(d => d.IncentiveTemplateId)
                .HasConstraintName("FK__Incentive__Incen__23EF8CA1");
        });

        modelBuilder.Entity<IncentiveTemplatePayrollProduct>(entity =>
        {
            entity.ToTable("IncentiveTemplatePayrollProduct");

            entity.Property(e => e.IncentiveTemplatePayrollProductId).HasColumnName("IncentiveTemplatePayrollProductID");
            entity.Property(e => e.CompanyWeight).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EmployeeWeight).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.IncentiveTemplateId).HasColumnName("IncentiveTemplateID");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.IncentiveTemplate).WithMany(p => p.IncentiveTemplatePayrollProducts)
                .HasForeignKey(d => d.IncentiveTemplateId)
                .HasConstraintName("FK__Incentive__Incen__7E62A77F");
        });

        modelBuilder.Entity<IncentiveTemplatePosproduct>(entity =>
        {
            entity.ToTable("IncentiveTemplatePOSProduct");

            entity.Property(e => e.IncentiveTemplatePosproductId).HasColumnName("IncentiveTemplatePOSProductID");
            entity.Property(e => e.Csrtarget)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CSRTarget");
            entity.Property(e => e.IncentiveTemplateId).HasColumnName("IncentiveTemplateID");
            entity.Property(e => e.IsApplicable).HasDefaultValue(false);
            entity.Property(e => e.Rmtarget)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RMTarget");
            entity.Property(e => e.Vipcsrtarget)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VIPCSRTarget");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.IncentiveTemplate).WithMany(p => p.IncentiveTemplatePosproducts)
                .HasForeignKey(d => d.IncentiveTemplateId)
                .HasConstraintName("FK_IncentiveTemplatePOSProduct_IncentiveTemplateID");
        });

        modelBuilder.Entity<IncentiveTemplatePrepaidCardProduct>(entity =>
        {
            entity.ToTable("IncentiveTemplatePrepaidCardProduct");

            entity.Property(e => e.IncentiveTemplatePrepaidCardProductId).HasColumnName("IncentiveTemplatePrepaidCardProductID");
            entity.Property(e => e.Csrtarget)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CSRTarget");
            entity.Property(e => e.IncentiveTemplateId).HasColumnName("IncentiveTemplateID");
            entity.Property(e => e.IsApplicable).HasDefaultValue(false);
            entity.Property(e => e.Rmtarget)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RMTarget");
            entity.Property(e => e.Vipcsrtarget)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VIPCSRTarget");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.IncentiveTemplate).WithMany(p => p.IncentiveTemplatePrepaidCardProducts)
                .HasForeignKey(d => d.IncentiveTemplateId)
                .HasConstraintName("FK_IncentiveTemplatePrepaidCardProduct_IncentiveTemplateID");
        });

        modelBuilder.Entity<IncentiveTemplateProductFieldSetting>(entity =>
        {
            entity.Property(e => e.IncentiveTemplateProductFieldSettingId).HasColumnName("IncentiveTemplateProductFieldSettingID");
            entity.Property(e => e.CanEditedOnDevice).HasDefaultValue(true);
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.Expression).HasMaxLength(100);
            entity.Property(e => e.FieldDataType).HasMaxLength(50);
            entity.Property(e => e.FieldLabel).HasMaxLength(100);
            entity.Property(e => e.FieldName).HasMaxLength(100);
            entity.Property(e => e.IncentiveTemplateProductFieldCategoryId)
                .HasDefaultValue(1)
                .HasColumnName("IncentiveTemplateProductFieldCategoryID");
            entity.Property(e => e.IsConfidential).HasDefaultValue(false);
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.OverwriteAlways).HasDefaultValue(true);
            entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.IncentiveTemplateProductFieldCategory).WithMany(p => p.IncentiveTemplateProductFieldSettings)
                .HasForeignKey(d => d.IncentiveTemplateProductFieldCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncentiveTemplateProductFieldSettings_FieldCategories");

            entity.HasOne(d => d.Organisation).WithMany(p => p.IncentiveTemplateProductFieldSettings)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncentiveTemplateProductFieldSettings_Organisations");

            entity.HasOne(d => d.ProductType).WithMany(p => p.IncentiveTemplateProductFieldSettings)
                .HasForeignKey(d => d.ProductTypeId)
                .HasConstraintName("FK__Incentive__Produ__013F142A");
        });

        modelBuilder.Entity<IncentiveTemplateProductFieldSettingMaster>(entity =>
        {
            entity.ToTable("IncentiveTemplateProductFieldSettingMaster");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FieldDataType).HasMaxLength(100);
            entity.Property(e => e.FieldLabel).HasMaxLength(200);
            entity.Property(e => e.FieldName).HasMaxLength(200);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsMandatory).HasDefaultValue(false);
            entity.Property(e => e.IsStaticField).HasDefaultValue(true);
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.ProductType).WithMany(p => p.IncentiveTemplateProductFieldSettingMasters)
                .HasForeignKey(d => d.ProductTypeId)
                .HasConstraintName("FK__Incentive__Produ__4D41188E");
        });

        modelBuilder.Entity<IncentiveTemplateProductImportAudit>(entity =>
        {
            entity.HasKey(e => e.IncentiveTemplateProductAuditId).HasName("PK__Incentiv__3BB1531B2B30EE64");

            entity.ToTable("IncentiveTemplateProductImportAudit");

            entity.Property(e => e.IncentiveTemplateProductAuditId).HasColumnName("IncentiveTemplateProductAuditID");
            entity.Property(e => e.ColumnName).HasMaxLength(100);
            entity.Property(e => e.IncentiveTransactionsBancAssuranceIslamicId).HasColumnName("IncentiveTransactionsBancAssuranceIslamicID");
            entity.Property(e => e.NewImportHistoryId).HasColumnName("NewImportHistoryID");
            entity.Property(e => e.OldImportHistoryId).HasColumnName("OldImportHistoryID");
            entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");

            entity.HasOne(d => d.NewImportHistory).WithMany(p => p.IncentiveTemplateProductImportAuditNewImportHistories)
                .HasForeignKey(d => d.NewImportHistoryId)
                .HasConstraintName("FK__Incentive__NewIm__041B80D5");

            entity.HasOne(d => d.OldImportHistory).WithMany(p => p.IncentiveTemplateProductImportAuditOldImportHistories)
                .HasForeignKey(d => d.OldImportHistoryId)
                .HasConstraintName("FK__Incentive__OldIm__050FA50E");
        });

        modelBuilder.Entity<IncentiveTemplateProductImportHistory>(entity =>
        {
            entity.HasKey(e => e.IncentiveTemplateProductImportHistoryId).HasName("PK__Incentiv__BAF3739B1794492E");

            entity.ToTable("IncentiveTemplateProductImportHistory");

            entity.Property(e => e.IncentiveTemplateProductImportHistoryId).HasColumnName("IncentiveTemplateProductImportHistoryID");
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.ImportTimeStamp).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsReverted).HasDefaultValue(false);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.UploadedAt).HasMaxLength(200);
            entity.Property(e => e.UploadedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.IncentiveTemplateProductImportHistories)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK__Incentive__Organ__0603C947");

            entity.HasOne(d => d.ProductType).WithMany(p => p.IncentiveTemplateProductImportHistories)
                .HasForeignKey(d => d.ProductTypeId)
                .HasConstraintName("FK__Incentive__Produ__06F7ED80");
        });

        modelBuilder.Entity<IncentiveTemplateProductImportMapping>(entity =>
        {
            entity.HasKey(e => e.IncentiveTemplateProductImportMappingId).HasName("PK__Incentiv__26AA16BD05C0AFA1");

            entity.ToTable("IncentiveTemplateProductImportMapping");

            entity.Property(e => e.IncentiveTemplateProductImportMappingId).HasColumnName("IncentiveTemplateProductImportMappingID");
            entity.Property(e => e.ImportFieldNameFromFile).HasMaxLength(100);
            entity.Property(e => e.ImportHistoryId).HasColumnName("ImportHistoryID");
            entity.Property(e => e.IncentiveTemplateProductFieldSettingId).HasColumnName("IncentiveTemplateProductFieldSettingID");

            entity.HasOne(d => d.ImportHistory).WithMany(p => p.IncentiveTemplateProductImportMappings)
                .HasForeignKey(d => d.ImportHistoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IncentiveTemplateProductImportMapping__ImportHistoryID");
        });

        modelBuilder.Entity<IncentiveTemplateProductMappingHistory>(entity =>
        {
            entity.HasKey(e => e.HistoryId).HasName("PK__Incentiv__4D7B4ADD42BEEC28");

            entity.ToTable("IncentiveTemplateProductMappingHistory");

            entity.Property(e => e.HistoryId).HasColumnName("HistoryID");
            entity.Property(e => e.BranchCode).HasMaxLength(200);
            entity.Property(e => e.BranchName).HasMaxLength(200);
            entity.Property(e => e.ClientId).HasColumnName("ClientID");
            entity.Property(e => e.ClientName).HasMaxLength(200);
            entity.Property(e => e.CommissionAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CompanyName).HasMaxLength(200);
            entity.Property(e => e.EmployeeNumber).HasMaxLength(200);
            entity.Property(e => e.IncentiveTemplateProductImportHistoryId).HasColumnName("IncentiveTemplateProductImportHistoryID");
            entity.Property(e => e.IncentiveTransactionsBancAssuranceIslamicId).HasColumnName("IncentiveTransactionsBancAssuranceIslamicID");
            entity.Property(e => e.PolicyAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PolicyNumber).HasMaxLength(200);
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.IncentiveTemplateProductImportHistory).WithMany(p => p.IncentiveTemplateProductMappingHistories)
                .HasForeignKey(d => d.IncentiveTemplateProductImportHistoryId)
                .HasConstraintName("FK__Incentive__Incen__08E035F2");
        });

        modelBuilder.Entity<IncentiveTemplateProductUnTaggedHistory>(entity =>
        {
            entity.ToTable("IncentiveTemplateProductUnTaggedHistory");

            entity.Property(e => e.IncentiveTemplateProductUnTaggedHistoryId).HasColumnName("IncentiveTemplateProductUnTaggedHistoryID");
            entity.Property(e => e.IncentiveTransactionsBancAssuranceIslamicId).HasColumnName("IncentiveTransactionsBancAssuranceIslamicID");
            entity.Property(e => e.UnTaggedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.IncentiveTemplateProductUnTaggedHistories)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_IncentiveTemplateProductUnTaggedHistory_Users");
        });

        modelBuilder.Entity<IncentiveTransactionsBancAssuranceConventional>(entity =>
        {
            entity.ToTable("IncentiveTransactions_BancAssurance_Conventional", tb => tb.HasTrigger("Trigger_OnUpdateIncentiveTransactions_BancAssurance_Conventional"));

            entity.HasIndex(e => e.IsMoved, "IX_IncentiveTransactions_BancAssurance_Conventional_IsMoved");

            entity.Property(e => e.IncentiveTransactionsBancAssuranceConventionalId).HasColumnName("IncentiveTransactionsBancAssuranceConventionalID");
            entity.Property(e => e.BranchCode).HasMaxLength(200);
            entity.Property(e => e.CommissionAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EmpId)
                .HasMaxLength(200)
                .HasColumnName("EmpID");
            entity.Property(e => e.Frequency).HasMaxLength(20);
            entity.Property(e => e.IncentiveTemplateProductImportHistoryId).HasColumnName("IncentiveTemplateProductImportHistoryID");
            entity.Property(e => e.IsMoved).HasDefaultValue(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NetAnnualPremium).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.NetFrequentPremium).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ProposalNumber).HasMaxLength(200);

            entity.HasOne(d => d.IncentiveTemplateProductImportHistory).WithMany(p => p.IncentiveTransactionsBancAssuranceConventionals)
                .HasForeignKey(d => d.IncentiveTemplateProductImportHistoryId)
                .HasConstraintName("FK__Incentive__Incen__4F83F61C");
        });

        modelBuilder.Entity<IncentiveTransactionsBancAssuranceConventionalFinal>(entity =>
        {
            entity.ToTable("IncentiveTransactions_BancAssurance_Conventional_Final");

            entity.HasIndex(e => e.EmpId, "IX_IncentiveTransactions_BancAssurance_Conventional_Final_EmpID");

            entity.HasIndex(e => e.IncentivePaymentDate, "IX_IncentiveTransactions_BancAssurance_Conventional_Final_IncentivePaymentDate");

            entity.HasIndex(e => e.OwnerId, "IX_IncentiveTransactions_BancAssurance_Conventional_Final_OwnerID");

            entity.HasIndex(e => e.ProposalNumber, "IX_IncentiveTransactions_BancAssurance_Conventional_Final_ProposalNumber");

            entity.Property(e => e.IncentiveTransactionsBancAssuranceConventionalFinalId).HasColumnName("IncentiveTransactionsBancAssuranceConventionalFinalID");
            entity.Property(e => e.BranchCode).HasMaxLength(200);
            entity.Property(e => e.CommissionAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.EmpId)
                .HasMaxLength(200)
                .HasColumnName("EmpID");
            entity.Property(e => e.Frequency).HasMaxLength(20);
            entity.Property(e => e.NetAnnualPremium).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.NetFrequentPremium).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            entity.Property(e => e.ProposalNumber).HasMaxLength(200);
        });

        modelBuilder.Entity<IncentiveTransactionsBancAssuranceIslamic>(entity =>
        {
            entity.ToTable("IncentiveTransactions_BancAssurance_Islamic", tb => tb.HasTrigger("Trigger_OnUpdateIncentiveTransactions_BancAssurance_Islamic"));

            entity.Property(e => e.IncentiveTransactionsBancAssuranceIslamicId).HasColumnName("IncentiveTransactionsBancAssuranceIslamicID");
            entity.Property(e => e.BranchCode).HasMaxLength(200);
            entity.Property(e => e.CommissionAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EmpId)
                .HasMaxLength(200)
                .HasColumnName("EmpID");
            entity.Property(e => e.Frequency).HasMaxLength(20);
            entity.Property(e => e.IncentiveTemplateProductImportHistoryId).HasColumnName("IncentiveTemplateProductImportHistoryID");
            entity.Property(e => e.IsMoved).HasDefaultValue(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NetAnnualPremium).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.NetFrequentPremium).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PolicyNumber).HasMaxLength(200);

            entity.HasOne(d => d.IncentiveTemplateProductImportHistory).WithMany(p => p.IncentiveTransactionsBancAssuranceIslamics)
                .HasForeignKey(d => d.IncentiveTemplateProductImportHistoryId)
                .HasConstraintName("FK__Incentive__Incen__3371C753");
        });

        modelBuilder.Entity<IncentiveTransactionsBancAssuranceIslamicFinal>(entity =>
        {
            entity.ToTable("IncentiveTransactions_BancAssurance_Islamic_Final");

            entity.Property(e => e.IncentiveTransactionsBancAssuranceIslamicFinalId).HasColumnName("IncentiveTransactionsBancAssuranceIslamicFinalID");
            entity.Property(e => e.BranchCode).HasMaxLength(200);
            entity.Property(e => e.CommissionAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.EmpId)
                .HasMaxLength(200)
                .HasColumnName("EmpID");
            entity.Property(e => e.Frequency).HasMaxLength(20);
            entity.Property(e => e.NetAnnualPremium).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.NetFrequentPremium).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            entity.Property(e => e.PolicyNumber).HasMaxLength(200);
        });

        modelBuilder.Entity<IncentiveTransactionsBancAssuranceIslamicReversed>(entity =>
        {
            entity.HasKey(e => e.IncentiveTransactionsBancAssuranceIslamicReverseId);

            entity.ToTable("IncentiveTransactions_BancAssurance_Islamic_Reversed", tb => tb.HasTrigger("Trigger_OnUpdateIncentiveTransactions_BancAssurance_Islamic_Reversed"));

            entity.Property(e => e.IncentiveTransactionsBancAssuranceIslamicReverseId).HasColumnName("IncentiveTransactionsBancAssuranceIslamicReverseID");
            entity.Property(e => e.BranchCode).HasMaxLength(200);
            entity.Property(e => e.CommissionAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EmpId)
                .HasMaxLength(200)
                .HasColumnName("EmpID");
            entity.Property(e => e.Frequency).HasMaxLength(20);
            entity.Property(e => e.IncentiveTemplateProductImportHistoryId).HasColumnName("IncentiveTemplateProductImportHistoryID");
            entity.Property(e => e.IsMoved).HasDefaultValue(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NetAnnualPremium).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.NetFrequentPremium).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PolicyNumber).HasMaxLength(200);

            entity.HasOne(d => d.IncentiveTemplateProductImportHistory).WithMany(p => p.IncentiveTransactionsBancAssuranceIslamicReverseds)
                .HasForeignKey(d => d.IncentiveTemplateProductImportHistoryId)
                .HasConstraintName("FK__Incentive__Incen__2523A7FC");
        });

        modelBuilder.Entity<IncentiveTransactionsBancAssuranceIslamicReversedFinal>(entity =>
        {
            entity.ToTable("IncentiveTransactions_BancAssurance_Islamic_Reversed_Final");

            entity.Property(e => e.IncentiveTransactionsBancAssuranceIslamicReversedFinalId).HasColumnName("IncentiveTransactionsBancAssuranceIslamicReversedFinalID");
            entity.Property(e => e.BranchCode).HasMaxLength(200);
            entity.Property(e => e.CommissionAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.EmpId)
                .HasMaxLength(200)
                .HasColumnName("EmpID");
            entity.Property(e => e.Frequency).HasMaxLength(20);
            entity.Property(e => e.NetAnnualPremium).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.NetFrequentPremium).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            entity.Property(e => e.PolicyNumber).HasMaxLength(200);
        });

        modelBuilder.Entity<IncentiveTransactionsCreditCardActivated>(entity =>
        {
            entity.ToTable("IncentiveTransactions_CreditCard_Activated");

            entity.HasIndex(e => e.IsMoved, "IX_IncentiveTransactions_CreditCard_Activated_IsMoved");

            entity.Property(e => e.IncentiveTransactionsCreditCardActivatedId).HasColumnName("IncentiveTransactionsCreditCardActivatedID");
            entity.Property(e => e.ActivationDate).HasColumnName("Activation_Date");
            entity.Property(e => e.AgreementDate).HasColumnName("Agreement_Date");
            entity.Property(e => e.BranchCode).HasColumnName("Branch_Code");
            entity.Property(e => e.CustomerSegment).HasMaxLength(200);
            entity.Property(e => e.GuaranteeWording).HasColumnName("Guarantee_Wording");
            entity.Property(e => e.IsMoved).HasDefaultValue(false);
            entity.Property(e => e.IssuerBin)
                .HasMaxLength(200)
                .HasColumnName("Issuer_Bin");
            entity.Property(e => e.NationalId)
                .HasMaxLength(200)
                .HasColumnName("NationalID");
            entity.Property(e => e.OracleNumber).HasColumnName("Oracle_Number");
            entity.Property(e => e.PrimarySupp).HasColumnName("Primary_Supp");
            entity.Property(e => e.SecuredUnsecured)
                .HasMaxLength(200)
                .HasColumnName("Secured_Unsecured");
            entity.Property(e => e.ShadowAccountNbr)
                .HasMaxLength(200)
                .HasColumnName("Shadow_Account_NBR");
        });

        modelBuilder.Entity<IncentiveTransactionsCreditCardActivatedFinal>(entity =>
        {
            entity.ToTable("IncentiveTransactions_CreditCard_Activated_Final");

            entity.HasIndex(e => e.ActivationDate, "IX_IncentiveTransactions_CreditCard_Activated_Final_ActivationDate");

            entity.HasIndex(e => e.Bin, "IX_IncentiveTransactions_CreditCard_Activated_Final_BIN");

            entity.HasIndex(e => e.BranchNumber, "IX_IncentiveTransactions_CreditCard_Activated_Final_BranchNumber");

            entity.HasIndex(e => e.IsPrimary, "IX_IncentiveTransactions_CreditCard_Activated_Final_IsPrimary");

            entity.HasIndex(e => e.IssuanceDate, "IX_IncentiveTransactions_CreditCard_Activated_Final_IssuanceDate");

            entity.HasIndex(e => e.UserId, "IX_IncentiveTransactions_CreditCard_Activated_Final_UserID");

            entity.Property(e => e.IncentiveTransactionsCreditCardActivatedFinalId).HasColumnName("IncentiveTransactionsCreditCardActivatedFinalID");
            entity.Property(e => e.Bin)
                .HasMaxLength(300)
                .HasColumnName("BIN");
            entity.Property(e => e.BranchNumber).HasMaxLength(300);
            entity.Property(e => e.CardShadowAccount).HasMaxLength(200);
            entity.Property(e => e.CustomerSegment).HasMaxLength(200);
            entity.Property(e => e.IncentiveAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NationalId)
                .HasMaxLength(200)
                .HasColumnName("NationalID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<IncentiveTransactionsCreditCardIssued>(entity =>
        {
            entity.ToTable("IncentiveTransactions_CreditCard_Issued");

            entity.HasIndex(e => e.IsMoved, "IX_IncentiveTransactions_CreditCard_Issued_IsMoved");

            entity.Property(e => e.IncentiveTransactionsCreditCardIssuedId).HasColumnName("IncentiveTransactionsCreditCardIssuedID");
            entity.Property(e => e.ActivationDate).HasColumnName("Activation_Date");
            entity.Property(e => e.AgreementDate).HasColumnName("Agreement_Date");
            entity.Property(e => e.BranchCode).HasColumnName("Branch_Code");
            entity.Property(e => e.CustomerSegment).HasMaxLength(200);
            entity.Property(e => e.GuaranteeWording).HasColumnName("Guarantee_Wording");
            entity.Property(e => e.IsMoved).HasDefaultValue(false);
            entity.Property(e => e.IssuerBin)
                .HasMaxLength(200)
                .HasColumnName("Issuer_Bin");
            entity.Property(e => e.NationalId)
                .HasMaxLength(200)
                .HasColumnName("NationalID");
            entity.Property(e => e.OracleNumber).HasColumnName("Oracle_Number");
            entity.Property(e => e.PrimarySupp).HasColumnName("Primary_Supp");
            entity.Property(e => e.SecuredUnsecured)
                .HasMaxLength(200)
                .HasColumnName("Secured_Unsecured");
            entity.Property(e => e.ShadowAccountNbr)
                .HasMaxLength(200)
                .HasColumnName("Shadow_Account_NBR");
        });

        modelBuilder.Entity<IncentiveTransactionsCreditCardIssuedFinal>(entity =>
        {
            entity.ToTable("IncentiveTransactions_CreditCard_Issued_Final");

            entity.HasIndex(e => e.Bin, "IX_IncentiveTransactions_CreditCard_Issued_Final_BIN");

            entity.HasIndex(e => e.BranchNumber, "IX_IncentiveTransactions_CreditCard_Issued_Final_BranchNumber");

            entity.HasIndex(e => e.IsPrimary, "IX_IncentiveTransactions_CreditCard_Issued_Final_IsPrimary");

            entity.HasIndex(e => e.IssuanceDate, "IX_IncentiveTransactions_CreditCard_Issued_Final_IssuanceDate");

            entity.HasIndex(e => e.UserId, "IX_IncentiveTransactions_CreditCard_Issued_Final_UserID");

            entity.Property(e => e.IncentiveTransactionsCreditCardIssuedFinalId).HasColumnName("IncentiveTransactionsCreditCardIssuedFinalID");
            entity.Property(e => e.Bin)
                .HasMaxLength(300)
                .HasColumnName("BIN");
            entity.Property(e => e.BranchNumber).HasMaxLength(300);
            entity.Property(e => e.CardShadowAccount).HasMaxLength(200);
            entity.Property(e => e.CustomerSegment).HasMaxLength(200);
            entity.Property(e => e.NationalId)
                .HasMaxLength(200)
                .HasColumnName("NationalID");
            entity.Property(e => e.SellerOracleNumber).HasMaxLength(200);
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<IncentiveTransactionsDebitCardActivation>(entity =>
        {
            entity.HasKey(e => e.IncentiveTransactionId);

            entity.ToTable("IncentiveTransactions_DebitCard_Activation", tb => tb.HasTrigger("Trigger_OnUpdateIncentiveTransactions_DebitCard_Activation"));

            entity.Property(e => e.IncentiveTransactionId).HasColumnName("IncentiveTransactionID");
            entity.Property(e => e.ActivationDate).HasMaxLength(200);
            entity.Property(e => e.IsMoved).HasDefaultValue(false);
            entity.Property(e => e.TokenNo).HasMaxLength(200);
        });

        modelBuilder.Entity<IncentiveTransactionsDebitCardFinal>(entity =>
        {
            entity.ToTable("IncentiveTransactions_DebitCard_Final");

            entity.HasIndex(e => e.TokenNo, "IX_IncentiveTransactions_DebitCard_Final_TokenNo");

            entity.Property(e => e.IncentiveTransactionsDebitCardFinalId).HasColumnName("IncentiveTransactionsDebitCardFinalID");
            entity.Property(e => e.Branch).HasMaxLength(200);
            entity.Property(e => e.BranchDesc).HasMaxLength(200);
            entity.Property(e => e.CardType).HasMaxLength(200);
            entity.Property(e => e.CardTypeDesc).HasMaxLength(200);
            entity.Property(e => e.CustomerTypeIndicator).HasMaxLength(200);
            entity.Property(e => e.EmployeeOracleNumber).HasMaxLength(200);
            entity.Property(e => e.IncentiveAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsPrimary).HasDefaultValue(false);
            entity.Property(e => e.Maker).HasMaxLength(200);
            entity.Property(e => e.Nid)
                .HasMaxLength(200)
                .HasColumnName("NID");
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            entity.Property(e => e.TokenNo).HasMaxLength(200);
        });

        modelBuilder.Entity<IncentiveTransactionsDebitCardIssuance>(entity =>
        {
            entity.HasKey(e => e.IncentiveTransactionsDebitCardId).HasName("PK_IncentiveTransactions_DebitCard");

            entity.ToTable("IncentiveTransactions_DebitCard_Issuance", tb => tb.HasTrigger("Trigger_OnUpdateIncentiveTransactions_DebitCard"));

            entity.Property(e => e.IncentiveTransactionsDebitCardId).HasColumnName("IncentiveTransactionsDebitCardID");
            entity.Property(e => e.Branch).HasMaxLength(200);
            entity.Property(e => e.BranchDesc).HasMaxLength(200);
            entity.Property(e => e.CardCategory).HasMaxLength(200);
            entity.Property(e => e.CardType).HasMaxLength(200);
            entity.Property(e => e.CardTypeDesc).HasMaxLength(200);
            entity.Property(e => e.CustomerTypeIndicator).HasMaxLength(200);
            entity.Property(e => e.EmployeeOracleNumber).HasMaxLength(200);
            entity.Property(e => e.ExpiryDate).HasMaxLength(200);
            entity.Property(e => e.IsMoved).HasDefaultValue(false);
            entity.Property(e => e.IssuanceDate).HasMaxLength(200);
            entity.Property(e => e.Maker).HasMaxLength(200);
            entity.Property(e => e.Nid)
                .HasMaxLength(200)
                .HasColumnName("NID");
            entity.Property(e => e.TokenNo).HasMaxLength(200);
        });

        modelBuilder.Entity<IncentiveTransactionsDebitCardTermination>(entity =>
        {
            entity.HasKey(e => e.IncentiveTransactionId);

            entity.ToTable("IncentiveTransactions_DebitCard_Termination", tb => tb.HasTrigger("Trigger_OnUpdateIncentiveTransactions_DebitCard_Termination"));

            entity.Property(e => e.IncentiveTransactionId).HasColumnName("IncentiveTransactionID");
            entity.Property(e => e.IsMoved).HasDefaultValue(false);
            entity.Property(e => e.TerminationDate).HasMaxLength(200);
            entity.Property(e => e.TokenNo).HasMaxLength(200);
        });

        modelBuilder.Entity<IncentiveTransactionsFinanceBranchIncentive>(entity =>
        {
            entity.ToTable("IncentiveTransactions_FinanceBranchIncentive");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount).HasMaxLength(22);
            entity.Property(e => e.BranchCode).HasMaxLength(50);
            entity.Property(e => e.BranchName).HasMaxLength(300);
            entity.Property(e => e.Constant1).HasMaxLength(300);
            entity.Property(e => e.Constant2).HasMaxLength(300);
            entity.Property(e => e.Constant3).HasMaxLength(300);
            entity.Property(e => e.Constant4).HasMaxLength(300);
            entity.Property(e => e.Currency).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(70);
            entity.Property(e => e.Glno)
                .HasMaxLength(50)
                .HasColumnName("GLNo");
            entity.Property(e => e.MonthName).HasMaxLength(50);
            entity.Property(e => e.Sequence).HasMaxLength(50);
            entity.Property(e => e.Transaction).HasMaxLength(10);
            entity.Property(e => e.YearName).HasMaxLength(50);
        });

        modelBuilder.Entity<IncentiveTransactionsInternetBanking>(entity =>
        {
            entity.ToTable("IncentiveTransactions_InternetBanking", tb => tb.HasTrigger("Trigger_OnUpdateIncentiveTransactions_InternetBanking"));

            entity.Property(e => e.IncentiveTransactionsInternetBankingId).HasColumnName("IncentiveTransactionsInternetBankingID");
            entity.Property(e => e.BranchCode).HasMaxLength(200);
            entity.Property(e => e.CifcreationDate)
                .HasMaxLength(200)
                .HasColumnName("CIFCreationDate");
            entity.Property(e => e.CsoracleId)
                .HasMaxLength(200)
                .HasColumnName("CSOracleID");
            entity.Property(e => e.CustomerCif)
                .HasMaxLength(200)
                .HasColumnName("CustomerCIF");
            entity.Property(e => e.CustomerNid)
                .HasMaxLength(200)
                .HasColumnName("CustomerNID");
            entity.Property(e => e.CustomerType).HasMaxLength(200);
            entity.Property(e => e.InternetBankingFlagDate).HasMaxLength(200);
            entity.Property(e => e.IsMoved).HasDefaultValue(false);
            entity.Property(e => e.RegistrationDate).HasMaxLength(200);
            entity.Property(e => e.RequestDate).HasMaxLength(200);
        });

        modelBuilder.Entity<IncentiveTransactionsInternetBankingFinal>(entity =>
        {
            entity.ToTable("IncentiveTransactions_InternetBanking_Final");

            entity.HasIndex(e => e.CustomerNid, "IX_IncentiveTransactions_InternetBanking_Final_CustomerNID");

            entity.Property(e => e.IncentiveTransactionsInternetBankingFinalId).HasColumnName("IncentiveTransactionsInternetBankingFinalID");
            entity.Property(e => e.BranchCode).HasMaxLength(200);
            entity.Property(e => e.CifcreationDate).HasColumnName("CIFCreationDate");
            entity.Property(e => e.CsoracleId)
                .HasMaxLength(200)
                .HasColumnName("CSOracleID");
            entity.Property(e => e.CustomerCif)
                .HasMaxLength(200)
                .HasColumnName("CustomerCIF");
            entity.Property(e => e.CustomerNid)
                .HasMaxLength(200)
                .HasColumnName("CustomerNID");
            entity.Property(e => e.CustomerType).HasMaxLength(200);
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
        });

        modelBuilder.Entity<IncentiveTransactionsLoan>(entity =>
        {
            entity.ToTable("IncentiveTransactions_Loan", tb => tb.HasTrigger("Trigger_OnUpdateIncentiveTransactions_Loan"));

            entity.HasIndex(e => e.IsMoved, "IX_IncentiveTransactions_Loan_IsMoved");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActualBookingDate).HasMaxLength(500);
            entity.Property(e => e.AdminFees).HasMaxLength(500);
            entity.Property(e => e.AdminFeesExceptionFlag).HasMaxLength(500);
            entity.Property(e => e.AdminFeesRate).HasMaxLength(500);
            entity.Property(e => e.BuyOutFlagForCashLoan).HasMaxLength(500);
            entity.Property(e => e.CompanyRank).HasMaxLength(500);
            entity.Property(e => e.CompanySector).HasMaxLength(500);
            entity.Property(e => e.CustomerCategory).HasMaxLength(500);
            entity.Property(e => e.CustomerFullName).HasMaxLength(500);
            entity.Property(e => e.CustomerId).HasMaxLength(500);
            entity.Property(e => e.GrossBookingAmount).HasMaxLength(500);
            entity.Property(e => e.GrossSalary).HasMaxLength(500);
            entity.Property(e => e.IncentiveSecured).HasMaxLength(500);
            entity.Property(e => e.InterestRate).HasMaxLength(500);
            entity.Property(e => e.InterestRateExceptionFlag).HasMaxLength(500);
            entity.Property(e => e.IsMoved).HasDefaultValue(false);
            entity.Property(e => e.LoanEclappliedRate)
                .HasMaxLength(500)
                .HasColumnName("LoanECLAppliedRate");
            entity.Property(e => e.LoanTenorPerMonth).HasMaxLength(500);
            entity.Property(e => e.MaturityDate).HasMaxLength(500);
            entity.Property(e => e.MobileNumber).HasMaxLength(500);
            entity.Property(e => e.NationalId).HasMaxLength(500);
            entity.Property(e => e.NetAchievedAmount).HasMaxLength(500);
            entity.Property(e => e.NetSalary).HasMaxLength(500);
            entity.Property(e => e.NewBranch).HasMaxLength(500);
            entity.Property(e => e.NewLoanNo).HasMaxLength(500);
            entity.Property(e => e.ProductDefaultRate).HasMaxLength(500);
            entity.Property(e => e.ProductName).HasMaxLength(500);
            entity.Property(e => e.ProductType).HasMaxLength(500);
            entity.Property(e => e.ReferralOracle).HasMaxLength(500);
            entity.Property(e => e.SellerOracle).HasMaxLength(500);
            entity.Property(e => e.TelesalesAchieved).HasMaxLength(500);
            entity.Property(e => e.TopUpFlag).HasMaxLength(500);
        });

        modelBuilder.Entity<IncentiveTransactionsLoanFinal>(entity =>
        {
            entity.ToTable("IncentiveTransactions_Loan_Final");

            entity.HasIndex(e => e.ActualBookingDate, "IX_IncentiveTransactions_Loan_Final_ActualBookingDate");

            entity.HasIndex(e => e.IsSecured, "IX_IncentiveTransactions_Loan_Final_IsSecured");

            entity.HasIndex(e => e.NewLoanNo, "IX_IncentiveTransactions_Loan_Final_NewLoanNo");

            entity.HasIndex(e => e.OwnerId, "IX_IncentiveTransactions_Loan_Final_OwnerID");

            entity.HasIndex(e => e.ReferrelUserId, "IX_IncentiveTransactions_Loan_Final_ReferrelUserID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActualBookingDate).HasColumnType("datetime");
            entity.Property(e => e.AdminFees).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AdminFeesExceptionFlag).HasDefaultValue(false);
            entity.Property(e => e.AdminFeesRate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BuyOutFlagForCashLoan).HasMaxLength(300);
            entity.Property(e => e.CompanyRank).HasMaxLength(300);
            entity.Property(e => e.CompanySector).HasMaxLength(300);
            entity.Property(e => e.CustomerCategory).HasMaxLength(300);
            entity.Property(e => e.CustomerFullName).HasMaxLength(200);
            entity.Property(e => e.CustomerId).HasMaxLength(50);
            entity.Property(e => e.GrossBookingAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GrossSalary).HasMaxLength(300);
            entity.Property(e => e.IncentiveAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IncentiveAmountBeforeCap).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IncentiveAmountCap).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InterestRate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InterestRateExceptionFlag).HasDefaultValue(false);
            entity.Property(e => e.LoanEclappliedRate)
                .HasMaxLength(300)
                .HasColumnName("LoanECLAppliedRate");
            entity.Property(e => e.LoanTenorPerMonth).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MobileNumber).HasMaxLength(300);
            entity.Property(e => e.NationalId).HasMaxLength(200);
            entity.Property(e => e.NetAchievedAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NetSalary).HasMaxLength(300);
            entity.Property(e => e.NewBranchCode).HasMaxLength(50);
            entity.Property(e => e.NewLoanNo).HasMaxLength(200);
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            entity.Property(e => e.ProductDefaultRate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductName).HasMaxLength(200);
            entity.Property(e => e.ProductType).HasMaxLength(200);
            entity.Property(e => e.ReferralIncentiveAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReferralOracle).HasMaxLength(200);
            entity.Property(e => e.ReferrelUserId).HasColumnName("ReferrelUserID");
            entity.Property(e => e.SellerOracle).HasMaxLength(200);
            entity.Property(e => e.TelesalesAchieved).HasMaxLength(300);

            entity.HasOne(d => d.Owner).WithMany(p => p.IncentiveTransactionsLoanFinalOwners)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK_IncentiveTransactions_Loan_Final_OwnerID");

            entity.HasOne(d => d.ReferrelUser).WithMany(p => p.IncentiveTransactionsLoanFinalReferrelUsers)
                .HasForeignKey(d => d.ReferrelUserId)
                .HasConstraintName("FK_IncentiveTransactions_Loan_Final_ReferrelUserID");
        });

        modelBuilder.Entity<IncentiveTransactionsLoanReversed>(entity =>
        {
            entity.ToTable("IncentiveTransactions_Loan_Reversed", tb => tb.HasTrigger("Trigger_OnUpdateIncentiveTransactions_Loan_Reversed"));

            entity.HasIndex(e => e.IsMoved, "IX_IncentiveTransactions_Loan_Reversed_IsMoved");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AdminFeesExceptionFlag).HasMaxLength(500);
            entity.Property(e => e.ClosedLoanDisbursementDate).HasMaxLength(500);
            entity.Property(e => e.ClosedLoanMaturityDate).HasMaxLength(500);
            entity.Property(e => e.ClosedLoanOldBranch).HasMaxLength(500);
            entity.Property(e => e.ClosedLoanProductName).HasMaxLength(500);
            entity.Property(e => e.ClosedLoanProductType).HasMaxLength(500);
            entity.Property(e => e.ClosingValueDate).HasMaxLength(500);
            entity.Property(e => e.GrossAmount).HasMaxLength(500);
            entity.Property(e => e.IncentiveSecured).HasMaxLength(500);
            entity.Property(e => e.InterestRateExceptionFlag).HasMaxLength(500);
            entity.Property(e => e.IsMoved).HasDefaultValue(false);
            entity.Property(e => e.LoanStatus).HasMaxLength(500);
            entity.Property(e => e.NewLoanNo).HasMaxLength(500);
            entity.Property(e => e.OldLoanNo).HasMaxLength(500);
            entity.Property(e => e.ReferralOracle).HasMaxLength(500);
            entity.Property(e => e.SellerOracle).HasMaxLength(500);
            entity.Property(e => e.TransactionDate).HasMaxLength(500);
        });

        modelBuilder.Entity<IncentiveTransactionsLoanReversedFinal>(entity =>
        {
            entity.ToTable("IncentiveTransactions_Loan_Reversed_Final");

            entity.HasIndex(e => e.IsSecured, "IX_IncentiveTransactions_Loan_Reversed_Final_IsSecured");

            entity.HasIndex(e => e.LoanStatus, "IX_IncentiveTransactions_Loan_Reversed_Final_LoanStatus");

            entity.HasIndex(e => e.NewLoanNo, "IX_IncentiveTransactions_Loan_Reversed_Final_NewLoanNo");

            entity.HasIndex(e => e.OwnerId, "IX_IncentiveTransactions_Loan_Reversed_Final_OwnerID");

            entity.HasIndex(e => e.TransactionDate, "IX_IncentiveTransactions_Loan_Reversed_Final_TransactionDate");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AdminFeesExceptionFlag).HasDefaultValue(false);
            entity.Property(e => e.ClosedLoanOldBranch).HasMaxLength(200);
            entity.Property(e => e.ClosedLoanProductName).HasMaxLength(200);
            entity.Property(e => e.ClosedLoanProductType).HasMaxLength(200);
            entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IncentiveAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IncentiveAmountBeforeCap).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IncentiveAmountCap).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InterestRateExceptionFlag).HasDefaultValue(false);
            entity.Property(e => e.IsSecured).HasDefaultValue(false);
            entity.Property(e => e.LoanStatus).HasMaxLength(200);
            entity.Property(e => e.NewLoanNo).HasMaxLength(200);
            entity.Property(e => e.OldLoanNo).HasMaxLength(200);
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            entity.Property(e => e.ReferralIncentiveAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReferralOracle).HasMaxLength(200);
            entity.Property(e => e.SellerOracle).HasMaxLength(200);

            entity.HasOne(d => d.Owner).WithMany(p => p.IncentiveTransactionsLoanReversedFinals)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK_IncentiveTransactions_Loan_Reversed_Final_OwnerID");
        });

        modelBuilder.Entity<IncentiveTransactionsNonSalesShareBranchIncentive>(entity =>
        {
            entity.ToTable("IncentiveTransactions_NonSalesShare_BranchIncentive");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BranchCode).HasMaxLength(50);
            entity.Property(e => e.TotalIncentiveAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<IncentiveTransactionsNonSalesShareCreditCardBranchIncentive>(entity =>
        {
            entity.ToTable("IncentiveTransactions_NonSalesShare_CreditCard_BranchIncentive");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BranchCode).HasMaxLength(50);
            entity.Property(e => e.IncentiveAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<IncentiveTransactionsNonSalesShareDebitCardBranchIncentive>(entity =>
        {
            entity.ToTable("IncentiveTransactions_NonSalesShare_DebitCard_BranchIncentive");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BranchCode).HasMaxLength(50);
            entity.Property(e => e.IncentiveAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<IncentiveTransactionsNonSalesShareLoanBranchIncentive>(entity =>
        {
            entity.ToTable("IncentiveTransactions_NonSalesShare_Loan_BranchIncentive");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BranchCode).HasMaxLength(50);
            entity.Property(e => e.IncentiveAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LoanNo).HasMaxLength(200);
        });

        modelBuilder.Entity<IncentiveTransactionsPayroll>(entity =>
        {
            entity.HasKey(e => e.IncentiveTransactionsPayrollId).HasName("PK_IncentiveTransactions_Payroll_IncentiveTransactionsPayrollID");

            entity.ToTable("IncentiveTransactions_Payroll", tb => tb.HasTrigger("Trigger_OnUpdateIncentiveTransactions_Payroll"));

            entity.Property(e => e.IncentiveTransactionsPayrollId).HasColumnName("IncentiveTransactionsPayrollID");
            entity.Property(e => e.Area).HasMaxLength(200);
            entity.Property(e => e.BmemployeeId)
                .HasMaxLength(200)
                .HasColumnName("BMEmployeeID");
            entity.Property(e => e.BranchName).HasMaxLength(200);
            entity.Property(e => e.BranchNumber).HasMaxLength(200);
            entity.Property(e => e.CompanyCode).HasMaxLength(200);
            entity.Property(e => e.CompanyName).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DbmemployeeId)
                .HasMaxLength(200)
                .HasColumnName("DBMEmployeeID");
            entity.Property(e => e.IncentiveTemplateProductImportHistoryId).HasColumnName("IncentiveTemplateProductImportHistoryID");
            entity.Property(e => e.IsMoved).HasDefaultValue(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.IncentiveTemplateProductImportHistory).WithMany(p => p.IncentiveTransactionsPayrolls)
                .HasForeignKey(d => d.IncentiveTemplateProductImportHistoryId)
                .HasConstraintName("FK__Incentive__Incen__108157BA");
        });

        modelBuilder.Entity<IncentiveTransactionsPayrollFinal>(entity =>
        {
            entity.ToTable("IncentiveTransactions_Payroll_Final");

            entity.Property(e => e.IncentiveTransactionsPayrollFinalId).HasColumnName("IncentiveTransactionsPayrollFinalID");
            entity.Property(e => e.Area).HasMaxLength(200);
            entity.Property(e => e.BmemployeeId)
                .HasMaxLength(200)
                .HasColumnName("BMEmployeeID");
            entity.Property(e => e.BmuserId).HasColumnName("BMUserID");
            entity.Property(e => e.BranchName).HasMaxLength(200);
            entity.Property(e => e.BranchNumber).HasMaxLength(200);
            entity.Property(e => e.CompanyCode).HasMaxLength(200);
            entity.Property(e => e.CompanyName).HasMaxLength(200);
            entity.Property(e => e.DbmemployeeId)
                .HasMaxLength(200)
                .HasColumnName("DBMEmployeeID");
            entity.Property(e => e.DbmuserId).HasColumnName("DBMUserID");
        });

        modelBuilder.Entity<IncentiveTransactionsPrepaidCard>(entity =>
        {
            entity.ToTable("IncentiveTransactions_PrepaidCard", tb => tb.HasTrigger("Trigger_OnUpdateIncentiveTransactions_PrepaidCard"));

            entity.Property(e => e.IncentiveTransactionsPrepaidCardId).HasColumnName("IncentiveTransactionsPrepaidCardID");
            entity.Property(e => e.ActivationDate).HasMaxLength(200);
            entity.Property(e => e.ActivatorBranch).HasMaxLength(200);
            entity.Property(e => e.CardType).HasMaxLength(200);
            entity.Property(e => e.EmployeeFileNo).HasMaxLength(200);
            entity.Property(e => e.ExpiryDate).HasMaxLength(200);
            entity.Property(e => e.IsMoved).HasDefaultValue(false);
            entity.Property(e => e.Status).HasMaxLength(200);
            entity.Property(e => e.TokenNo).HasMaxLength(200);
        });

        modelBuilder.Entity<IncentiveTransactionsPrepaidCardFinal>(entity =>
        {
            entity.ToTable("IncentiveTransactions_PrepaidCard_Final");

            entity.HasIndex(e => e.TokenNo, "IX_IncentiveTransactions_PrepaidCard_Final_TokenNo");

            entity.Property(e => e.IncentiveTransactionsPrepaidCardFinalId).HasColumnName("IncentiveTransactionsPrepaidCardFinalID");
            entity.Property(e => e.ActivatorBranch).HasMaxLength(200);
            entity.Property(e => e.CardType).HasMaxLength(200);
            entity.Property(e => e.EmployeeFileNo).HasMaxLength(200);
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            entity.Property(e => e.Status).HasMaxLength(200);
            entity.Property(e => e.TokenNo).HasMaxLength(200);
        });

        modelBuilder.Entity<IncentiveTransactionsReferral>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_IncentiveTransactions_ReferralOracle");

            entity.ToTable("IncentiveTransactions_Referral");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BranchCode).HasMaxLength(50);
            entity.Property(e => e.IncentiveProductTypeId).HasColumnName("IncentiveProductTypeID");
            entity.Property(e => e.NetIncentiveAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReferralOracleId)
                .HasMaxLength(200)
                .HasColumnName("ReferralOracleID");
        });

        modelBuilder.Entity<IncentiveUserTemplateCcprimaryLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_IncetiveUserTemplateCCPrimaryLogs");

            entity.ToTable("IncentiveUserTemplateCCPrimaryLogs");

            entity.HasIndex(e => new { e.UserId, e.Month, e.Year, e.CreditCardTypeId, e.GranteeTypeId }, "IX_IncetiveUserTemplateCCPrimaryLogsUniqueIndex").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClawBackValue).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ClawBackValueTypeId).HasColumnName("ClawBackValueTypeID");
            entity.Property(e => e.CreditCardTypeId).HasColumnName("CreditCardTypeID");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.GranteeTypeId).HasColumnName("GranteeTypeID");
            entity.Property(e => e.IncentiveAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.IsClawBackApplicable).HasDefaultValue(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<IncentiveUserTemplateCcsupplementaryLog>(entity =>
        {
            entity.ToTable("IncentiveUserTemplateCCSupplementaryLogs");

            entity.HasIndex(e => new { e.UserId, e.Month, e.Year, e.CreditCardTypeId, e.GranteeTypeId }, "IX_IncentiveUserTemplateCCSupplementaryLogsUniqueIndex").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClawBackValue).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ClawBackValueTypeId).HasColumnName("ClawBackValueTypeID");
            entity.Property(e => e.CreditCardTypeId).HasColumnName("CreditCardTypeID");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.GranteeTypeId).HasColumnName("GranteeTypeID");
            entity.Property(e => e.IncentiveAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.IsClawBackApplicable).HasDefaultValue(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<IncentiveUserTemplateDebitCardConfigurationLog>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DebitCardTypeId).HasColumnName("DebitCardTypeID");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IncentiveAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<IncentiveUserTemplateLog>(entity =>
        {
            entity.HasIndex(e => new { e.UserId, e.Month, e.Year }, "IX_IncentiveUserTemplateLogsUniqueIndex").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BeforeClawbackCap).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CcActivationDuration).HasColumnName("CC_ActivationDuration");
            entity.Property(e => e.CcActivationUnit).HasColumnName("CC_ActivationUnit");
            entity.Property(e => e.ClawbackCap).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CreditCardTierGroupId).HasColumnName("CreditCardTierGroupID");
            entity.Property(e => e.LsincentiveFactor)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("LSIncentiveFactor");
            entity.Property(e => e.LuincentiveFactor)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("LUIncentiveFactor");
            entity.Property(e => e.NetIncentiveCap).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ReferralShare).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.RoleShare).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TemplateName).HasMaxLength(500);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.CreditCardTierGroup).WithMany(p => p.IncentiveUserTemplateLogs)
                .HasForeignKey(d => d.CreditCardTierGroupId)
                .HasConstraintName("FK_IncentiveUserTemplateLogs_IncentiveCreditCardTierGroup");
        });

        modelBuilder.Entity<IncentiveUserWiseMonthProRataStat>(entity =>
        {
            entity.HasIndex(e => e.IncentiveProductTypeId, "IX_IncentiveUserWiseMonthProRataStats_IncentiveProductTypeId");

            entity.HasIndex(e => e.Month, "IX_IncentiveUserWiseMonthProRataStats_Month");

            entity.HasIndex(e => e.OrganisationId, "IX_IncentiveUserWiseMonthProRataStats_OrganisationID");

            entity.HasIndex(e => e.UserId, "IX_IncentiveUserWiseMonthProRataStats_UserID");

            entity.HasIndex(e => e.Year, "IX_IncentiveUserWiseMonthProRataStats_Year");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Achieved).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AchievedPercentageAfterWeightage).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.AchievementPercentage).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CompanyAchieved).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompanyAchievedPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompanyTarget).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CreatedAt).HasMaxLength(300);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EmployeeAchieved).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmployeeAchievedPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmployeeTarget).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.IncentiveAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.LoansIncentiveFactor).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ModifiedAt).HasMaxLength(300);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ReferralAchieved).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SelfAchieved).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Target).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Weightage).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<IncentiveUserWiseMonthlyStat>(entity =>
        {
            entity.HasIndex(e => e.IncentiveProductTypeId, "IX_IncentiveUserWiseMonthlyStats_IncentiveProductTypeId");

            entity.HasIndex(e => e.Month, "IX_IncentiveUserWiseMonthlyStats_Month");

            entity.HasIndex(e => e.OrganisationId, "IX_IncentiveUserWiseMonthlyStats_OrganisationID");

            entity.HasIndex(e => e.UserId, "IX_IncentiveUserWiseMonthlyStats_UserID");

            entity.HasIndex(e => e.Year, "IX_IncentiveUserWiseMonthlyStats_Year");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Achieved).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AchievedPercentageAfterWeightage).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.AchievementPercentage).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Area).HasMaxLength(400);
            entity.Property(e => e.BranchCode).HasMaxLength(400);
            entity.Property(e => e.BranchName).HasMaxLength(400);
            entity.Property(e => e.ClawbackAmountAfterCap).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ClawbackAmountBeforeCap).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompanyAchieved).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompanyAchievedPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedAt).HasMaxLength(300);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EmployeeAchieved).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmployeeAchievedPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IncentiveAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(300);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NetIncentiveAmountBeforeCap).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ReferralAchieved).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReversedReferralAchieved).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReversedSelfAchieved).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SelfAchieved).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Target).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalIncentiveAmountBeforeClawbackAfterCap).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalIncentiveAmountBeforeClawbackBeforeCap).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Weightage).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.IncentiveProductType).WithMany(p => p.IncentiveUserWiseMonthlyStats)
                .HasForeignKey(d => d.IncentiveProductTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncentiveUserWiseMonthlyStats_IncentiveProductType");

            entity.HasOne(d => d.Organisation).WithMany(p => p.IncentiveUserWiseMonthlyStats)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_IncentiveUserWiseMonthlyStats_Organisations");
        });

        modelBuilder.Entity<IncentiveUserWiseNonMonthlyProductStat>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Achieved).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AchievedPercentageAfterWeightage).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.AchievementPercentage).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Area).HasMaxLength(400);
            entity.Property(e => e.BranchCode).HasMaxLength(400);
            entity.Property(e => e.BranchName).HasMaxLength(400);
            entity.Property(e => e.ClawbackAmountAfterCap).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ClawbackAmountBeforeCap).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompanyAchieved).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompanyAchievedPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedAt).HasMaxLength(300);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EmployeeAchieved).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmployeeAchievedPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IncentiveAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(300);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NetIncentiveAmountBeforeCap).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ReferralAchieved).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReversedReferralAchieved).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReversedSelfAchieved).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SelfAchieved).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Target).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalIncentiveAmountBeforeClawbackAfterCap).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalIncentiveAmountBeforeClawbackBeforeCap).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Weightage).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.IncentiveProductType).WithMany(p => p.IncentiveUserWiseNonMonthlyProductStats)
                .HasForeignKey(d => d.IncentiveProductTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncentiveUserWiseNonMonthlyProductStats_IncentiveProductType");

            entity.HasOne(d => d.Organisation).WithMany(p => p.IncentiveUserWiseNonMonthlyProductStats)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_IncentiveUserWiseNonMonthlyProductStats_Organisations");
        });

        modelBuilder.Entity<InternalMessageStatus>(entity =>
        {
            entity.ToTable("InternalMessageStatus");

            entity.Property(e => e.InternalMessageStatusId).HasColumnName("InternalMessageStatusID");
            entity.Property(e => e.DeliverDateTime).HasColumnType("datetime");
            entity.Property(e => e.DeliverStatus).HasDefaultValue(false);
            entity.Property(e => e.InternalMessageId).HasColumnName("InternalMessageID");
            entity.Property(e => e.ReadDateTime).HasColumnType("datetime");
            entity.Property(e => e.ReadStatus).HasDefaultValue(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.InternalMessage).WithMany(p => p.InternalMessageStatuses)
                .HasForeignKey(d => d.InternalMessageId)
                .HasConstraintName("FK_InternalMessageStatus_InternalMessaging");

            entity.HasOne(d => d.User).WithMany(p => p.InternalMessageStatuses)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_InternalMessageStatus_Users");
        });

        modelBuilder.Entity<InternalMessaging>(entity =>
        {
            entity.HasKey(e => e.InternalMessageId);

            entity.ToTable("InternalMessaging");

            entity.HasIndex(e => e.ServerDateTime, "IX_InternalMessaging_ServerDateTime");

            entity.Property(e => e.InternalMessageId).HasColumnName("InternalMessageID");
            entity.Property(e => e.CreatedAt).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.MessageDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedAt).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SendById).HasColumnName("SendByID");
            entity.Property(e => e.SendToId).HasColumnName("SendToID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.SendBy).WithMany(p => p.InternalMessagingSendBies)
                .HasForeignKey(d => d.SendById)
                .HasConstraintName("FK_InternalMessaging_Users");

            entity.HasOne(d => d.SendTo).WithMany(p => p.InternalMessagingSendTos)
                .HasForeignKey(d => d.SendToId)
                .HasConstraintName("FK_InternalMessaging_Users1");
        });

        modelBuilder.Entity<JobTitleParentJobTitleMapping>(entity =>
        {
            entity.HasKey(e => e.MappingId);

            entity.ToTable("JobTitleParentJobTitleMapping", tb => tb.HasTrigger("Trigger_OnInsertUpdateJobTitleParentJobTitleMappings"));

            entity.Property(e => e.MappingId).HasColumnName("MappingID");
            entity.Property(e => e.BranchCode).HasMaxLength(300);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DigiRole).HasMaxLength(300);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.JobTitle).HasMaxLength(300);
            entity.Property(e => e.JobTitleParentJobTitleMappingImportHistoryId).HasColumnName("JobTitleParentJobTitleMappingImportHistoryID");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ParentJobTitle).HasMaxLength(300);
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");
            entity.Property(e => e.ShortRole).HasMaxLength(300);
        });

        modelBuilder.Entity<JobTitleParentJobTitleMappingImportFieldSetting>(entity =>
        {
            entity.HasKey(e => e.JobTitleParentJobTitleMappingFieldSettingId).HasName("PK_JobTitleParentJobTitleMappingFieldSettings");

            entity.Property(e => e.JobTitleParentJobTitleMappingFieldSettingId).HasColumnName("JobTitleParentJobTitleMappingFieldSettingID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.Expression).HasMaxLength(100);
            entity.Property(e => e.FieldDataType).HasMaxLength(50);
            entity.Property(e => e.FieldLabel).HasMaxLength(100);
            entity.Property(e => e.FieldName).HasMaxLength(100);
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.JobTitleParentJobTitleMappingImportFieldSettings)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobTitleParentJobTitleMappingFieldSettings_JobTitleParentJobTitleMappingFieldSettings");
        });

        modelBuilder.Entity<JobTitleParentJobTitleMappingImportFieldSettingMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_JobTitleParentJobTitleMappingSettingMaster");

            entity.ToTable("JobTitleParentJobTitleMappingImportFieldSettingMaster");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FieldDataType).HasMaxLength(100);
            entity.Property(e => e.FieldLabel).HasMaxLength(200);
            entity.Property(e => e.FieldName).HasMaxLength(200);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsMandatory).HasDefaultValue(false);
            entity.Property(e => e.IsStaticField).HasDefaultValue(true);
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<JobTitleParentJobTitleMappingImportHistory>(entity =>
        {
            entity.HasKey(e => e.JobTitleParentJobTitleMappingImportHistoryId).HasName("PK__JobTitle__5780D6F55706388F");

            entity.ToTable("JobTitleParentJobTitleMappingImportHistory");

            entity.Property(e => e.JobTitleParentJobTitleMappingImportHistoryId).HasColumnName("JobTitleParentJobTitleMappingImportHistoryID");
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.ImportTimeStamp).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsReverted).HasDefaultValue(false);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.UploadedAt).HasMaxLength(200);
            entity.Property(e => e.UploadedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.JobTitleParentJobTitleMappingImportHistories)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK__JobTitleP__Organ__27AFA12C");
        });

        modelBuilder.Entity<JobTitleParentJobTitleMappingImportMapping>(entity =>
        {
            entity.HasKey(e => e.JobTitleParentJobTitleMappingImportMappingId).HasName("PK__JobTitle__94BB6045AEA362BD");

            entity.ToTable("JobTitleParentJobTitleMappingImportMapping");

            entity.Property(e => e.JobTitleParentJobTitleMappingImportMappingId).HasColumnName("JobTitleParentJobTitleMappingImportMappingID");
            entity.Property(e => e.ImportFieldNameFromFile).HasMaxLength(100);
            entity.Property(e => e.ImportHistoryId).HasColumnName("ImportHistoryID");
            entity.Property(e => e.JobTitleParentJobTitleMappingFieldSettingId).HasColumnName("JobTitleParentJobTitleMappingFieldSettingID");

            entity.HasOne(d => d.ImportHistory).WithMany(p => p.JobTitleParentJobTitleMappingImportMappings)
                .HasForeignKey(d => d.ImportHistoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__JobTitleParentJobTitleMappingImportMapping__ImportHistoryID");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.LanguageId).HasName("PK_SupportedLanguages");

            entity.Property(e => e.LanguageId).HasColumnName("LanguageID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(500)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<LanguageSpeak>(entity =>
        {
            entity.ToTable("LanguageSpeak");

            entity.Property(e => e.LanguageSpeakId).HasColumnName("LanguageSpeakID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<LanguageSpeakRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LanguageSpeakRelatedData");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LanguageSpeakId).HasColumnName("LanguageSpeakID");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
        });

        modelBuilder.Entity<LicensePaymentStatus>(entity =>
        {
            entity.ToTable("LicensePaymentStatus");

            entity.Property(e => e.LicensePaymentStatusId).HasColumnName("LicensePaymentStatusID");
            entity.Property(e => e.PaymentStatusName).HasMaxLength(200);
        });

        modelBuilder.Entity<LicenseReferral>(entity =>
        {
            entity.Property(e => e.LicenseReferralId).HasColumnName("LicenseReferralID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.HubSpotStatusId).HasColumnName("HubSpotStatusID");
            entity.Property(e => e.IsSyncWithHs)
                .HasDefaultValue(false)
                .HasColumnName("IsSyncWithHS");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ReferralCode).HasMaxLength(200);
            entity.Property(e => e.ReferralCodeUsedDate).HasColumnType("datetime");
            entity.Property(e => e.ReferralEmail).HasMaxLength(50);
            entity.Property(e => e.ReferredByOrganisationId).HasColumnName("ReferredByOrganisationID");
            entity.Property(e => e.ReferredByUserId).HasColumnName("ReferredByUserID");
            entity.Property(e => e.ReferredDate).HasColumnType("datetime");
            entity.Property(e => e.ReferredToOrganisationId).HasColumnName("ReferredToOrganisationID");
            entity.Property(e => e.ReferredToUserId).HasColumnName("ReferredToUserID");

            entity.HasOne(d => d.ReferredByOrganisation).WithMany(p => p.LicenseReferrals)
                .HasForeignKey(d => d.ReferredByOrganisationId)
                .HasConstraintName("FK_LicenseReferrals_Organisations");

            entity.HasOne(d => d.ReferredByUser).WithMany(p => p.LicenseReferralReferredByUsers)
                .HasForeignKey(d => d.ReferredByUserId)
                .HasConstraintName("FK_LicenseReferrals_Users");

            entity.HasOne(d => d.ReferredToUser).WithMany(p => p.LicenseReferralReferredToUsers)
                .HasForeignKey(d => d.ReferredToUserId)
                .HasConstraintName("FK_LicenseReferrals_Users1");
        });

        modelBuilder.Entity<LicenseReferralPercentage>(entity =>
        {
            entity.ToTable("LicenseReferralPercentage");

            entity.Property(e => e.LicenseReferralPercentageId).HasColumnName("LicenseReferralPercentageID");
            entity.Property(e => e.ReferralPercentage).HasColumnType("numeric(5, 2)");
        });

        modelBuilder.Entity<LicenseReferralTransaction>(entity =>
        {
            entity.Property(e => e.LicenseReferralTransactionId).HasColumnName("LicenseReferralTransactionID");
            entity.Property(e => e.LicenseReferralId).HasColumnName("LicenseReferralID");
            entity.Property(e => e.LicenseReferralTransactionStatusId).HasColumnName("LicenseReferralTransactionStatusID");
            entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.LicenseReferral).WithMany(p => p.LicenseReferralTransactions)
                .HasForeignKey(d => d.LicenseReferralId)
                .HasConstraintName("FK_LicenseReferralTransactions_LicenseReferrals");

            entity.HasOne(d => d.LicenseReferralTransactionStatus).WithMany(p => p.LicenseReferralTransactions)
                .HasForeignKey(d => d.LicenseReferralTransactionStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LicenseReferralTransactions_LicenseReferralTransactionStatus");

            entity.HasOne(d => d.User).WithMany(p => p.LicenseReferralTransactions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_LicenseReferralTransactions_Users");
        });

        modelBuilder.Entity<LicenseReferralTransactionStatus>(entity =>
        {
            entity.ToTable("LicenseReferralTransactionStatus");

            entity.Property(e => e.LicenseReferralTransactionStatusId).HasColumnName("LicenseReferralTransactionStatusID");
            entity.Property(e => e.ReferralTransactionStatus).HasMaxLength(50);
        });

        modelBuilder.Entity<LicenseTransaction>(entity =>
        {
            entity.HasKey(e => e.LicenseTransactionId).HasName("PK_Licenses");

            entity.Property(e => e.LicenseTransactionId).HasColumnName("LicenseTransactionID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LicenseTransationStatusId)
                .HasDefaultValue(0L)
                .HasColumnName("LicenseTransationStatusID");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.LicenseTransationStatus).WithMany(p => p.LicenseTransactions)
                .HasForeignKey(d => d.LicenseTransationStatusId)
                .HasConstraintName("FK_LicenseTransactions_LicenseTransactionStatus");

            entity.HasOne(d => d.Organisation).WithMany(p => p.LicenseTransactions)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_LicenseTransactions_Organisations");
        });

        modelBuilder.Entity<LicenseTransactionStatus>(entity =>
        {
            entity.HasKey(e => e.LicenseTransactionStatusId).HasName("PK_TransactionStatus");

            entity.ToTable("LicenseTransactionStatus");

            entity.Property(e => e.LicenseTransactionStatusId).HasColumnName("LicenseTransactionStatusID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<LicenseVoucherCode>(entity =>
        {
            entity.HasKey(e => e.VoucherCodeId).HasName("PK_VoucherCode");

            entity.ToTable("LicenseVoucherCode");

            entity.Property(e => e.VoucherCodeId).HasColumnName("VoucherCodeID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.VoucherCode).HasMaxLength(50);
        });

        modelBuilder.Entity<MasterPage>(entity =>
        {
            entity.HasKey(e => e.MasterPageId).HasName("PK__MasterPa__16D1D10C5DFA0EC0");

            entity.ToTable("MasterPage");

            entity.Property(e => e.MasterPageId).HasColumnName("MasterPageID");
            entity.Property(e => e.PageCode).HasMaxLength(100);
            entity.Property(e => e.TableName).HasMaxLength(250);
            entity.Property(e => e.ViewName).HasMaxLength(500);
        });

        modelBuilder.Entity<MasterPageAuditTrail>(entity =>
        {
            entity.HasKey(e => e.AuditId).HasName("PK__MasterPa__A17F23B83CA9743E");

            entity.ToTable("MasterPageAuditTrail");

            entity.Property(e => e.AuditId).HasColumnName("AuditID");
            entity.Property(e => e.ActionType).HasMaxLength(250);
            entity.Property(e => e.ActionedOn).HasMaxLength(250);
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.MasterPageName).HasMaxLength(250);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
        });

        modelBuilder.Entity<MasterPageField>(entity =>
        {
            entity.HasKey(e => e.MasterPageFieldId).HasName("PK__MasterPa__C831C0FD10C65EBB");

            entity.Property(e => e.MasterPageFieldId).HasColumnName("MasterPageFieldID");
            entity.Property(e => e.ColumnTextField).HasMaxLength(500);
            entity.Property(e => e.FieldName).HasMaxLength(250);
            entity.Property(e => e.MasterPageId).HasColumnName("MasterPageID");

            entity.HasOne(d => d.MasterPage).WithMany(p => p.MasterPageFields)
                .HasForeignKey(d => d.MasterPageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MasterPageFields_MasterPage");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.MenuId).HasName("PK_Menu");

            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IsDefaultHomePage).HasDefaultValue(false);
            entity.Property(e => e.MenuUrl).HasColumnName("MenuURL");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NameOl1).HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2).HasColumnName("Name_OL2");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MenuAction>(entity =>
        {
            entity.ToTable("MenuAction");

            entity.Property(e => e.ActionName).HasMaxLength(300);
            entity.Property(e => e.ControllerName).HasMaxLength(300);
            entity.Property(e => e.MenuId).HasColumnName("MenuID");

            entity.HasOne(d => d.Menu).WithMany(p => p.MenuActions)
                .HasForeignKey(d => d.MenuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MenuAction_Menus1");
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<MonthlyIncentiveProductType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MonthlyIncentiveProductType");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ProductName).HasMaxLength(200);
        });

        modelBuilder.Entity<NationalIdType>(entity =>
        {
            entity.Property(e => e.NationalIdTypeId).HasColumnName("NationalIdTypeID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsDefault).HasDefaultValue(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.NationalIdTypeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_NationalIdTypes_CreatedBy_Users");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.NationalIdTypeModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_NationalIdTypes_ModifiedBy_Users");

            entity.HasOne(d => d.Organisation).WithMany(p => p.NationalIdTypes)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_NationalIdTypes_Organisations");
        });

        modelBuilder.Entity<Nationality>(entity =>
        {
            entity.ToTable("Nationality");

            entity.Property(e => e.NationalityId).HasColumnName("NationalityID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsDefault).HasDefaultValue(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.NationalityCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_Nationality_CreatedBy_Users");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.NationalityModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_Nationality_ModifiedBy_Users");

            entity.HasOne(d => d.Organisation).WithMany(p => p.Nationalities)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_Nationality_Organisations");
        });

        modelBuilder.Entity<Note>(entity =>
        {
            entity.HasIndex(e => e.ContactId, "IX_Notes_ContactID");

            entity.HasIndex(e => e.CreatedBy, "IX_Notes_CreatedBy");

            entity.HasIndex(e => e.CreatedOn, "IX_Notes_CreatedOn");

            entity.HasIndex(e => e.EntityId, "IX_Notes_EntityID");

            entity.HasIndex(e => e.ModuleId, "IX_Notes_ModuleID");

            entity.HasIndex(e => e.RepresentativeId, "IX_Notes_RepresentativeID");

            entity.HasIndex(e => e.ServerDateTime, "IX_Notes_ServerDateTime");

            entity.Property(e => e.NoteId).HasColumnName("NoteID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.EntityId).HasColumnName("EntityID");
            entity.Property(e => e.IsDeleteRequestRaised).HasDefaultValue(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.RepresentativeId).HasColumnName("RepresentativeID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SyncedInCrm)
                .HasDefaultValue(false)
                .HasColumnName("SyncedInCRM");

            entity.HasOne(d => d.Contact).WithMany(p => p.Notes)
                .HasForeignKey(d => d.ContactId)
                .HasConstraintName("FK_Notes_Contacts");

            entity.HasOne(d => d.Module).WithMany(p => p.Notes)
                .HasForeignKey(d => d.ModuleId)
                .HasConstraintName("FK_Notes_Modules");

            entity.HasOne(d => d.Organisation).WithMany(p => p.Notes)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_Notes_Organisations");
        });

        modelBuilder.Entity<Organisation>(entity =>
        {
            entity.HasKey(e => e.OrganisationId).HasName("PK_Organisation");

            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceObjId).HasColumnName("DeviceObjID");
            entity.Property(e => e.IndustryId).HasColumnName("IndustryID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NameOl1).HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2).HasColumnName("Name_OL2");
            entity.Property(e => e.OrganisationTypeId).HasColumnName("OrganisationTypeID");
            entity.Property(e => e.ParentOrganisationId).HasColumnName("ParentOrganisationID");
            entity.Property(e => e.PhoneNo).HasMaxLength(200);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SourceId).HasColumnName("SourceID");
            entity.Property(e => e.TimeZoneId).HasColumnName("TimeZoneID");
            entity.Property(e => e.Website).HasMaxLength(200);

            entity.HasOne(d => d.Industry).WithMany(p => p.Organisations)
                .HasForeignKey(d => d.IndustryId)
                .HasConstraintName("FK_Organisations_OrganisationIndustry");

            entity.HasOne(d => d.OrganisationType).WithMany(p => p.Organisations)
                .HasForeignKey(d => d.OrganisationTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Organisations_OrganisationTypes");

            entity.HasOne(d => d.Source).WithMany(p => p.Organisations)
                .HasForeignKey(d => d.SourceId)
                .HasConstraintName("FK_Organisations_OrganisationSource");

            entity.HasOne(d => d.TimeZone).WithMany(p => p.Organisations)
                .HasForeignKey(d => d.TimeZoneId)
                .HasConstraintName("FK_Organisations_TimeZones");
        });

        modelBuilder.Entity<OrganisationAdgroupMapping>(entity =>
        {
            entity.HasKey(e => e.AdmappingId);

            entity.ToTable("OrganisationADGroupMapping");

            entity.Property(e => e.AdmappingId).HasColumnName("ADMappingID");
            entity.Property(e => e.Adgroup).HasColumnName("ADGroup");
            entity.Property(e => e.IsRestrictedFromOwnership).HasDefaultValue(false);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.RestrictOtherContactSearch).HasDefaultValue(false);
            entity.Property(e => e.WorkflowGroup).HasMaxLength(200);
        });

        modelBuilder.Entity<OrganisationCurrencyMapping>(entity =>
        {
            entity.ToTable("OrganisationCurrencyMapping");

            entity.Property(e => e.OrganisationCurrencyMappingId).HasColumnName("OrganisationCurrencyMappingID");
            entity.Property(e => e.BaseCurrencyId).HasColumnName("BaseCurrencyID");
            entity.Property(e => e.ConversionValue).HasColumnType("numeric(18, 4)");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(500)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Currency).WithMany(p => p.OrganisationCurrencyMappings)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrganisationCurrencyMapping_Currencies");

            entity.HasOne(d => d.Organisation).WithMany(p => p.OrganisationCurrencyMappings)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrganisationCurrencyMapping_Organisations");
        });

        modelBuilder.Entity<OrganisationIndustry>(entity =>
        {
            entity.HasKey(e => e.IndustryId);

            entity.ToTable("OrganisationIndustry");

            entity.Property(e => e.IndustryId).HasColumnName("IndustryID");
        });

        modelBuilder.Entity<OrganisationModulePermission>(entity =>
        {
            entity.HasKey(e => e.OrganisationModulePermissionId).HasName("PK_OrganisationModulePermission");

            entity.Property(e => e.OrganisationModulePermissionId).HasColumnName("OrganisationModulePermissionID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(500)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Module).WithMany(p => p.OrganisationModulePermissions)
                .HasForeignKey(d => d.ModuleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrganisationModulePermissions_Modules");

            entity.HasOne(d => d.Organisation).WithMany(p => p.OrganisationModulePermissions)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrganisationModulePermission_Organisations");
        });

        modelBuilder.Entity<OrganisationProductFamilyMapping>(entity =>
        {
            entity.ToTable("OrganisationProductFamilyMapping");

            entity.Property(e => e.OrganisationProductFamilyMappingId).HasColumnName("OrganisationProductFamilyMappingID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ProductFamilyId).HasColumnName("ProductFamilyID");
            entity.Property(e => e.SalesMethodId).HasColumnName("SalesMethodID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.OrganisationProductFamilyMappings)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_OrganisationProductFamilyMapping_Organisations");

            entity.HasOne(d => d.ProductFamily).WithMany(p => p.OrganisationProductFamilyMappings)
                .HasForeignKey(d => d.ProductFamilyId)
                .HasConstraintName("FK_OrganisationProductFamilyMapping_ProductFamily");
        });

        modelBuilder.Entity<OrganisationRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("OrganisationRelatedData");

            entity.Property(e => e.Name).HasColumnName("NAME");
            entity.Property(e => e.OrganisationSettingsMappingId).HasColumnName("OrganisationSettingsMappingID");
        });

        modelBuilder.Entity<OrganisationSetting>(entity =>
        {
            entity.HasIndex(e => e.SettingsKey, "IX_OrganisationSettings_SettingsKey");

            entity.Property(e => e.OrganisationSettingId).HasColumnName("OrganisationSettingID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DescriptionOl1).HasColumnName("Description_OL1");
            entity.Property(e => e.DescriptionOl2).HasColumnName("Description_OL2");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.DisplayNameOl1).HasColumnName("DisplayName_OL1");
            entity.Property(e => e.DisplayNameOl2).HasColumnName("DisplayName_OL2");
            entity.Property(e => e.ForBe).HasColumnName("ForBE");
            entity.Property(e => e.ForLob).HasColumnName("ForLOB");
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SettingControlTypeId).HasColumnName("SettingControlTypeID");
            entity.Property(e => e.SettingsKey).HasMaxLength(400);

            entity.HasOne(d => d.SettingControlType).WithMany(p => p.OrganisationSettings)
                .HasForeignKey(d => d.SettingControlTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Settings_SettingControlTypes");
        });

        modelBuilder.Entity<OrganisationSettingMapping>(entity =>
        {
            entity.HasKey(e => e.OrganisationSettingsMappingId).HasName("PK_OrganisationSettingsMapping");

            entity.ToTable("OrganisationSettingMapping");

            entity.HasIndex(e => e.OrganisationId, "IX_OrganisationSettingMapping_OrganisationID");

            entity.HasIndex(e => e.OrganisationSettingId, "IX_OrganisationSettingMapping_OrganisationSettingID");

            entity.Property(e => e.OrganisationSettingsMappingId).HasColumnName("OrganisationSettingsMappingID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.OrganisationSettingId).HasColumnName("OrganisationSettingID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SettingsValue).HasMaxLength(512);

            entity.HasOne(d => d.Organisation).WithMany(p => p.OrganisationSettingMappings)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrganisationSettingMapping_Organisations");

            entity.HasOne(d => d.OrganisationSetting).WithMany(p => p.OrganisationSettingMappings)
                .HasForeignKey(d => d.OrganisationSettingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrganisationSettingMapping_Settings");
        });

        modelBuilder.Entity<OrganisationSource>(entity =>
        {
            entity.HasKey(e => e.SourceId);

            entity.ToTable("OrganisationSource");

            entity.Property(e => e.SourceId).HasColumnName("SourceID");
        });

        modelBuilder.Entity<OrganisationTierMapping>(entity =>
        {
            entity.ToTable("OrganisationTierMapping");

            entity.Property(e => e.OrganisationTierMappingId).HasColumnName("OrganisationTierMappingID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceObjId).HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.NameOl1)
                .HasMaxLength(500)
                .HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2)
                .HasMaxLength(500)
                .HasColumnName("Name_OL2");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TierId).HasColumnName("TierID");
            entity.Property(e => e.TierReminderDurationUnitId).HasColumnName("TierReminderDurationUnitID");

            entity.HasOne(d => d.Organisation).WithMany(p => p.OrganisationTierMappings)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrganisationTierMapping_Organisations");

            entity.HasOne(d => d.Tier).WithMany(p => p.OrganisationTierMappings)
                .HasForeignKey(d => d.TierId)
                .HasConstraintName("FK_OrganisationTierMapping_Tiers");
        });

        modelBuilder.Entity<OrganisationTierRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("OrganisationTierRelatedData");

            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.OrganisationTierMappingId).HasColumnName("OrganisationTierMappingID");
        });

        modelBuilder.Entity<OrganisationType>(entity =>
        {
            entity.HasKey(e => e.OrganisationTypeId).HasName("PK_OrganisationType");

            entity.Property(e => e.OrganisationTypeId).HasColumnName("OrganisationTypeID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(500)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TitleOl1).HasColumnName("Title_OL1");
            entity.Property(e => e.TitleOl2).HasColumnName("Title_OL2");
        });

        modelBuilder.Entity<PortfolioTransferStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId);

            entity.ToTable("PortfolioTransferStatus");

            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK_Product");

            entity.HasIndex(e => e.IsDeleted, "IX_Products_IsDeleted");

            entity.HasIndex(e => e.Name, "IX_Products_Name");

            entity.HasIndex(e => e.OrganisationId, "IX_Products_OrganisationID");

            entity.HasIndex(e => e.ProductFamilyId, "IX_Products_ProductFamilyID");

            entity.HasIndex(e => e.ServerDateTime, "IX_Products_ServerDateTime");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceId).HasColumnName("DeviceID");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(100)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsDefault).HasDefaultValue(false);
            entity.Property(e => e.IsSystemEntry).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(4000);
            entity.Property(e => e.NameOl1)
                .HasMaxLength(4000)
                .HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2)
                .HasMaxLength(4000)
                .HasColumnName("Name_OL2");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ProductFamilyId).HasColumnName("ProductFamilyID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.Products)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_Products_Organisations");

            entity.HasOne(d => d.ProductFamily).WithMany(p => p.Products)
                .HasForeignKey(d => d.ProductFamilyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Products_ProductFamily");
        });

        modelBuilder.Entity<ProductDynamicField>(entity =>
        {
            entity.Property(e => e.ProductDynamicFieldId).HasColumnName("ProductDynamicFieldID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductDynamicFields)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductDynamicFields_Products");
        });

        modelBuilder.Entity<ProductFamily>(entity =>
        {
            entity.ToTable("ProductFamily");

            entity.Property(e => e.ProductFamilyId).HasColumnName("ProductFamilyID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(100)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IsDefault).HasDefaultValue(false);
            entity.Property(e => e.IsSystemEntry).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(4000);
            entity.Property(e => e.NameOl1)
                .HasMaxLength(4000)
                .HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2)
                .HasMaxLength(4000)
                .HasColumnName("Name_OL2");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.ProductFamilies)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductFamily_Organisations");
        });

        modelBuilder.Entity<ProductFamilyRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ProductFamilyRelatedData");

            entity.Property(e => e.Name).HasMaxLength(4000);
            entity.Property(e => e.ProductFamilyId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ProductFamilyID");
        });

        modelBuilder.Entity<ProductListRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ProductListRelatedData");

            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.FamilyName).HasMaxLength(4000);
            entity.Property(e => e.Name).HasMaxLength(4000);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
        });

        modelBuilder.Entity<ProductScheme>(entity =>
        {
            entity.Property(e => e.ProductSchemeId).HasColumnName("ProductSchemeID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(200)
                .HasColumnName("CRMCode");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.NameOl1)
                .HasMaxLength(200)
                .HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2)
                .HasMaxLength(200)
                .HasColumnName("Name_OL2");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.ProductSchemes)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_ProductSchemes_Organisations");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductSchemes)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ProductSchemes_Products");
        });

        modelBuilder.Entity<ProductSchemeRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ProductSchemeRelatedData");

            entity.Property(e => e.ProductName).HasMaxLength(4000);
            entity.Property(e => e.ProductScheme).HasMaxLength(200);
            entity.Property(e => e.ProductSchemeId).HasColumnName("ProductSchemeID");
        });

        modelBuilder.Entity<ProductType>(entity =>
        {
            entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
            entity.Property(e => e.CreatedAt).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(200)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(100);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.NameOl1)
                .HasMaxLength(500)
                .HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2)
                .HasMaxLength(500)
                .HasColumnName("Name_OL2");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.ProductTypes)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_ProductTypes_Organisations");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductTypes)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ProductTypes_Products");
        });

        modelBuilder.Entity<ProductTypeRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ProductTypeRelatedData");

            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.ProductName).HasMaxLength(4000);
            entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
        });

        modelBuilder.Entity<ProductUnTaggedHistory>(entity =>
        {
            entity.HasKey(e => e.ProductUnTaggedHistoryId).HasName("PK_ProductUntaggedHistory");

            entity.ToTable("ProductUnTaggedHistory");

            entity.Property(e => e.ProductUnTaggedHistoryId).HasColumnName("ProductUnTaggedHistoryID");
            entity.Property(e => e.EntityId).HasColumnName("EntityID");
            entity.Property(e => e.Module).HasMaxLength(50);
            entity.Property(e => e.UnTaggedDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.ProductUnTaggedHistories)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_ProductUnTaggedHistory_Users");
        });

        modelBuilder.Entity<RefreshingFetchCount>(entity =>
        {
            entity.ToTable("RefreshingFetchCount");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
        });

        modelBuilder.Entity<ReportName>(entity =>
        {
            entity.Property(e => e.ReportNameId).HasColumnName("ReportNameID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ReportName1).HasColumnName("ReportName");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DefaultUrl)
                .HasMaxLength(200)
                .HasColumnName("DefaultURL");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IsAdmin).HasDefaultValue(0L);
            entity.Property(e => e.IsAdrole).HasColumnName("IsADRole");
            entity.Property(e => e.IsDraft).HasDefaultValue(false);
            entity.Property(e => e.IsSystemEntry).HasDefaultValue(false);
            entity.Property(e => e.LimitExternalAccess).HasDefaultValue(false);
            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NameOl1).HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2).HasColumnName("Name_OL2");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.Roles)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_Roles_Organisation");
        });

        modelBuilder.Entity<RoleDesignationMapping>(entity =>
        {
            entity.ToTable("RoleDesignationMapping");

            entity.Property(e => e.RoleDesignationMappingId).HasColumnName("RoleDesignationMappingID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RoleDesignationMappingImportHistoryId).HasColumnName("RoleDesignationMappingImportHistoryID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Designation).WithMany(p => p.RoleDesignationMappings)
                .HasForeignKey(d => d.DesignationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoleDesignationMapping_DesignationID");

            entity.HasOne(d => d.Role).WithMany(p => p.RoleDesignationMappings)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoleDesignationMapping_Roles");
        });

        modelBuilder.Entity<RoleDesignationMappingImportAudit>(entity =>
        {
            entity.HasKey(e => e.RoleDesignationMappingImportAuditId).HasName("PK__RoleDesi__F0461EFDC887A09F");

            entity.ToTable("RoleDesignationMappingImportAudit");

            entity.Property(e => e.RoleDesignationMappingImportAuditId).HasColumnName("RoleDesignationMappingImportAuditID");
            entity.Property(e => e.ColumnName).HasMaxLength(100);
            entity.Property(e => e.NewImportHistoryId).HasColumnName("NewImportHistoryID");
            entity.Property(e => e.OldImportHistoryId).HasColumnName("OldImportHistoryID");
            entity.Property(e => e.RoleDesignationMappingId).HasColumnName("RoleDesignationMappingID");

            entity.HasOne(d => d.NewImportHistory).WithMany(p => p.RoleDesignationMappingImportAuditNewImportHistories)
                .HasForeignKey(d => d.NewImportHistoryId)
                .HasConstraintName("FK__RoleDesig__NewIm__344A823B");

            entity.HasOne(d => d.OldImportHistory).WithMany(p => p.RoleDesignationMappingImportAuditOldImportHistories)
                .HasForeignKey(d => d.OldImportHistoryId)
                .HasConstraintName("FK__RoleDesig__OldIm__353EA674");

            entity.HasOne(d => d.RoleDesignationMapping).WithMany(p => p.RoleDesignationMappingImportAudits)
                .HasForeignKey(d => d.RoleDesignationMappingId)
                .HasConstraintName("FK_RoleDesignationMappingImportAudit_RoleDesignationMappingID");
        });

        modelBuilder.Entity<RoleDesignationMappingImportFieldSetting>(entity =>
        {
            entity.HasKey(e => e.RoleDesignationMappingFieldSettingId).HasName("PK_RoleDesignationMappingFieldSettings");

            entity.Property(e => e.RoleDesignationMappingFieldSettingId).HasColumnName("RoleDesignationMappingFieldSettingID");
            entity.Property(e => e.CanEditedOnDevice).HasDefaultValue(true);
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.Expression).HasMaxLength(100);
            entity.Property(e => e.FieldDataType).HasMaxLength(50);
            entity.Property(e => e.FieldLabel).HasMaxLength(100);
            entity.Property(e => e.FieldName).HasMaxLength(100);
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.OverwriteAlways).HasDefaultValue(true);
            entity.Property(e => e.RoleDesignationMappingFieldCategoryId)
                .HasDefaultValue(1)
                .HasColumnName("RoleDesignationMappingFieldCategoryID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.RoleDesignationMappingImportFieldSettings)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoleDesignationMappingFieldSettings_RoleDesignationMappingFieldSettings");
        });

        modelBuilder.Entity<RoleDesignationMappingImportFieldSettingMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RoleDesignationMappingSettingMaster");

            entity.ToTable("RoleDesignationMappingImportFieldSettingMaster");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FieldDataType).HasMaxLength(100);
            entity.Property(e => e.FieldLabel).HasMaxLength(200);
            entity.Property(e => e.FieldName).HasMaxLength(200);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsMandatory).HasDefaultValue(false);
            entity.Property(e => e.IsStaticField).HasDefaultValue(true);
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<RoleDesignationMappingImportHistory>(entity =>
        {
            entity.HasKey(e => e.RoleDesignationMappingImportHistoryId).HasName("PK__RoleDesi__B3E313417D68D8CE");

            entity.ToTable("RoleDesignationMappingImportHistory");

            entity.Property(e => e.RoleDesignationMappingImportHistoryId).HasColumnName("RoleDesignationMappingImportHistoryID");
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.ImportTimeStamp).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsReverted).HasDefaultValue(false);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.UploadedAt).HasMaxLength(200);
            entity.Property(e => e.UploadedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.RoleDesignationMappingImportHistories)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK__RoleDesig__Organ__381B131F");
        });

        modelBuilder.Entity<RoleDesignationMappingImportMapping>(entity =>
        {
            entity.HasKey(e => e.RoleDesignationMappingImportMappingId).HasName("PK__RoleDesi__03CF75118EAA0E66");

            entity.ToTable("RoleDesignationMappingImportMapping");

            entity.Property(e => e.RoleDesignationMappingImportMappingId).HasColumnName("RoleDesignationMappingImportMappingID");
            entity.Property(e => e.ImportFieldNameFromFile).HasMaxLength(100);
            entity.Property(e => e.ImportHistoryId).HasColumnName("ImportHistoryID");
            entity.Property(e => e.RoleDesignationMappingFieldSettingId).HasColumnName("RoleDesignationMappingFieldSettingID");

            entity.HasOne(d => d.ImportHistory).WithMany(p => p.RoleDesignationMappingImportMappings)
                .HasForeignKey(d => d.ImportHistoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RoleDesignationMappingImportMapping__ImportHistoryID");
        });

        modelBuilder.Entity<RoleDesignationMappingRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RoleDesignationMappingRelatedData");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
        });

        modelBuilder.Entity<RoleListRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RoleListRelatedData");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
        });

        modelBuilder.Entity<RoleMenuMapping>(entity =>
        {
            entity.ToTable("RoleMenuMapping");

            entity.HasIndex(e => e.IsDeleted, "IX_RoleMenuMapping_IsDeleted");

            entity.HasIndex(e => e.MenuId, "IX_RoleMenuMapping_MenuID");

            entity.HasIndex(e => e.RoleId, "IX_RoleMenuMapping_RoleID");

            entity.Property(e => e.RoleMenuMappingId).HasColumnName("RoleMenuMappingID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Menu).WithMany(p => p.RoleMenuMappings)
                .HasForeignKey(d => d.MenuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoleMenuMapping_Menu");

            entity.HasOne(d => d.Role).WithMany(p => p.RoleMenuMappings)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoleMenuMapping_Roles");
        });

        modelBuilder.Entity<RoleMenuMappingMakerChecker>(entity =>
        {
            entity.ToTable("RoleMenuMapping_MakerChecker");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.RoleMakerId).HasColumnName("RoleMakerID");
        });

        modelBuilder.Entity<RoleProductMapping>(entity =>
        {
            entity.HasKey(e => e.RoleProductMappingId).HasName("PK__RoleProd__4B658F9E343273A9");

            entity.ToTable("RoleProductMapping");

            entity.Property(e => e.RoleProductMappingId).HasColumnName("RoleProductMappingID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Product).WithMany(p => p.RoleProductMappings)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RoleProdu__Produ__5A660982");

            entity.HasOne(d => d.Role).WithMany(p => p.RoleProductMappings)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoleProductMapping_RoleID");
        });

        modelBuilder.Entity<RolesMakerChecker>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MakerChecker_Roles");

            entity.ToTable("Roles_MakerChecker");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DefaultUrl)
                .HasMaxLength(200)
                .HasColumnName("DefaultURL");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.IsAdmin).HasDefaultValue(0L);
            entity.Property(e => e.IsAdrole).HasColumnName("IsADRole");
            entity.Property(e => e.IsSystemEntry).HasDefaultValue(false);
            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NameOl1).HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2).HasColumnName("Name_OL2");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.RequestType).HasMaxLength(50);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<SalesMethod>(entity =>
        {
            entity.Property(e => e.SalesMethodId).HasColumnName("SalesMethodID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsDefault).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.NameOl1)
                .HasMaxLength(200)
                .HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2)
                .HasMaxLength(200)
                .HasColumnName("Name_OL2");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.SalesMethods)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_SalesMethods_Organisations");
        });

        modelBuilder.Entity<Salutation>(entity =>
        {
            entity.HasKey(e => e.SalutationId).HasName("PK_Salutation");

            entity.Property(e => e.SalutationId).HasColumnName("SalutationID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NameOl1).HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2).HasColumnName("Name_OL2");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.Salutations)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Salutations_Organisations");
        });

        modelBuilder.Entity<SecurityQuestion>(entity =>
        {
            entity.Property(e => e.SecurityQuestionId).HasColumnName("SecurityQuestionID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(4000);
            entity.Property(e => e.NameOl1)
                .HasMaxLength(4000)
                .HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2)
                .HasMaxLength(4000)
                .HasColumnName("Name_OL2");
            entity.Property(e => e.OrganisationId)
                .HasComment("If null - default")
                .HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.SecurityQuestions)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_SecurityQuestions_Organisations");
        });

        modelBuilder.Entity<SeniorityLevel>(entity =>
        {
            entity.HasKey(e => e.SeniorityLevelId).HasName("PK__Seniorit__7DA2504327CC951D");

            entity.ToTable("SeniorityLevel");

            entity.Property(e => e.SeniorityLevelId).HasColumnName("SeniorityLevelID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsDefault).HasDefaultValue(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.SeniorityLevels)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK__Seniority__Organ__4BA21D88");
        });

        modelBuilder.Entity<SettingControlType>(entity =>
        {
            entity.HasKey(e => e.SettingControlTypeId).HasName("PK_SettingControls");

            entity.Property(e => e.SettingControlTypeId).HasColumnName("SettingControlTypeID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<StageHistoryRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("StageHistoryRelatedData");

            entity.Property(e => e.CreatedOn).HasMaxLength(4000);
            entity.Property(e => e.DealId).HasColumnName("DealID");
            entity.Property(e => e.DealStage).HasMaxLength(200);
            entity.Property(e => e.DealStageExitDate).HasMaxLength(4000);
            entity.Property(e => e.DealStageId).HasColumnName("DealStageID");
            entity.Property(e => e.Tat)
                .HasMaxLength(500)
                .HasColumnName("TAT");
        });

        modelBuilder.Entity<SubscriptionCustomerMapping>(entity =>
        {
            entity.ToTable("SubscriptionCustomerMapping");

            entity.Property(e => e.SubscriptionCustomerMappingId).HasColumnName("SubscriptionCustomerMappingID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.PayfortCustomerId).HasColumnName("PayfortCustomerID");

            entity.HasOne(d => d.Organisation).WithMany(p => p.SubscriptionCustomerMappings)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_SubscriptionCustomerMapping_Organisations");
        });

        modelBuilder.Entity<SubscriptionOrganisationMapping>(entity =>
        {
            entity.HasKey(e => e.SubscriptionOrganisationMappingId).HasName("PK_OrganisationSubscriptionMapping");

            entity.ToTable("SubscriptionOrganisationMapping");

            entity.Property(e => e.SubscriptionOrganisationMappingId).HasColumnName("SubscriptionOrganisationMappingID");
            entity.Property(e => e.CreatedAt).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.SubscriptionDateTime).HasColumnType("datetime");
            entity.Property(e => e.SubscriptionTypeId).HasColumnName("SubscriptionTypeID");

            entity.HasOne(d => d.Organisation).WithMany(p => p.SubscriptionOrganisationMappings)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_OrganisationSubscriptionMapping_Organisations");

            entity.HasOne(d => d.SubscriptionType).WithMany(p => p.SubscriptionOrganisationMappings)
                .HasForeignKey(d => d.SubscriptionTypeId)
                .HasConstraintName("FK_OrganisationSubscriptionMapping_SubscriptionTypes");
        });

        modelBuilder.Entity<SubscriptionRedemption>(entity =>
        {
            entity.ToTable("SubscriptionRedemption");

            entity.Property(e => e.SubscriptionRedemptionId).HasColumnName("SubscriptionRedemptionID");
            entity.Property(e => e.CreatedAt).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.RedeemDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.SubscriptionRedemptions)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_SubscriptionRedemption_Organisations");
        });

        modelBuilder.Entity<SubscriptionTransaction>(entity =>
        {
            entity.Property(e => e.SubscriptionTransactionId).HasColumnName("SubscriptionTransactionID");
            entity.Property(e => e.AmountPerUserPerMonth).HasColumnType("money");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CurencyCode).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.PayfortChargeId).HasColumnName("PayfortChargeID");
            entity.Property(e => e.PayfortCustomerId).HasColumnName("PayfortCustomerID");
            entity.Property(e => e.SubscriptionOrganisationMappingId).HasColumnName("SubscriptionOrganisationMappingID");
            entity.Property(e => e.SubscriptionTransactionStatusId).HasColumnName("SubscriptionTransactionStatusID");
            entity.Property(e => e.TotalAmount).HasColumnType("money");

            entity.HasOne(d => d.SubscriptionOrganisationMapping).WithMany(p => p.SubscriptionTransactions)
                .HasForeignKey(d => d.SubscriptionOrganisationMappingId)
                .HasConstraintName("FK_SubscriptionTransactions_SubscriptionOrganisationMapping");

            entity.HasOne(d => d.SubscriptionTransactionStatus).WithMany(p => p.SubscriptionTransactions)
                .HasForeignKey(d => d.SubscriptionTransactionStatusId)
                .HasConstraintName("FK_SubscriptionTransactions_SubscriptionTransactionStatus");
        });

        modelBuilder.Entity<SubscriptionTransactionStatus>(entity =>
        {
            entity.ToTable("SubscriptionTransactionStatus");

            entity.Property(e => e.SubscriptionTransactionStatusId).HasColumnName("SubscriptionTransactionStatusID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<SubscriptionType>(entity =>
        {
            entity.HasKey(e => e.SubscriptionTypeId).HasName("PK_Subscriptions");

            entity.Property(e => e.SubscriptionTypeId).HasColumnName("SubscriptionTypeID");
            entity.Property(e => e.AnnualRecurringAmountPerMonth).HasColumnType("money");
            entity.Property(e => e.CamCardScanCount).HasDefaultValue(-1L);
            entity.Property(e => e.CreatedAt).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.IsAttachmentAllowed).HasDefaultValue(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsEnterpriseEdition).HasDefaultValue(false);
            entity.Property(e => e.ModifiedAt).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.MonthlyRecurringAmountPerMonth).HasColumnType("money");
        });

        modelBuilder.Entity<TempOrganisationAdgroupMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Temp_OrganisationADGroupMapping_ID");

            entity.ToTable("Temp_OrganisationADGroupMapping");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.WorkflowGroup).HasMaxLength(200);
        });

        modelBuilder.Entity<TempRoleProductMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Temp_Rol__3214EC27144985E9");

            entity.ToTable("Temp_RoleProductMapping");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.RoleProductMappingId).HasColumnName("RoleProductMappingID");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TempUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Users_ID");

            entity.ToTable("Temp_Users");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Area).HasMaxLength(300);
            entity.Property(e => e.AutoContactAllocation).HasDefaultValue(false);
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BranchCode).HasMaxLength(300);
            entity.Property(e => e.BranchName).HasMaxLength(300);
            entity.Property(e => e.BranchZone).HasMaxLength(300);
            entity.Property(e => e.CallCount).HasDefaultValue(0);
            entity.Property(e => e.ClosedDealCount).HasDefaultValue(0);
            entity.Property(e => e.ClosedDealRevenue)
                .HasDefaultValue(0.0m)
                .HasColumnType("money");
            entity.Property(e => e.ClosedDealSize)
                .HasDefaultValue(0.0m)
                .HasColumnType("money");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(300)
                .HasColumnName("EmployeeID");
            entity.Property(e => e.EmployeeNumber).HasMaxLength(300);
            entity.Property(e => e.HasFullDataAccessForReport).HasDefaultValue(false);
            entity.Property(e => e.IncentiveBancAssuranceRoleId).HasColumnName("IncentiveBancAssuranceRoleID");
            entity.Property(e => e.IncentiveTemplateId).HasColumnName("IncentiveTemplateID");
            entity.Property(e => e.IsForceReset).HasDefaultValue(false);
            entity.Property(e => e.IsOrganisationFilterAllowed).HasDefaultValue(false);
            entity.Property(e => e.LastResetEmailDateTime).HasColumnType("datetime");
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            entity.Property(e => e.MeetingCount).HasDefaultValue(0);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NoOfCsrreporting).HasColumnName("NoOfCSRReporting");
            entity.Property(e => e.NoOfRmreporting).HasColumnName("NoOfRMReporting");
            entity.Property(e => e.NoOfVipcsrreporting).HasColumnName("NoOfVIPCSRReporting");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.Phone).HasMaxLength(200);
            entity.Property(e => e.Region).HasMaxLength(200);
            entity.Property(e => e.RequestType).HasMaxLength(50);
            entity.Property(e => e.RestrictOtherContactSearch).HasDefaultValue(false);
            entity.Property(e => e.SalutationId).HasColumnName("SalutationID");
            entity.Property(e => e.SeniorityLevelId).HasColumnName("SeniorityLevelID");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");
            entity.Property(e => e.Status).HasDefaultValueSql("((0))");
            entity.Property(e => e.UnitId).HasColumnName("UnitID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserImportHistoryId).HasColumnName("UserImportHistoryID");

            entity.HasOne(d => d.Organisation).WithMany(p => p.TempUsers)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_Temp_Users_Organisations");

            entity.HasOne(d => d.User).WithMany(p => p.TempUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Temp_Users_Users");

            entity.HasOne(d => d.UserImportHistory).WithMany(p => p.TempUsers)
                .HasForeignKey(d => d.UserImportHistoryId)
                .HasConstraintName("FK_Temp_Users_UserImportHistoryID");
        });

        modelBuilder.Entity<TempUserDynamicField>(entity =>
        {
            entity.ToTable("Temp_UserDynamicFields");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Field1).HasMaxLength(500);
            entity.Property(e => e.Field2).HasMaxLength(500);
            entity.Property(e => e.Field3).HasMaxLength(500);
            entity.Property(e => e.Field4).HasMaxLength(500);
            entity.Property(e => e.Field5).HasMaxLength(500);
            entity.Property(e => e.Field6).HasMaxLength(500);
            entity.Property(e => e.Field7).HasMaxLength(500);
            entity.Property(e => e.Field8).HasMaxLength(500);
            entity.Property(e => e.Field9).HasMaxLength(500);
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TempUserExplicitAccessMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UserExplicitAccessMapping_ID");

            entity.ToTable("Temp_UserExplicitAccessMapping");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccessCategoryId).HasColumnName("AccessCategoryID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.OtherUserId).HasColumnName("OtherUserID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserExplicitAccessMappingId).HasColumnName("UserExplicitAccessMappingID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TempUserGroupMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UserGroupMapping_ID");

            entity.ToTable("Temp_UserGroupMapping");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationIdasSubGroup).HasColumnName("OrganisationIDAsSubGroup");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");
            entity.Property(e => e.UserGroupId).HasColumnName("UserGroupID");
            entity.Property(e => e.UserGroupIdasSubGroup).HasColumnName("UserGroupIDAsSubGroup");
            entity.Property(e => e.UserGroupMappingId).HasColumnName("UserGroupMappingID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TempUserImportHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Temp_Use__3214EC27978F1DED");

            entity.ToTable("Temp_UserImportHistory");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.ImportTimeStamp).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsReverted).HasDefaultValue(false);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.UploadedAt).HasMaxLength(200);
            entity.Property(e => e.UploadedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.TempUserImportHistories)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK__Temp_User__Organ__53433F50");
        });

        modelBuilder.Entity<TempUserImportMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Temp_Use__3214EC272D98015A");

            entity.ToTable("Temp_UserImportMapping");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ImportFieldNameFromFile).HasMaxLength(100);
            entity.Property(e => e.ImportHistoryId).HasColumnName("ImportHistoryID");
            entity.Property(e => e.UserFieldSettingId).HasColumnName("UserFieldSettingID");

            entity.HasOne(d => d.ImportHistory).WithMany(p => p.TempUserImportMappings)
                .HasForeignKey(d => d.ImportHistoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Temp_UserImportMapping__ID");
        });

        modelBuilder.Entity<TempUserIncentiveProductAccessInImport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Temp_Use__3214EC2714E8F848");

            entity.ToTable("Temp_UserIncentiveProductAccessInImport");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IncentiveProductTypeId).HasColumnName("IncentiveProductTypeID");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.IncentiveProductType).WithMany(p => p.TempUserIncentiveProductAccessInImports)
                .HasForeignKey(d => d.IncentiveProductTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Temp_User__Incen__552B87C2");
        });

        modelBuilder.Entity<TempUserIncentiveProductAccessInReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Temp_Use__3214EC27EB59BEDA");

            entity.ToTable("Temp_UserIncentiveProductAccessInReport");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IncentiveProductTypeId).HasColumnName("IncentiveProductTypeID");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.IncentiveProductType).WithMany(p => p.TempUserIncentiveProductAccessInReports)
                .HasForeignKey(d => d.IncentiveProductTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Temp_User__Incen__561FABFB");
        });

        modelBuilder.Entity<TempUserLanguageMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Temp_Use__3214EC27428FD9C6");

            entity.ToTable("Temp_UserLanguageMapping");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LanguageSpeakId).HasColumnName("LanguageSpeakID");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserLanguageMappingId).HasColumnName("UserLanguageMappingID");
        });

        modelBuilder.Entity<TempUserProductMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Temp_Use__3214EC276C081279");

            entity.ToTable("Temp_UserProductMapping");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserProductMappingId).HasColumnName("UserProductMappingID");
        });

        modelBuilder.Entity<TempUserRoleMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UserRoleMapping_ID");

            entity.ToTable("Temp_UserRoleMapping");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserRoleMappingId).HasColumnName("UserRoleMappingID");
        });

        modelBuilder.Entity<TempUserSegmentMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Temp_Use__3214EC2755005FA7");

            entity.ToTable("Temp_UserSegmentMapping");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ContactSegmentId).HasColumnName("ContactSegmentID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserSegmentMappingId).HasColumnName("UserSegmentMappingID");
        });

        modelBuilder.Entity<TempUserWorkAddressMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Temp_Use__3214EC271DAFA668");

            entity.ToTable("Temp_UserWorkAddressMapping");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserWorkAddressMappingId).HasColumnName("UserWorkAddressMappingID");
            entity.Property(e => e.WorkAddressId).HasColumnName("WorkAddressID");
        });

        modelBuilder.Entity<TierReminderDurationUnit>(entity =>
        {
            entity.Property(e => e.TierReminderDurationUnitId).HasColumnName("TierReminderDurationUnitID");
        });

        modelBuilder.Entity<TiersModel>(entity =>
        {
            entity.HasKey(e => e.TierId).HasName("PK_ContactTiers");

            entity.ToTable("TiersModel");

            entity.Property(e => e.TierId).HasColumnName("TierID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId).HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TierName).HasMaxLength(500);
            entity.Property(e => e.TierReminderDurationUnitId).HasColumnName("TierReminderDurationUnitID");
        });

        modelBuilder.Entity<TimeZone>(entity =>
        {
            entity.Property(e => e.TimeZoneId).HasColumnName("TimeZoneID");
            entity.Property(e => e.DisplayName).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.Property(e => e.UnitId).HasColumnName("UnitID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NameOl1).HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2).HasColumnName("Name_OL2");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

            entity.HasOne(d => d.Organisation).WithMany(p => p.Units)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Units_Organisations");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.BranchCode, "IDX_Users_BranchCode");

            entity.HasIndex(e => e.BranchName, "IDX_Users_BranchName");

            entity.HasIndex(e => e.AduserId, "IX_Users_ADUserID");

            entity.HasIndex(e => e.EmployeeId, "IX_Users_EmployeeID");

            entity.HasIndex(e => e.EmployeeNumber, "IX_Users_EmployeeNumber");

            entity.HasIndex(e => e.IsDeleted, "IX_Users_IsDeleted");

            entity.HasIndex(e => new { e.IsActive, e.IsDeleted }, "IX_Users_IsDeleted_IsActive");

            entity.HasIndex(e => e.ManagerId, "IX_Users_ManagerID");

            entity.HasIndex(e => e.OrganisationId, "IX_Users_OrganisationID");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Addepartment).HasColumnName("ADDepartment");
            entity.Property(e => e.AduserCn).HasColumnName("ADUserCN");
            entity.Property(e => e.AduserId)
                .HasMaxLength(300)
                .HasColumnName("ADUserID");
            entity.Property(e => e.AduserPrincipalName).HasColumnName("ADUserPrincipalName");
            entity.Property(e => e.Area).HasMaxLength(200);
            entity.Property(e => e.AutoContactAllocation).HasDefaultValue(false);
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BranchCode).HasMaxLength(300);
            entity.Property(e => e.BranchName).HasMaxLength(300);
            entity.Property(e => e.BranchZone).HasMaxLength(400);
            entity.Property(e => e.CamCardScanCount).HasDefaultValue(0L);
            entity.Property(e => e.Comment).HasMaxLength(500);
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.CummulativePoints).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.DeviceUniqueId).HasColumnName("DeviceUniqueID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(300)
                .HasColumnName("EmployeeID");
            entity.Property(e => e.EmployeeNumber).HasMaxLength(300);
            entity.Property(e => e.HasFullDataAccessForReport).HasDefaultValue(false);
            entity.Property(e => e.IncentiveBancAssuranceRoleId).HasColumnName("IncentiveBancAssuranceRoleID");
            entity.Property(e => e.IncentiveTemplateId).HasColumnName("IncentiveTemplateID");
            entity.Property(e => e.IsAduser)
                .HasDefaultValue(false)
                .HasColumnName("IsADUser");
            entity.Property(e => e.IsBackupAdmin).HasDefaultValue(false);
            entity.Property(e => e.IsDraft).HasDefaultValue(false);
            entity.Property(e => e.IsForceReset).HasDefaultValue(false);
            entity.Property(e => e.IsSubscribed).HasDefaultValue(true);
            entity.Property(e => e.LastContactAutoAllocationDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastResetEmailDateTime).HasColumnType("datetime");
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NoOfCsrreporting).HasColumnName("NoOfCSRReporting");
            entity.Property(e => e.NoOfRmreporting).HasColumnName("NoOfRMReporting");
            entity.Property(e => e.NoOfVipcsrreporting).HasColumnName("NoOfVIPCSRReporting");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.PrefferedLanguageId).HasDefaultValue(1L);
            entity.Property(e => e.RestrictOtherContactSearch).HasDefaultValue(false);
            entity.Property(e => e.SalutationId).HasColumnName("SalutationID");
            entity.Property(e => e.SeniorityLevelId).HasColumnName("SeniorityLevelID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TimeZoneId).HasColumnName("TimeZoneID");
            entity.Property(e => e.UnitId).HasColumnName("UnitID");
            entity.Property(e => e.UserImportHistoryId).HasColumnName("UserImportHistoryID");

            entity.HasOne(d => d.AllowedContactTypesNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.AllowedContactTypes)
                .HasConstraintName("FK_Users_AllowedContactType");

            entity.HasOne(d => d.IncentiveBancAssuranceRole).WithMany(p => p.Users)
                .HasForeignKey(d => d.IncentiveBancAssuranceRoleId)
                .HasConstraintName("FK_Users_IncentiveBancAssuranceRoleID");

            entity.HasOne(d => d.IncentiveTemplate).WithMany(p => p.Users)
                .HasForeignKey(d => d.IncentiveTemplateId)
                .HasConstraintName("FK_Temp_Users_IncentiveTemplateID");

            entity.HasOne(d => d.Organisation).WithMany(p => p.Users)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_Organisations");

            entity.HasOne(d => d.TimeZone).WithMany(p => p.Users)
                .HasForeignKey(d => d.TimeZoneId)
                .HasConstraintName("FK_Users_TimeZones");

            entity.HasOne(d => d.UserImportHistory).WithMany(p => p.Users)
                .HasForeignKey(d => d.UserImportHistoryId)
                .HasConstraintName("FK_Users_UserImportHistoryID");
        });

        modelBuilder.Entity<UserAuditTrail>(entity =>
        {
            entity.HasKey(e => e.AuditId);

            entity.ToTable("UserAuditTrail");

            entity.HasIndex(e => e.DateTime, "IX_UserAuditTrail_DateTime");

            entity.HasIndex(e => e.OrganisationId, "IX_UserAuditTrail_OrganisationID");

            entity.HasIndex(e => e.UserId, "IX_UserAuditTrail_UserID");

            entity.Property(e => e.AuditId).HasColumnName("AuditID");
            entity.Property(e => e.AuditType).HasMaxLength(50);
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Organisation).WithMany(p => p.UserAuditTrails)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_UserAuditTrail_Organisations");

            entity.HasOne(d => d.User).WithMany(p => p.UserAuditTrails)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserAuditTrail_UserAuditTrail");
        });

        modelBuilder.Entity<UserAuthenticationLog>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_UserAuthenticationLogs_UserID");

            entity.Property(e => e.UserAuthenticationLogId).HasColumnName("UserAuthenticationLogID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsMasterDataUpdated).HasDefaultValue(false);
            entity.Property(e => e.LastRequestedTime).HasColumnType("datetime");
            entity.Property(e => e.LoggedInTime).HasColumnType("datetime");
            entity.Property(e => e.LoggedOutTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.UserAuthenticationLogs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserAuthenticationLogs_Users");
        });

        modelBuilder.Entity<UserBranchMappingLog>(entity =>
        {
            entity.HasKey(e => e.MappingId);

            entity.ToTable("UserBranchMappingLog");

            entity.Property(e => e.MappingId).HasColumnName("MappingID");
            entity.Property(e => e.ChangedDateTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.UserBranchMappingLogs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserBranchMappingLog_UserID");
        });

        modelBuilder.Entity<UserDeviceProfile>(entity =>
        {
            entity.HasKey(e => e.UserDeviceProfileId).HasName("PK_UserDeviceProfile");

            entity.Property(e => e.UserDeviceProfileId).HasColumnName("UserDeviceProfileID");
            entity.Property(e => e.ApplicationId)
                .HasMaxLength(500)
                .HasColumnName("ApplicationID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceDetails).HasMaxLength(200);
            entity.Property(e => e.DeviceId)
                .HasMaxLength(500)
                .HasColumnName("DeviceID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsBlocked).HasDefaultValue(false);
            entity.Property(e => e.LastLoginAt).HasMaxLength(200);
            entity.Property(e => e.LastLoginOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.UserDeviceProfiles)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserDeviceProfiles_Users");
        });

        modelBuilder.Entity<UserDynamicField>(entity =>
        {
            entity.Property(e => e.UserDynamicFieldId).HasColumnName("UserDynamicFieldID");
            entity.Property(e => e.Field1).HasMaxLength(500);
            entity.Property(e => e.Field2).HasMaxLength(500);
            entity.Property(e => e.Field3).HasMaxLength(500);
            entity.Property(e => e.Field4).HasMaxLength(500);
            entity.Property(e => e.Field5).HasMaxLength(500);
            entity.Property(e => e.Field6).HasMaxLength(500);
            entity.Property(e => e.Field7).HasMaxLength(500);
            entity.Property(e => e.Field8).HasMaxLength(500);
            entity.Property(e => e.Field9).HasMaxLength(500);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.UserDynamicFields)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserDynamicFields_Users");
        });

        modelBuilder.Entity<UserEmailNotificationConfiguration>(entity =>
        {
            entity.ToTable("UserEmailNotificationConfiguration");

            entity.HasIndex(e => e.CanSubscribe, "IX_UserEmailNotificationConfiguration_CanSubscribe").HasFilter("([CanSubscribe]=(1))");

            entity.HasIndex(e => e.EmailFrequencyId, "IX_UserEmailNotificationConfiguration_EmailFrequencyID");

            entity.HasIndex(e => e.ForTeam, "IX_UserEmailNotificationConfiguration_ForTeam");

            entity.HasIndex(e => e.IsDeleted, "IX_UserEmailNotificationConfiguration_IsDeleted");

            entity.HasIndex(e => e.IsManagerInCc, "IX_UserEmailNotificationConfiguration_IsManagerInCC");

            entity.HasIndex(e => e.IsParallelAccessUserInCc, "IX_UserEmailNotificationConfiguration_IsParallelAccessUserInCC");

            entity.HasIndex(e => e.ReportNameId, "IX_UserEmailNotificationConfiguration_ReportNameID");

            entity.HasIndex(e => e.UserId, "IX_UserEmailNotificationConfiguration_UserID");

            entity.Property(e => e.UserEmailNotificationConfigurationId).HasColumnName("UserEmailNotificationConfigurationID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EmailFrequencyId).HasColumnName("EmailFrequencyID");
            entity.Property(e => e.IsManagerInCc)
                .HasDefaultValue(true)
                .HasColumnName("IsManagerInCC");
            entity.Property(e => e.IsParallelAccessUserInCc)
                .HasDefaultValue(true)
                .HasColumnName("IsParallelAccessUserInCC");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ReportNameId).HasColumnName("ReportNameID");
            entity.Property(e => e.ShowLastWeekData).HasDefaultValue(true);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.EmailFrequency).WithMany(p => p.UserEmailNotificationConfigurations)
                .HasForeignKey(d => d.EmailFrequencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserEmailNotificationConfiguration_EmailFrequency");

            entity.HasOne(d => d.User).WithMany(p => p.UserEmailNotificationConfigurations)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserEmailNotificationConfiguration_UserEmailNotificationConfiguration");
        });

        modelBuilder.Entity<UserEmailNotificationConfigurationRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("UserEmailNotificationConfigurationRelatedData");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EmailFrequencyName)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.IsManagerInCc).HasColumnName("IsManagerInCC");
            entity.Property(e => e.IsParallelAccessUserInCc).HasColumnName("IsParallelAccessUserInCC");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.UserEmailNotificationConfigurationId).HasColumnName("UserEmailNotificationConfigurationID");
        });

        modelBuilder.Entity<UserEmailNotificationSendLog>(entity =>
        {
            entity.ToTable("UserEmailNotificationSendLog");

            entity.HasIndex(e => e.ForTeam, "IX_UserEmailNotificationSendLog_ForTeam");

            entity.HasIndex(e => e.ReportNameId, "IX_UserEmailNotificationSendLog_ReportNameID");

            entity.HasIndex(e => e.UserId, "IX_UserEmailNotificationSendLog_UserID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ReportNameId).HasColumnName("ReportNameID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.UserEmailNotificationSendLogs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserEmailNotificationSendLog_Users");
        });

        modelBuilder.Entity<UserExplicitAccessMapping>(entity =>
        {
            entity.ToTable("UserExplicitAccessMapping");

            entity.HasIndex(e => e.AccessCategoryId, "IX_UserExplicitAccessMapping_AccessCategoryID");

            entity.HasIndex(e => e.IsDeleted, "IX_UserExplicitAccessMapping_IsDeleted");

            entity.HasIndex(e => e.OtherUserId, "IX_UserExplicitAccessMapping_OtherUserID");

            entity.HasIndex(e => e.UserId, "IX_UserExplicitAccessMapping_UserID");

            entity.Property(e => e.UserExplicitAccessMappingId).HasColumnName("UserExplicitAccessMappingID");
            entity.Property(e => e.AccessCategoryId).HasColumnName("AccessCategoryID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.OtherUserId).HasColumnName("OtherUserID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.OtherUser).WithMany(p => p.UserExplicitAccessMappingOtherUsers)
                .HasForeignKey(d => d.OtherUserId)
                .HasConstraintName("FK_UserExplicitAccessMapping_Users");

            entity.HasOne(d => d.User).WithMany(p => p.UserExplicitAccessMappingUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserExplicitAccessMapping_UserExplicitAccessMapping");
        });

        modelBuilder.Entity<UserExplicitAccessMappingAudit>(entity =>
        {
            entity.HasKey(e => e.AuditId).HasName("PK__UserExpl__A17F23B8B407312C");

            entity.ToTable("UserExplicitAccessMappingAudit");

            entity.Property(e => e.AuditId).HasColumnName("AuditID");
            entity.Property(e => e.UserExplicitAccessMappingId).HasColumnName("UserExplicitAccessMappingID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserFieldSetting>(entity =>
        {
            entity.Property(e => e.UserFieldSettingId).HasColumnName("UserFieldSettingID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.Expression).HasMaxLength(100);
            entity.Property(e => e.FieldDataType).HasMaxLength(50);
            entity.Property(e => e.FieldLabel).HasMaxLength(100);
            entity.Property(e => e.FieldName).HasMaxLength(100);
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.OverwriteAlways).HasDefaultValue(true);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.UserFieldSettings)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserFieldSettings_UserFieldSettings");
        });

        modelBuilder.Entity<UserFieldSettingMaster>(entity =>
        {
            entity.ToTable("UserFieldSettingMaster");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FieldDataType).HasMaxLength(100);
            entity.Property(e => e.FieldLabel).HasMaxLength(200);
            entity.Property(e => e.FieldName).HasMaxLength(200);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsMandatory).HasDefaultValue(false);
            entity.Property(e => e.IsStaticField).HasDefaultValue(true);
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<UserGroup>(entity =>
        {
            entity.Property(e => e.UserGroupId).HasColumnName("UserGroupID");
            entity.Property(e => e.AutoContactAllocation).HasDefaultValue(false);
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DeviceObjId).HasColumnName("DeviceObjID");
            entity.Property(e => e.FocalPointUserId).HasColumnName("FocalPointUserID");
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.NameOl1).HasColumnName("Name_OL1");
            entity.Property(e => e.NameOl2).HasColumnName("Name_OL2");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.RestrictOtherContactSearch).HasDefaultValue(false);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.UserGroups)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserGroups_Organisations");
        });

        modelBuilder.Entity<UserGroupMapping>(entity =>
        {
            entity.ToTable("UserGroupMapping");

            entity.HasIndex(e => e.UserGroupId, "IX_UserGroupMapping_UserGroupIDD");

            entity.HasIndex(e => e.UserId, "IX_UserGroupMapping_UserID");

            entity.Property(e => e.UserGroupMappingId).HasColumnName("UserGroupMappingID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationIdasSubGroup).HasColumnName("OrganisationIDAsSubGroup");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserGroupId).HasColumnName("UserGroupID");
            entity.Property(e => e.UserGroupIdasSubGroup).HasColumnName("UserGroupIDAsSubGroup");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.OrganisationIdasSubGroupNavigation).WithMany(p => p.UserGroupMappings)
                .HasForeignKey(d => d.OrganisationIdasSubGroup)
                .HasConstraintName("FK_UserGroupMapping_Organisations");

            entity.HasOne(d => d.UserGroup).WithMany(p => p.UserGroupMappingUserGroups)
                .HasForeignKey(d => d.UserGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserGroupMapping_UserGroups_ID");

            entity.HasOne(d => d.UserGroupIdasSubGroupNavigation).WithMany(p => p.UserGroupMappingUserGroupIdasSubGroupNavigations)
                .HasForeignKey(d => d.UserGroupIdasSubGroup)
                .HasConstraintName("FK_UserGroupMapping_UserGroups");

            entity.HasOne(d => d.User).WithMany(p => p.UserGroupMappings)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserGroupMapping_Users");
        });

        modelBuilder.Entity<UserGroupRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("UserGroupRelatedData");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.UserGroupId).HasColumnName("UserGroupID");
        });

        modelBuilder.Entity<UserImportAudit>(entity =>
        {
            entity.HasKey(e => e.UserImportAuditId).HasName("PK__UserImpo__A9E655B6E4006947");

            entity.ToTable("UserImportAudit");

            entity.Property(e => e.UserImportAuditId).HasColumnName("UserImportAuditID");
            entity.Property(e => e.ColumnName).HasMaxLength(100);
            entity.Property(e => e.NewImportHistoryId).HasColumnName("NewImportHistoryID");
            entity.Property(e => e.OldImportHistoryId).HasColumnName("OldImportHistoryID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.NewImportHistory).WithMany(p => p.UserImportAuditNewImportHistories)
                .HasForeignKey(d => d.NewImportHistoryId)
                .HasConstraintName("FK__UserImpor__NewIm__6932806F");

            entity.HasOne(d => d.OldImportHistory).WithMany(p => p.UserImportAuditOldImportHistories)
                .HasForeignKey(d => d.OldImportHistoryId)
                .HasConstraintName("FK__UserImpor__OldIm__6A26A4A8");

            entity.HasOne(d => d.User).WithMany(p => p.UserImportAudits)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserImpor__UserI__20891011");
        });

        modelBuilder.Entity<UserImportHistory>(entity =>
        {
            entity.HasKey(e => e.UserImportHistoryId).HasName("PK__UserImpo__FECAD520E396CC45");

            entity.ToTable("UserImportHistory");

            entity.Property(e => e.UserImportHistoryId).HasColumnName("UserImportHistoryID");
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.ImportTimeStamp).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsReverted).HasDefaultValue(false);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.UploadedAt).HasMaxLength(200);
            entity.Property(e => e.UploadedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.UserImportHistories)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK__UserImpor__Organ__6C0EED1A");
        });

        modelBuilder.Entity<UserImportMapping>(entity =>
        {
            entity.HasKey(e => e.UserImportMappingId).HasName("PK__UserImpo__78969619BB098DB6");

            entity.ToTable("UserImportMapping");

            entity.Property(e => e.UserImportMappingId).HasColumnName("UserImportMappingID");
            entity.Property(e => e.ImportFieldNameFromFile).HasMaxLength(100);
            entity.Property(e => e.ImportHistoryId).HasColumnName("ImportHistoryID");
            entity.Property(e => e.UserFieldSettingId).HasColumnName("UserFieldSettingID");

            entity.HasOne(d => d.ImportHistory).WithMany(p => p.UserImportMappings)
                .HasForeignKey(d => d.ImportHistoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserImportMapping__ImportHistoryID");
        });

        modelBuilder.Entity<UserIncentiveProductAccessInImport>(entity =>
        {
            entity.HasKey(e => e.UserIncentiveProductAccessInImportId).HasName("PK__UserInce__5E42F369815ACEDA");

            entity.ToTable("UserIncentiveProductAccessInImport");

            entity.Property(e => e.UserIncentiveProductAccessInImportId).HasColumnName("UserIncentiveProductAccessInImportID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IncentiveProductTypeId).HasColumnName("IncentiveProductTypeID");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.IncentiveProductType).WithMany(p => p.UserIncentiveProductAccessInImports)
                .HasForeignKey(d => d.IncentiveProductTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserIncen__Incen__6DF7358C");

            entity.HasOne(d => d.User).WithMany(p => p.UserIncentiveProductAccessInImports)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserIncentiveProductAccessInImport_UserID");
        });

        modelBuilder.Entity<UserIncentiveProductAccessInReport>(entity =>
        {
            entity.HasKey(e => e.UserIncentiveProductAccessInReportId).HasName("PK__UserInce__DB181532AD1A4EA5");

            entity.ToTable("UserIncentiveProductAccessInReport");

            entity.Property(e => e.UserIncentiveProductAccessInReportId).HasColumnName("UserIncentiveProductAccessInReportID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IncentiveProductTypeId).HasColumnName("IncentiveProductTypeID");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.IncentiveProductType).WithMany(p => p.UserIncentiveProductAccessInReports)
                .HasForeignKey(d => d.IncentiveProductTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserIncen__Incen__6FDF7DFE");

            entity.HasOne(d => d.User).WithMany(p => p.UserIncentiveProductAccessInReports)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserIncentiveProductAccessInReport_UserID");
        });

        modelBuilder.Entity<UserIncentiveTemplateMappingLog>(entity =>
        {
            entity.HasKey(e => e.MappingId);

            entity.ToTable("UserIncentiveTemplateMappingLog");

            entity.Property(e => e.MappingId).HasColumnName("MappingID");
            entity.Property(e => e.ChangedDateTime).HasColumnType("datetime");
            entity.Property(e => e.IncentiveTemplateId).HasColumnName("IncentiveTemplateID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.IncentiveTemplate).WithMany(p => p.UserIncentiveTemplateMappingLogs)
                .HasForeignKey(d => d.IncentiveTemplateId)
                .HasConstraintName("FK_UserIncentiveTemplateMappingLog_IncentiveTemplateID");

            entity.HasOne(d => d.User).WithMany(p => p.UserIncentiveTemplateMappingLogs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserIncentiveTemplateMappingLog_UserID");
        });

        modelBuilder.Entity<UserLanguageMapping>(entity =>
        {
            entity.HasKey(e => e.UserLanguageMappingId).HasName("PK__UserLang__9A8371C6F5D5DA57");

            entity.ToTable("UserLanguageMapping");

            entity.Property(e => e.UserLanguageMappingId).HasColumnName("UserLanguageMappingID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.LanguageSpeakId).HasColumnName("LanguageSpeakID");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.LanguageSpeak).WithMany(p => p.UserLanguageMappings)
                .HasForeignKey(d => d.LanguageSpeakId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserLangu__Langu__73B00EE2");

            entity.HasOne(d => d.User).WithMany(p => p.UserLanguageMappings)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserLangu__UserI__0F097E54");
        });

        modelBuilder.Entity<UserLocationHistory>(entity =>
        {
            entity.ToTable("UserLocationHistory");

            entity.Property(e => e.UserLocationHistoryId).HasColumnName("UserLocationHistoryID");
            entity.Property(e => e.LastModifiedOn)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LatLongCoordinate).HasMaxLength(500);
            entity.Property(e => e.Location).HasMaxLength(500);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.UserLocationHistories)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserLocationHistory_Users");
        });

        modelBuilder.Entity<UserLoginPasswordHistory>(entity =>
        {
            entity.HasKey(e => e.HistoryId).HasName("PK_UserLoginPasswordHistory");

            entity.HasIndex(e => e.UserId, "IX_UserLoginPasswordHistories_UserID");

            entity.Property(e => e.HistoryId).HasColumnName("HistoryID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ForceResetOn).HasColumnType("datetime");
            entity.Property(e => e.IsForceReset).HasDefaultValue(false);
            entity.Property(e => e.LogOutTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.UserLoginPasswordHistories)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserLoginPasswordHistories_Users");
        });

        modelBuilder.Entity<UserManagerMappingLog>(entity =>
        {
            entity.HasKey(e => e.MappingId);

            entity.ToTable("UserManagerMappingLog");

            entity.Property(e => e.MappingId).HasColumnName("MappingID");
            entity.Property(e => e.ChangedDateTime).HasColumnType("datetime");
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Manager).WithMany(p => p.UserManagerMappingLogManagers)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("FK_UserManagerMappingLog_ManagerID");

            entity.HasOne(d => d.User).WithMany(p => p.UserManagerMappingLogUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserManagerMappingLog_UserID");
        });

        modelBuilder.Entity<UserModuleAccessMapping>(entity =>
        {
            entity.ToTable("UserModuleAccessMapping");

            entity.Property(e => e.UserModuleAccessMappingId).HasColumnName("UserModuleAccessMappingID");
            entity.Property(e => e.AccessToUserId).HasColumnName("AccessToUserID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.AccessToUser).WithMany(p => p.UserModuleAccessMappingAccessToUsers)
                .HasForeignKey(d => d.AccessToUserId)
                .HasConstraintName("FK_UserModuleAccessMapping_Users_AccessTo");

            entity.HasOne(d => d.Module).WithMany(p => p.UserModuleAccessMappings)
                .HasForeignKey(d => d.ModuleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserModuleAccessMapping_Modules");

            entity.HasOne(d => d.User).WithMany(p => p.UserModuleAccessMappingUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserModuleAccessMapping_Users");
        });

        modelBuilder.Entity<UserMonthlyTarget>(entity =>
        {
            entity.HasKey(e => e.UserMonthlyTargetId).HasName("PK_UserMonthlyTarget");

            entity.HasIndex(e => e.UserId, "IX_UserMonthlyTarget_UserID");

            entity.Property(e => e.UserMonthlyTargetId).HasColumnName("UserMonthlyTargetID");
            entity.Property(e => e.CallCount).HasDefaultValue(0);
            entity.Property(e => e.ClosedDealCount).HasDefaultValue(0);
            entity.Property(e => e.ClosedDealRevenue)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.ClosedDealSize).HasColumnType("money");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.MeetingCount).HasDefaultValue(0);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.UserMonthlyTargets)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserMonthlyTargets_Users");
        });

        modelBuilder.Entity<UserOtphistory>(entity =>
        {
            entity.ToTable("UserOTPHistory");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsValid).HasDefaultValue(true);
            entity.Property(e => e.Otp)
                .HasMaxLength(10)
                .HasColumnName("OTP");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.UserOtphistories)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserOTPHistory_Users");
        });

        modelBuilder.Entity<UserPinMapping>(entity =>
        {
            entity.ToTable("UserPinMapping");

            entity.HasIndex(e => e.UserId, "IX_UserPinMapping_UserID");

            entity.Property(e => e.UserPinMappingId).HasColumnName("UserPinMappingID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.UserPinMappings)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserPinMapping_Users");
        });

        modelBuilder.Entity<UserProductMapping>(entity =>
        {
            entity.HasKey(e => e.UserProductMappingId).HasName("PK__UserProd__916D075624898402");

            entity.ToTable("UserProductMapping");

            entity.Property(e => e.UserProductMappingId).HasColumnName("UserProductMappingID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Product).WithMany(p => p.UserProductMappings)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserProdu__Produ__7D39791C");

            entity.HasOne(d => d.User).WithMany(p => p.UserProductMappings)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserProdu__UserI__10F1C6C6");
        });

        modelBuilder.Entity<UserQuestionAnswerMapping>(entity =>
        {
            entity.HasKey(e => e.UserQuestionAnswerMappingId).HasName("PK_UserQuestionsMapping");

            entity.ToTable("UserQuestionAnswerMapping");

            entity.Property(e => e.Answers).HasMaxLength(4000);
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Question).WithMany(p => p.UserQuestionAnswerMappings)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserQuestionAnswerMapping_SecurityQuestions");

            entity.HasOne(d => d.User).WithMany(p => p.UserQuestionAnswerMappings)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserQuestionAnswerMapping_Users");
        });

        modelBuilder.Entity<UserRoleMapping>(entity =>
        {
            entity.ToTable("UserRoleMapping");

            entity.HasIndex(e => e.RoleId, "IX_UserRoleMapping_RoleID");

            entity.HasIndex(e => e.UserId, "IX_UserRoleMapping_UserID");

            entity.Property(e => e.UserRoleMappingId).HasColumnName("UserRoleMappingID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Role).WithMany(p => p.UserRoleMappings)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRoleMapping_Roles");

            entity.HasOne(d => d.User).WithMany(p => p.UserRoleMappings)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRoleMapping_Users");
        });

        modelBuilder.Entity<UserSegmentMapping>(entity =>
        {
            entity.HasKey(e => e.UserSegmentMappingId).HasName("PK__UserSegm__A5AC5CAC1677ABD9");

            entity.ToTable("UserSegmentMapping");

            entity.Property(e => e.UserSegmentMappingId).HasColumnName("UserSegmentMappingID");
            entity.Property(e => e.ContactSegmentId).HasColumnName("ContactSegmentID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.ContactSegment).WithMany(p => p.UserSegmentMappings)
                .HasForeignKey(d => d.ContactSegmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserSegme__Conta__0A93743A");

            entity.HasOne(d => d.User).WithMany(p => p.UserSegmentMappings)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserSegme__UserI__12DA0F38");
        });

        modelBuilder.Entity<UserSessionTokenHistory>(entity =>
        {
            entity.HasKey(e => e.UserSessionTokenId).HasName("PK_UserSessionTokenHistory");

            entity.Property(e => e.UserSessionTokenId).HasColumnName("UserSessionTokenID");
            entity.Property(e => e.IsActive).HasDefaultValue(false);
            entity.Property(e => e.LogOnDateTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserSetting>(entity =>
        {
            entity.Property(e => e.UserSettingId).HasColumnName("UserSettingID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crmcode)
                .HasMaxLength(100)
                .HasColumnName("CRMCode");
            entity.Property(e => e.DescriptionOl1).HasColumnName("Description_OL1");
            entity.Property(e => e.DescriptionOl2).HasColumnName("Description_OL2");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.DisplayNameOl1).HasColumnName("DisplayName_OL1");
            entity.Property(e => e.DisplayNameOl2).HasColumnName("DisplayName_OL2");
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SettingControlTypeId).HasColumnName("SettingControlTypeID");

            entity.HasOne(d => d.SettingControlType).WithMany(p => p.UserSettings)
                .HasForeignKey(d => d.SettingControlTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserSettings_SettingControlTypes");
        });

        modelBuilder.Entity<UserSettingMapping>(entity =>
        {
            entity.ToTable("UserSettingMapping");

            entity.Property(e => e.UserSettingMappingId)
                .ValueGeneratedNever()
                .HasColumnName("UserSettingMappingID");
            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserSettingId).HasColumnName("UserSettingID");

            entity.HasOne(d => d.User).WithMany(p => p.UserSettingMappings)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserSettingMapping_Users");

            entity.HasOne(d => d.UserSetting).WithMany(p => p.UserSettingMappings)
                .HasForeignKey(d => d.UserSettingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserSettingMapping_UserSettings");
        });

        modelBuilder.Entity<UserSuccessfulLogin>(entity =>
        {
            entity.ToTable("UserSuccessfulLogin");

            entity.HasIndex(e => e.UserId, "IX_UserSuccessfulLogin_UserID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BrowserName).HasMaxLength(100);
            entity.Property(e => e.ClientIpaddress)
                .HasMaxLength(50)
                .HasColumnName("ClientIPAddress");
            entity.Property(e => e.LastLoginDateTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.UserSuccessfulLogins)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserSuccessfulLogin_Users");
        });

        modelBuilder.Entity<UserUnTaggedHistory>(entity =>
        {
            entity.HasKey(e => e.UserUnTaggedHistoryId);

            entity.ToTable("UserUnTaggedHistory");

            entity.Property(e => e.UserUnTaggedHistoryId).HasColumnName("UserUnTaggedHistoryID");
            entity.Property(e => e.DeviceObjectId).HasColumnName("DeviceObjectID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.UnTaggedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.UnTaggedByNavigation).WithMany(p => p.UserUnTaggedHistories)
                .HasForeignKey(d => d.UnTaggedBy)
                .HasConstraintName("FK_UserUnTaggedHistory_Users");
        });

        modelBuilder.Entity<UserWorkAddressMapping>(entity =>
        {
            entity.HasKey(e => e.UserWorkAddressMappingId).HasName("PK__UserWork__4CA995892BA57174");

            entity.ToTable("UserWorkAddressMapping");

            entity.Property(e => e.UserWorkAddressMappingId).HasColumnName("UserWorkAddressMappingID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.WorkAddressId).HasColumnName("WorkAddressID");

            entity.HasOne(d => d.User).WithMany(p => p.UserWorkAddressMappings)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserWorkA__UserI__13CE3371");

            entity.HasOne(d => d.WorkAddress).WithMany(p => p.UserWorkAddressMappings)
                .HasForeignKey(d => d.WorkAddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserWorkA__WorkA__6D78DDF6");
        });

        modelBuilder.Entity<ValidateLink>(entity =>
        {
            entity.HasKey(e => e.LinkId);

            entity.ToTable("ValidateLink");

            entity.Property(e => e.LinkId).HasColumnName("LinkID");
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.ValidateLinks)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ValidateLink_ValidateLink");
        });

        modelBuilder.Entity<VwAaibAllActivity>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_AAIB_AllActivities");

            entity.Property(e => e.ActivityCreatedDate).HasMaxLength(4000);
            entity.Property(e => e.ActivityDoneDate).HasMaxLength(4000);
            entity.Property(e => e.ActivityDoneTime)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.ActivityOutcome).HasColumnName("Activity Outcome");
            entity.Property(e => e.ActivityOwnerBranchCode).HasMaxLength(300);
            entity.Property(e => e.ActivityOwnerBranchName).HasMaxLength(300);
            entity.Property(e => e.ActivityStatus)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.ActivityType).HasMaxLength(50);
            entity.Property(e => e.ContactBranchCode).HasMaxLength(200);
            entity.Property(e => e.ContactBranchName).HasMaxLength(100);
            entity.Property(e => e.ContactName).HasMaxLength(256);
            entity.Property(e => e.ContactSegment).HasMaxLength(500);
            entity.Property(e => e.CustomerId)
                .HasMaxLength(100)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ScheduledDate).HasMaxLength(4000);
            entity.Property(e => e.ScheduledTime).HasMaxLength(20);
        });

        modelBuilder.Entity<VwAaibAllDeal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_AAIB_AllDeals");

            entity.Property(e => e.ActualDealCloseDate).HasMaxLength(4000);
            entity.Property(e => e.ActualDealRevenue).HasColumnType("money");
            entity.Property(e => e.ActualDealSize).HasColumnType("money");
            entity.Property(e => e.CampaignId).HasColumnName("CampaignID");
            entity.Property(e => e.CampaignName).HasMaxLength(100);
            entity.Property(e => e.ContactBranchCode).HasMaxLength(100);
            entity.Property(e => e.ContactBranchName).HasMaxLength(200);
            entity.Property(e => e.ContactCity)
                .HasMaxLength(2000)
                .HasColumnName("Contact_City");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(500)
                .HasColumnName("Contact_Email");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.ContactLastContactedDate).HasMaxLength(4000);
            entity.Property(e => e.ContactName).HasMaxLength(256);
            entity.Property(e => e.ContactNationalId)
                .HasMaxLength(100)
                .HasColumnName("ContactNationalID");
            entity.Property(e => e.ContactNextContactDate).HasMaxLength(4000);
            entity.Property(e => e.ContactOfficeNumber)
                .HasMaxLength(500)
                .HasColumnName("Contact_OfficeNumber");
            entity.Property(e => e.ContactOwnerName).HasMaxLength(256);
            entity.Property(e => e.ContactResidenceNumber)
                .HasMaxLength(500)
                .HasColumnName("Contact_ResidenceNumber");
            entity.Property(e => e.ContactSegment).HasMaxLength(500);
            entity.Property(e => e.ContactTier).HasMaxLength(500);
            entity.Property(e => e.ContactTradeLicenseNumber).HasMaxLength(100);
            entity.Property(e => e.ContactType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CreatorCountry).HasMaxLength(2000);
            entity.Property(e => e.CreatorUserId).HasColumnName("Creator_UserID");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(100)
                .HasColumnName("CustomerID");
            entity.Property(e => e.CustomerType).HasMaxLength(200);
            entity.Property(e => e.DealCreationDate).HasMaxLength(4000);
            entity.Property(e => e.DealCreationTime)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DealId).HasColumnName("DealID");
            entity.Property(e => e.DealLastModifiedDate).HasMaxLength(4000);
            entity.Property(e => e.DealLastModifiedTime)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DealOwnerBranchCode).HasMaxLength(300);
            entity.Property(e => e.DealOwnerBranchName).HasMaxLength(300);
            entity.Property(e => e.DealOwnerInternalCode).HasMaxLength(100);
            entity.Property(e => e.DealPhaseName).HasMaxLength(200);
            entity.Property(e => e.DealSource).HasMaxLength(200);
            entity.Property(e => e.DealStage).HasMaxLength(200);
            entity.Property(e => e.DealSubject).HasMaxLength(500);
            entity.Property(e => e.EmployerName).HasMaxLength(300);
            entity.Property(e => e.ExpectedDealCloseDate).HasMaxLength(4000);
            entity.Property(e => e.ExpectedDealRevenue).HasColumnType("money");
            entity.Property(e => e.ExpectedDealSize).HasColumnType("money");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.OwnerUserId).HasColumnName("Owner_UserID");
            entity.Property(e => e.ProductExpiryDate).HasMaxLength(4000);
            entity.Property(e => e.ProductFamilyId).HasColumnName("ProductFamilyID");
            entity.Property(e => e.ProductFamilyName).HasMaxLength(4000);
            entity.Property(e => e.ProductName).HasMaxLength(4000);
            entity.Property(e => e.ProductScheme).HasMaxLength(200);
            entity.Property(e => e.ProductStartDate).HasMaxLength(4000);
            entity.Property(e => e.ProductType).HasMaxLength(500);
            entity.Property(e => e.ReferenceNumber).HasMaxLength(100);
            entity.Property(e => e.RepEmail)
                .HasMaxLength(500)
                .HasColumnName("Rep_Email");
            entity.Property(e => e.RepOfficeNumber)
                .HasMaxLength(500)
                .HasColumnName("Rep_OfficeNumber");
            entity.Property(e => e.RepResidenceNumber)
                .HasMaxLength(500)
                .HasColumnName("Rep_ResidenceNumber");
            entity.Property(e => e.RepresentativeName).HasMaxLength(501);
        });

        modelBuilder.Entity<VwMenuTree>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMenuTree");

            entity.Property(e => e.Deptid).HasColumnName("deptid");
            entity.Property(e => e.Level).HasColumnName("LEVEL");
            entity.Property(e => e.Parent).HasColumnName("parent");
            entity.Property(e => e.Treepath)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("treepath");
        });

        modelBuilder.Entity<VwOrgSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwOrgSettings");

            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.OrganisationSettingId).HasColumnName("OrganisationSettingID");
            entity.Property(e => e.SettingsKey).HasMaxLength(400);
            entity.Property(e => e.SettingsValue).HasMaxLength(512);
        });

        modelBuilder.Entity<VwOrganisationTree>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwOrganisationTree");

            entity.Property(e => e.Deptid).HasColumnName("deptid");
            entity.Property(e => e.Level).HasColumnName("LEVEL");
            entity.Property(e => e.Organisations).HasColumnName("organisations");
            entity.Property(e => e.Parent).HasColumnName("parent");
            entity.Property(e => e.Treepath)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("treepath");
        });

        modelBuilder.Entity<VwRoleMenuMapping>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwRoleMenuMapping");

            entity.Property(e => e.CreatedAt).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeviceObjId)
                .HasMaxLength(200)
                .HasColumnName("DeviceObjID");
            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.ModifiedAt).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.RoleMenuMappingId).HasColumnName("RoleMenuMappingID");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<WindowsSchedulerSetting>(entity =>
        {
            entity.HasKey(e => e.WindowsSchedulerSettingId).HasName("PK__WindowsS__3214EC079518E288");

            entity.Property(e => e.WindowsSchedulerSettingId).HasColumnName("WindowsSchedulerSettingID");
            entity.Property(e => e.CalculationMonth).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.ControlType).HasMaxLength(50);
            entity.Property(e => e.ExportFileNameExtension)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ExportFileNamePrefix).HasMaxLength(200);
            entity.Property(e => e.ExportFileNameSufix).HasMaxLength(200);
            entity.Property(e => e.FrequencyId).HasColumnName("FrequencyID");
            entity.Property(e => e.IsExportAllowed).HasDefaultValue(false);
            entity.Property(e => e.Key).HasMaxLength(255);
            entity.Property(e => e.ModifiedOn)
                .HasDefaultValueSql("(sysutcdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.SelectedIntervalTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<WorkAddress>(entity =>
        {
            entity.HasKey(e => e.WorkAddressId).HasName("PK__WorkAddr__BF677F27E75D8545");

            entity.ToTable("WorkAddress");

            entity.Property(e => e.WorkAddressId).HasColumnName("WorkAddressID");
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BranchCode).HasMaxLength(300);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(300);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.ServerDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Organisation).WithMany(p => p.WorkAddresses)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK__WorkAddre__Organ__141CDE74");
        });

        modelBuilder.Entity<WorkflowGroupHistoryRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("WorkflowGroupHistoryRelatedData");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DealId).HasColumnName("DealID");
            entity.Property(e => e.DealStage).HasMaxLength(255);
            entity.Property(e => e.DealStageId)
                .HasMaxLength(255)
                .HasColumnName("DealStageID");
            entity.Property(e => e.ExitDate).HasColumnType("datetime");
            entity.Property(e => e.GroupHistoryId).HasColumnName("GroupHistoryID");
            entity.Property(e => e.GroupName).HasMaxLength(255);
            entity.Property(e => e.Tat)
                .HasMaxLength(100)
                .HasColumnName("TAT");
        });

        modelBuilder.Entity<WorkflowUserHistoryRelatedDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("WorkflowUserHistoryRelatedData");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DealId).HasColumnName("DealID");
            entity.Property(e => e.DealStage).HasMaxLength(255);
            entity.Property(e => e.DealStageId).HasColumnName("DealStageID");
            entity.Property(e => e.ExitDate).HasColumnType("datetime");
            entity.Property(e => e.GroupName).HasMaxLength(255);
            entity.Property(e => e.ParticipantHistoryId).HasColumnName("ParticipantHistoryID");
            entity.Property(e => e.ParticipantName).HasMaxLength(255);
            entity.Property(e => e.Tat)
                .HasMaxLength(100)
                .HasColumnName("TAT");
            entity.Property(e => e.WorkFlowUserId).HasColumnName("WorkFlowUserID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
