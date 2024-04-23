using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ErrorLog
{
    public int ErrorLogId { get; set; }

    public string? Spname { get; set; }

    public string? ErrorMessage { get; set; }

    public int? ErrorSeverity { get; set; }

    public int? ErrorState { get; set; }

    public DateTime? LogDateTime { get; set; }
}
