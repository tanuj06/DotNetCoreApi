using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class AuditConfiguration
{
    public int ConfigurationId { get; set; }

    public string TableName { get; set; } = null!;

    public string? Pkfield { get; set; }

    public string FieldName { get; set; } = null!;

    public string? ReferrelTableName { get; set; }

    public string? ReferrelTablePkfield { get; set; }

    public string? ReferrelTableDataColumnName { get; set; }
}
