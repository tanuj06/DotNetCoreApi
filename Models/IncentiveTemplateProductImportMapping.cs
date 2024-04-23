using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTemplateProductImportMapping
{
    public long IncentiveTemplateProductImportMappingId { get; set; }

    public long IncentiveTemplateProductFieldSettingId { get; set; }

    public string ImportFieldNameFromFile { get; set; } = null!;

    public long ImportHistoryId { get; set; }

    public virtual IncentiveTemplateProductImportHistory ImportHistory { get; set; } = null!;
}
