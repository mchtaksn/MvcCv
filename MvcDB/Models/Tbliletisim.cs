using System;
using System.Collections.Generic;

namespace MvcDB.Models;

public partial class Tbliletisim
{
    public int Id { get; set; }

    public string? Adsoyad { get; set; }

    public string? Mail { get; set; }

    public string? Konu { get; set; }

    public string? Mesaj { get; set; }

    public DateOnly? Tarih { get; set; }
}
