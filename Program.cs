// Итоговая проверочная работа
// Задача: написать программу, которая из исходного массива строк сформирует массив из строк, длина которых меньше либо равна 3 символам.
// Шаг 1: вводим массив arrayOfString с клавиатуры
// Шаг 2: выводим красиво получившийся массив на экран
// Шаг 3: ищем количество элементов массива arrayOfString, длина которых соответствует условию задачи (count)
// Шаг 4: создаем новый массив arrayOfString1, размер которого равен переменной count
// Шаг 5: создаем метод, который будет заполнять новый массив arrayOfString1 только подходящими нам элементами (длина строки меньше либо равна 3 символам)
// Шаг 6: Выводим массив arrayOfString1 на экран

void NewArray (string[] arrayOfString, string[] arrayOfString1)
{
    int j = 0;
    for (int i = 0; i < arrayOfString.Length; i++)
        {
            int b = arrayOfString[i].Length;
            if (b <= 3)
            {
                arrayOfString1[j] = arrayOfString[i];
                j++;
            }
        }
Console.WriteLine("Итоговый массив: ");
Console.WriteLine($"[{string.Join(", ", arrayOfString1)}]");
}

Console.Clear();
Console.WriteLine("Введите данные через пробел: ");
string[] arrayOfString = Console.ReadLine().Split(" ");
Console.WriteLine("Первоначальный массив: ");
Console.WriteLine($"[{string.Join(", ", arrayOfString)}]");
int count = 0;
for (int i = 0; i < arrayOfString.Length; i++)
    {
        int b = arrayOfString[i].Length;
        if (b <= 3)
        {
            count ++;
        }
    }
string[] arrayOfString1 = new string[count];
NewArray (arrayOfString, arrayOfString1);