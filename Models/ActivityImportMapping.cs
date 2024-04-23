using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ActivityImportMapping
{
    public long ActivityImportMappingId { get; set; }

    public long ActivityFieldSettingId { get; set; }

    public string ImportFieldNameFromFile { get; set; } = null!;

    public long ImportHistoryId { get; set; }

    public virtual ActivityImportHistory ImportHistory { get; set; } = null!;
}
