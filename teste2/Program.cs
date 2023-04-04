using System;
using System.Collections;

class Program
{
    static ArrayList nomes = new ArrayList();
    static ArrayList idsEquipamentos = new ArrayList();
    static ArrayList numerosDeSerie = new ArrayList();
    static ArrayList precos = new ArrayList();
    static ArrayList fabricantes = new ArrayList();
    static ArrayList datasDeFabricacao = new ArrayList();

    static int contadorIdEquipamento = 0;

    static ArrayList titulos = new ArrayList();
    static ArrayList descricoesChamados = new ArrayList();
    static ArrayList equipamentos = new ArrayList();
    static ArrayList dataDeAbertura = new ArrayList();
    static ArrayList idChamados = new ArrayList();

    static int contadorIdchamados = 0;


    static int opcaoMenus = 0;


    static void Main()
    {
        //ADICIONANDO EQUIPAMENTOS
        //----------------------------------------------------------------
        nomes.Add("Monitor");
        idsEquipamentos.Add(0);
        numerosDeSerie.Add(12);
        precos.Add(200);
        fabricantes.Add("NIKE");
        datasDeFabricacao.Add("12/12/2000");
        //----------------------------------------------------------------
        nomes.Add("Celular");
        idsEquipamentos.Add(1);
        numerosDeSerie.Add(102);
        precos.Add(205);
        fabricantes.Add("NIKE");
        datasDeFabricacao.Add("12/12/2000");
        //----------------------------------------------------------------
        nomes.Add("CelularVelho");
        idsEquipamentos.Add(2);
        numerosDeSerie.Add(15);
        precos.Add(700);
        fabricantes.Add("Samsung");
        datasDeFabricacao.Add("12/12/2010");
        //----------------------------------------------------------------
        nomes.Add("Impressora");
        idsEquipamentos.Add(3);
        numerosDeSerie.Add(25);
        precos.Add(900);
        fabricantes.Add("Samsung");
        datasDeFabricacao.Add("12/12/2010");
        //----------------------------------------------------------------

        //ADICIONANDO CHAMADOS
        //----------------------------------------------------------------
        titulos.Add("Quebrou Monitor");
        descricoesChamados.Add("Quebrou a tela e não acende o lado direito");
        equipamentos.Add(0);
        dataDeAbertura.Add("29/03/2023");
        idChamados.Add(0);
        //----------------------------------------------------------------
        titulos.Add("Quebrou Celular");
        descricoesChamados.Add("Quebrou a tela");
        equipamentos.Add(1);
        dataDeAbertura.Add("21/02/2023");
        idChamados.Add(1);
        //----------------------------------------------------------------
        titulos.Add("Impressora falhou");
        descricoesChamados.Add("Impresssora não imprimi");
        equipamentos.Add(3);
        dataDeAbertura.Add("11/01/2023");
        idChamados.Add(2);
        //----------------------------------------------------------------
        titulos.Add("Celular não liga");
        descricoesChamados.Add("Apenas não liga");
        equipamentos.Add(2);
        dataDeAbertura.Add("02/02/2023");
        idChamados.Add(3);
        //----------------------------------------------------------------

        contadorIdEquipamento = idsEquipamentos.Count;
        contadorIdchamados = idChamados.Count;

        while (opcaoMenus != 3)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("(1) Gerenciar Chamados");
            Console.WriteLine("(2) Gerenciar Equipamentos");
            Console.WriteLine("(3) Sair");
            opcaoMenus = int.Parse(Console.ReadLine());
            Console.ResetColor();

            int opcaoEquipamento = 0;
            int opcaoChamado = 0;

            switch (opcaoMenus)
            {
                case 1:
                    while (opcaoChamado != 5)
                    {
                        Console.Clear();

                        Console.WriteLine("Selecione uma opção: ");
                        Console.WriteLine("(1) Registrar chamado");
                        Console.WriteLine("(2) Visualizar chamados registrados");
                        Console.WriteLine("(3) Editar um chamado");
                        Console.WriteLine("(4) Excluir um chamado");
                        Console.WriteLine("(5) Voltar ao Menu Principal");
                        opcaoChamado = int.Parse(Console.ReadLine());

                        switch (opcaoChamado)
                        {
                            case 1:
                                CriarChamado(titulos, descricoesChamados, equipamentos, dataDeAbertura, idChamados);
                                break;
                            case 2:
                                ListarChamados();
                                break;
                            case 3:
                                EditarChamado(titulos, descricoesChamados, equipamentos, dataDeAbertura, idChamados);
                                break;
                            case 4:
                                RemoverChamado(titulos, descricoesChamados, equipamentos, dataDeAbertura, idChamados);
                                break;
                            case 5:
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("-------------");
                                Console.WriteLine("|Voltando...|");
                                Console.WriteLine("-------------");
                                Console.ResetColor();
                                continue;
                        }
                        Console.ReadLine();
                    }
                    break;
                case 2:
                    while (opcaoEquipamento != 5)
                    {
                        Console.Clear();

                        Console.WriteLine("Selecione uma opção: ");
                        Console.WriteLine("(1) Registrar equipamento");
                        Console.WriteLine("(2) Visualizar equipamentos registrados");
                        Console.WriteLine("(3) Editar um equipamento");
                        Console.WriteLine("(4) Excluir um equipamento");
                        Console.WriteLine("(5) Voltar ao Menu Principal");
                        opcaoEquipamento = int.Parse(Console.ReadLine());

                        switch (opcaoEquipamento)
                        {
                            case 1:
                                CriarEquipamento(nomes, precos, idsEquipamentos, numerosDeSerie, fabricantes, datasDeFabricacao);
                                break;
                            case 2:
                                ListarEquipamentos();
                                break;
                            case 3:
                                EditarEquipamento(nomes, precos, numerosDeSerie, datasDeFabricacao, fabricantes, idsEquipamentos);
                                break;
                            case 4:
                                ExcluirEquipamento(nomes, precos, idsEquipamentos, numerosDeSerie, fabricantes, datasDeFabricacao);
                                break;
                            case 5:
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("-------------");
                                Console.WriteLine("|Voltando...|");
                                Console.WriteLine("-------------");
                                Console.ResetColor();
                                continue;
                        }
                        Console.ReadLine();
                    }
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("|Encerrando o PROGRAMA...|");
                    Console.WriteLine("--------------------------");
                    Console.ResetColor();
                    return;
            }
        }
    }

    private static void ExcluirEquipamento(ArrayList nomes, ArrayList precos, ArrayList idsEquipamentos, ArrayList numerosDeSerie, ArrayList fabricantes, ArrayList datasDeFabricacao)
    {
        Console.WriteLine("Digite o ID do equipamento que deseja excluir: ");
        int idParaExcluir = int.Parse(Console.ReadLine());

        while (idParaExcluir > idsEquipamentos.Count || idParaExcluir < 0)
        {
            Console.WriteLine("Equipamento não existe!");
            Console.WriteLine();
            Console.WriteLine("Digite o ID que deseja excluir: ");
            idParaExcluir = int.Parse(Console.ReadLine());
        }

        nomes.RemoveAt(idParaExcluir);
        precos.RemoveAt(idParaExcluir);
        idsEquipamentos.RemoveAt(idParaExcluir);
        numerosDeSerie.RemoveAt(idParaExcluir);
        fabricantes.RemoveAt(idParaExcluir);
        datasDeFabricacao.RemoveAt(idParaExcluir);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("|Equipamento excluído com sucesso!|");
        Console.WriteLine("-----------------------------------");
        Console.ResetColor();


    }

    private static void ListarEquipamentos()
    {
        Console.WriteLine("Equipamentos registrados:");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("ID | NOME       | PREÇO  | FABRICANTE| DATA DE FABRICAÇÃO |");
        Console.WriteLine("-----------------------------------------------------------");
        Console.ResetColor();

        for (int i = 0; i < idsEquipamentos.Count; i++)
        {
            Console.WriteLine("{0,-3}|{1,-12}|{2,-8}|{3,-11}|{4,-20}|", idsEquipamentos[i], nomes[i], precos[i], fabricantes[i], datasDeFabricacao[i]);
        }

    }

    private static void CriarEquipamento(ArrayList nomes, ArrayList precos, ArrayList idsEquipamentos, ArrayList numerosDeSerie, ArrayList fabricantes, ArrayList datasDeFabricacao)
    {

        Console.WriteLine("Digite o nome do equipamento: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o preço de aquisição do equipamento: ");
        double preco = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o número de série do equipamento: ");
        string numeroSerie = Console.ReadLine();
        Console.WriteLine("Digite a data de fabricação do equipamento: ");
        string dataFabricacao = Console.ReadLine();
        Console.WriteLine("Digite o fabricante do equipamento: ");
        string fabricante = Console.ReadLine();


        while (nome.Length < 6)
        {
            Console.WriteLine("O nome do equipamento deve ter no mínimo 6 caracteres.");
            Console.WriteLine("Digite novamente o nome (com 6 ou mais caracteres): ");
            nome = Console.ReadLine();
        }

        nomes.Add(nome);
        precos.Add(preco);
        idsEquipamentos.Add(contadorIdEquipamento);
        numerosDeSerie.Add(numeroSerie);
        fabricantes.Add(fabricante);
        datasDeFabricacao.Add(dataFabricacao);

        contadorIdEquipamento++;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("|Equipamento registrado com sucesso!|");
        Console.WriteLine("-------------------------------------");
        Console.ResetColor();

    }

    static void EditarEquipamento(ArrayList nomes, ArrayList precos, ArrayList numerosDeSerie, ArrayList datasDeFabricacao, ArrayList fabricantes, ArrayList idsEquipamentos)
    {
        Console.WriteLine("Qual equipamento você deseja editar? (determine o ID) ");
        int id = int.Parse(Console.ReadLine());

        while (id > idsEquipamentos.Count || id < 0)
        {
            Console.WriteLine("Este ID não existe, digite um ID existente: ");
            id = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite o novo nome do equipamento: ");
        string novoNome = Console.ReadLine();
        Console.WriteLine("Digite o novo preço de aquisição do equipamento: ");
        double novoPreco = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o novo número de série do equipamento: ");
        string novoNumeroSerie = Console.ReadLine();
        Console.WriteLine("Digite a nova data de fabricação do equipamento: ");
        string novaDataFabricacao = Console.ReadLine();
        Console.WriteLine("Digite o novo fabricante do equipamento: ");
        string novoFabricante = Console.ReadLine();


        nomes[id] = novoNome;
        precos[id] = novoPreco;
        numerosDeSerie[id] = novoNumeroSerie;
        fabricantes[id] = novoFabricante;
        datasDeFabricacao[id] = novaDataFabricacao;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("|Equipamento atualizado com sucesso!|");
        Console.WriteLine("-------------------------------------");
        Console.ResetColor();
    }

    private static void CriarChamado(ArrayList titulos, ArrayList descricoesChamados, ArrayList equipamentos, ArrayList dataDeAbertura, ArrayList idChamados)
    {

        Console.WriteLine("Digite o título do chamado: ");
        string titulo = Console.ReadLine();
        Console.WriteLine("Digite a descrição do chamado: ");
        string descricao = Console.ReadLine();
        Console.WriteLine("Digite o id do equipamento deste chamado: ");
        int equipamentoId = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a data de abertura do chamado: ");
        string dataAbertura = Console.ReadLine();


        titulos.Add(titulo);
        descricoesChamados.Add(descricao);
        equipamentos.Add(equipamentoId);
        dataDeAbertura.Add(dataAbertura);
        idChamados.Add(contadorIdchamados);

        contadorIdchamados++;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("---------------------------------");
        Console.WriteLine("|Chamado registrado com sucesso!|");
        Console.WriteLine("---------------------------------");
        Console.ResetColor();

    }

    private static void ListarChamados()
    {
        Console.WriteLine("Chamados registrados:");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("ID |        TITULO          | EQUIPAMENTO |     DATA DE ABERTURA     |");
        Console.WriteLine("----------------------------------------------------------------------");
        Console.ResetColor();

        for (int i = 0; i < idChamados.Count; i++)
        {
            int posicaoIdEquipamento = (int)equipamentos[i];
            Console.WriteLine("{0,-3}|{1,-24}|{2,-13}|{3,-26}|", idChamados[i], titulos[i], nomes[posicaoIdEquipamento], dataDeAbertura[i]);
        }
    }

    private static void EditarChamado(ArrayList titulos, ArrayList descricoesChamados, ArrayList equipamentos, ArrayList dataDeAbertura, ArrayList idChamados)
    {
        Console.WriteLine("Qual chamado você deseja editar? (determine o ID) ");
        int id = int.Parse(Console.ReadLine());

        while (id > idChamados.Count || id < 0)
        {
            Console.WriteLine("Este ID não existe, digite um ID existente: ");
            id = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite o novo título do chamado: ");
        string novotitulo = Console.ReadLine();
        Console.WriteLine("Digite anova descrição do chamado: ");
        string novaDescricao = Console.ReadLine();
        Console.WriteLine("Digite o novo ID do equipamento do chamado: ");
        int equipamento = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nova data de abertura do chamado: ");
        string novaDataAbertura = Console.ReadLine();


        titulos[id] = novotitulo;
        descricoesChamados[id] = novaDescricao;
        equipamentos[id] = equipamento;
        dataDeAbertura[id] = novaDataAbertura;


        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("---------------------------------");
        Console.WriteLine("|Chamado atualizado com sucesso!|");
        Console.WriteLine("---------------------------------");
        Console.ResetColor();
    }
    private static void RemoverChamado(ArrayList titulos, ArrayList descricoesChamados, ArrayList equipamentos, ArrayList dataDeAbertura, ArrayList idChamados)
    {
        Console.WriteLine("Digite o ID do chamado que deseja excluir: ");
        int idParaExcluir = int.Parse(Console.ReadLine());

        while (idParaExcluir > idChamados.Count || idParaExcluir < 0)
        {
            Console.WriteLine("Chamado não existe!");
            Console.WriteLine();
            Console.WriteLine("Digite o ID que deseja excluir: ");
            idParaExcluir = int.Parse(Console.ReadLine());
        }

        titulos.RemoveAt(idParaExcluir);
        descricoesChamados.RemoveAt(idParaExcluir);
        equipamentos.RemoveAt(idParaExcluir);
        dataDeAbertura.RemoveAt(idParaExcluir);
        idChamados.RemoveAt(idParaExcluir);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("-------------------------------");
        Console.WriteLine("|Chamado excluído com sucesso!|");
        Console.WriteLine("-------------------------------");
        Console.ResetColor();

    }
}