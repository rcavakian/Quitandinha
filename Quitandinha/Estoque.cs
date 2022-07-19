using System;
using System.Collections.Generic;
using System.Text;

namespace Quitandinha
{
    class Estoque
    {
        // falta fazer o encapsulamento dos atributos
        List<Alimento> alimentos = new List<Alimento>();
        List<Bebida> bebidas = new List<Bebida>();
        List<Limpeza> limpezas = new List<Limpeza>();
        
        
        public void cadastrarItem()
        {
            Console.Write("\nDigite o tipo de produto a ser cadastrado:\n[1]-Alimento\n[2]-Bebida\n[3]-Produto de limpeza\nOpção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Alimento alimento = new Alimento();
                    
                    Console.Write("\nDigite a descrição do alimento: ");
                    alimento.DescricaoItem = Console.ReadLine();
                    
                    // alimento.TipoItem = "alimento";
                    Console.Write("Digite a quantidade: ");
                    alimento.QuantidadeItem = int.Parse(Console.ReadLine());
                    
                    Console.Write("Digite a data de entrada no estoque no formato DD/MM/AAAA: ");
                    alimento.DataEntrada = DateTime.Parse(Console.ReadLine());
                    while (alimento.DataEntrada > DateTime.Now)
                    {
                        Console.Write("Não pode cadastrar data futura, entre com uma nova data: ");
                        alimento.DataEntrada = DateTime.Parse(Console.ReadLine());
                    }

                    Console.Write("O alimento é perícivel (1-sim ou 2-não): ");
                    int resposta = int.Parse(Console.ReadLine());
                    if (resposta == 1)
                    {
                        alimento.EhPerecivel = true;
                    }
                    else
                    {
                        alimento.EhPerecivel = false;
                    }

                    Console.Write(
                        "\nInforme o metodo de armazenamento:" +
                        "\n[1]-Refrigerado" +
                        "\n[2]-Congelado" +
                        "\n[3]-Ambiente" +
                        "\nOpção: ");
                    int metodo = int.Parse(Console.ReadLine());

                    switch (metodo)
                    {
                        case 1:
                            alimento.FormaArmazenamento = "refrigerado";
                            break;
                        case 2:
                            alimento.FormaArmazenamento = "congelado";
                            break;
                        case 3:
                            alimento.FormaArmazenamento = "ambiente";
                            break;
                        default:
                            break;
                    }
                    
                    Console.Write(
                        "\nInforme o grupo alimentar: " +
                        "\n[1]-Hortaliças" +
                        "\n[2]-Frutas" +
                        "\n[3]-Leguminosas" +
                        "\n[4]-Carnes e ovos" +
                        "\n[5]-Leite e derivados" +
                        "\n[6]-Açucares" +
                        "\n[7]-Óleos e gorduras" +
                        "\nOpção: ");
                    int grupoAlimento = int.Parse(Console.ReadLine());

                    switch (grupoAlimento)
                    {
                        case 1:
                            alimento.GrupoAlimentar = "Hortaliças";
                            break;
                        case 2:
                            alimento.GrupoAlimentar = "Frutas";
                            break;
                        case 3:
                            alimento.GrupoAlimentar = "Leguminosas";
                            break;
                        case 4:
                            alimento.GrupoAlimentar = "Carnes e ovos";
                            break;
                        case 5:
                            alimento.GrupoAlimentar = "Leite e derivados";
                            break;
                        case 6:
                            alimento.GrupoAlimentar = "Açucares";
                            break;
                        case 7:
                            alimento.GrupoAlimentar = "Óleos e gorduras";
                            break;
                        default:
                            break;
                    }
                    alimentos.Add(alimento);

                    break;

                case 2:
                    Bebida bebida = new Bebida();
                    Console.Write("\nDigite a descrição da bebida: ");
                    bebida.DescricaoItem = Console.ReadLine();

                    Console.Write("Digite a quantidade de unidades: ");
                    bebida.QuantidadeItem = int.Parse(Console.ReadLine());

                    Console.Write("Digite a data de entrada no estoque no formato DD/MM/AAAA: ");
                    bebida.DataEntrada = DateTime.Parse(Console.ReadLine());
                    while (bebida.DataEntrada > DateTime.Now)
                    {
                        Console.Write("Não pode cadastrar data futura, entre com uma nova data: ");
                        bebida.DataEntrada = DateTime.Parse(Console.ReadLine());
                    }
                    
                    
                    Console.Write("A bebida é alcoolica (1-sim ou 2-não): ");
                    int alcoolico = int.Parse(Console.ReadLine());
                    if (alcoolico == 1)
                    {
                        bebida.EhAlcoolico = true;
                    }
                    else
                    {
                        bebida.EhAlcoolico = false;
                    }

                    Console.Write("Informe o volume/capacidade em mililitros(ml): ");
                    bebida.Volume = int.Parse(Console.ReadLine());

                    // suco, refrigerante, agua mineral, chá, cerveja, cachaça, vinho
                    Console.Write(
                        "\nInforme a categoria da bebida:" +
                        "\n[1]-Suco" +
                        "\n[2]-Refrigerante" +
                        "\n[3]-Água mineral" +
                        "\n[4]-Chá" +
                        "\n[5]-Cerveja" +
                        "\n[6]-Cachaça" +
                        "\n[7]-Vinho" +
                        "\nOpção: ");
                    int tipoBebida = int.Parse(Console.ReadLine());

                    switch (tipoBebida)
                    {
                        case 1:
                            bebida.Categoria = "Suco";
                            break;
                        case 2:
                            bebida.Categoria = "Refrigerante";
                            break;
                        case 3:
                            bebida.Categoria = "Água mineral";
                            break;
                        case 4:
                            bebida.Categoria = "Chá";
                            break;
                        case 5:
                            bebida.Categoria = "Cerveja";
                            break;
                        case 6:
                            bebida.Categoria = "Cachaça";
                            break;
                        case 7:
                            bebida.Categoria = "Vinho";
                            break;
                        default:
                            break;
                    }
                    bebidas.Add(bebida);

                    break;

                case 3:
                    Limpeza limpeza = new Limpeza();

                    Console.Write("\nDigite a descrição do produto de limpeza: ");
                    limpeza.DescricaoItem = Console.ReadLine();

                    Console.Write("Digite a quantidade de unidades: ");
                    limpeza.QuantidadeItem = int.Parse(Console.ReadLine());

                    Console.Write("Digite a data de entrada no estoque no formato DD/MM/AAAA: ");
                    limpeza.DataEntrada = DateTime.Parse(Console.ReadLine());
                    while (limpeza.DataEntrada > DateTime.Now)
                    {
                        Console.Write("Não pode cadastrar data futura, entre com uma nova data: ");
                        limpeza.DataEntrada = DateTime.Parse(Console.ReadLine());
                    }

                    Console.Write("\nInforme a categoria do produto de limpeza:" +
                        "\n[1]-Limpadores/Multiuso" +
                        "\n[2]-Desengordurantes" +
                        "\n[3]-Álcool" +
                        "\n[4]-Limpa-vidros" +
                        "\n[5]-Desinfetante" +
                        "\n[6]-Detergente" +
                        "\n[7]-Sabão em barra" +
                        "\n[8]-Água sanitária" +
                        "\nCategoria: ");
                    int categoria = int.Parse(Console.ReadLine());
                    
                    switch (categoria)
                    {
                        case 1:
                            limpeza.Categoria = "Limpadores/Multiuso";
                            break;
                        case 2:
                            limpeza.Categoria = "Desengordurantes";
                            break;
                        case 3:
                            limpeza.Categoria = "Álcool";
                            break;
                        case 4:
                            limpeza.Categoria = "Limpa-vidros";
                            break;
                        case 5:
                            limpeza.Categoria = "Desinfetante";
                            break;
                        case 6:
                            limpeza.Categoria = "Detergente";
                            break;
                        case 7:
                            limpeza.Categoria = "Sabão em barra";
                            break;
                        case 8:
                            limpeza.Categoria = "Água sanitária";
                            break;
                        default:
                            break;
                    }

                    Console.Write("\nInforme o volume unitario em mililitros(ml): ");
                    limpeza.Volume = int.Parse(Console.ReadLine());
                    
                    limpezas.Add(limpeza);
                    
                    break;

                default:
                    break;
            }
        }

