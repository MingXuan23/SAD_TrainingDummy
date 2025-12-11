using System;
using System.Collections.Generic;

namespace Training6.models;

public partial class User
{
    public Guid Uuid { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int RoleId { get; set; }

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual Role Role { get; set; } = null!;

    public List<Item> getItem()
    {
        if (RoleId == 1)
        {
            return helper.db.Items.ToList();
        }

        return Items.ToList();
    }
}
