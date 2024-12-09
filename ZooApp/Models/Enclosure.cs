using System;
using System.Collections.Generic;

namespace ZooApp.Models;

public partial class Enclosure
{
    public int EnclosureId { get; set; }

    public string? EnclosureName { get; set; }

    public int? Capacity { get; set; }

    public virtual ICollection<AnimalAssignment> AnimalAssignments { get; set; } = new List<AnimalAssignment>();
}
