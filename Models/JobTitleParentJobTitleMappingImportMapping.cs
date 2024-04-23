using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class JobTitleParentJobTitleMappingImportMapping
{
    public long JobTitleParentJobTitleMappingImportMappingId { get; set; }

    public long JobTitleParentJobTitleMappingFieldSettingId { get; set; }

    public string ImportFieldNameFromFile { get; set; } = null!;

    public long ImportHistoryId { get; set; }

    public virtual JobTitleParentJobTitleMappingImportHistory ImportHistory { get; set; } = null!;
}
