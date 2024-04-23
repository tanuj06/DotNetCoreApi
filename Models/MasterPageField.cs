using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class MasterPageField
{
    public long MasterPageFieldId { get; set; }

    public long MasterPageId { get; set; }

    public string? FieldName { get; set; }

    public bool? IsPrimaryColumn { get; set; }

    public bool IsFlagColumn { get; set; }

    public string? ColumnTextField { get; set; }

    public bool IsDefaultTextColumn { get; set; }

    public bool IsMappingField { get; set; }

    public virtual MasterPage MasterPage { get; set; } = null!;
}