		public void exibirProdutos()
        {
            Console.Write(
                "\nInforme o tipo de produto para exibição:" +
                "\n[1]-Alimentos" +
                "\n[2]-Bebidas" +
                "\n[3]-Produtos de Limpeza" +
                "\n[4]-Todos" +
                "\nOpção: ");
            int argumento = int.Parse(Console.ReadLine());

            switch (argumento)
            {
                case 1:
                    exibirAlimentos();
                    break;

                case 2:
                    foreach (var bebida in bebidas)
                    {
                        exibirBebidas(bebida);
                    }
                    
                    break;

                case 3:
                    exibirLimpezas();
                    break;

                case 4:
                    // fazer logica para poder imprimir todos os produtos do estoque sem ter que fazer um foreach para cada
                    Console.WriteLine("Alimentos encontrados no estoque:");
                    exibirAlimentos();
                    Console.WriteLine();

                    Console.WriteLine("Bebidas encontradas no estoque:");
                    foreach (var bebida in bebidas)
                    {
                        exibirBebidas(bebida);
                    }
                    Console.WriteLine();

                    Console.WriteLine("Produtos de limpeza encontrados no estoque:");
                    exibirLimpezas();
                    Console.WriteLine();

                    break;

                default:
                    break;
            }
        }

        public void consultarProduto()
        {
            Console.Write("\nConsulte por: \n[1]-Cateogria \n[2]-Descrição \nOpção: ");
            int opcaoConsulta = int.Parse(Console.ReadLine());

            switch(opcaoConsulta)
            {
                case 1:
                    //codigo para fazer o filtro no atributo categoria
                    Console.WriteLine("\nInforme a categoria: ");
                    string categoria = Console.ReadLine();
                    foreach (var alimento in alimentos)
                    {
                        if (categoria == alimento.GrupoAlimentar)
                        {
                            Console.Write(
                                "\nDescrição: " + alimento.DescricaoItem +
                                "\nQuantidade: " + alimento.QuantidadeItem +
                                "\nData de entrada: " + alimento.DataEntrada.ToShortDateString() +
                                "\nAlimento perecível: " + alimento.EhPerecivel.ToString() +
                                "\nForma de armazenamento: " + alimento.FormaArmazenamento +
                                "\nGrupo alimentar: " + alimento.GrupoAlimentar);
                            Console.WriteLine();
                        } 
                    }

                    foreach (var bebida in bebidas)
                    {
                        if (categoria == bebida.Categoria)
                        {


                            exibirBebidas(bebida);
                                /*Console.Write(
                                "\nDescrição: " + bebida.DescricaoItem +
                                "\nQuantidade: " + bebida.QuantidadeItem +
                                "\nData de entrada: " + bebida.DataEntrada.ToShortDateString() +
                                "\nBebida alcóolica: " + bebida.EhAlcoolico.ToString() +
                                "\nVolume unitário: " + bebida.Volume +
                                "\nCategoria: " + bebida.Categoria);
                            Console.WriteLine();*/
                        }
                    }

                    foreach (var limpeza in limpezas)
                    {
                        if (categoria == limpeza.Categoria)
                        {
                            Console.Write(
                                "\nDescrição: " + limpeza.DescricaoItem +
                                "\nQuantidade: " + limpeza.QuantidadeItem +
                                "\nData de entrada: " + limpeza.DataEntrada.ToShortDateString() +
                                "\nCategoria: " + limpeza.Categoria +
                                "\nVolume unitario: " + limpeza.Volume);
                            Console.WriteLine();
                        }
                    }

                    break;

                case 2:
                    //codigo para fazer o filtro no atributo descrição
                    Console.WriteLine("\nInforme a descrição: ");
                    string descricao = Console.ReadLine();

                    
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
		public void solicitarItem()
        {

        }

        void cadastrarBasico()
        {
            /*implementar codigo para poder cadastrar os atributos comuns aos tres 
             * tipos de Produto(Alimento, Bebida, Limpeza)*/
        }
        void exibirAlimentos(Alimento alimento)
        {
           // foreach (var alimento in alimentos)
            //{
                Console.Write(
                    "\nDescrição: " + alimento.DescricaoItem +
                    "\nQuantidade: " + alimento.QuantidadeItem +
                    "\nData de entrada: " + alimento.DataEntrada.ToShortDateString() +
                    "\nAlimento perecível: " + alimento.EhPerecivel.ToString() +
                    "\nForma de armazenamento: " + alimento.FormaArmazenamento +
                    "\nGrupo alimentar: " + alimento.GrupoAlimentar);
                Console.WriteLine();
            //}
        }

        void exibirBebidas(Bebida bebida)
        {
           // foreach (var bebida in bebidas)
           // {
                Console.Write(
                    "\nDescrição: " + bebida.DescricaoItem +
                    "\nQuantidade: " + bebida.QuantidadeItem +
                    "\nData de entrada: " + bebida.DataEntrada.ToShortDateString() +
                    "\nBebida alcóolica: " + bebida.EhAlcoolico.ToString() +
                    "\nVolume unitário: " + bebida.Volume +
                    "\nCategoria: " + bebida.Categoria);
                Console.WriteLine();
            //}
        }

        void exibirLimpezas(Limpeza limpeza)
        {
            //foreach (var limpeza in limpezas)
            //{
                Console.Write(
                    "\nDescrição: " + limpeza.DescricaoItem +
                    "\nQuantidade: " + limpeza.QuantidadeItem +
                    "\nData de entrada: " + limpeza.DataEntrada.ToShortDateString() +
                    "\nCategoria: " + limpeza.Categoria +
                    "\nVolume unitario: " + limpeza.Volume);
                Console.WriteLine();
            //}
        }
    }
}
