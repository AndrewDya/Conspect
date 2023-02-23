// Теория 1 (Работа с Git)
// git remote add origin https://github.com/AndrewDya/Conspect.git - Команды для выгрузки на удалённый репозиторий с ПК
// git branch -M master
// git push -u origin master; git push origin <branch> - branch имя ветки которую надо отправить
// git clone https://github.com/AndrewDya/Conspect.git - склонировать внешний репозиторий на ПК
// git remote set-url origin https://github.com/AndrewDya/Tasks-C-Sharp.git
// git pull - скачать всё из удалённого репозитория и merge
// git init - инициализация локального репозитория
// git status - состояние git
// git add ... - добавить файлы к следующему коммиту
// git commit -m "message" - создание коммита
// git log - вывод на экран истории всех коммитов
// git log --graph - вывод на экран истории всех коммитов в виде графа
// git checkout ... - переход от одного коммита к другому, переключиться
// git checkout master - вернуться к ветке master и продолжить
// git diff - увидеть разницу между текущим и закомиченным файлом
// git branch - просмотр имеющихся веток
// git brach -d ... - удаление ветки
// git merge ... - объединение двух веток (слияние с основной)
// - Pull request (предложение изменения кода в чужом репозитории):
// - Делаем fork репозитория
// - Делаем clone СВОЕЙ версии репозитория
// - Создаём новую ветку и в неё вносим свои изменения
// - Фиксируем изменения (делаем коммиты)
// - Отправляем свою версию в свой GitHub
// - На сайте GitHub нажимаем кнопку Pull request
// dotnet new console - создать новый проект
// dotnet run - запустить проект
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine()); 
// ctrl + c прекратить выполнение программы

// Теория 2 (Операции)
// || Условный оператор ИЛИ (хотя бы одно из условий должно выполняться); && Условный оператор И (оба условия должны выполняться); ! логическое отрицание
// & оператор И (Оператор & вычисляет оба операнда); | оператор ИЛИ (Оператор | вычисляет оба операнда)
// int a = new Random().Next(1,3); генерация случайного числа от 1 до 3
// for (int i = 0; i < 10; i++) - цикл с условием; где i++ инкримент эквивалентный i = i + 1
// Console.WtiteLine(Math.Abs(a)) модуль a
// Console.WtiteLine(Math.Round(a, 2)) округление a до 2 знаков после запятой
// Math.Sqrt(x); квадратный корень х
// Math.Pow(x, 3); возведение в х степень 3
// % отстаток от деления: Например 11 % 2 == 1

// Одномерные Массивы
// string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" }; - массив строк название weekDays с элементами {} без указания длины
// int[] array1 = new int[] { 1, 3, 5, 7, 9 }; - массив числовой название array1 с элементами {} без указания длины
// int[] array = new int[5] - оператор new создаёт одномерный массив и указывается тип (int) и число (5) элементов
// for (int i = 0; i < array.Length; i++) - цикл с перебором числа элементов
// Console.WriteLine(array.Length); - вывод длины массива array
// Console.WriteLine(weekDays[6]); - вывод шестого элемента массива weekDays
// Пример вывода элементов массива через цикл foreach (обрабатывает элементы в порядке возрастания индекса, начиная с индекса 0 и заканчивая индексом Length - 1:), 
// где i - может быть любым другим названием
// int[] array1 = new int[] { 1, 3, 5, 7, 9 };
// foreach (int i in array1)
// {Console.Write($"{i} ");}

// Оператор break завершает выполнение ближайшего оператора
// int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
// foreach (int number in numbers)
// {
//     if (number == 3)
//     {break;}
//     Console.Write($"{number} ");
// }
// Console.WriteLine();
// Console.WriteLine("End of the example.");

// Двумерные Массивы
// string[,] table = new string[2,3] - [,] - двумерный массив типа string под названием table 2 строки и 3 столбца
// table[1,2] = "слово";
// int[,] array2 = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
// array2[2, 1] = 25; - присвоить значение 25 элементу массива array2 в строке 2 и столбце 1
// String.Empty - инициализация пустой строки
// Пример двумерного массива
// int[,] matrix = new int[3,4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for(int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
// Console.WriteLine();
// }

// Методы; функции
// метод (1) который ничего НЕ принимает, ничего НЕ возвращает
// void Method()
// {Console.WriteLine("Автор")} - {содержание метода}
// Method1() - вызов метода
// метод (2) который принимает, но НЕ возвращает
// метод (3) который ничего НЕ принимает, но возвращает
// метод (4) который принимает и возвращает

// Строки (из семинара)
// string s = "Hello World";
// string s1 = "Hello";
// string s2 = "World";
// int[] nums = {1, 2, 3, 4, 5};
// string s3 = s1 + " " + s2;
// string s4 = string.Concat(s1, s2);
// string s5 = string.Join(" ", nums);
// string s = "1, 2, 3, 4, 5, 6, 7";
// foreach (var item in s)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine(s5);
// string s = "1, 2, 3, 4, 5, 6, 7.";
// string[] nums = s.Split(new char[]{' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries);
// int[] n = nums.Select(Int32.Parse).ToArray();
// foreach (var item in nums)
// {
//     Console.WriteLine(item);
// }
// string s1 = "10 21 35 45 57 68 79";
// int[] num1 = Array.ConvertAll(s1.Split(), int.Parse);

// Лекция. Рекурсия - функция, вызывающая саму себя
// При описании рекурсии важно задавать условие выхода
// Факториал
// double Factorial(int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n-1);
// }
// for (int i = 1; i < 40; i++)
// {
// Console.WriteLine($"{i}! = {Factorial(i)}");
// }

// Числа Фибоначи
// double Fibonacci(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// for (int i = 1; i < 20; i++)
// {
//     Console.WriteLine($"f({i}) = {Fibonacci(i)}");
// }

// Сумма чисел от 1 до n
// int SumRec(int n)
// {
//     if (n == 0) return 0;
//     else return n + SumRec (n - 1);
// }
// Console.WriteLine(SumRec(3));