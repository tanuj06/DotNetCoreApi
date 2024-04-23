using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class BatchFileUploadColumnValidationMapping
{
    public long MappingId { get; set; }

    public long ConfigurationId { get; set; }

    public int FieldId { get; set; }

    public int OrderNo { get; set; }

    public int ModuleId { get; set; }

    public string? DeviceObjId { get; set; }
}
