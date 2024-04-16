using System;
using System.Collections.Generic;

namespace Acquaintance;

public partial class Administrator
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public virtual LoginPassword IdNavigation { get; set; } = null!;
}
