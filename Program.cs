 //  Задача 64: Написать рекурсивную функцию перевода из десятичной системы исчисления в
 //   двоичную. 

void Recurs(int n){
    int a = 0;
    if(n > 0){
          if(n%2 == 1) 
          n = n/2;
          a += 1;
        }
        Console.Write(a  + " ");
}

Console.Write("Enter your number: ");
int n = Convert.ToInt32(Console.ReadLine());
Recurs(n);



//   Задайте значения M и N. Напишите программу, которая найдёт
//  сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int CalculateSumm(int m, int n)
// 		{
// 			int start = m;
// 			int end = n;
// 			if(m > n)
// 			{
// 				start = n;
// 				end = m;
// 			}
// 			return (end + start)*(end - start + 1)/2; // по формуле суммы членов арифметической прогрессии
// 		}
// 		Console.Write("Enter your m number: ");
//         int m = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Enter your n number: ");
//         int n = Convert.ToInt32(Console.ReadLine());
// 		Console.WriteLine(CalculateSumm(m,n));