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

int ReadInt(string text)  //функция будет внутрь себя принимать некторый текст
{
    System.Console.WriteLine(text);  //будем выводить текст
    return Convert.ToInt32(Console.ReadLine()); //примаем какой то результат/переменную,
    //возвращаем результат/переменную
}

int number = ReadInt("введите число ");
System.Console.WriteLine(FindLen(number));
