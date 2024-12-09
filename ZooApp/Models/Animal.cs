using System;
using System.Collections.Generic;

namespace ZooApp.Models;

public partial class Animal
{
    public int AnimalId { get; set; }

    public string? Species { get; set; }

    public string? Habitat { get; set; }

    public int? Age { get; set; }

    public virtual ICollection<AnimalAssignment> AnimalAssignments { get; set; } = new List<AnimalAssignment>();
}
