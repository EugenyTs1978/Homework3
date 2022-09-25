/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Hello, World!");*/
int[] Cube(int Number)
{
    int[] array = new int[Number];
    for(int index = 0; index < Number; index++)
    {
        array[index] = Convert.ToInt32(Math.Pow(index + 1,3));
    }
    return array;
}
int getNumberFromUser(string userInformation)
{
    int result = 0;
    while(result < 1) 
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if(result < 1)
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
int userNumber = getNumberFromUser("Введите целое положительное число: ");
foreach(int element in Cube(userNumber))
{
    Console.WriteLine(element);
}
