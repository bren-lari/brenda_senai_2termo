﻿using System;
using System.Collections.Generic;

#nullable disable

namespace senai_spMedicalGroup_tarde.Domains
{
    public partial class TipoUsuario
    {
        public int IdTipoUsuario { get; set; }
        public int? IdUsuario { get; set; }
        public string TituloTipoUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}