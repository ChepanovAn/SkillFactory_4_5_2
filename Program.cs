using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_4_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;

            Console.WriteLine("Введите имя");

            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");

            User.LastName = Console.ReadLine();

            Console.WriteLine("Введите логин");

            User.Login = Console.ReadLine();
        }
    }
}
