using System;

namespace PDF7
{
    internal class PDF_7
    {
        private static void Main()
        {
            Boss timur = new Boss("Тимур", "Генеральный директор", null);
            Boss rashid = new Boss("Рашид", "Финансовый директор", null);
            Boss ilcham = new Boss("О Ильхам", "Директор по автоматизации", null);
            Boss arkadi = new Boss("Оркадий", "Начальник инф.систем", null);
            Boss volodya = new Boss("Володя", "Зам.начальник инф.систем", null);
            Boss ilshat = new Boss("Ильшат", "Главный в секторе системщиков", null);
            Boss ivanych = new Boss("Иваныч", "Зам.начальник в секторе системщиков", null);
            Boss sergey = new Boss("Сергей", "Главный в секторе разработчиков", null);
            Boss lyaysan = new Boss("Ляйсан", "Зам.начальник в секторе разработчиков", null);
            Accountant lukas = new Accountant("Лукас");
            ItSpecialist ilya = new ItSpecialist("Илья", ItSpecialization.SystemAdmin);
            ItSpecialist vitya = new ItSpecialist("Витя", ItSpecialization.SystemAdmin);
            ItSpecialist zenya = new ItSpecialist("Женя", ItSpecialization.SystemAdmin);
            ItSpecialist marat = new ItSpecialist("Марат", ItSpecialization.Developer);
            ItSpecialist dina = new ItSpecialist("Дина", ItSpecialization.Developer);
            ItSpecialist anton = new ItSpecialist("Антон", ItSpecialization.Developer);
            ItSpecialist ildar = new ItSpecialist("Ильдар", ItSpecialization.Developer);

            timur.AddSubordinate(rashid);
            rashid.AddSubordinate(lukas);
            timur.AddSubordinate(ilcham);
            ilcham.AddSubordinate(arkadi);
            arkadi.AddSubordinate(volodya);
            arkadi.AddSubordinate(ilshat);
            arkadi.AddSubordinate(sergey);
            volodya.AddSubordinate(ilshat);
            volodya.AddSubordinate(sergey);
            ilshat.AddSubordinate(ivanych);
            ilshat.AddSubordinate(ilya);
            ilshat.AddSubordinate(vitya);
            ilshat.AddSubordinate(zenya);
            ivanych.AddSubordinate(ilya);
            ivanych.AddSubordinate(vitya);
            ivanych.AddSubordinate(zenya);
            sergey.AddSubordinate(lyaysan);
            sergey.AddSubordinate(marat);
            sergey.AddSubordinate(dina);
            sergey.AddSubordinate(anton);
            sergey.AddSubordinate(ildar);
            lyaysan.AddSubordinate(marat);
            lyaysan.AddSubordinate(dina);
            lyaysan.AddSubordinate(anton);
            lyaysan.AddSubordinate(ildar);

            Task task1 = new Task("Написать новый софт", Department.ItDevelopers);
            Task task2 = new Task("Починить сеть", Department.ItSystems);
            Task task3 = new Task("Посчитать налоги", Department.Management);

            task1.PrintInfo();
            task2.PrintInfo();
            task3.PrintInfo();

            sergey.GiveTask(task1, dina);
            ilshat.GiveTask(task2, ilya);
            timur.GiveTask(task1, dina);
            arkadi.GiveTask(task1, marat);
            volodya.GiveTask(task1, sergey);
            volodya.GiveTask(task2, sergey);
        }
    }
}
