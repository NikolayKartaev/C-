//Заводим массив

Console.WriteLine("Введите количество элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());

int start = 5, end = 10;
double[] array = new double[n]; // задаем массив из вещественных числе, состоящий из n количества элементов

for (int i = 0; i < n; i++)
{
    array[i] = Math.Round(new Random().NextDouble() * (end - start) + start, 2); // .NextDouble() генерирует дробную часть от 0 до 1
    // * (end - start) + start; добавляет целую часть
    // 
}

Console.WriteLine($"Результат: [{string.Join(", ", array)}]"); // переводим в строку значение аргумента array
// и соединяем через разделитель, указанный в " "