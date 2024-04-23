using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentivePayrollTargetImportMapping
{
    public long PayrollTargetImportMappingId { get; set; }

    public long PayrollTargetFieldSettingId { get; set; }

    public string ImportFieldNameFromFile { get; set; } = null!;

    public long ImportHistoryId { get; set; }

    public virtual IncentivePayrollTargetImportHistory ImportHistory { get; set; } = null!;
}
