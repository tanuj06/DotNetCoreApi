using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactFieldSettingsMaster
{
    public long Id { get; set; }

    public long ContactTypeId { get; set; }

    public bool IsStaticField { get; set; }

    public double? FieldIndex { get; set; }

    public string FieldName { get; set; } = null!;

    public string FieldLabel { get; set; } = null!;

    public int? ContactFieldCategoryId { get; set; }

    public bool OverwriteIfEmpty { get; set; }

    public bool OverwriteAlways { get; set; }

    public bool CanEditedOnDevice { get; set; }

    public string? FieldDataType { get; set; }

    public bool IsMandatory { get; set; }

    public bool IsMandatoryForAddEdit { get; set; }

    public bool IsBasicInfo { get; set; }

    public string? Expression { get; set; }

    public bool IsVisible { get; set; }

    public bool IsThisPartOfUniqueCheck { get; set; }

    public bool? IsConfidential { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public bool? IsRepresentative { get; set; }

    public bool? IsEmployer { get; set; }
}
