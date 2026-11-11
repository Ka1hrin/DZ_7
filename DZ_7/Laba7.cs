using System;
using System.Collections.Generic;

namespace DZ_7
{
    class Laba7
    {
        private static void Main()
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Homework1();
            Homework2();
        }

        private static void Task1()
        {
            Console.WriteLine("Упражнение 8.1\n");
            BankAccount account1 = new BankAccount(5500m, TypesOfAccount.Savings);
            BankAccount account2 = new BankAccount(500m, TypesOfAccount.Current);
            account1.PrintInfo();
            account2.PrintInfo();

            account2.Transfer(account1, 1000m);
            Console.WriteLine();
            account1.PrintInfo();
            account2.PrintInfo();
        }

        private static void Task2()
        {
            Console.WriteLine("Упражнение 8.2\n");
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
                throw new ArgumentException("Строка не может быть пустой!");

            string newStr = Reverse(str);
            Console.WriteLine($"Ваша перевернутая строка: {newStr}");
        }

        #region
        /// <summary>
        /// Метод переворачивает строку
        /// </summary>
        private static string Reverse(string str)
        {
            char[] arrayStr = str.ToCharArray();
            Array.Reverse(arrayStr);
            return new string(arrayStr);
        }
        #endregion

        private static void Task3()
        {
            Console.WriteLine("Упражнение 8.3\n");
            Console.Write("Введите название файла (пример, 'File.txt'): ");
            string file = Console.ReadLine();
            if (string.IsNullOrEmpty(file))
                throw new ArgumentException("Строка не может быть пустой!");
            ReadFile(file);
        }

        #region
        /// <summary>
        /// Метод, который читает файл и перезаписывает его
        /// </summary>
        private static void ReadFile(string file)
        {
            if (!File.Exists(file))
                throw new FileNotFoundException(file);
            string arrayFile = File.ReadAllText(file);
            string upArray = arrayFile.ToUpper();
            File.WriteAllText("NewFile.txt", upArray);
            Console.WriteLine("Файл успешно перезаписан!");

        }
        #endregion

        private static void Task4()
        {
            Console.WriteLine("Упражнение 8.4\n");
            int number = 12344;
            Check(number);
            DateTime dateTime = DateTime.Now;
            Check(dateTime);
            string str = "lalala";
            Check(str);
            BankAccount account1 = new BankAccount(5500m, TypesOfAccount.Savings);
            Check(account1);
        }

        #region
        /// <summary>
        /// Метод, который проверяет, реальзует ли объект данного типа метод интерфейса System.IFormattable
        /// </summary>
        private static void Check(object obj)
        {
            if (obj is IFormattable)
            {
                IFormattable formattable = obj as IFormattable;
                Console.WriteLine($"{obj.GetType().Name} реализует IFormattable");
                Console.WriteLine($"Пример работы метода интерфейса System.IFormattable: {formattable}");
            }  
            else
            {
                Console.WriteLine($"{obj.GetType().Name} не реализует IFormattable!");
            }
            
        }
        #endregion

        private static void Homework1()
        {
            Console.WriteLine("Домашнее задание 8.1\n");
            string file = "Email.txt";
            if (!File.Exists(file))
                throw new FileNotFoundException(file);

            string[] lines = File.ReadAllLines(file);

            string[] email = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                SearchMail(ref lines[i]);
                email[i] = lines[i];
            }

            File.WriteAllLines("NewEmails.txt", email);
            Console.WriteLine("Файл успешно перезаписан!");
        }

        #region
        /// <summary>
        /// Метод, который перезаписывает строку
        /// </summary>
        public static void SearchMail(ref string s)
        {
            int index = s.IndexOf('#');
            if (index == -1)
                return;
            s = s.Substring(index + 1).Trim();
        }
        #endregion

        private static void Homework2()
        {
            Console.WriteLine("Домашнее задание 8.2\n");
            Song song1 = new Song("Группа крови", "Виктор Цой");
            Song song2 = new Song("Как на войне", "Агата Кристи");
            song2.Prev = song1;
            Song song3 = new Song("Владимирский централ", "Михаил Круг");
            song3.Prev = song2;
            Song song4 = new Song("Нервы", "Нервы");
            song4.Prev = song3;

            List<Song> list = new List<Song> { song1, song2, song3, song4 };

            foreach(Song song in list)
            {
                Console.WriteLine(song.Title());
            }

            if (song1.Equals(song2))
            {
                Console.WriteLine("Песни совпадают!");
            }
            else
            {
                Console.WriteLine("Песни не совпадают!");
            }
        }
    }
}
