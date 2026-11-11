using System;

namespace PDF7
{
    public enum ItSpecialization
    {
        SystemAdmin, Developer
    }

    public static class Help
    {
        /// <summary>
        /// Метод, который тип ItSpecialization преобразует в строку
        /// </summary>
        public static string EnumName(ItSpecialization specialization)
        {
            return specialization switch
            {
                ItSpecialization.Developer => "Разработчик",
                ItSpecialization.SystemAdmin => "Системщик",
                _ => "Неизвестный тип!"
            };
        }

        /// <summary>
        /// Метод, который тип Department преобразует в строку
        /// </summary>
        public static string EnumName(Department department)
        {
            return department switch
            {
                Department.ItDevelopers => "Разработчик",
                Department.ItSystems => "Системщик",
                Department.Management => "Начальство",
                _ => "Неизвестный тип!"
            };
        }
    }
}