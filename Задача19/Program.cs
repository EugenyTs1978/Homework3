/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.*/

string Palindrom(int Number)
{
    if ((Number / 10000 == Number % 10) && (Number / 1000 %10 == Number / 10 % 10))
    {
        return "да";
    }
    else
    {
        return "нет";
    }
}
int getNumberFromUser(string userInformation)
{
    int result = 0;
    while(result == 0 || result/10000 == 0 || result/10000 > 9)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if(result == 0 || result/10000 == 0 || result/10000 > 9)
        {
            Console.WriteLine("Некорректное значение");
        }
        else
        {
            break;
        }
    }
    return result;
}
int getNumber = getNumberFromUser("Введите пятизначное число: ");
Console.WriteLine(Palindrom(getNumber));
