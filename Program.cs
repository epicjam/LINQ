// See https://aka.ms/new-console-template for more information
using System.Linq;
using System;
using System.Collections;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, Teacher!");
        Console.WriteLine();
        Console.WriteLine();


        //TASK 1: Найти все строки в списке строк, которые состоят только из цифр => "123", "456".
        Console.WriteLine("TASK 1: Найти все строки в списке строк, которые состоят только из цифр.");

        List<string> strings = new List<string> { "123", "2D4", "456", "ABC" };
        string s1 = "123";
        string s2 = "456";
        var numberline = strings.Where(x => x.Contains(s1) || x.Contains(s2));

        foreach (var s in numberline)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine();
        Console.WriteLine();

        //TASK 2: Найти максимальное и минимальное значение в числовом списке только с положительными числами => max = 10, min = 4.
        Console.WriteLine("TASK 2: Найти максимальное и минимальное значение в числовом списке только с положительными числами => max = 10, min = 4.");

        List<int> numbers = new List<int> { -2, 4, -6, 8, 10, -12 };
        var min = numbers.Where(n => n > 0).Min(n => n);
        var max = numbers.Where(n => n > 0).Max(n => n);

        Console.WriteLine(min);
        Console.WriteLine(max);

        Console.WriteLine();
        Console.WriteLine();

        //TASK 3: Найти наиболее часто встречающееся слово в списке строк.
        Console.WriteLine("TASK 3: Найти наиболее часто встречающееся слово в списке строк.");

        List<string> arrayList = new List<string>() { "машина", "холм", "дом", "небо", "белый", "дом", "борт" };

        var wordfrequent = arrayList.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;

        foreach (var s in wordfrequent)
        {
            Console.Write(s);
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();


        //TASK 4: Отсортировать список строк по длине в порядке убывания, а затем по алфавиту для строк одинаковой длины.
        //Подсказка: после сортировки использовать ThenBy(OrderBy(...).ThenBy(...)).
        Console.WriteLine("TASK 4: Отсортировать список строк по длине в порядке убывания, а затем по алфавиту для строк одинаковой длины.");

        var wordfrequentt = arrayList.OrderByDescending(x => x.Length).ThenBy(x => x).ThenBy(x => x.Length == 4);

        foreach (var s in wordfrequentt)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine();
        Console.WriteLine();


        //TASK 5: Найти разницу в днях между самым ранним и самым поздним днем в списке дат. Подсказка: можно использовать Substract(...).
        Console.WriteLine("TASK 5: Найти разницу в днях между самым ранним и самым поздним днем в списке дат.");

        List<DateTime> dates = new List<DateTime> { new DateTime(2022, 1, 1), new DateTime(2022, 3, 15), new DateTime(2022, 2, 10) };

        TimeSpan dayDifference = dates.ElementAt(1).Subtract(dates.ElementAt(2));
        Console.WriteLine($"Разница в днях: {dayDifference}");
        Console.WriteLine();
        Console.WriteLine();


        //TASK 6: Найти все пары чисел в списке, сумма которых равна заданному числу. Заданное число к примеру 7.
        Console.WriteLine("TASK 6: Найти все пары чисел в списке, сумма которых равна заданному числу. Заданное число к примеру 7.");

        var list = new List<int>() { 1, 2, 3, 4, 5 };
        int targetNum = 7;

        List<Tuple<int, int>> pairs = list
            .SelectMany((element, index) =>
            {
                return list
                .Skip(index + 1)
                .Select(element2 =>
                {
                    return Tuple.Create(element, element2);
                })
                .Where(tuple => tuple.Item1 + tuple.Item2 == targetNum);
            }).ToList();

        foreach (var pair in pairs)
        {
            Console.WriteLine($"({pair.Item1}, {pair.Item2})");
        }
        Console.WriteLine();
        Console.WriteLine();


        //TASK 7: Посчитать количество уникальных слов в списке строк, игнорируя регистр.
        Console.WriteLine("TASK 7: Посчитать количество уникальных слов в списке строк, игнорируя регистр.");
        Console.WriteLine();

        List<string> arrayList2 = new List<string>() { "дом", "дом", "дом", "Небо", "дом", "дом", "борт" };

        var uniqueword = arrayList2.GroupBy(k => k).Distinct().Count();
        Console.WriteLine($"Всего уникальных слов: { uniqueword }");
        Console.WriteLine();

        var uniqueWord = arrayList2.GroupBy(k => k);
        foreach (var value in uniqueWord)
        {
            Console.WriteLine("{0} --> {1}", value.Key, value.Distinct().Count());
        }
        Console.WriteLine();
        Console.WriteLine();

        //TASK 8: Получить список всех чисел от 1 до 100, которые являются квадратами другого числа.
        //Использовать Enumerable.Range(1, 100). Задает список чисел от 1 до 100. 
        //К пример результатом будет 6 => 36 (6 является квадратом 36). Также стоит использовать Any().
        Console.WriteLine("TASK 8: Получить список всех чисел от 1 до 100, которые являются квадратами другого числа.");
        Console.WriteLine();
        IEnumerable<int> range = Enumerable.Range(1, 100);
        var squares = range.Select(x => x * x);
        var i = 0;

        foreach (int num in squares)
        {
            i++;
            Console.WriteLine($"{i} => {num}");
        }
        Console.WriteLine();
        Console.WriteLine();


        //TASK 9: Найти все строки в списке, которые содержат все гласные буквы.
        Console.WriteLine("TASK 9: Найти все строки в списке, которые содержат все гласные буквы.");
        Console.WriteLine();

        List<string> strings1 = new List<string> { "ааа", "ттт", "упиу", "оеоеццц" };

        var vowels = strings1.Except(strings1.Where(s => s.Contains("б") || s.Contains("в") || s.Contains("г") || s.Contains("д") ||
        s.Contains("ж") || s.Contains("з") || s.Contains("к") || s.Contains("л") || s.Contains("м") || s.Contains("н") || s.Contains("п") ||
        s.Contains("р") || s.Contains("с") || s.Contains("т") || s.Contains("ф") || s.Contains("х") || s.Contains("ц"))).ToList();

        foreach (var str in vowels)
        {
            Console.WriteLine(str);
        }
        Console.WriteLine();
        Console.WriteLine();


        //TASK 10: Получить список уникальных символов из заданной строки. (Без дубликатов, пример раpбирали на занятии).
        Console.WriteLine("TASK 10: Получить список уникальных символов из заданной строки.");
        Console.WriteLine();

        //List<string> strings2 = new List<string> { "***fv;alva'psovj" };
        string strings2 = "***fv;alva'psovj";
        var uniqueSymbol = strings2.ToCharArray().Distinct().ToArray();
        var target = new string(uniqueSymbol);

        Console.Write(uniqueSymbol);
        Console.WriteLine();
        Console.WriteLine();


        //TASK 11: Выполнить соединение (Join()) двух коллекций на основе общего свойства и выбрать определенные поля из каждой коллекции.
        Console.WriteLine("TASK 11: Выполнить соединение (Join()) двух коллекций на основе общего свойства и выбрать определенные поля из каждой коллекции.");
        Console.WriteLine();

        List<Person> persons = new List<Person>
        {
            new Person { Id = 1, Name = "John" },
            new Person { Id = 2, Name = "Jane" },
        };

        List<Address> addresses = new List<Address>
        {
            new Address { PersonId = 1, City = "New York" },
            new Address { PersonId = 2, City = "London" },
        };

        Console.WriteLine("Соединенные данные из двух коллекций:");
        var query = persons.Join(addresses, 
            p => p.Id,
            ad => ad.PersonId,
            (p, ad) => new { Name = p.Name, City = ad.City });

        foreach (var result in query)
        {
            Console.WriteLine($"{result.Name} - {result.City}");
        }
    }
}

class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Address
{
    public int PersonId { get; set; }
    public string City { get; set; }
}