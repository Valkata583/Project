using System;
using System.Collections.Generic;

namespace VoluyakAPI.Models;

public partial class Game
{
    public int Id { get; set; }

    public virtual ICollection<Description> Descriptions { get; set; } = new List<Description>();

    public virtual ICollection<Leaderbord> Leaderbords { get; set; } = new List<Leaderbord>();
}
