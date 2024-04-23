using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class DbscriptVersion
{
    public long DbscriptVersionId { get; set; }

    public string? VersionNo { get; set; }

    public string? VersionDesc { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ExecutedOn { get; set; }
}
