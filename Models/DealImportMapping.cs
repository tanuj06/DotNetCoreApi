using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DealImportMapping
{
    public long DealImportMappingId { get; set; }

    public long DealFieldSettingId { get; set; }

    public string ImportFieldNameFromFile { get; set; } = null!;

    public long ImportHistoryId { get; set; }

    public virtual DealImportHistory ImportHistory { get; set; } = null!;
}
