using System;
using System.Collections.Generic;
using System.Text;

namespace Quitandinha
{
    class Bebida : Produto
    {
        public Bebida(bool alcoolico, int volume, string categoria)
        {
            EhAlcoolico = alcoolico;
            Volume = volume; // Volume do item individual
            Categoria = categoria; // suco, refrigerante, agua mineral, chá, cerveja, cachaça, vinho

        }

        public Bebida()
        {
        }

        public bool EhAlcoolico { get; set; }
        public int Volume { get; set; }
        public string Categoria { get; set; }
    }
}
