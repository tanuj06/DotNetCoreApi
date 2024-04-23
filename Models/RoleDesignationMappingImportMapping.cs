using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class RoleDesignationMappingImportMapping
{
    public long RoleDesignationMappingImportMappingId { get; set; }

    public long RoleDesignationMappingFieldSettingId { get; set; }

    public string ImportFieldNameFromFile { get; set; } = null!;

    public long ImportHistoryId { get; set; }

    public virtual RoleDesignationMappingImportHistory ImportHistory { get; set; } = null!;
}
