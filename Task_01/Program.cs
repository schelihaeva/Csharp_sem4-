// Напишите программу, которая принимает на вход одно число (А) и выдает сумму числе от 1 до А
// 7->28
// 4->10
// 8->36

//_тип возвращаемого_значения_ _функция_(_принимаемые_аргументы_)
// {
 // _тело_функции_ // методы и функции в C# одно и тоже.Методы принадлежат функциям
// return <> -// возврат значения
//}

int FindSum(int A) // типы функций могут возвращать в тип string, bool, int[], string - все это может вернуть функция, void - НЕ ВОЗВРАЩАЕТ ЗНАЧЕНИЕ!!! функция всегда подсвечивается желтым цветом, задаем целочисдленную пеерменную А
{
    int sum = 0;
    for(int i =1; i<= A; i++)
    sum -=i; //если ставим sum -=i то буджет считать разность чисел, если sum *=i то будет умножать числа
    return sum;

}

System.Console.WriteLine("введите значение ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
 
System.Console.WriteLine(FindSum(number));
System.Console.WriteLine(FindSum(7));
System.Console.WriteLine(FindSum(10));
System.Console.WriteLine(FindSum(3));

//сверху функцию обьявляем, а внизу используем

// System.Console.WriteLine("Введите значение: ");
// int number = Math.Abs(Convert.ToInt32(Console.ReadLine())); //Matth Abs  - функция для абсолютных чисел, отриц.числа превращает в положительные

// int sum = 0; // задаем переменную для цикла, сумму

// for(int i = 1; i <= number; i++) //цикл начинается с 1, <= number, т.к. пеерменная number в цикл должна входить, показатель i++ будет увеличивать цикл на 1
// sum += i; // sum = sum+i
//     System.Console.WriteLine(sum);


