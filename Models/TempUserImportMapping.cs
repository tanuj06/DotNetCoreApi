using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class TempUserImportMapping
{
    public long Id { get; set; }

    public long UserFieldSettingId { get; set; }

    public string ImportFieldNameFromFile { get; set; } = null!;

    public long ImportHistoryId { get; set; }

    public virtual TempUserImportHistory ImportHistory { get; set; } = null!;
}
