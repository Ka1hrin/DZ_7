using System;

namespace PDF7
{
    public abstract class Employee
    {
        private string _name;
        private string _position;
        public virtual Department Department
        {
            get
            {
                return Department.Management;
            }
        }

        public Employee(string name, string position)
        {
            Name = name;
            Position = position;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Строка не может быть пустой!");
                _name = value;
            }
        }

        public string Position
        {
            get { return _position; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Строка не может быть пустой!");
                _position = value;
            }
        }

        /// <summary>
        /// Метод, который выводит информацию о сотруднике
        /// </summary>
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Имя сотрудника: {_name}\nДолжность: {_position}\n");
        }
    }
}
