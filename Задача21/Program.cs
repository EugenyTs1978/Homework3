/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.*/
double Length3D(int CoordinateX_1,int CoordinateY_1,int CoordinateZ_1,
                int CoordinateX_2,int CoordinateY_2,int CoordinateZ_2)
{
    return Math.Sqrt(Math.Pow((CoordinateX_1 - CoordinateX_2),2) +
            Math.Pow((CoordinateY_1 - CoordinateY_2),2)+Math.Pow((CoordinateZ_1 - CoordinateZ_2),2));
}
int getCoordinateFromUser(string userInformation)
{
    int result = 0;
    while(result == 0) 
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if(result == 0 && userLine !="0")
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
Console.WriteLine("Введите целочисленные координаты");

int userCoordinateX_1 = getCoordinateFromUser("X1: ");
int userCoordinateY_1 = getCoordinateFromUser("Y1: ");
int userCoordinateZ_1 = getCoordinateFromUser("Z1: ");
int userCoordinateX_2 = getCoordinateFromUser("X2: ");
int userCoordinateY_2 = getCoordinateFromUser("Y2: ");
int userCoordinateZ_2 = getCoordinateFromUser("Z2: ");

Console.WriteLine(Length3D(userCoordinateX_1,userCoordinateY_1,userCoordinateZ_1,
                           userCoordinateX_2,userCoordinateY_2,userCoordinateZ_2));
