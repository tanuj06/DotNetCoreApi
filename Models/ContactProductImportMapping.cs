using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactProductImportMapping
{
    public long ContactProductImportMappingId { get; set; }

    public long ContactFieldSettingId { get; set; }

    public string ImportFieldNameFromFile { get; set; } = null!;

    public long ImportHistoryId { get; set; }

    public virtual ContactProductFieldSetting ContactFieldSetting { get; set; } = null!;

    public virtual ContactProductImportHistory ImportHistory { get; set; } = null!;
}
