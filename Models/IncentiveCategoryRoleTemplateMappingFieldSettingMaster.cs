using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveCategoryRoleTemplateMappingFieldSettingMaster
{
    public long Id { get; set; }

    public bool? IsStaticField { get; set; }

    public double? FieldIndex { get; set; }

    public string? FieldName { get; set; }

    public string? FieldLabel { get; set; }

    public string? FieldDataType { get; set; }

    public bool? IsMandatory { get; set; }

    public bool? IsVisible { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }
}
