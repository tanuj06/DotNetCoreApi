using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class BatchFileUploadExcelColumnMapping
{
    public long MappingId { get; set; }

    public long ConfigurationId { get; set; }

    public int ModuleId { get; set; }

    public long FieldSettingId { get; set; }

    public string ImportFieldNameFromFile { get; set; } = null!;

    public long ValidationId { get; set; }

    public string? RegularExpression { get; set; }

    public bool IsMandatory { get; set; }

    public string? DeviceObjId { get; set; }
}
