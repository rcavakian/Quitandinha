using System;
using System.Collections.Generic;
using System.Text;

namespace Quitandinha
{
    abstract class Produto
    {
        public Produto(string descricao, string tipo, int quantidade, DateTime data) 
        {

        DescricaoItem = descricao; // Aqui é para informar especificamente de qual produto se trata. Exemplo: feijão carioquinha, arroz branco parborizado, refrigerante Coca-Cola etc 
        // TipoItem = tipo; // alimento, bebida ou produto de limpeza
        QuantidadeItem = quantidade; // ???
        DataEntrada = data; // data de entrada no estoque

        }
        public Produto()
        {
        }

        public string DescricaoItem { get; set; }
        public string TipoItem { get; set; }
        public int QuantidadeItem { get; set; }
        public DateTime DataEntrada { get; set; }
                    
    }
}
