using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class Curso1
    {
        static Dictionary<string, List<int>> bandas = new Dictionary<string, List<int>>();


        private static void PrintWelcomeMessage()
        {
            string welcomeMessage = "Bem vindos ao Screen Sound!";

            Console.WriteLine(@"
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
            Console.WriteLine(welcomeMessage);
        }

        private static void printOptions()
        {
            Console.WriteLine("\n1 - Registrar banda");
            Console.WriteLine("2 - Mostrar bandas");
            Console.WriteLine("3 - Avaliar bandas");
            Console.WriteLine("4 - Exibir média de uma banda");
            Console.WriteLine("0 - sair");

            Console.Write("\nSelect an option: ");

            int selectedOption = int.Parse(Console.ReadLine());


            switch (selectedOption)
            {
                case 1:
                    {
                        groupRegister();
                        break;
                    }
                case 2:
                    {
                        printGroups();
                        break;
                    }
                case 3:
                    {
                        rateGroup();
                        break;
                    }
                case 4:
                    {
                        showGroupRate();
                        break;
                    }
                case 0:
                    {
                        Console.WriteLine($"\nSaindo...");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opção inválida. Encerrando o programa.");
                        break;
                    }
            }
        }

        private static void groupRegister()
        {
            Console.Clear();
            showOptionTitle("Registro de bandas");
            Console.Write("Nome da banda: ");
            string name = Console.ReadLine();
            if (name != null || name != "")
            {
                bandas.Add(name, new List<int>());
            }
            Thread.Sleep(1000);
            Console.Clear();
            printOptions();
        }

        private static void printGroups()
        {
            showOptionTitle("Exibindo todas as bandas registradas");
            foreach (string banda in bandas.Keys)
            {
                Console.WriteLine($"| {banda} |");
            };

            Console.Write("Aperte uma tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
            printOptions();
        }

        private static void showOptionTitle(string phrase)
        {
            string details = "";

            for (int i = 0; i < phrase.Length + 6; i++)
            {
                details += "*";
            }

            Console.WriteLine(@$"
{details}
   {phrase}
{details}");
        }

        private static void rateGroup()
        {
            Console.Clear();
            showOptionTitle("Dar nota a uma banda");
            string name = Console.ReadLine();
            if (bandas.ContainsKey(name))
            {
                Console.Write("Digite a nota: ");
                int rate = int.Parse(Console.ReadLine());
                bandas[name].Add(rate);
                Console.WriteLine("Nota registrada com sucesso.");

                Thread.Sleep(1000);
                Console.Clear();
                printOptions();
            }
            else
            {
                Console.WriteLine($"A banda {name} não foi encontrada");
                Console.Write("Aperte uma tecla para voltar ao menu");
                Console.ReadKey();
                printOptions();
            }
        }

        private static void showGroupRate()
        {
            Console.Clear();
            showOptionTitle("Exibindo nota da banda");
            string name = Console.ReadLine();
            if (bandas.ContainsKey(name))
            {
                float totalRate = 0;

                bandas[name].ForEach(rate =>
                {
                    totalRate += rate;
                });

                float avrgRate = totalRate / bandas[name].Count();

                if (float.IsNaN(avrgRate))
                {
                    Console.WriteLine($"A nota da banda {name} é {avrgRate}");
                }
                else
                {
                    Console.WriteLine("A banda não possui notas");
                }

                Console.Write("Aperte uma tecla para voltar ao menu");
                Console.ReadKey();
                Console.Clear();
                printOptions();
            }
            else
            {
                Console.WriteLine($"A banda {name} não foi encontrada");
                Console.Write("Aperte uma tecla para voltar ao menu");
                Console.ReadKey();
                printOptions();
            }
        }



        public static void execute()
        {
            PrintWelcomeMessage();
            printOptions();
        }
    }


}
