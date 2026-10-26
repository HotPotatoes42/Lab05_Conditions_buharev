// using System.Diagnostics;
// using System.Net.ServerSentEvents;
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// if (number > 0) {
//     Console.WriteLine("Число положительное.");
// }
// else if (number < 0) {
//     Console.WriteLine("Число отрицательное.");
// }
// else {
//     Console.WriteLine("Число равно нулю.");
// }

// Console.Write("Введите балл (0-100): ");
// int score = int.Parse(Console.ReadLine());

// if (score >= 91) {
//     Console.WriteLine("Оценка: Отлично (5)");
// }
// else if (score >= 71) {
//     Console.WriteLine("Оценка: Хорошо (4)");
// }
// else if (score >= 51) {
//     Console.WriteLine("Оценка: Удовлетворительно (3)");
// }
// else {
//     Console.WriteLine("Оценка: Неудовлетворительно (2)");
// }

// Console.Write("Введите количество посещений (из 19): ");
// int attendance = int.Parse(Console.ReadLine());

// Console.Write("Введите средний балл по практике: ");
// double practiceGpa = double.Parse(Console.ReadLine());

// bool goodAttendance = attendance >= 14; // посещаемость >= 75%
// bool goodGrades = practiceGpa >= 3.0;   // оценка не ниже 3

// if (goodAttendance && goodGrades) {
//     Console.WriteLine("+ Допуск к экзамену разрешён.");
// }
// else if (!goodAttendance && goodGrades) {
//     Console.WriteLine("- Недостаточно посещений. Нужно отработать пропуски.");
// }
// else if (goodAttendance && !goodGrades) {
//     Console.WriteLine("- Низкий балл по практике. Нужно пересдать работы.");
// }
// else {
//     Console.WriteLine("- Проблемы и с посещаемостью, и с оценками. Срочно к преподавателю.");
// }

// string result1;
// if (StringComparer >= 60)
//     result1 = "Зачёт";
// else
//     result1 = "Незачёт";

// string result2 = StringComparer >= 60 ? "Зачёт" : "Незачёт";

// Console.Write("Введите ваш возраст: ");
// int age = int.Parse(Console.ReadLine());
// string ageGroup = age >= 18 ? "совершеннолетний" : "несовершеннолетний";
// Console.WriteLine($"Вы {ageGroup}.");

// Console.Write("\nВведите температуру за окном (°C): ");
// double temp = double.Parse(Console.ReadLine());
// string weather = temp >= 20 ? "тепло" : (temp >= 0 ? "прохладно" : "мороз");
// Console.WriteLine($"За окном {weather}.");

// Console.Write("\nВведите число:");
// int n = int.Parse(Console.ReadLine());
// string parity = n % 2 == 0 ? "чётное" : "нечётное";
// Console.WriteLine($"Число {n} - {parity}.");

// if (day == 1) Console.WriteLine("Понедельник");
// else if (day == 2) Console.WriteLine("Вторник");
// else if (day == 3) Console.WriteLine("Среда");

// switch (day)
// {
//     case 1: Console.WriteLine("Понедельник"); break;
//     case 2: Console.WriteLine("Вторник"); break;
//     case 3: Console.WriteLine("Среда"); break;
//     default: Console.WriteLine("Неизвестный день"); break;
//}

// Console.WriteLine("Меню");
// Console.WriteLine("1. Посмотреть расписание");
// Console.WriteLine("2. Посмотреть оценки");
// Console.WriteLine("3. Связаться с преподавателем");
// Console.WriteLine("4. Выйти");
// Console.Write("Выберите пункт (1-4): ");

// string choice = Console.ReadLine();

// switch (choice) {
//     case "1":
//         Console.WriteLine("Расписание: ИСП-244, каб. 102, 08:30");
//         break;
//     case "2":
//         Console.WriteLine("Ваши оценки: ИРСПО - 20, РМП - 35,");
//         break;
//     case "3":
//         Console.WriteLine("Email: denis.leontev92@yandex.ru");
//         break;
//     case "4":
//         Console.WriteLine("До свидания!");
//         break;
//     default:
//         Console.WriteLine($"Ошибка: пункт «{choice}» не существует. Введите число от 1 до 4.");
//         break;
// }

// Console.Write("\nВведите номер дня недели (1-7): ");
// int dayNumber = int.Parse(Console.ReadLine());

// switch (dayNumber) {
//     case 1:
//     case 2:
//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("Рабочий день — пора учиться!");
//         break;
//     case 6:
//     case 7:
//         Console.WriteLine("Выходной — заслуженный отдых.");
//         break;
//     default:
//         Console.WriteLine("Такого дня не существует.");
//         break;
// }

// for (int i = 0; i <= 12; i++)
// {
// Console.Write("\nВведите номер дня недели (1-7): ");
//     int MNumber = i;

