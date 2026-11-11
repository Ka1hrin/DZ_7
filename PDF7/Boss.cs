using System;

namespace PDF7
{
    public class Boss : Employee
    {
        private List<Employee> _subordinates;
        public override Department Department
        {
            get
            {
                if (Position.Contains("разработчиков"))
                    return Department.ItDevelopers;

                if (Position.Contains("систем"))
                    return Department.ItSystems;

                return Department.Management;
            }
        }

        public Boss(string name, string position, List<Employee> subordinates)
            : base (name, position)
        {
            Subordinates = subordinates;
        }

        public List<Employee> Subordinates
        {
            get {  return _subordinates; }
            set
            {
                if (value == null)
                    _subordinates = new List<Employee>();
                else
                    _subordinates = value;
            }
        }


        /// <summary>
        /// Метод, который добавляет сотрудника в подчинение
        /// </summary>
        public void AddSubordinate(Employee employee)
        {
            if (employee == null || employee == this)
                throw new ArgumentException("Вы не можете добавить несуществующего работника или себя!");
            _subordinates.Add(employee);
        }

        /// <summary>
        /// Метод, который проверяет, находится ли сотрудник в прямом подчинении
        /// </summary>
        public bool HasSubordinates(Employee employee)
        {
            if (employee == null)
                return false;

            foreach (Employee subordinate in _subordinates)
            {
                if (subordinate == employee)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Метод, который дает задачу и выводит, принял ли ее сотрудник
        /// </summary>
        public void GiveTask(Task task, Employee employee)
        {
            if (task == null || employee == null)
            {
                throw new ArgumentNullException();
            }

            if (!HasSubordinates(employee))
            {
                Console.WriteLine($"{Name} не является прямым руководителем {employee.Name}.\n");
                return;
            }

            if (task.Target != employee.Department)
            {
                Console.WriteLine($"{Name} не может выдать задачу «{task.Description}» сотруднику {employee.Name}, так как задача относится к другому отделу.\n");
                return;
            }

            Console.WriteLine($"{Name} даёт задачу «{task.Description}» сотруднику {employee.Name}. {employee.Name} БЕРЕТ задачу.\n");
        }

        /// <summary>
        /// Метод, который выводит информацию о начальнике
        /// </summary>
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.Write("Список подчиненных: ");
            foreach(Employee subordinates in Subordinates)
            {
                Console.Write($"{subordinates.Name} ");
            }
        }
    }
}