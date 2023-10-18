// Запишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке [1,0,1,1,0,1,0,0]
// 1 способ решения
// int[] array = new int[8];
// Random rand = new Random();


// for(int i=0; i<array.Length; i++)
// {
//     array[i] = rand.Next(0,2);
// }


// for(int i = 0; i < array.Length; i++)
// {
//     System.Console.WriteLine(array[i] + " ");
// }
 //2 вариант

 void FillArray (int[] arrayToFill)
 {
    Random rand = new Random();
    for (int i = 0; i < arrayToFill.Length; i++)
    {
        arrayToFill[i] = rand.Next(0,2);
    }
 }
 int[] array = new int[0];

FillArray(array);

for(int i = 0; i < array.Length; i++)
 {
     System.Console.WriteLine(array[i] + " ");
}