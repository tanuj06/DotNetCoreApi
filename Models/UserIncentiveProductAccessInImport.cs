using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class UserIncentiveProductAccessInImport
{
    public long UserIncentiveProductAccessInImportId { get; set; }

    public long UserId { get; set; }

    public int IncentiveProductTypeId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual IncentiveProductType IncentiveProductType { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
