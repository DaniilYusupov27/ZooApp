using System;
using System.Collections.Generic;

namespace ZooApp.Models;

public partial class AnimalAssignment
{
    public int AssignmentId { get; set; }

    public int? AnimalId { get; set; }

    public int? EnclosureId { get; set; }

    public virtual Animal? Animal { get; set; }

    public virtual Enclosure? Enclosure { get; set; }
}
