﻿using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class ContactDynamicField
{
    public long ContactDynamicFieldId { get; set; }

    public long ContactId { get; set; }

    public string? Field1 { get; set; }

    public string? Field2 { get; set; }

    public string? Field3 { get; set; }

    public string? Field4 { get; set; }

    public string? Field5 { get; set; }

    public string? Field6 { get; set; }

    public string? Field7 { get; set; }

    public string? Field8 { get; set; }

    public string? Field9 { get; set; }

    public string? Field10 { get; set; }

    public string? Field11 { get; set; }

    public string? Field12 { get; set; }

    public string? Field13 { get; set; }

    public string? Field14 { get; set; }

    public string? Field15 { get; set; }

    public string? Field16 { get; set; }

    public string? Field17 { get; set; }

    public string? Field18 { get; set; }

    public string? Field19 { get; set; }

    public string? Field20 { get; set; }

    public string? Field21 { get; set; }

    public string? Field22 { get; set; }

    public string? Field23 { get; set; }

    public string? Field24 { get; set; }

    public string? Field25 { get; set; }

    public string? Field26 { get; set; }

    public string? Field27 { get; set; }

    public string? Field28 { get; set; }

    public string? Field29 { get; set; }

    public string? Field30 { get; set; }

    public string? Field31 { get; set; }

    public string? Field32 { get; set; }

    public string? Field33 { get; set; }

    public string? Field34 { get; set; }

    public string? Field35 { get; set; }

    public string? Field36 { get; set; }

    public string? Field37 { get; set; }

    public string? Field38 { get; set; }

    public string? Field39 { get; set; }

    public string? Field40 { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Contact Contact { get; set; } = null!;
}
