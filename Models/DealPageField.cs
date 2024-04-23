using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DealPageField
{
    public long DealPageFieldId { get; set; }

    public string? FieldName { get; set; }

    public bool? IsPrimaryColumn { get; set; }

    public bool IsFlagColumn { get; set; }

    public string? ColumnTextField { get; set; }

    public bool IsDefaultTextColumn { get; set; }

    public bool IsMappingField { get; set; }

    public int? AuditType { get; set; }

    public string? RelatedField { get; set; }

    public string? MappingTableName { get; set; }

    public bool IsDynamicField { get; set; }
}
