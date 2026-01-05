using System;
using System.Collections.Generic;

namespace Training20251231.models;

public partial class User
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public bool MailingListSubscription { get; set; }

    public string? ProfilePicture { get; set; }

    public string SecurityQuestion { get; set; } = null!;

    public string SecurityAnswer { get; set; } = null!;

    public string? PreferredDeliveryMethod { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
}
