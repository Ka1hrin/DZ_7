using System;

namespace PDF7
{
    public class Task
    {
        private string _description;
        private Department _department;

        public Task(string description, Department department)
        {
            Description = description;
            Target = department;
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Строка не может быть пустой!");
                _description = value;
            }
        }

        public Department Target
        {
            get { return _department; }
            set
            {
                if (!Enum.IsDefined(typeof(Department), value))
                    throw new ArgumentException("Некорректный тип!");
                _department = value;
            }
        }

        /// <summary>
        /// Метод, который печатает информацию о задаче
        /// </summary>
        public void PrintInfo()
        {
            Console.WriteLine($"Задача: {_description}\nОтдел: {Help.EnumName(_department)}\n");
        }
    }
}