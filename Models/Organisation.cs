using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class Organisation
{
    public long OrganisationId { get; set; }

    public long OrganisationTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string? NameOl1 { get; set; }

    public string? NameOl2 { get; set; }

    public string? Website { get; set; }

    public string? Address { get; set; }

    public string? PhoneNo { get; set; }

    public long? ParentOrganisationId { get; set; }

    public double? Sequence { get; set; }

    public string? Crmcode { get; set; }

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

    public string? Country { get; set; }

    public int? IndustryId { get; set; }

    public int? SourceId { get; set; }

    public long? TimeZoneId { get; set; }

    public virtual ICollection<ActivityClassification> ActivityClassifications { get; set; } = new List<ActivityClassification>();

    public virtual ICollection<ActivityDuration> ActivityDurations { get; set; } = new List<ActivityDuration>();

    public virtual ICollection<ActivityFieldSetting> ActivityFieldSettings { get; set; } = new List<ActivityFieldSetting>();

    public virtual ICollection<ActivityImportHistory> ActivityImportHistories { get; set; } = new List<ActivityImportHistory>();

    public virtual ICollection<ActivityNote> ActivityNotes { get; set; } = new List<ActivityNote>();

    public virtual ICollection<ActivityReminderDuration> ActivityReminderDurations { get; set; } = new List<ActivityReminderDuration>();

    public virtual ICollection<ActivityTime> ActivityTimes { get; set; } = new List<ActivityTime>();

    public virtual ICollection<AduserSyncLog> AduserSyncLogs { get; set; } = new List<AduserSyncLog>();

    public virtual ICollection<BankEmployeeFieldSetting> BankEmployeeFieldSettings { get; set; } = new List<BankEmployeeFieldSetting>();

    public virtual ICollection<BankEmployeeImportHistory> BankEmployeeImportHistories { get; set; } = new List<BankEmployeeImportHistory>();

    public virtual ICollection<BankEmployee> BankEmployees { get; set; } = new List<BankEmployee>();

    public virtual ICollection<Bank> Banks { get; set; } = new List<Bank>();

    public virtual ICollection<CampaignReference> CampaignReferences { get; set; } = new List<CampaignReference>();

    public virtual ICollection<ChecklistDocument> ChecklistDocuments { get; set; } = new List<ChecklistDocument>();

    public virtual ICollection<ChecklistGroup> ChecklistGroups { get; set; } = new List<ChecklistGroup>();

    public virtual ICollection<ChecklistManagement> ChecklistManagements { get; set; } = new List<ChecklistManagement>();

    public virtual ICollection<CommunicationType> CommunicationTypes { get; set; } = new List<CommunicationType>();

    public virtual ICollection<ContactAutoAllocationFieldSetting> ContactAutoAllocationFieldSettings { get; set; } = new List<ContactAutoAllocationFieldSetting>();

    public virtual ICollection<ContactDealSource> ContactDealSources { get; set; } = new List<ContactDealSource>();

    public virtual ICollection<ContactFieldSetting> ContactFieldSettings { get; set; } = new List<ContactFieldSetting>();

    public virtual ICollection<ContactGroup> ContactGroups { get; set; } = new List<ContactGroup>();

    public virtual ICollection<ContactImportHistory> ContactImportHistories { get; set; } = new List<ContactImportHistory>();

    public virtual ICollection<ContactProductFieldSetting> ContactProductFieldSettings { get; set; } = new List<ContactProductFieldSetting>();

    public virtual ICollection<ContactProductImportHistory> ContactProductImportHistories { get; set; } = new List<ContactProductImportHistory>();

    public virtual ICollection<ContactRelationshipMapping> ContactRelationshipMappings { get; set; } = new List<ContactRelationshipMapping>();

    public virtual ICollection<ContactRelationshipTypeInverseMapping> ContactRelationshipTypeInverseMappings { get; set; } = new List<ContactRelationshipTypeInverseMapping>();

    public virtual ICollection<ContactRelationshipType> ContactRelationshipTypes { get; set; } = new List<ContactRelationshipType>();

    public virtual ICollection<ContactSegment> ContactSegments { get; set; } = new List<ContactSegment>();

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual ICollection<CorrospondanceType> CorrospondanceTypes { get; set; } = new List<CorrospondanceType>();

    public virtual ICollection<Currency> Currencies { get; set; } = new List<Currency>();

    public virtual ICollection<CustomerType> CustomerTypes { get; set; } = new List<CustomerType>();

    public virtual ICollection<DashboardCirclesConfiguration> DashboardCirclesConfigurations { get; set; } = new List<DashboardCirclesConfiguration>();

    public virtual ICollection<DealCompetitor> DealCompetitors { get; set; } = new List<DealCompetitor>();

    public virtual ICollection<DealFieldSetting> DealFieldSettings { get; set; } = new List<DealFieldSetting>();

    public virtual ICollection<DealImportHistory> DealImportHistories { get; set; } = new List<DealImportHistory>();

    public virtual ICollection<DealStage> DealStages { get; set; } = new List<DealStage>();

    public virtual ICollection<Deal> Deals { get; set; } = new List<Deal>();

    public virtual ICollection<Designation> Designations { get; set; } = new List<Designation>();

    public virtual ICollection<EmploymentType> EmploymentTypes { get; set; } = new List<EmploymentType>();

    public virtual ICollection<FbleadFormProductMapping> FbleadFormProductMappings { get; set; } = new List<FbleadFormProductMapping>();

    public virtual ICollection<GameDepartmentAwardMapping> GameDepartmentAwardMappings { get; set; } = new List<GameDepartmentAwardMapping>();

    public virtual ICollection<GameLevelSetup> GameLevelSetups { get; set; } = new List<GameLevelSetup>();

    public virtual ICollection<GameSetting> GameSettings { get; set; } = new List<GameSetting>();

    public virtual ICollection<Game> Games { get; set; } = new List<Game>();

    public virtual ICollection<IncentiveBranchCategoryFieldSetting> IncentiveBranchCategoryFieldSettings { get; set; } = new List<IncentiveBranchCategoryFieldSetting>();

    public virtual ICollection<IncentiveBranchCategoryImportHistory> IncentiveBranchCategoryImportHistories { get; set; } = new List<IncentiveBranchCategoryImportHistory>();

    public virtual ICollection<IncentiveCategoryRoleTemplateMappingFieldSetting> IncentiveCategoryRoleTemplateMappingFieldSettings { get; set; } = new List<IncentiveCategoryRoleTemplateMappingFieldSetting>();

    public virtual ICollection<IncentiveCategoryRoleTemplateMappingImportHistory> IncentiveCategoryRoleTemplateMappingImportHistories { get; set; } = new List<IncentiveCategoryRoleTemplateMappingImportHistory>();

    public virtual ICollection<IncentiveCreditCardTierGroup> IncentiveCreditCardTierGroups { get; set; } = new List<IncentiveCreditCardTierGroup>();

    public virtual ICollection<IncentiveCreditCardTier> IncentiveCreditCardTiers { get; set; } = new List<IncentiveCreditCardTier>();

    public virtual ICollection<IncentiveDebitCardType> IncentiveDebitCardTypes { get; set; } = new List<IncentiveDebitCardType>();

    public virtual ICollection<IncentiveGranteeIndicatorWording> IncentiveGranteeIndicatorWordings { get; set; } = new List<IncentiveGranteeIndicatorWording>();

    public virtual ICollection<IncentiveGranteeType> IncentiveGranteeTypes { get; set; } = new List<IncentiveGranteeType>();

    public virtual ICollection<IncentivePayrollTargetImportFieldSetting> IncentivePayrollTargetImportFieldSettings { get; set; } = new List<IncentivePayrollTargetImportFieldSetting>();

    public virtual ICollection<IncentivePayrollTargetImportHistory> IncentivePayrollTargetImportHistories { get; set; } = new List<IncentivePayrollTargetImportHistory>();

    public virtual ICollection<IncentivePrepaidCardType> IncentivePrepaidCardTypes { get; set; } = new List<IncentivePrepaidCardType>();

    public virtual ICollection<IncentivePrimaryCreditCardType> IncentivePrimaryCreditCardTypes { get; set; } = new List<IncentivePrimaryCreditCardType>();

    public virtual ICollection<IncentiveSupplementaryCreditCardType> IncentiveSupplementaryCreditCardTypes { get; set; } = new List<IncentiveSupplementaryCreditCardType>();

    public virtual ICollection<IncentiveTemplateProductFieldSetting> IncentiveTemplateProductFieldSettings { get; set; } = new List<IncentiveTemplateProductFieldSetting>();

    public virtual ICollection<IncentiveTemplateProductImportHistory> IncentiveTemplateProductImportHistories { get; set; } = new List<IncentiveTemplateProductImportHistory>();

    public virtual ICollection<IncentiveUserWiseMonthlyStat> IncentiveUserWiseMonthlyStats { get; set; } = new List<IncentiveUserWiseMonthlyStat>();

    public virtual ICollection<IncentiveUserWiseNonMonthlyProductStat> IncentiveUserWiseNonMonthlyProductStats { get; set; } = new List<IncentiveUserWiseNonMonthlyProductStat>();

    public virtual OrganisationIndustry? Industry { get; set; }

    public virtual ICollection<JobTitleParentJobTitleMappingImportFieldSetting> JobTitleParentJobTitleMappingImportFieldSettings { get; set; } = new List<JobTitleParentJobTitleMappingImportFieldSetting>();

    public virtual ICollection<JobTitleParentJobTitleMappingImportHistory> JobTitleParentJobTitleMappingImportHistories { get; set; } = new List<JobTitleParentJobTitleMappingImportHistory>();

    public virtual ICollection<LicenseReferral> LicenseReferrals { get; set; } = new List<LicenseReferral>();

    public virtual ICollection<LicenseTransaction> LicenseTransactions { get; set; } = new List<LicenseTransaction>();

    public virtual ICollection<NationalIdType> NationalIdTypes { get; set; } = new List<NationalIdType>();

    public virtual ICollection<Nationality> Nationalities { get; set; } = new List<Nationality>();

    public virtual ICollection<Note> Notes { get; set; } = new List<Note>();

    public virtual ICollection<OrganisationCurrencyMapping> OrganisationCurrencyMappings { get; set; } = new List<OrganisationCurrencyMapping>();

    public virtual ICollection<OrganisationModulePermission> OrganisationModulePermissions { get; set; } = new List<OrganisationModulePermission>();

    public virtual ICollection<OrganisationProductFamilyMapping> OrganisationProductFamilyMappings { get; set; } = new List<OrganisationProductFamilyMapping>();

    public virtual ICollection<OrganisationSettingMapping> OrganisationSettingMappings { get; set; } = new List<OrganisationSettingMapping>();

    public virtual ICollection<OrganisationTierMapping> OrganisationTierMappings { get; set; } = new List<OrganisationTierMapping>();

    public virtual OrganisationType OrganisationType { get; set; } = null!;

    public virtual ICollection<ProductFamily> ProductFamilies { get; set; } = new List<ProductFamily>();

    public virtual ICollection<ProductScheme> ProductSchemes { get; set; } = new List<ProductScheme>();

    public virtual ICollection<ProductType> ProductTypes { get; set; } = new List<ProductType>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<RoleDesignationMappingImportFieldSetting> RoleDesignationMappingImportFieldSettings { get; set; } = new List<RoleDesignationMappingImportFieldSetting>();

    public virtual ICollection<RoleDesignationMappingImportHistory> RoleDesignationMappingImportHistories { get; set; } = new List<RoleDesignationMappingImportHistory>();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();

    public virtual ICollection<SalesMethod> SalesMethods { get; set; } = new List<SalesMethod>();

    public virtual ICollection<Salutation> Salutations { get; set; } = new List<Salutation>();

    public virtual ICollection<SecurityQuestion> SecurityQuestions { get; set; } = new List<SecurityQuestion>();

    public virtual ICollection<SeniorityLevel> SeniorityLevels { get; set; } = new List<SeniorityLevel>();

    public virtual OrganisationSource? Source { get; set; }

    public virtual ICollection<SubscriptionCustomerMapping> SubscriptionCustomerMappings { get; set; } = new List<SubscriptionCustomerMapping>();

    public virtual ICollection<SubscriptionOrganisationMapping> SubscriptionOrganisationMappings { get; set; } = new List<SubscriptionOrganisationMapping>();

    public virtual ICollection<SubscriptionRedemption> SubscriptionRedemptions { get; set; } = new List<SubscriptionRedemption>();

    public virtual ICollection<TempUserImportHistory> TempUserImportHistories { get; set; } = new List<TempUserImportHistory>();

    public virtual ICollection<TempUser> TempUsers { get; set; } = new List<TempUser>();

    public virtual TimeZone? TimeZone { get; set; }

    public virtual ICollection<Unit> Units { get; set; } = new List<Unit>();

    public virtual ICollection<UserAuditTrail> UserAuditTrails { get; set; } = new List<UserAuditTrail>();

    public virtual ICollection<UserFieldSetting> UserFieldSettings { get; set; } = new List<UserFieldSetting>();

    public virtual ICollection<UserGroupMapping> UserGroupMappings { get; set; } = new List<UserGroupMapping>();

    public virtual ICollection<UserGroup> UserGroups { get; set; } = new List<UserGroup>();

    public virtual ICollection<UserImportHistory> UserImportHistories { get; set; } = new List<UserImportHistory>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public virtual ICollection<WorkAddress> WorkAddresses { get; set; } = new List<WorkAddress>();
}
