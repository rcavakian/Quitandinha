using System;
using System.Collections.Generic;
using System.Text;

namespace Quitandinha
{
    class Limpeza: Produto
    {
        public Limpeza(string categoria, int volume)
        {
            
            Categoria = categoria; // Limpadores/Multiuso, Desengordurantes, Álcool, Limpa-vidros, Desinfetante, Detergente, Sabão em barra, Água sanitária
            Volume = volume; // Volume do item individual
        }

        public Limpeza()
        {
        }

        public string Categoria { get; set; }
        public int Volume { get; set; }
    }
}
