using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class Bank
{
    public long BankId { get; set; }

    public string? BankName { get; set; }

    public long? OrganisationId { get; set; }

    public long CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public virtual ICollection<BankEmployee> BankEmployees { get; set; } = new List<BankEmployee>();

    public virtual Organisation? Organisation { get; set; }
}
