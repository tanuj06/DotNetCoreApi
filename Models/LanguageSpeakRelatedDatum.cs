using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class LanguageSpeakRelatedDatum
{
    public int LanguageSpeakId { get; set; }

    public string? Name { get; set; }

    public long? OrganisationId { get; set; }

    public string OrganisationName { get; set; } = null!;

    public bool? IsDefault { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
