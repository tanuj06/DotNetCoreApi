using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveCategoryRoleTemplateMappingImportMapping
{
    public long IncentiveCategoryRoleTemplateMappingImportMappingId { get; set; }

    public long IncentiveCategoryRoleTemplateMappingFieldSettingId { get; set; }

    public string ImportFieldNameFromFile { get; set; } = null!;

    public long ImportHistoryId { get; set; }

    public virtual IncentiveCategoryRoleTemplateMappingImportHistory ImportHistory { get; set; } = null!;
}
