using System;
using System.Runtime.InteropServices;

class MainClass
{
    static void Main(string[] args)
    {
        (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;

        int number = 0;
        while (number < 3)
        {
            Console.WriteLine("Введите имя");

            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");

            User.LastName = Console.ReadLine();

            Console.WriteLine("Введите логин");

            User.Login = Console.ReadLine();

            User.LoginLength = User.Login.Length;

            Console.WriteLine("Есть ли у вас животные? Да или Нет");

            var result = Console.ReadLine();

            if (result == "Да")
            {
                User.HasPet = true;
            }

            Console.WriteLine("Введите возраст пользователя");

            User.Age = Convert.ToInt32(Console.ReadLine());

            User.favcolors = new string[3];

            Console.WriteLine("Введите три любимых цвета пользователя:");

            for (int i = 0; i < User.favcolors.Length; i++)
            {
                Console.ReadLine();
            }

            number++;
        }

        

    }
}