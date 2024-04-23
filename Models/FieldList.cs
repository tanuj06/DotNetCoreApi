using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class FieldList
{
    public string PageCode { get; set; } = null!;

    public long Id { get; set; }

    public string? FieldName { get; set; }

    public string? FieldValue { get; set; }

    public Guid Identifier { get; set; }
}
