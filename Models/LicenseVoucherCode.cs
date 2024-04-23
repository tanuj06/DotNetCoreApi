using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class LicenseVoucherCode
{
    public int VoucherCodeId { get; set; }

    public string VoucherCode { get; set; } = null!;

    public int MonthUnits { get; set; }

    public DateTime ExpiryDate { get; set; }

    public bool IsActive { get; set; }

    public string? Comment { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public bool IsDeleted { get; set; }
}
