using System;
using System.Collections.Generic;

namespace Training6.models;

public partial class ItemNote
{
    public int Id { get; set; }

    public int ItemId { get; set; }

    public string Name { get; set; } = null!;

    public string? Desc { get; set; }

    public bool Done { get; set; }

    public virtual Item Item { get; set; } = null!;
}