//     switch (MNumber)
//     {
//         case 1:
//         case 2:
//         case 12:
//             Console.WriteLine("Зима");
//             break;
//         case 3:
//         case 4:
//         case 5:
//             Console.WriteLine("Весна");
//             break;
//         case 6:
//         case 7:
//         case 8:
//             Console.WriteLine("Лето");
//             break;
//         case 9:
//         case 10:
//         case 11:
//             Console.WriteLine("Осень");
//             break;
//         default:
//             Console.WriteLine("Такого дня не существует.");
//             break;
//     }
// }

// Random random = new Random();
// int secret = random.Next(1, 101);

// int attempts = 0;
// bool guessed = false;

// Console.WriteLine("Угадай число (1-100)");
// Console.WriteLine("Я загадал число. Попробуй угадать!");

// while (!guessed)
// {
//     Console.Write($"попытка {attempts + 1}. Твой вариант:");
//     string input = Console.ReadLine();
//     if (!int.TryParse(input, out int guess))
//     {
//         Console.WriteLine("!!! Введите целое число, а не текст");
//         continue;
//     }
//     if (guess < 1 || guess > 100)
//     {
//         Console.WriteLine("!!! Число должно быть от 1 до 100!");
//         continue;
//     }
//     attempts++;
//     if (guess < secret)
//     {
//         // Подсказка «горячо/тепло/холодно» через switch
//         int diff = secret - guess;
//         string hint = GetHint(diff);
//         Console.WriteLine($"↑ Больше! {hint}\n");
//     }
//     else if (guess > secret)
//     {
//         int diff = guess - secret;
//         string hint = GetHint(diff);
//         Console.WriteLine($"↓ Меньше! {hint}\n");
//     }
//     else
//     {
//         guessed = true; // угадал!
//     }
// }

// string result = attempts <= 7
//     ? $"Отличный результат! Всего {attempts} попыток."
//     : $"Число найдено за {attempts} попыток. Можно лучше!";

// Console.WriteLine($"🎉 Правильно! Загаданное число: {secret}");
// Console.WriteLine($"{result}");


// string GetHint(int difference)
// {
//     switch (difference)
//     {
//         case <= 3:
//             return "� Горячо!";
//         case <= 10:
//             return "� Тепло.";
//         case <= 25:
//             return "� Прохладно.";
//         default:
//             return "❄ Холодно!";
//     }
// }

// // 1 задание
// string password = Console.ReadLine();
// string confirmPassword = Console.ReadLine();

// // Проверяем их на совпадение
// if (password == confirmPassword)
// {
//     Console.WriteLine("Пароль принят");
// }
// else
// {
//     Console.WriteLine("Пароль не принят");
// }
// // 2
// Console.WriteLine("Возраст");
// int age = int.Parse(Console.ReadLine());
// if (age >= 18)
// {
//     Console.WriteLine("Разрешён");
// }
// else
// {
//     Console.WriteLine("Запрещён");
// }
// // 3
// Console.WriteLine("число a");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("число b");
// int b = int.Parse(Console.ReadLine());
// Console.WriteLine("Знак");
// int itog = 0;
// string znak = Console.ReadLine();

// if (znak == "+")
// {
//     itog = a + b;
// }
// else if (znak == "-")
// {
//     itog = a - b;
// }
// else if (znak == "*")
// {
//     itog = a * b;
// }
// else if (znak == "/")
// {
//     itog = a / b;
// }
// Console.WriteLine(itog);
// // 4
// int count = 0;
// for (int i = 0; i < 3; i++)
// {
//     int number = int.Parse(Console.ReadLine());
//     if (number > 0)
//     {
//         count += 1;
//     }
// }
// Console.WriteLine("Кол-во положительных чисел:");
// Console.WriteLine(count);
// // 5

string drakon = "Кто не дышит, но живёт; хоть не нужно — много пьёт; и в жизни, и в смерти тело как лёд.";
Console.WriteLine("1) Путь A: Войти в комнату с драконом");
Console.WriteLine("2) Путь B: Пойти по тёмному коридору");
int stroka = int.Parse(Console.ReadLine());
if (stroka == 1) {
    // Thread.Sleep(500);
    Console.Write("Дракон говорит: ");
    for (int i = 0; i < drakon.Length;i++)
    {
        Thread.Sleep(50);
        Console.Write(drakon[i]);
    }
    Console.ReadLine();
    string answer = Console.ReadLine();
    if (answer == "рыба")
    {
        Console.WriteLine("Дракон говорит: Проходи");
    }
    else
    {
        Console.WriteLine("Дракон говорит: Тебе конец");
    }
}
else if (stroka == 2) {
    Console.WriteLine("На вашем пути 2 двери, в какую вы войдёте?");
    Console.WriteLine("1) Дверь 1");
    Console.WriteLine("2) Дверь 2");
    int answer = int.Parse(Console.ReadLine());
    if (answer == 1)
    {
        Console.WriteLine("За ней скрыты сокровища Dungeon Master’а.");
    }
    else if (answer == 2)
    {
        Console.WriteLine("За ней — ловушка с ядовитыми шипами.");
    }
}