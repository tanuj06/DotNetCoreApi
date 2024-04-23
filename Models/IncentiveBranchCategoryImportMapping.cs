using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveBranchCategoryImportMapping
{
    public long IncentiveBranchCategoryImportMappingId { get; set; }

    public long IncentiveBranchCategoryFieldSettingId { get; set; }

    public string ImportFieldNameFromFile { get; set; } = null!;

    public long ImportHistoryId { get; set; }

    public virtual IncentiveBranchCategoryImportHistory ImportHistory { get; set; } = null!;
}
