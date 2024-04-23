using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class TempUser
{
    public long Id { get; set; }

    public long? UserId { get; set; }

    public long? OrganisationId { get; set; }

    public string? UserName { get; set; }

    public long? ManagerId { get; set; }

    public long? SalutationId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public DateTime? Dob { get; set; }

    public long? DesignationId { get; set; }

    public long? UnitId { get; set; }

    public int? AllowedContactTypes { get; set; }

    public long? PrefferedLanguageId { get; set; }

    public string? PasswordSalt { get; set; }

    public byte[]? PasswordHash { get; set; }

    public bool IsActive { get; set; }

    public bool IsLocked { get; set; }

    public bool? IsForceReset { get; set; }

    public int? ResetEmailSendCount { get; set; }

    public DateTime? LastResetEmailDateTime { get; set; }

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

    public string? OperationsEmail { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public string? CityName { get; set; }

    public string? CountryName { get; set; }

    public string? StateName { get; set; }

    public string? Zip { get; set; }

    public int? CallCount { get; set; }

    public int? MeetingCount { get; set; }

    public int? ClosedDealCount { get; set; }

    public decimal? ClosedDealRevenue { get; set; }

    public decimal? ClosedDealSize { get; set; }

    public string? Status { get; set; }

    public string? Comment { get; set; }

    public bool? IsOrganisationFilterAllowed { get; set; }

    public string? RequestType { get; set; }

    public bool? HasFullDataAccessForReport { get; set; }

    public bool? IsBackupAdmin { get; set; }

    public bool? AutoContactAllocation { get; set; }

    public bool? RestrictOtherContactSearch { get; set; }

    public string? BranchName { get; set; }

    public string? BranchCode { get; set; }

    public string? BranchZone { get; set; }

    public string? Area { get; set; }

    public string? Region { get; set; }

    public int? SeniorityLevelId { get; set; }

    public bool IsRestrictedFromOwnership { get; set; }

    public long? UserImportHistoryId { get; set; }

    public long? IncentiveTemplateId { get; set; }

    public long? IncentiveBancAssuranceRoleId { get; set; }

    public int? NoOfCsrreporting { get; set; }

    public int? NoOfVipcsrreporting { get; set; }

    public int? NoOfRmreporting { get; set; }

    public string? EmployeeId { get; set; }

    public string? EmployeeNumber { get; set; }

    public long? BankId { get; set; }

    public virtual Organisation? Organisation { get; set; }

    public virtual User? User { get; set; }

    public virtual UserImportHistory? UserImportHistory { get; set; }
}
