using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class CrmapicallLogsV2
{
    public long CrmrequestLogId { get; set; }

    public DateTime? RequestTimeStamp { get; set; }

    public string? ServiceName { get; set; }

    public string? HttpErrorCode { get; set; }

    public string? HttpErrorDescription { get; set; }

    public string? RequestBody { get; set; }

    public string? ResponseBody { get; set; }

    public DateTime? ResponseTimeStamp { get; set; }

    public string? ClientIpaddress { get; set; }

    public string? UniqueReferenceCode { get; set; }

    public string? ChannelId { get; set; }

    public string? FinancialId { get; set; }

    public string? Url { get; set; }

    public string? HttpMethod { get; set; }

    public string? HttpHeader { get; set; }
}
