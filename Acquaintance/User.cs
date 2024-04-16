using System;
using System.Collections.Generic;

namespace Acquaintance;

public partial class User
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? City { get; set; }

    public bool? Sex { get; set; }

    public string? Mail { get; set; }

    public long? Number { get; set; }

    public byte[]? Photo { get; set; }

    public string? Favorites { get; set; }

    public int? Likes { get; set; }

    public virtual LoginPassword IdNavigation { get; set; } = null!;
}
