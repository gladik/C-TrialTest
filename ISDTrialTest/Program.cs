using ISDTrialTest.Enum;
using ISDTrialTest.Events;
using System;
using System.Collections.Generic;

namespace ISDTrialTest
{
    class Program
    {
        static void Main()
        {
            var famililist = new List<Family>();

            //Создание семьи
            famililist.Add(new Parent("Папа", 55, Gender.Male));
            famililist.Add(new Parent("Мама", 50, Gender.Female));
            famililist.Add(new Children("Дочь", 25, Gender.Female));

            //Подписываем их действия на событие.
            var me = new FamilyAction();

            //Подписывание всей семьи на событие.
            foreach (var item in famililist)
            {
                me.Action += item.Work;
                me.Action += item.Move;
            }

            //Выполнение всей семье заранее заданых действий.
            me.DoAction();

            Console.ReadLine();
        }
    }
}
