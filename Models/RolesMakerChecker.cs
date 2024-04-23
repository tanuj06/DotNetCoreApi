using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class RolesMakerChecker
{
    public long Id { get; set; }

    public long? RoleId { get; set; }

    public string? Name { get; set; }

    public string? NameOl1 { get; set; }

    public string? NameOl2 { get; set; }

    public long? OrganisationId { get; set; }

    public long? OrganisationLevel { get; set; }

    public long? IsAdmin { get; set; }

    public bool? IsSystemEntry { get; set; }

    public string? Description { get; set; }

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

    public bool? IsDefault { get; set; }

    public string? DefaultUrl { get; set; }

    public int? MenuId { get; set; }

    public string? Status { get; set; }

    public string? Comment { get; set; }

    public string? RequestType { get; set; }

    public bool IsAdrole { get; set; }

    public bool LimitExternalAccess { get; set; }

    public bool SystemStageUpdateAccess { get; set; }
}
