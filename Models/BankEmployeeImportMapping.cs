using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class BankEmployeeImportMapping
{
    public long BankEmployeeImportMappingId { get; set; }

    public long BankEmployeeFieldSettingId { get; set; }

    public string ImportFieldNameFromFile { get; set; } = null!;

    public long ImportHistoryId { get; set; }

    public virtual BankEmployeeImportHistory ImportHistory { get; set; } = null!;
}
