using System;
using System.Collections.Generic;

namespace Training20251224.models;

public partial class QuantityBasedRuleDetail
{
    public int RuleId { get; set; }

    public int? PromotionId { get; set; }

    public int MinQuantity { get; set; }

    public decimal DiscountValue { get; set; }

    public virtual Promotion? Promotion { get; set; }
}
