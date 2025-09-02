using System;

//funcao -> acoes que  tem que fazer vem com verbo  verificar, atualizar(infinitivo)

//criar uma lista de tarefas
List<string> tarefas = new List<string>();
List<bool> statusTarefas = new List<bool>();


void ExibirMenu()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("==========ASSISTENTE PESSOAL===========");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("1. Adicionar tarefa");
    Console.WriteLine("2. Listar tarefas");
    Console.WriteLine("3. Marcar tarefa como concluída");
    Console.WriteLine("4. Excluir tarefa");
    Console.WriteLine("5. Exibir resumo das tarefas");
    Console.WriteLine("0. Sair");
    Console.WriteLine("Escolha uma opção: :)");
}

//metodos

void CadastrarTarefa()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Digite uma nova tarefa");
    string novaTarefa = Console.ReadLine();
    tarefas.Add(novaTarefa);
    statusTarefas.Add(false);

    Console.WriteLine("Eba tarefa adiciona com sucesso!!");
}


void ListaTarefas()
{

    //string nome = "aninha"
    //2== 2 

    //Verificar se existe alguma tarefa cadastrada
    Console.ForegroundColor = ConsoleColor.Green;
    if (tarefas.Count == 0)
    {
        Console.WriteLine("Nenhuma tarefa Cadastrada");
        return;
    }

    Console.WriteLine("=== Lista de Tarefas ====");
    //for(inicializador; condicao; ; incrmentar/decrementar
    //tarefas.count => 10;
    for (int i = 0; i < tarefas.Count; i++)
    {
        bool status = statusTarefas[i];
        string cheack;

        if (status == true)
        {
            cheack = "[X]";
        }
        else
        {
            cheack = "[]";
        }

        //bool status = statusTarefa[i];
        Console.WriteLine($" {status} - {tarefas[i]}");
    }

}

void MarcarComoConcluida()
{
    ListaTarefas();

    Console.WriteLine("Informe o numero da tarefa a ser concluida:");
    int numTarefa = Convert.ToInt32(Console.ReadLine()!) - 1;
    //01
    //02
    //03

    //02

    if (numTarefa >= 0 && numTarefa < tarefas.Count)
    {
        statusTarefas[numTarefa] = true;
        Console.WriteLine("Tarefa como concluida");
    }
    {
        Console.WriteLine("Numero invalido. essa tarefa nao existe");
    }

}

void ExcluirTarefa()
{
    ListaTarefas();

    Console.WriteLine("Informe o numero da tarefa a ser concluida:");
    int numTarefa = Convert.ToInt32(Console.ReadLine()!) - 1;
    //01
    //02
    //03

    //02

    if (numTarefa >= 0 && numTarefa <= tarefas.Count)
    {
        tarefas.RemoveAt(numTarefa);
        statusTarefas.RemoveAt(numTarefa);
        Console.WriteLine("Tarefa removida com Sucesso!");
    }
    {
        Console.WriteLine("Numero invalido. essa tarefa nao existe");
    }

}


void ExibirResumo()
{
    int totalDeTarefas = tarefas.Count;
    //eese pega todos os status com true e false;
    //int tarefasConcluidas = statusTarefas.Count;
    //Estamos pegando somnete os status que estao true:
     int tarefasConcluidas = statusTarefas.FindAll(x => x).Count();
    int tarefasPendentes = totalDeTarefas - tarefasConcluidas;

    Console.WriteLine("=== Resumo ===");
    //interpolacao
    Console.WriteLine($"Total de tarefas: {totalDeTarefas}");
    Console.WriteLine($"Total de tarefas: {tarefasConcluidas}");
    Console.WriteLine($"Total de tarefas: {tarefasPendentes}");

}
//if() ->
//swirch case ->..
do
{
    ExibirMenu();
    string opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
            CadastrarTarefa();
            break;
        case "2":
            ListaTarefas();
            break;
        case "3":
            MarcarComoConcluida();
            break;
        case "4":
            ExcluirTarefa();
            break;
        case "5":
            ExibirResumo();
            break;
        case "0":
            Console.WriteLine("Tchau ate a proxima;");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;

    }
} while (true);


//using System;
//using System.Collections.Generic;

//// Listas globais
//List<string> tarefas = new List<string>();
//List<bool> statusTarefas = new List<bool>();

