using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class BatchFileUploadValidationRule
{
    public long ValidationId { get; set; }

    public string RuleName { get; set; } = null!;
}
