// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int Cube(int number)
{
     return number * number * number;
}

int numberN = InputInt("Введите число N: ");
int min = 1;

while (min <= numberN)
{
    if(min < numberN)
    {
        int table = Cube(min);
        Console.Write(table + ", ");
    }
    else if(min == numberN)
    {
        int table = Cube(min);
        Console.Write(table + " ");  
    }
min++;    
}
