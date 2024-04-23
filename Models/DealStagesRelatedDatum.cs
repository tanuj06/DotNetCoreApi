using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DealStagesRelatedDatum
{
    public long DealStageId { get; set; }

    public long? OrganisationId { get; set; }

    public string? Name { get; set; }

    public string? StageDescription { get; set; }

    public double? Sequence { get; set; }

    public string? Crmcode { get; set; }

    public string? DealStageCode { get; set; }

    public int? StagnantPeriodInDays { get; set; }

    public bool IsApprovalRequired { get; set; }

    public bool IsVisibleForRm { get; set; }

    public bool IsActive { get; set; }

    public long? DefaultAvailableWithGroupId { get; set; }

    public string? DefaultAvailableWithGroup { get; set; }

    public string? AvailableWithGroups { get; set; }

    public string? VisibilityToGroups { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
