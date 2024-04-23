using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class CrmapiCallLog
{
    public long CrmrequestLogId { get; set; }

    public string? ClientTimestamp { get; set; }

    public string? ServiceName { get; set; }

    public string? SourceMessageId { get; set; }

    public string? ServerTimestamp { get; set; }

    public string? HttpErrorCode { get; set; }

    public string? HttpErrorDescription { get; set; }

    public string? Status { get; set; }

    public string? ErrorCode { get; set; }

    public string? ErrorDescription { get; set; }

    public string? Body { get; set; }

    public string? ResponseBody { get; set; }
}