//// Exibe o menu principal
//void ExibirMenu()
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine("========== ASSISTENTE PESSOAL ===========");
//    Console.ForegroundColor = ConsoleColor.Yellow;
//    Console.WriteLine("1. Adicionar tarefa");
//    Console.WriteLine("2. Listar tarefas");
//    Console.WriteLine("3. Marcar tarefa como concluída");
//    Console.WriteLine("4. Excluir tarefa");
//    Console.WriteLine("5. Exibir resumo das tarefas");
//    Console.WriteLine("0. Sair");
//    Console.Write("Escolha uma opção: :) ");
//    Console.ResetColor();
//}

//// Adiciona uma nova tarefa
//void CadastrarTarefa()
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine("Digite uma nova tarefa:");
//    string novaTarefa = Console.ReadLine();
//    tarefas.Add(novaTarefa);
//    statusTarefas.Add(false);
//    Console.WriteLine("Eba! Tarefa adicionada com sucesso!!");
//    Console.ResetColor();
//}

//// Lista todas as tarefas
//void ListaTarfeas()
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    if (tarefas.Count == 0)
//    {
//        Console.WriteLine("Nenhuma tarefa cadastrada.");
//        Console.ResetColor();
//        return;
//    }

//    Console.WriteLine("=== Lista de Tarefas ===");
//    for (int i = 0; i < tarefas.Count; i++)
//    {
//        bool status = statusTarefas[i];
//        string check = status ? "[X]" : "[ ]";
//        Console.WriteLine($"{i + 1}. {check} - {tarefas[i]}");
//    }
//    Console.ResetColor();
//}

//// Marca uma tarefa como concluída
//void MarcarComoConcluida()
//{
//    ListaTarfeas();

//    if (tarefas.Count == 0)
//        return;

//    Console.WriteLine("Informe o número da tarefa a ser concluída:");
//    int numTarefa = Convert.ToInt32(Console.ReadLine()) - 1;

//    if (numTarefa >= 0 && numTarefa < tarefas.Count)
//    {
//        statusTarefas[numTarefa] = true;
//        Console.WriteLine("Tarefa marcada como concluída!");
//    }
//    else
//    {
//        Console.WriteLine("Número inválido. Essa tarefa não existe.");
//    }
//}

//// Exclui uma tarefa
//void ExcluirTarefa()
//{
//    ListaTarfeas();

//    if (tarefas.Count == 0)
//        return;

//    Console.WriteLine("Informe o número da tarefa a ser excluída:");
//    int numero = Convert.ToInt32(Console.ReadLine()) - 1;

//    if (numero >= 0 && numero < tarefas.Count)
//    {
//        string tarefaRemovida = tarefas[numero];
//        tarefas.RemoveAt(numero);
//        statusTarefas.RemoveAt(numero);
//        Console.WriteLine($"Tarefa \"{tarefaRemovida}\" foi excluída com sucesso!");
//    }
//    else
//    {
//        Console.WriteLine("Número inválido. Essa tarefa não existe.");
//    }
//}

//// Exibe um resumo das tarefas
//void ExibirResumo()
//{
//    int total = tarefas.Count;
//    int concluidas = 0;
//    int pendentes = 0;

//    foreach (bool status in statusTarefas)
//    {
//        if (status)
//            concluidas++;
//        else
//            pendentes++;
//    }

//    Console.ForegroundColor = ConsoleColor.Cyan;
//    Console.WriteLine("===== RESUMO DAS TAREFAS =====");
//    Console.WriteLine($"Total de tarefas: {total}");
//    Console.WriteLine($"Concluídas: {concluidas}");
//    Console.WriteLine($"Pendentes: {pendentes}");
//    Console.ResetColor();
//}

//// Loop principal
//do
//{
//    ExibirMenu();
//    string opcao = Console.ReadLine();
//    Console.Clear();

//    switch (opcao)
//    {
//        case "1":
//            CadastrarTarefa();
//            break;
//        case "2":
//            ListaTarfeas();
//            break;
//        case "3":
//            MarcarComoConcluida();
//            break;
//        case "4":
//            ExcluirTarefa();
//            break;
//        case "5":
//            ExibirResumo();
//            break;
//        case "0":
//            Console.WriteLine("Saindo... Até logo!");
//            return;
//        default:
//            Console.WriteLine("Opção inválida. Tente novamente.");
//            break;
//    }

