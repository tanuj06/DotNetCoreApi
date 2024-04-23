using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ExternalApirequestLogging
{
    public long ExternalApilogId { get; set; }

    public string? ClientAddress { get; set; }

    public string? Apiname { get; set; }

    public DateTime? LogDate { get; set; }

    public string? JsonRequest { get; set; }

    public string? Status { get; set; }

    public string? StatusCode { get; set; }

    public string? Description { get; set; }
}
