using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Training20251231.models;

public partial class Address
{
    public int Id { get; set; }

    public string Label { get; set; } = null!;

    public string Address1 { get; set; } = null!;

    //
    public int UserId { get; set; }

    public bool Preffered { get; set; }

    [JsonIgnore]
    [ValidateNever]
    public virtual User User { get; set; } = null!;
}
