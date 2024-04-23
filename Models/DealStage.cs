using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DealStage
{
    public long DealStageId { get; set; }

    public long? ParentDealStageId { get; set; }

    public long? DealStageModelId { get; set; }

    public long? OrganisationId { get; set; }

    public string? Name { get; set; }

    public string? NameOl1 { get; set; }

    public string? NameOl2 { get; set; }

    public string? StageDescription { get; set; }

    public string? DealStageCode { get; set; }

    public bool? IsDefaultUploadStage { get; set; }

    public string? Crmcode { get; set; }

    public double? Sequence { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public bool IsSystemEntry { get; set; }

    public int? StagnantPeriodInDays { get; set; }

    public bool? IsApprovalRequired { get; set; }

    public bool? IsVisibleForRm { get; set; }

    public bool? IsActive { get; set; }

    public long? DefaultAvailableWithGroupId { get; set; }

    public long? SalesMethodId { get; set; }

    public string? DeviceObjId { get; set; }

    public string? OrderingNo { get; set; }

    public decimal? Probability { get; set; }

    public bool? SystemControlledStage { get; set; }

    public virtual ICollection<DealStageAccessRightsGroupMapping> DealStageAccessRightsGroupMappings { get; set; } = new List<DealStageAccessRightsGroupMapping>();

    public virtual ICollection<DealStageAvailableWithGroupMapping> DealStageAvailableWithGroupMappings { get; set; } = new List<DealStageAvailableWithGroupMapping>();

    public virtual ICollection<DealStageDateCapture> DealStageDateCaptures { get; set; } = new List<DealStageDateCapture>();

    public virtual DealStageModel? DealStageModel { get; set; }

    public virtual ICollection<DealWorkFlowMemberForwardHistory> DealWorkFlowMemberForwardHistories { get; set; } = new List<DealWorkFlowMemberForwardHistory>();

    public virtual ICollection<DealWorkFlowParticipantHistory> DealWorkFlowParticipantHistories { get; set; } = new List<DealWorkFlowParticipantHistory>();

    public virtual ICollection<DealWorkFlowUserGroupHistory> DealWorkFlowUserGroupHistories { get; set; } = new List<DealWorkFlowUserGroupHistory>();

    public virtual ICollection<Deal> Deals { get; set; } = new List<Deal>();

    public virtual Organisation? Organisation { get; set; }
}
