﻿using System;
using System.Collections.Generic;

namespace MVCCRUD.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string Clave { get; set; } = null!;
}
