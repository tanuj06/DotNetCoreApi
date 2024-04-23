using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactFieldSettingsRelatedDatum
{
    public long ContactFieldSettingId { get; set; }

    public double? Sequence { get; set; }

    public string FieldName { get; set; } = null!;

    public string FieldLabel { get; set; } = null!;

    public bool IsMandatory { get; set; }

    public bool IsVisible { get; set; }

    public int? ContactFieldCategoryId { get; set; }

    public string? ContactFieldCategory { get; set; }

    public long OrganisationId { get; set; }

    public bool IsDeleted { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
