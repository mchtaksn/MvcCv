using System;
using System.Collections.Generic;

namespace MvcDB.Models;

public partial class Tbldeneyimlerim
{
    public int Id { get; set; }

    public string? Baslik { get; set; }

    public string? Altbaslik { get; set; }

    public string? Aciklama { get; set; }

    public string? Tarih { get; set; }
}
