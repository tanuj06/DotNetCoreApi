using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTemplatePayrollProduct
{
    public long IncentiveTemplatePayrollProductId { get; set; }

    public long? IncentiveTemplateId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? IsDeleted { get; set; }

    public decimal? CompanyWeight { get; set; }

    public decimal? EmployeeWeight { get; set; }

    public bool IsApplicable { get; set; }

    public virtual IncentiveTemplate? IncentiveTemplate { get; set; }
}
