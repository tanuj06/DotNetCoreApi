using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveProductType
{
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public bool IsVisible { get; set; }

    public bool? IsImportEnabled { get; set; }

    public bool? IsHurdleApplicable { get; set; }

    public bool? IsStrategicProduct { get; set; }

    public bool IsIncentiveApplicable { get; set; }

    public bool IsMonthlyScorecardProduct { get; set; }

    public int? DisplayOrder { get; set; }

    public bool? IsPreviousMonthCalculationEnabled { get; set; }

    public int? MinDaysOfPreviousMonthCalculation { get; set; }

    public virtual ICollection<IncentiveTemplateProductFieldSettingMaster> IncentiveTemplateProductFieldSettingMasters { get; set; } = new List<IncentiveTemplateProductFieldSettingMaster>();

    public virtual ICollection<IncentiveTemplateProductFieldSetting> IncentiveTemplateProductFieldSettings { get; set; } = new List<IncentiveTemplateProductFieldSetting>();

    public virtual ICollection<IncentiveTemplateProductImportHistory> IncentiveTemplateProductImportHistories { get; set; } = new List<IncentiveTemplateProductImportHistory>();

    public virtual ICollection<IncentiveUserWiseMonthlyStat> IncentiveUserWiseMonthlyStats { get; set; } = new List<IncentiveUserWiseMonthlyStat>();

    public virtual ICollection<IncentiveUserWiseNonMonthlyProductStat> IncentiveUserWiseNonMonthlyProductStats { get; set; } = new List<IncentiveUserWiseNonMonthlyProductStat>();

    public virtual ICollection<TempUserIncentiveProductAccessInImport> TempUserIncentiveProductAccessInImports { get; set; } = new List<TempUserIncentiveProductAccessInImport>();

    public virtual ICollection<TempUserIncentiveProductAccessInReport> TempUserIncentiveProductAccessInReports { get; set; } = new List<TempUserIncentiveProductAccessInReport>();

    public virtual ICollection<UserIncentiveProductAccessInImport> UserIncentiveProductAccessInImports { get; set; } = new List<UserIncentiveProductAccessInImport>();

    public virtual ICollection<UserIncentiveProductAccessInReport> UserIncentiveProductAccessInReports { get; set; } = new List<UserIncentiveProductAccessInReport>();
}
