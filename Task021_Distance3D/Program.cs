// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int Quadro(int number)
{
     return number * number;
}

int xA = InputInt("Введите координату X для точки А: ");
int yA = InputInt("Введите координату Y для точки А: ");
int zA = InputInt("Введите координату Z для точки A: ");

int xB = InputInt("Введите координату X для точки B: ");
int yB = InputInt("Введите координату Y для точки B: ");
int zB = InputInt("Введите координату Z для точки B: ");


int xx = xA - xB;
int yy = yA - yB;
int zz = zA - zB;


double sqrt = Math.Sqrt(Quadro(xx) + Quadro(yy) + Quadro(zz));
Console.WriteLine("Расстояние между точками " + sqrt + " см");

