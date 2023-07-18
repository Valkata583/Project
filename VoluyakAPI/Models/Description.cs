using System;
using System.Collections.Generic;

namespace VoluyakAPI.Models;

public partial class Description
{
    public string Title { get; set; } = null!;

    public string Descripe { get; set; } = null!;

    public int? GameId { get; set; }

    public virtual Game? Game { get; set; }
}
