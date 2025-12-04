using System;
using System.Collections.Generic;

namespace WinFormsApp1.models;

public partial class ProductIngredient
{
    public int IngredientId { get; set; }

    public int ProductId { get; set; }

    public string IngredientName { get; set; } = null!;

    public decimal QuantityRequired { get; set; }

    public string UnitOfMeasure { get; set; } = null!;

    public decimal? CostPerUnit { get; set; }

    public string? SupplierName { get; set; }

    public string? Notes { get; set; }

    public virtual Product Product { get; set; } = null!;
}
