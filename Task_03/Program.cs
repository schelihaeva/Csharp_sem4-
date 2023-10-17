// напишите программу, которая принимает на вход число и выдает количество цифр в числе
// 456->3
// 78->2
// 89126->5
// break -оператор, кторый завершает близлежащий цикл, return-оператор , кторый завершает функцию вцелом

// 1 способ строковый
// string? strNumber = Console.ReadLine(); // принимаем значение в строку,спомощью ? можем выводить пустую строку и будет писать 0
// System.Console.WriteLine(strNumber?.lenght); // выводим значение lenght 

//2способ, если нам дается переменная
// int number = Convert.ToInt32(Console.ReadLine());
// string? strNumber = Convert.Tostring(number);
// System.Console.WriteLine(strNumber?.lenght);


//3 способ  с помощбю деления на 10 находим кол-во символов в числе
// System.Console.WriteLine("введите число ");
// int number = Convert.ToInt32(Console.ReadLine());
// int LenNumber = 0;

// while (number > 0)
// {
//     number /=10;
//     LenNumber++;
// }
// System.Console.WriteLine(LenNumber);

// 1234 / 10 -> 123 / 10 - > 12 /10 ->1 / 10- >0


//4 способ применяем функцию
 int FindLen(int N)
 {
   int Len = 0;
     while (N > 0)
   {
        N /=10;
        Len++;
     }
    return Len;  //возвращаем длинну
 }
System.Console.WriteLine("введите число ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(FindLen(number));