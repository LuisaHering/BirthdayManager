using Dominio.Model.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repo
{
    public class StarterMenuRepo
    {
        public static void Starter()
        {
            Console.Clear();
            //Beggining Bday Sorter
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to Bday Sorter! How may i be of assistance?");
            Console.WriteLine("");

            //menu presentation
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("-Add Bday! | ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("2");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("-Find Bday! | ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("3");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-Full Bday List!");

            //User choice input
            string input = Console.ReadLine();

            if (input == "1")
            {
                PersonRepo.AddToList();
                AddBdayMenu();

            }
            else if (input == "2")
            {
                PersonRepo.FindBday();
                FindBdayMenu();
            }
            else if (input == "3")
            {
                PersonRepo.FullBday();
                FullBdayMenu();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opcão não encontrada");
                Console.ForegroundColor = ConsoleColor.White;
                Starter();
            }

        }

        public static void AddBdayMenu()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("-Add more people | ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("2");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-Back to main menu");

            string inputAddMenu = Console.ReadLine();
            Console.WriteLine();

            if (inputAddMenu == "1")
            {
                PersonRepo.AddToList();
                AddBdayMenu();
            }
            else if (inputAddMenu == "2")
            {
                Starter();
            }

        }

        public static void FullBdayMenu()
        {
            Console.WriteLine("Deseja voltar ao menu principal?");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("-Não | ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("2");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-Sim");

            string inputAddMenu = Console.ReadLine();
            Console.WriteLine();

            if ((inputAddMenu == "1") || (inputAddMenu == "nao") || (inputAddMenu == "não") || (inputAddMenu == "Não") || (inputAddMenu == "Nao"))
            {
                Console.WriteLine("Ok.");
            }
            else if ((inputAddMenu == "2") || (inputAddMenu == "Sim") || (inputAddMenu == "sim"))
            {
                Starter();
            }

        }

        public static void FindBdayMenu()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("-Find another person | ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("2");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-Back to main menu");

            string inputAddMenu = Console.ReadLine();
            Console.WriteLine();

            if (inputAddMenu == "1")
            {
                PersonRepo.FindBday();
            }
            else if (inputAddMenu == "2")
            {
                Starter();
            }

        }
    }

}
