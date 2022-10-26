
using Dynamic;

using System.Dynamic;

//dynamic a;
//a = 2;
//a++;
//Console.WriteLine(a);

//a = "Hello world!!!";
//Console.WriteLine(a);
//a++;
//a.Member = 1;

//a = new SomeClass();
//a.Guutt = "Super gut!";
//Console.WriteLine(a.Guutt);


dynamic person = new ExpandoObject();
person.Name = "Tom";
person.Age = 46;
person.Languages = new List<string> { "english", "german", "french" };

Console.WriteLine($"{person.Name} - {person.Age}");
foreach (var lang in person.Languages)
    Console.WriteLine(lang);

// объявляем метод
person.IncrementAge = (Action<int>)(x => person.Age += x);
person.IncrementAge(6); // увеличиваем возраст на 6 лет
Console.WriteLine($"{person.Name} - {person.Age}");

