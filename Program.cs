// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.


// int InputIntNumber()
// {
//     while (true)
//     {
//         Console.Write("Ведите трёхзначное число: ");
//         int number = int.Parse(Console.ReadLine() ?? "0");
//         while (number > 99 && number < 1000)
//         return number;
//     }
// }
// int num = InputIntNumber();

// int frsNum = num / 100;
// int secNum = num / 10 % 10;
// int thrNum = num % 10;

// Console.WriteLine("Это цифра " + secNum);

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Console.Clear();
// int InputIntNumber()
// {
//     while (true)
//     {
//         try
//         {
//             Console.Write("Ведите целое число: ");
//             int number = int.Parse(Console.ReadLine() ?? "0");
//             return number;
//         }
//         catch
//         {
//             Console.WriteLine("Ошибка, введите целое число!");
//         }
//     }
// }

// int num = InputIntNumber();
// int length = num.ToString().Length;
// while (length > 3)
// {
//     num = num / 10;
//     length --;
// }

// int frsNum = num / 100;
// int secNum = num / 10 % 10;
// int thrNum = num % 10;

// if (frsNum == 0)
// {
//     if (secNum == 0)
//         Console.WriteLine("Второй и третьей цифры нет");
//     else
//         Console.WriteLine("Третьей цифры нет");
// }
// else
//     Console.WriteLine("Третья цифра заданного числа: " + thrNum);

// Напишите программу, которая принимает на вход цифру, обозначающую день 
// недели, и проверяет, является ли этот день выходным.


// int InputIntNumber()
// {
//     while (true)
//     {
//         try
//         {
//             Console.Write("Введите день недели: ");
//             int number = int.Parse(Console.ReadLine() ?? "0");
//             return number;
//         }
//         catch
//         {
//             Console.WriteLine("Ошибка, введите целое число!");
//         }
//     }
// }

// Day:
// int num = InputIntNumber();

// if(num <= 7 && num >= 1)
// {
//     Console.Write("Введенный день недели ");
//     if(num >= 6)
//         Console.Write("выходной! Ура!");
//     else
//         Console.Write("трудовые будни! Грусть.");
// }
// else
// {
//    Console.WriteLine("В неделе всего 7 дней, дружок-пирожок, а ты что написал?"); 
//    goto Day;    
// }