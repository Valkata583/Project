using System;
using System.Collections.Generic;

namespace VoluyakAPI.Models;

public partial class Leaderbord
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public int Points { get; set; }

    public int? GameId { get; set; }

    public virtual Game? Game { get; set; }
}
