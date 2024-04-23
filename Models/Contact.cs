using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class Contact
{
    public long ContactId { get; set; }

    public long ContactTypeId { get; set; }

    public long? OrganisationId { get; set; }

    public long? SalutationId { get; set; }

    public long? ContactSegmentId { get; set; }

    public long? OrganisationTierMappingId { get; set; }

    public long? ImportHistoryId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? CompanyName { get; set; }

    public string? CustomerId { get; set; }

    public long? ProfileImageId { get; set; }

    public long? ContactSourceId { get; set; }

    public long? CampaignReferenceId { get; set; }

    public string? CompanyWebsite { get; set; }

    public string? JobTitle { get; set; }

    public DateOnly? LastContactedDate { get; set; }

    public DateOnly? NextContactedDate { get; set; }

    public bool? IsRepresentative { get; set; }

    public long? CreatorId { get; set; }

    public long? CreatorOrgId { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsClient { get; set; }

    public bool? IsEmployer { get; set; }

    public bool? IsConfidential { get; set; }

    public bool? IsEdited { get; set; }

    public bool? IsUploaded { get; set; }

    public string? Crmcode { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public bool? IsDeleteRequestRaised { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public int? AddedFromSource { get; set; }

    public string? DeviceId { get; set; }

    public bool? SyncedInCrm { get; set; }

    public string? PrimaryEmailAddress { get; set; }

    public string? PrimaryPhoneNumber { get; set; }

    public string? CrmsyncErrorCode { get; set; }

    public string? CrmsyncErrorMessage { get; set; }

    public DateOnly? Dob { get; set; }

    public string? LeadId { get; set; }

    public string? NationalId { get; set; }

    public string? TradeLicenseNumber { get; set; }

    public string? PoboxNumber { get; set; }

    public string? BranchName { get; set; }

    public string? BranchCode { get; set; }

    public int? ContactStatusId { get; set; }

    public int? NationalityId { get; set; }

    public int? EmploymentTypeId { get; set; }

    public int? NationalIdTypeId { get; set; }

    public decimal? MonthlySalary { get; set; }

    public int? LanguageSpeakId { get; set; }

    public bool? IncludeContactForGamification { get; set; }

    public bool? IsFavourite { get; set; }

    public bool? IsContacted { get; set; }

    public bool? IsNeverContacted { get; set; }

    public bool? IsDueToContact { get; set; }

    public bool? IsNotYetDueToContact { get; set; }

    public bool? IsOverdueToContact { get; set; }

    public bool? HasPipelineDeal { get; set; }

    public bool? HasOverdueDeal { get; set; }

    public bool? HasClosedDeal { get; set; }

    public bool? HasPlannedActivity { get; set; }

    public int? ReferralType { get; set; }

    public long? ReferredBy { get; set; }

    public string? OtherReferral { get; set; }

    public string? Gender { get; set; }

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();

    public virtual ICollection<ActivityMappingHistory> ActivityMappingHistories { get; set; } = new List<ActivityMappingHistory>();

    public virtual CampaignReference? CampaignReference { get; set; }

    public virtual ICollection<ContactAssignmentEmailNotificationLog> ContactAssignmentEmailNotificationLogs { get; set; } = new List<ContactAssignmentEmailNotificationLog>();

    public virtual ICollection<ContactCampaignMappingHistory> ContactCampaignMappingHistories { get; set; } = new List<ContactCampaignMappingHistory>();

    public virtual ICollection<ContactDynamicField> ContactDynamicFields { get; set; } = new List<ContactDynamicField>();

    public virtual ICollection<ContactGroupMapping> ContactGroupMappings { get; set; } = new List<ContactGroupMapping>();

    public virtual ICollection<ContactImportAudit> ContactImportAudits { get; set; } = new List<ContactImportAudit>();

    public virtual ICollection<ContactOfflineSyncLog> ContactOfflineSyncLogs { get; set; } = new List<ContactOfflineSyncLog>();

    public virtual ICollection<ContactProductImportAudit> ContactProductImportAudits { get; set; } = new List<ContactProductImportAudit>();

    public virtual ICollection<ContactProductMappingHistory> ContactProductMappingHistories { get; set; } = new List<ContactProductMappingHistory>();

    public virtual ICollection<ContactRelationshipMapping> ContactRelationshipMappingContacts { get; set; } = new List<ContactRelationshipMapping>();

    public virtual ICollection<ContactRelationshipMapping> ContactRelationshipMappingRelationshipWithContacts { get; set; } = new List<ContactRelationshipMapping>();

    public virtual ContactSegment? ContactSegment { get; set; }

    public virtual ContactDealSource? ContactSource { get; set; }

    public virtual ContactStatus? ContactStatus { get; set; }

    public virtual ContactType ContactType { get; set; } = null!;

    public virtual ICollection<ContactUserMapping> ContactUserMappings { get; set; } = new List<ContactUserMapping>();

    public virtual ICollection<Deal> Deals { get; set; } = new List<Deal>();

    public virtual EmploymentType? EmploymentType { get; set; }

    public virtual ContactImportHistory? ImportHistory { get; set; }

    public virtual ICollection<ImportHistoryContactMapping> ImportHistoryContactMappings { get; set; } = new List<ImportHistoryContactMapping>();

    public virtual LanguageSpeak? LanguageSpeak { get; set; }

    public virtual NationalIdType? NationalIdType { get; set; }

    public virtual Nationality? Nationality { get; set; }

    public virtual ICollection<Note> Notes { get; set; } = new List<Note>();

    public virtual Organisation? Organisation { get; set; }

    public virtual OrganisationTierMapping? OrganisationTierMapping { get; set; }

    public virtual BankEmployee? ReferredByNavigation { get; set; }

    public virtual Salutation? Salutation { get; set; }
}
