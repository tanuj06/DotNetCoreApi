using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class AuditAll
{
    public long AuditId { get; set; }

    public string? ModuleName { get; set; }

    public string? TableName { get; set; }

    public string? FieldName { get; set; }

    public long? Pkid { get; set; }

    public string? Pkvalue { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public string? Description { get; set; }

    public string? ReferrelTableName { get; set; }

    public string? ReferrelTablePkfield { get; set; }

    public string? ReferrelTableDataColumnName { get; set; }

    public string? UserName { get; set; }

    public string? UpdateDate { get; set; }
}
