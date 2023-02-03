// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

int InputInt(string msg)
{
    System.Console.Write(msg + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

void InputNumbers(int[] array, int size)
{
    for (int i = 0; i < size; i++)
    {
        System.Console.Write($"Введите {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array, string msg)
{
    System.Console.Write(msg);
    for ( int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int Comparison(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0 )
        {
            count += 1;
        } 
    }
    return count;
}

int size = InputInt("Количество чисел, которык желаете ввести");
int[] array = new int[size];
InputNumbers(array, size);
PrintArray(array, "Введенные пользователем числа: ");
Console.WriteLine($"Введено чисел больше ноля > {Comparison(array)} ");