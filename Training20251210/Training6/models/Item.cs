using System;
using System.Collections.Generic;

namespace Training6.models;

public partial class Item
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public Guid UserId { get; set; }

    public int? Notecount { get; set; }

    public int Priority { get; set; }

    public DateTime DateTime { get; set; }

    public virtual ICollection<ItemNote> ItemNotes { get; set; } = new List<ItemNote>();

    public virtual User User { get; set; } = null!;
}
