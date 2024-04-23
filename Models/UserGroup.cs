using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserGroup
{
    public long UserGroupId { get; set; }

    public long OrganisationId { get; set; }

    public string Name { get; set; } = null!;

    public string? NameOl1 { get; set; }

    public string? NameOl2 { get; set; }

    public string? Description { get; set; }

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

    public bool IsManager { get; set; }

    public int? ManagerId { get; set; }

    public bool? AutoContactAllocation { get; set; }

    public bool? RestrictOtherContactSearch { get; set; }

    public bool? IsDealWorkFlow { get; set; }

    public long? FocalPointUserId { get; set; }

    public bool IsRestrictedFromOwnership { get; set; }

    public bool LimitedUserEdit { get; set; }

    public virtual ICollection<DealStageAccessRightsGroupMapping> DealStageAccessRightsGroupMappings { get; set; } = new List<DealStageAccessRightsGroupMapping>();

    public virtual ICollection<DealStageAvailableWithGroupMapping> DealStageAvailableWithGroupMappings { get; set; } = new List<DealStageAvailableWithGroupMapping>();

    public virtual ICollection<DealWorkFlowMemberForwardHistory> DealWorkFlowMemberForwardHistories { get; set; } = new List<DealWorkFlowMemberForwardHistory>();

    public virtual ICollection<DealWorkFlowUserGroupHistory> DealWorkFlowUserGroupHistories { get; set; } = new List<DealWorkFlowUserGroupHistory>();

    public virtual Organisation Organisation { get; set; } = null!;

    public virtual ICollection<UserGroupMapping> UserGroupMappingUserGroupIdasSubGroupNavigations { get; set; } = new List<UserGroupMapping>();

    public virtual ICollection<UserGroupMapping> UserGroupMappingUserGroups { get; set; } = new List<UserGroupMapping>();
}
