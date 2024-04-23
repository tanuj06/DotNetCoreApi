using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class MasterPage
{
    public long MasterPageId { get; set; }

    public string? TableName { get; set; }

    public string? PageCode { get; set; }

    public string? ViewName { get; set; }

    public bool IsIncentiveModule { get; set; }

    public virtual ICollection<MasterPageField> MasterPageFields { get; set; } = new List<MasterPageField>();
}
