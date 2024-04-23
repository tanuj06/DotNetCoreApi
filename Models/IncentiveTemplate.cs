using System;
using System.Collections.Generic;

namespace CGMMiddleWare.Models;

public partial class IncentiveTemplate
{
    public long IncentiveTemplateId { get; set; }

    public string? Name { get; set; }

    public long? IncentiveRoleShareTemplateId { get; set; }

    public bool? IsManager { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? IsDeleted { get; set; }

    public long? OrganisationId { get; set; }

    public int? MinNoOfActivatedCard { get; set; }

    public int? HurdleTemplateId { get; set; }

    public decimal? FinalIncentiveCap { get; set; }

    public virtual ICollection<IncentiveCategoryRoleTemplateMapping> IncentiveCategoryRoleTemplateMappings { get; set; } = new List<IncentiveCategoryRoleTemplateMapping>();

    public virtual ICollection<IncentivePrimaryCcperBinconfiguration> IncentivePrimaryCcperBinconfigurations { get; set; } = new List<IncentivePrimaryCcperBinconfiguration>();

    public virtual IncentiveRoleShareTemplate? IncentiveRoleShareTemplate { get; set; }

    public virtual ICollection<IncentiveSupplementaryCcperBinconfiguration> IncentiveSupplementaryCcperBinconfigurations { get; set; } = new List<IncentiveSupplementaryCcperBinconfiguration>();

    public virtual ICollection<IncentiveTemplateBancAssuranceProductParameter> IncentiveTemplateBancAssuranceProductParameters { get; set; } = new List<IncentiveTemplateBancAssuranceProductParameter>();

    public virtual ICollection<IncentiveTemplateCreditCardProduct> IncentiveTemplateCreditCardProducts { get; set; } = new List<IncentiveTemplateCreditCardProduct>();

    public virtual ICollection<IncentiveTemplateDebitCardProduct> IncentiveTemplateDebitCardProducts { get; set; } = new List<IncentiveTemplateDebitCardProduct>();

    public virtual ICollection<IncentiveTemplateInternetBankingProduct> IncentiveTemplateInternetBankingProducts { get; set; } = new List<IncentiveTemplateInternetBankingProduct>();

    public virtual ICollection<IncentiveTemplateLoanProductParameter> IncentiveTemplateLoanProductParameters { get; set; } = new List<IncentiveTemplateLoanProductParameter>();

    public virtual ICollection<IncentiveTemplatePayrollProduct> IncentiveTemplatePayrollProducts { get; set; } = new List<IncentiveTemplatePayrollProduct>();

    public virtual ICollection<IncentiveTemplatePosproduct> IncentiveTemplatePosproducts { get; set; } = new List<IncentiveTemplatePosproduct>();

    public virtual ICollection<IncentiveTemplatePrepaidCardProduct> IncentiveTemplatePrepaidCardProducts { get; set; } = new List<IncentiveTemplatePrepaidCardProduct>();

    public virtual ICollection<UserIncentiveTemplateMappingLog> UserIncentiveTemplateMappingLogs { get; set; } = new List<UserIncentiveTemplateMappingLog>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
