using System;
using System.Collections.Generic;

namespace Acquaintance;

public partial class LoginPassword
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual User? User { get; set; }
}
