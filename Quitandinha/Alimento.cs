using System;
using System.Collections.Generic;
using System.Text;

namespace Quitandinha
{
    class Alimento: Produto
    {
        public Alimento(bool pericivel, string armazenamento, string categoria)
        {
            EhPerecivel = pericivel;
            FormaArmazenamento = armazenamento; // refrigerado, congelado, ambiente
            GrupoAlimentar = categoria; // Hortaliças, Frutas, Leguminosas, Carnes e ovos, Leite e derivados, Açúcares, Óleos e gorduras
        }
        public Alimento()
        {
        }

        public bool EhPerecivel { get; set; }
        public string FormaArmazenamento { get; set; }
        public string GrupoAlimentar { get; set; }

    }
}
