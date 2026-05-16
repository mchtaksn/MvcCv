using System;
using System.Collections.Generic;

namespace MvcDB.Models;

public partial class Tblyeteneklerim
{
    public int Id { get; set; }

    public string? Yetenek { get; set; }

    public byte? Oran { get; set; }
}
