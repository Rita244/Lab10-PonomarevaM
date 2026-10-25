// ### Шаг 2. Операции над строкой

// using System;

// namespace Lab10_P
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string text = "  Строки в C# неизменяемы  ";

//             Console.WriteLine($"1. Длина строки text: {text.Length}");

//             string clean = text.Trim();
//             Console.WriteLine($"2. Строка clean: '{clean}'");

//             Console.WriteLine($"3. Длина строки clean: {clean.Length}");

//             Console.WriteLine($"4. Первый символ: '{clean[0]}', последний символ: '{clean[clean.Length - 1]}'");

//             string upperClean = clean.ToUpper();
//             Console.WriteLine($"5. В верхнем регистре: '{upperClean}'");

//             bool containsUpper = clean.Contains("С#");
//             bool containsLower = clean.Contains("с#");
//             Console.WriteLine($"6. Содержит 'С#' (большая): {containsUpper}");
//             Console.WriteLine($"   Содержит 'с#' (маленькая): {containsLower}");

//             int position = clean.IndexOf("С#");
//             Console.WriteLine($"7. Позиция 'С#': {position}");

//             string replaced = clean.Replace("неизменяемы", "удобны");
//             Console.WriteLine($"8. С заменой: '{replaced}'");

//             upperClean = clean.ToUpper();
//             Console.WriteLine($"Шаг 3. clean.ToUpper(): '{upperClean}'");
//             Console.WriteLine($"Шаг 3. Исходная clean: '{clean}'");

//             // Строка clean НЕ изменилась. Метод ToUpper() не меняет исходную строку, 
//             // а возвращает новую строку в верхнем регистре. Мы сохранили её в переменную upperClean, 
//             // а переменная clean осталась прежней. Это доказывает неизменяемость строк в C#

//             Console.ReadLine();
//         }
//     }
// }


// ### Шаг 4. Substring

// using System;


// string date = "15.09.2025";

// string day = date.Substring(0, 2);
// string month = date.Substring(3, 2);
// string year = date.Substring(6, 4);

// Console.WriteLine($"День: {day}");
// Console.WriteLine($"Месяц: {month}");
// Console.WriteLine($"Год: {year}");



// ### Шаг 5. Split по запятой

// string line = "Иванов,25,Программист";
            
//             string[] parts = line.Split(',');
            
//             Console.WriteLine($"Количество частей: {parts.Length}");
            
//             for (int i = 0; i < parts.Length; i++)
//             {
//                 Console.WriteLine($"Индекс {i}: {parts[i]}");
//             }
            
//             Console.WriteLine($"{parts[0]}, {parts[1]} лет, {parts[2]}");


// ### Шаг 6. Split по пробелам

//             string sentence = "  Сегодня   хорошая   погода  ";

//             string[] splitNormal = sentence.Split(' ');
//             Console.WriteLine($"Length без RemoveEmptyEntries: {splitNormal.Length}");

//             string[] splitClean = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//             Console.WriteLine($"Length с RemoveEmptyEntries: {splitClean.Length}");

//             foreach (string word in splitClean)
//             {
//                 Console.WriteLine(word);
// }

// Метод Split возвращает массив строк (string[])
//  А массивы мы изучали в ПР9
//  Поэтому мы можем применять к результату все те же знания: 
//  считать длину через.Length, перебирать через foreach и обращаться по индексам


// ### Шаг 7. Проверки ввода

// string userInput = "";
// while (string.IsNullOrWhiteSpace(userInput))
// {
//     Console.Write("Введите строку: ");
//     userInput = Console.ReadLine();
// }

// string trimmedInput = userInput.Trim();

// bool hasCode = trimmedInput.Contains("код", StringComparison.OrdinalIgnoreCase);
// Console.WriteLine($"Содержит слово 'код': {(hasCode ? "да" : "нет")}");

// bool startsWithPrivet = trimmedInput.StartsWith("привет", StringComparison.OrdinalIgnoreCase);
// Console.WriteLine($"Начинается с 'привет': {(startsWithPrivet ? "да" : "нет")}");

// bool endsWithExclamation = trimmedInput.EndsWith("!");
// Console.WriteLine($"Заканчивается восклицательным знаком: {(endsWithExclamation ? "да" : "нет")}");


// ### Шаг 8. `+=` и StringBuilder

// using System.Text;
// string result = "";
// for(int i = 1; i <= 5; i++)
// {
//     result += i + " ";
// }


// StringBuilder sb = new();
// for(int i = 1; i <= 5; i++)
// {
//     sb.Append(i).Append(" ");
// }

// string[] students = ["Иван", "Анна", "Пётр"];
// StringBuilder report = new();
// report.AppendLine("=== ОТЧЁТ ===")
//      .AppendLine("Группа: 2ИС-1")
//      .AppendLine($"Студентов: {students.Length}");

// for(int i = 0; i < students.Length; i++)
// {
//     report.AppendLine($"{i+1}. {students[i]}");
// }


// ### Шаг 10. Таблица товаров


// string[] products = ["Хлеб", "Молоко", "Ноутбук"];
// double[] prices = [45, 89.5, 65999.99];

// Console.WriteLine("№   Товар               Цена");
// Console.WriteLine(new string('-', 28));

// for(int i = 0; i < products.Length; i++)
// {
//     Console.WriteLine($"{(i+1):D2}  {products[i],-15}{prices[i],10:N2}");
// }

// double percent = 0.256;
// int number = 255;

// Console.WriteLine($"{percent:P0}");
// Console.WriteLine($"{number:X}");

