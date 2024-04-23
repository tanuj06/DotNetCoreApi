using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class Product
{
    public long ProductId { get; set; }

    public long ProductFamilyId { get; set; }

    public long? OrganisationId { get; set; }

    public string Name { get; set; } = null!;

    public string? NameOl1 { get; set; }

    public string? NameOl2 { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public double? Sequence { get; set; }

    public string? Crmcode { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? CreatedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeviceObjId { get; set; }

    public int? SyncStatus { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public string? OperationsEmail { get; set; }

    public bool? IsSystemEntry { get; set; }

    public bool? IsDefault { get; set; }

    public string? DeviceId { get; set; }

    public virtual ICollection<ChecklistManagement> ChecklistManagements { get; set; } = new List<ChecklistManagement>();

    public virtual ICollection<Deal> Deals { get; set; } = new List<Deal>();

    public virtual ICollection<ExternalProductMapping> ExternalProductMappings { get; set; } = new List<ExternalProductMapping>();

    public virtual ICollection<FbleadFormProductMapping> FbleadFormProductMappings { get; set; } = new List<FbleadFormProductMapping>();

    public virtual ICollection<GameProductMapping> GameProductMappings { get; set; } = new List<GameProductMapping>();

    public virtual Organisation? Organisation { get; set; }

    public virtual ICollection<ProductDynamicField> ProductDynamicFields { get; set; } = new List<ProductDynamicField>();

    public virtual ProductFamily ProductFamily { get; set; } = null!;

    public virtual ICollection<ProductScheme> ProductSchemes { get; set; } = new List<ProductScheme>();

    public virtual ICollection<ProductType> ProductTypes { get; set; } = new List<ProductType>();

    public virtual ICollection<RoleProductMapping> RoleProductMappings { get; set; } = new List<RoleProductMapping>();

    public virtual ICollection<UserProductMapping> UserProductMappings { get; set; } = new List<UserProductMapping>();
}
