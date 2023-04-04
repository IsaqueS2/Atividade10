using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {

        ArrayList equipamentos = new ArrayList();

        while (true)
        {

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adicionar equipamento");
            Console.WriteLine("2 - Visualizar equipamentos");
            Console.WriteLine("3 - Editar equipamento");
            Console.WriteLine("4 - Excluir equipamento");
            Console.WriteLine("5 - Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Digite o nome do equipamento (mínimo 6 caracteres):");
                    string nome = Console.ReadLine();
                    while (nome.Length < 6)
                    {
                        Console.WriteLine("O nome deve ter no mínimo 6 caracteres. Digite novamente:");
                        nome = Console.ReadLine();
                    }

                    Console.WriteLine("Digite o preço de aquisição:");
                    double preco = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite o número de série:");
                    int numeroSerie = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite a data de fabricação (dd/mm/aaaa):");
                    DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o fabricante:");
                    string fabricante = Console.ReadLine();

                    Hashtable equipamento = new Hashtable();
                    equipamento.Add("Nome", nome);
                    equipamento.Add("Preco", preco);
                    equipamento.Add("NumeroSerie", numeroSerie);
                    equipamento.Add("DataFabricacao", dataFabricacao);
                    equipamento.Add("Fabricante", fabricante);

                    equipamentos.Add(equipamento);
                    Console.WriteLine("Equipamento adicionado com sucesso!");
                    break;

                case "2":
                    Console.WriteLine("Equipamentos registrados:");
                    foreach (Hashtable e in equipamentos)
                    {
                        Console.WriteLine("Nome: " + e["Nome"]);
                        Console.WriteLine("Preço: " + e["Preco"]);
                        Console.WriteLine("Número de série: " + e["NumeroSerie"]);
                        Console.WriteLine("Data de fabricação: " + e["DataFabricacao"]);
                        Console.WriteLine("Fabricante: " + e["Fabricante"]);
                        Console.WriteLine("---------------------------");
                    }
                    break;

                case "3":
                    Console.WriteLine("Digite o número de série do equipamento que deseja editar:");
                    int numeroSerieEditar = Convert.ToInt32(Console.ReadLine());

                    foreach (Hashtable e in equipamentos)
                    {
                        if (Convert.ToInt32(e["NumeroSerie"]) == numeroSerieEditar)
                        {
                            Console.WriteLine("Digite o novo nome do equipamento:");
                            string novoNome = Console.ReadLine();
                            while (novoNome.Length < 6)
                            {
                                Console.WriteLine("O nome deve ter no mínimo 6 caracteres. Digite novamente:");
                                novoNome = Console.ReadLine();
                            }
                            e["Nome"] = novoNome;

                            Console.WriteLine("Digite o novo preço de aquisição:");
                            double novoPreco = Convert.ToDouble(Console.ReadLine());
                            e["Preco"] = novoPreco;

                            Console.WriteLine("Digite a nova data de fabricação (dd/mm/aaaa):");
                            DateTime novaDataFabricacao = DateTime.Parse(Console.ReadLine());
                            e["DataFabricacao"] = novaDataFabricacao;

                            Console.WriteLine("Digite o novo fabricante:");
                            string novoFabricante = Console.ReadLine();
                            e["Fabricante"] = novoFabricante;

                            Console.WriteLine("Equipamento editado com sucesso!");
                            break;
                        }
                       
                      
                    }
                    break;

                case "4":
                   
              
                    Console.WriteLine("Digite o número de série do equipamento que deseja excluir:");
                    string numeroSerie = Console.ReadLine();

                    for (int i = 0; i < equipamentos.Count; i++)
                    {
                        if (((string[])equipamentos[i])[2] == numeroSerie)
                        {
                            equipamentos.RemoveAt(i);
                            Console.WriteLine("Equipamento removido com sucesso!");
                            break;
                        }
                    }

                    // Atualizar o arquivo de texto com a lista atualizada de equipamentos
                    AtualizarArquivo(inventario);

                    break;


                case "5":
                    Console.WriteLine("Encerrando o programa...");
                    return;
            }
        }
    }
}

