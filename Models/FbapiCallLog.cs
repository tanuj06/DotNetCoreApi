using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class FbapiCallLog
{
    public long FbrequestLogId { get; set; }

    public string? ApiName { get; set; }

    public string? RequestTimeStamp { get; set; }

    public string? RequestBody { get; set; }

    public string? Fbtimestamp { get; set; }

    public string? ResponseBody { get; set; }

    public string? Status { get; set; }

    public string? HttpErrorCode { get; set; }

    public string? HttpErrorDescription { get; set; }

    public string? ErrorCode { get; set; }

    public string? ErrorDescription { get; set; }
}
