// найти полож.числ  с помощью return

System.Console.WriteLine("введите число ");
int number = Convert.ToInt32(Console.ReadLine());

   
//                                       // нам нужны положительные числа от 0 до 10
// //можно сделать через return вариант 1
 if(number <0 || number > 10) 
 {
 System.Console.WriteLine("no text");
 return;
 }
// // или так вариант2
//  if(number >=0 $$ <= 10)
//  {
//     System.Console.WriteLine("text");
//  }
//  else
 {
     System.Console.WriteLine("текст");
 }