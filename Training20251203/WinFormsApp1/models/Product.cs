using System;
using System.Collections.Generic;

namespace WinFormsApp1.models;

public partial class Product
{
    public int ProductId { get; set; }

    public string Sku { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public string? Description { get; set; }

    public string? Category { get; set; }

    public decimal RetailPrice { get; set; }

    public decimal ProductionCost { get; set; }

    public string? ServingSize { get; set; }

    public int? WarningThresold { get; set; }

    public string? AllergenInfo { get; set; }

    public int Quantity { get; set; }

    public int? ShelfLifeDays { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<ProductIngredient> ProductIngredients { get; set; } = new List<ProductIngredient>();
}
