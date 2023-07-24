// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

void printArray(int[] nums)                         // Функция вывода массива
{                                                   //
    int length = nums.Length;                       //
    for (int k = 0; k < length; k++)                //
    {                                               //
        Console.Write($"{nums[k]}; ");              //
    }                                               //
    Console.WriteLine();                            //
}                                                   //

int[] numbers = new int[10];
int length = numbers.Length;

int count = 0;
int num = 0;
int result = 0;

while (count < 10)
{
    Console.Write("Введите число: ");
    num = Convert.ToInt32(Console.ReadLine());
    numbers[count] = num;
    count++;
}

for (int i = 0; i < length; i++)
{
    if (numbers[i] > 0)
    {
        result++;
    }
}

printArray(numbers);
Console.WriteLine($"Количество положительных чисел: {result}");
