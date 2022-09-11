// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear ();

Console.Write ("Введите число ");
int A = int.Parse (Console.ReadLine());

Console.Write ("Введите число ");
int B = int.Parse (Console.ReadLine());

Console.Write ("Введите число ");
int C = int.Parse (Console.ReadLine());

Console.Write ("Введите число ");
int D = int.Parse (Console.ReadLine());

Console.Write ("Введите число ");
int E = int.Parse (Console.ReadLine());

Console.Write ("Введите число ");
int I = int.Parse (Console.ReadLine());

int[] array = new int[6] { A, B, C, D, E, I };

Console.WriteLine("Новый массив: ");
Console.WriteLine(String.Join(" ", array));
int result = 0;
for (int i = 0; i<array.Length; i++)
{
     if(array[i] > 0 ) result ++; 
}
Console.WriteLine(result);