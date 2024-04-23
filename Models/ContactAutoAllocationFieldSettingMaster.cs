using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactAutoAllocationFieldSettingMaster
{
    public int Id { get; set; }

    public string? FieldName { get; set; }

    public bool? IsMandatory { get; set; }

    public int? Weightage { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }
}
