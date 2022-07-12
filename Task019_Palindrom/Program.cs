// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

string fiveDigitNumber = InputDigit("Введите пятизначное число: ");

if (fiveDigitNumber.Length == 5)
{
    CheckNumber(fiveDigitNumber);
}
else
{
    Console.WriteLine("Вы ввели неверное число. Попробуйте еще раз!");
}

string InputDigit(string output)
{
    Console.Write(output);
    string number = Console.ReadLine();
    return number;
}

void CheckNumber(string number)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"Введенное вами число '{number}' является палиндромом");
    }
    else
        Console.WriteLine($"Введенное вами число '{number}' не является палиндромом");
}