//    Console.WriteLine("\nPressione ENTER para continuar...");
//    Console.ReadLine();
//    Console.Clear();

//} while (true);






//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    // Listas globais para armazenar as tarefas e o status de conclusão
//    static List<string> tarefas = new List<string>();
//    static List<bool> concluido = new List<bool>();

//    static void Main()
//    {
//        // Loop principal
//        do
//        {
//            ExibirMenu();
//            string opcao = Console.ReadLine();
//            Console.Clear();

//            switch (opcao)
//            {
//                case "1":
//                    CadastrarTarefa();
//                    break;
//                case "2":
//                    ListarTarefas();
//                    break;
//                case "3":
//                    MarcarComoConcluida();
//                    break;
//                case "4":
//                    ExcluirTarefa();
//                    break;
//                case "5":
//                    ExibirResumo();
//                    break;
//                case "0":
//                    Console.WriteLine("Saindo... Até logo!");
//                    return;
//                default:
//                    Console.WriteLine("Opção inválida");
//                    break;
//            }

//            Console.WriteLine("\nPressione qualquer tecla para continuar...");
//            Console.ReadKey();
//            Console.Clear();

//        } while (true);
//    }

//    static void ExibirMenu()
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine("========== ASSISTENTE PESSOAL ===========");
//        Console.ForegroundColor = ConsoleColor.Yellow;
//        Console.WriteLine("1. Adicionar tarefa");
//        Console.WriteLine("2. Listar tarefas");
//        Console.WriteLine("3. Marcar tarefa como concluída");
//        Console.WriteLine("4. Excluir tarefa");
//        Console.WriteLine("5. Exibir resumo das tarefas");
//        Console.WriteLine("0. Sair");
//        Console.WriteLine("Escolha uma opção: :)");
//        Console.ResetColor();
//    }

//    static void CadastrarTarefa()
//    {
//        Console.Write("Digite a nova tarefa: ");
//        string novaTarefa = Console.ReadLine();

//        if (!string.IsNullOrWhiteSpace(novaTarefa))
//        {
//            tarefas.Add(novaTarefa);
//            concluido.Add(false);
//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine("Tarefa adicionada com sucesso!");
//        }
//        else
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine("Tarefa inválida. Não foi adicionada.");
//        }

//        Console.ResetColor();
//    }

//    static void ListarTarefas()
//    {
//        Console.ForegroundColor = ConsoleColor.Cyan;

//        if (tarefas.Count == 0)
//        {
//            Console.WriteLine("Nenhuma tarefa cadastrada.");
//        }
//        else
//        {
//            Console.WriteLine("Lista de tarefas:");
//            for (int i = 0; i < tarefas.Count; i++)
//            {
//                string status = concluido[i] ? "[Concluída]" : "[Pendente]";
//                Console.WriteLine($"{i + 1}. {tarefas[i]} {status}");
//            }
//        }

//        Console.ResetColor();
//    }

//    static void MarcarComoConcluida()
//    {
//        ListarTarefas();

//        Console.Write("\nDigite o número da tarefa a marcar como concluída: ");
//        if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 1 && numero <= tarefas.Count)
//        {
//            concluido[numero - 1] = true;
//            Console.WriteLine("Tarefa marcada como concluída.");
//        }
//        else
//        {
//            Console.WriteLine("Número inválido.");
//        }
//    }

//    static void ExcluirTarefa()
//    {
//        ListarTarefas();

//        Console.Write("\nDigite o número da tarefa a excluir: ");
//        if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 1 && numero <= tarefas.Count)
//        {
//            tarefas.RemoveAt(numero - 1);
//            concluido.RemoveAt(numero - 1);
//            Console.WriteLine("Tarefa excluída com sucesso.");
//        }
//        else
//        {
//            Console.WriteLine("Número inválido.");
//        }
//    }

//    static void ExibirResumo()
//    {
//        int total = tarefas.Count;
//        int feitas = concluido.Count(x => x);
//        int pendentes = total - feitas;

//        Console.WriteLine("===== RESUMO =====");
//        Console.WriteLine($"Total de tarefas: {total}");
//        Console.WriteLine($"Concluídas: {feitas}");
//        Console.WriteLine($"Pendentes: {pendentes}");
//    }
//}
