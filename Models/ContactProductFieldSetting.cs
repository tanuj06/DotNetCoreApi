using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactProductFieldSetting
{
    public long ContactProductFieldSettingId { get; set; }

    public long OrganisationId { get; set; }

    public bool IsStaticField { get; set; }

    public double? FieldIndex { get; set; }

    public string FieldName { get; set; } = null!;

    public string FieldLabel { get; set; } = null!;

    public string? FieldDataType { get; set; }

    public bool IsMandatory { get; set; }

    public bool IsVisible { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual ICollection<ContactProductImportMapping> ContactProductImportMappings { get; set; } = new List<ContactProductImportMapping>();

    public virtual Organisation Organisation { get; set; } = null!;
}
