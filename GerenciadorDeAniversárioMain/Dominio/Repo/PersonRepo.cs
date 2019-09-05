using Dominio.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Model.Repo
{
    public class PersonRepo
    {
        public static List<Person> people = new List<Person>();
        public static Person AddBday()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Adicionando nova pessoa:");

            Person firstPerson = new Person();

            int idPerson = people.Count + 1;
            firstPerson.PersonId = idPerson;


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite o primeiro nome da pessoa");
            firstPerson.Nome = Console.ReadLine();


            Console.WriteLine("Digite o último sobrenome da pessoa");
            firstPerson.Sobrenome = Console.ReadLine();


            Console.WriteLine("Digite a data de aniversário nesse formato DD/MM/YYYY");
            firstPerson.BdayDate = Console.ReadLine();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pessoa added com sucesso");
            Console.ForegroundColor = ConsoleColor.White;



            return firstPerson;
            

        }

        public static void AddToList()
        {
            Person firstPerson1 = AddBday();
            people.Add(firstPerson1);
        }

        public static void FindBday()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Procurando pessoa:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite o nome ou parte do nome da pessoa que deseja procurar");
            string searchInput = Console.ReadLine();

            foreach(Person p in people)
            {
                if ((p.Nome.Contains(searchInput)) || (p.Sobrenome.Contains(searchInput)))
                {
                    Console.WriteLine($"{p.PersonId} - {p.Nome} {p.Sobrenome}");
                }
            }


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite o numero da pessoa desejada:");
            Console.ForegroundColor = ConsoleColor.White;
         
            int selectionInput = Convert.ToInt32(Console.ReadLine());

            foreach (Person p in people)
            {
                if (selectionInput == p.PersonId)
                {
                    Console.WriteLine($"{p.PersonId} - {p.Nome} {p.Sobrenome}");
                    Console.WriteLine($"Nasceu dia: {p.BdayDate}");
                    Console.Write($"Faltam ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(p.TimeToBday());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" dias para seu aniversário");
                    Console.WriteLine();
                }
            }
           
            Console.ReadLine();
        }

        public static void FullBday()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Lista completa de pessoas:");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Person a in people)
            {
                Console.WriteLine($"{a.PersonId} - {a.Nome} {a.Sobrenome}");
                Console.WriteLine($"Nasceu dia: {a.BdayDate}");
                Console.Write($"Faltam ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(a.TimeToBday());
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" dias para seu aniversário");
                Console.WriteLine();
            }

            Console.ReadLine();
        }

    }
}
