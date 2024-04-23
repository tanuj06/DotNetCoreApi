using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class CommunicationTypesRelatedDatum
{
    public long CommunicationTypeId { get; set; }

    public long CommunicationCategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool? IsDefault { get; set; }

    public long OrganisationId { get; set; }

    public bool IsDeleted { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
