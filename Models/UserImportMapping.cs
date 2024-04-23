using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserImportMapping
{
    public long UserImportMappingId { get; set; }

    public long UserFieldSettingId { get; set; }

    public string ImportFieldNameFromFile { get; set; } = null!;

    public long ImportHistoryId { get; set; }

    public virtual UserImportHistory ImportHistory { get; set; } = null!;
}
