using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class GameSetupPageField
{
    public long GameSetupPageFieldId { get; set; }

    public string? FieldName { get; set; }

    public bool? IsPrimaryColumn { get; set; }

    public bool IsFlagColumn { get; set; }

    public string? ColumnTextField { get; set; }

    public bool IsDefaultTextColumn { get; set; }

    public bool IsMappingField { get; set; }

    public string? RelatedField { get; set; }

    public bool IsAddMode { get; set; }
}
