// напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N
// 4 -> 24
// 5 ->120

int num (String N)
{
    System.Console.WriteLine(N);
    return Convert.ToInt32(Console.ReadLine());
}
int Result(int N)
{
int mult = 1;
for(int i = 2; i <=N; i++)
{
   mult *= i; // res*1, res*2  и т.д.до N
}
return mult;
}
//.................
int number = num ("введите число ");
System.Console.WriteLine(Result(number));
