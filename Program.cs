// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.Write("Введите первое число: ");
//         int number1 = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Введите второе число: ");
//         int number2 = Convert.ToInt32(Console.ReadLine());

//         if (number1 > number2)
//         {
//             Console.WriteLine("Первое число больше второго");
//         }
//         else if (number1 < number2)
//         {
//             Console.WriteLine("Первое число меньше второго");
//         }
//         else
//         {
//             Console.WriteLine("Числа равны");
//         }
//     }
// }



// Console.Write("Введите первое число: ");
//         int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
//         int number2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
//         int number3 = Convert.ToInt32(Console.ReadLine());
//     int max=number1;

// if (number2>max)max=number2;
// if (number3>max)max=number3;
// Console.WriteLine("Максимальное число " +max);



Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.Read());
if (a % 2 == 0) Console.WriteLine("Число четное");
else Console.WriteLine("Число нечетное");
