using System;

namespace DisciplineList
{
    class Program
    {
        enum Disciplines
        {
            // загальноосвітні дисципліни
            IноземнаМоваЗаПрофесiйнимСпрямуванням = 1,
            Фiлософiя,
            Правознавство,

            // обов'язкові професійні дисципліни
            ВищаМатематика,
            ОсновиПрограмування,
            IнформацiйнiТехнологiїВПрофесiйнiйДiяльностi,

            // дисципліни за вибором студента
            КомпютернаГрафiкаТаВiзуалiзацiяДаних,
            ОсновиКiбербезпеки,
            АрхiтектураКомпютера
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Перелiк дисциплiн:");

            Console.WriteLine($"{(int)Disciplines.IноземнаМоваЗаПрофесiйнимСпрямуванням} - Iноземна мова за професiйним спрямуванням");
            Console.WriteLine($"{(int)Disciplines.Фiлософiя} - Фiлософiя");
            Console.WriteLine($"{(int)Disciplines.Правознавство} - Правознавство");
            Console.WriteLine($"{(int)Disciplines.ВищаМатематика} - Вища математика");
            Console.WriteLine($"{(int)Disciplines.ОсновиПрограмування} - Основи програмування");
            Console.WriteLine($"{(int)Disciplines.IнформацiйнiТехнологiїВПрофесiйнiйДiяльностi} - Iнформацiйнi технологiї в професiйнiй дiяльностi");
            Console.WriteLine($"{(int)Disciplines.КомпютернаГрафiкаТаВiзуалiзацiяДаних} - Комп'ютерна графiка та вiзуалiзацiя даних");
            Console.WriteLine($"{(int)Disciplines.ОсновиКiбербезпеки} - Основи кiбербезпеки");
            Console.WriteLine($"{(int)Disciplines.АрхiтектураКомпютера} - Архiтектура комп'ютера");

            Console.Write("\nВведiть номери дисциплiн, якi ви хочете вивчати (вiдокремлюйте номери комами): ");

            string input = Console.ReadLine();

            string[] inputArray = input.Split(',');

            Console.WriteLine($"Ви хочете вивчати наступнi дисциплiни:");

            foreach (string s in inputArray)
            {
                if (Enum.TryParse(s, out Disciplines discipline))
                {
                    Console.WriteLine($"{s} - {discipline}");
                }
                else
                {
                    Console.WriteLine($"Invalid input: {s}");
                }
            }

            Console.WriteLine("\nАвтор: Березан");
            Console.WriteLine("\nПерелiк дисциплiн за циклами:");

            Console.WriteLine("\nЗагальноосвiтнi дисциплiни:");
            Console.WriteLine($"{(int)Disciplines.IноземнаМоваЗаПрофесiйнимСпрямуванням} - Iноземна мова за професiйним спрямуванням");
            Console.WriteLine($"{(int)Disciplines.Фiлософiя} - Фiлософiя");
            Console.WriteLine($"{(int)Disciplines.Правознавство} - Правознавство");

            Console.WriteLine("\nОбов’язковi професiйнi дисциплiни:");
            Console.WriteLine($"{(int)Disciplines.ВищаМатематика} - Вища математика");
            Console.WriteLine($"{(int)Disciplines.ОсновиПрограмування} - Основи програмування");
            Console.WriteLine($"{(int)Disciplines.IнформацiйнiТехнологiїВПрофесiйнiйДiяльностi} - Iнформацiйнi технологiї в професiйнiй дiяльностi");

            Console.WriteLine("\nДисциплiни за вибором студента:");
            Console.WriteLine($"{(int)Disciplines.КомпютернаГрафiкаТаВiзуалiзацiяДаних} - Комп'ютерна графiка та вiзуалiзацiя даних");
            Console.WriteLine($"{(int)Disciplines.ОсновиКiбербезпеки} - Основи кiбербезпеки");
            Console.WriteLine($"{(int)Disciplines.АрхiтектураКомпютера} - Архiтектура комп'ютера");

            Console.ReadKey();
        }
    }
}
