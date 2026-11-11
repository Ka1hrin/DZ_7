using System;

namespace PDF7
{
    public class ItSpecialist : Employee
    {
        private ItSpecialization _specialization;
        public override Department Department
        {
            get
            {
                return Specialization switch
                {
                    ItSpecialization.SystemAdmin => Department.ItSystems,
                    ItSpecialization.Developer => Department.ItDevelopers,
                    _ => Department.Management
                };
            }
        }

        public ItSpecialist(string name, ItSpecialization specialization) : base(name, "Сотрудник")
        {
            Specialization = specialization;
        }

        public ItSpecialization Specialization
        {
            get { return _specialization; }
            set
            {
                if (!Enum.IsDefined(typeof(ItSpecialization), value))
                    throw new ArgumentException("Некорректный тип!");
                _specialization = value;
            }
        }

        /// <summary>
        /// Метод, который выведет информацию о сотруднике
        /// </summary>
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Специализация: {Help.EnumName(_specialization)}");
        }
    }
}