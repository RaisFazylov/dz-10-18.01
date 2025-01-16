﻿using System;
using System.Collections.Generic;
namespace EventsSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Задача 1.
            Студентам периодически необходимо участвовать в различных мероприятиях (студенты
            могут быть в разных группах).
            Участвовать каждый студент во всех мероприятиях не должен. Однако существуют
            студенты-халявщики, которые не хотят делать вообще ничего. Поэтому было решено, что
            человек, не участвовавший ни в одном из последних трех мероприятий с большей
            вероятностью будет выбран в качестве участника.
            Необходимо создать программу, которая будет из текстового файла считывать всех студентов
            и их принадлежность к группе. Далее пользователь создает мероприятие с необходимым
            количеством участников, оно записывается в специально созданный файл. Далее дозаписать
            в файл с мероприятием всех участников мероприятия. */
            EventManager eventManager = new EventManager();
            eventManager.LoadStudents("students.txt"); // Путь к файлу со студенти
            Console.WriteLine("Создание мероприятия");
            eventManager.CreateEvent("Театральная постановка", new DateTime(2022, 11, 30), 3);

            /* Задача 2.
            У каждого есть хобби. Написать программу для слежения за интересующим вас событием
            (выход сериала, концерт и т.д.)
            Создать не менее трех человек с разными увлечениями. Пользователь вводит (можно из
            заранее определенного списка) событие. Если событие совпало с увлечением кого-либо,
            вывести его реакцию на событие.*/
            var people = new List<Person>
            {
                new Person("Александр", new List<string> { "концерт", "выставка" }),
                new Person("Мария", new List<string> { "выход сериала", "фильм" }),
                new Person("Иван", new List<string> { "путешествия", "книги" })
            };

            EventNotifier notifier = new EventNotifier(people);

            Console.WriteLine("Введите событие:");
            string eventName = Console.ReadLine();

            notifier.Notify(eventName);
        }
    }
}
