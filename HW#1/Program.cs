/*
Нарисовать блок-схему алгоритма программы, которая из имеющегося массива строк формирует
массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться колекциями, лучше обойтись исключительно массивами
*/

Console.Clear();
string[] arrayFirst = {"Type", "5", "Badge_ID", "cost", "-25", "timeSheet", ":)", "company"};
int arrayFirstLength = arrayFirst.Length;
Console.Write("[" + string.Join(", ", arrayFirst) + "]");

int randomJ = new Random().Next(0, 4);
string[] arraySecond = new string[randomJ];

for (int i = 0; i < arraySecond.Length; i++)
{
    int randomN = new Random().Next(0, arrayFirstLength);
    arraySecond[i] = arrayFirst[randomN];
}

Console.Write(" -> " + "[" + string.Join(", ", arraySecond) + "]");
Console.ReadKey();

