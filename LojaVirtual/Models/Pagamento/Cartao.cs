﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models.Pagamento
{
    public class Cartao
    {
        public string Nome { get; set; }
        public string Numero { get; set; }
        public string Vencimento { get; set; }
        public string Verificador { get; set; }
    }
}
