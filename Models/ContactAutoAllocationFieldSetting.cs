using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactAutoAllocationFieldSetting
{
    public long ContactAutoAllocationFieldSettingId { get; set; }

    public string FieldName { get; set; } = null!;

    public long OrganisationId { get; set; }

    public bool IsMandatory { get; set; }

    public int? Weightage { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual Organisation Organisation { get; set; } = null!;
}
