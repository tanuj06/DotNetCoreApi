using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class WindowsSchedulerSetting
{
    public int WindowsSchedulerSettingId { get; set; }

    public string Key { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string ControlType { get; set; } = null!;

    public int? FrequencyId { get; set; }

    public int? SelectedDay { get; set; }

    public int? SelectedIntervalType { get; set; }

    public DateTime? SelectedIntervalTime { get; set; }

    public int? SelectedIntervalValue { get; set; }

    public int? SelectedIntervalUnit { get; set; }

    public bool? IsExportAllowed { get; set; }

    public string? ExportReportPath { get; set; }

    public string? ExportFileNamePrefix { get; set; }

    public string? ExportFileNameSufix { get; set; }

    public string? ExportFileNameExtension { get; set; }

    public int? CalculationMonth { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsDeleted { get; set; }
}
