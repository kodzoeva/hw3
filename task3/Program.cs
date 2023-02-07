// //Напишите программу, которая принимает на вход |
// пятизначное число и проверяет, является ли оно 
// палиндромом. Не используйте строки


Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Введеное число является палиндромом");
    }
    else
    {
        Console.WriteLine($"{number} - Введенное число не является палиндромом");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - введите пятизначное число");
}


