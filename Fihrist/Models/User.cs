﻿using System;
using System.Collections.Generic;

namespace Fihrist.Models;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<RoleUser> RoleUsers { get; set; } = new List<RoleUser>();
}
