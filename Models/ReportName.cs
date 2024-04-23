using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ReportName
{
    public int ReportNameId { get; set; }

    public string ReportName1 { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsDeleted { get; set; }
}
