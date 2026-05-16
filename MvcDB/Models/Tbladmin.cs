using System;
using System.Collections.Generic;

namespace MvcDB.Models;

public partial class Tbladmin
{
    public int Id { get; set; }

    public string? Kullaniciadi { get; set; }

    public string? Sifre { get; set; }
}
