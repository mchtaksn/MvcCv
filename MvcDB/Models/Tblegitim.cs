using System;
using System.Collections.Generic;

namespace MvcDB.Models;

public partial class Tblegitim
{
    public int Id { get; set; }

    public string? Baslik { get; set; }

    public string? Altbaslik1 { get; set; }

    public string? Altbaslik2 { get; set; }

    public string? Gno { get; set; }

    public string? Tarih { get; set; }
}
