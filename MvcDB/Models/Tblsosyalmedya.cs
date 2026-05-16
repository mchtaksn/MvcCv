using System;
using System.Collections.Generic;

namespace MvcDB.Models;

public partial class Tblsosyalmedya
{
    public int Id { get; set; }

    public string? Ad { get; set; }

    public string? Link { get; set; }

    public string? Ikon { get; set; }

    public bool? Durum { get; set; }
}
