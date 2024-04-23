using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactImportMapping
{
    public long ContactImportMappingId { get; set; }

    public long ContactFieldSettingId { get; set; }

    public string ImportFieldNameFromFile { get; set; } = null!;

    public long ImportHistoryId { get; set; }

    public virtual ContactFieldSetting ContactFieldSetting { get; set; } = null!;

    public virtual ContactImportHistory ImportHistory { get; set; } = null!;
}
