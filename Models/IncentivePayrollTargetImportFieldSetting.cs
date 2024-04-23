using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentivePayrollTargetImportFieldSetting
{
    public long PayrollTargetFieldSettingId { get; set; }

    public long OrganisationId { get; set; }

    public int PayrollTargetFieldCategoryId { get; set; }

    public bool IsStaticField { get; set; }

    public double? FieldIndex { get; set; }

    public string FieldName { get; set; } = null!;

    public string FieldLabel { get; set; } = null!;

    public bool OverwriteIfEmpty { get; set; }

    public bool OverwriteAlways { get; set; }

    public bool CanEditedOnDevice { get; set; }

    public string FieldDataType { get; set; } = null!;

    public bool IsMandatory { get; set; }

    public string? Expression { get; set; }

    public bool IsVisible { get; set; }

    public bool IsThisPartOfUniqueCheck { get; set; }

    public bool? IsConfidential { get; set; }

    public string? Crmcode { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual Organisation Organisation { get; set; } = null!;
}
