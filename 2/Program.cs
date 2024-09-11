
/*
//Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int[] coords = new int[2]; //[] объявляет массив, new int[2] создает новый массив с двумя ячейками

Console.Write("Input x: ");
coords[0] = Convert.ToInt32(Console.ReadLine()); //coords[0] обращаетя к 0 элементу массива
Console.Write("Input y: ");
coords[1] = Convert.ToInt32(Console.ReadLine());

// cw+tab = автозаполнение System.Console.WriteLine();
if (coords[0]>0 && coords[1]>0) {System.Console.WriteLine("1");}
if (coords[0]<0 && coords[1]>0) {System.Console.WriteLine("2");}
if (coords[0]<0 && coords[1]<0) {System.Console.WriteLine("3");}
if (coords[0]>0 && coords[1]<0) {System.Console.WriteLine("4");}
else {System.Console.WriteLine("incorrect input");}
*/



/*
//Еще задача. Напишите программу, которая по заданному номеру четверти, показывает диапазон 
//возможных координат точек в этой четверти (x и y).

System.Console.Write("Input quadrants' number: ");
int num = Convert.ToInt32(Console.ReadLine());

string[] quads = {"x > 0, y > 0", "x < 0, y > 0", "x < 0, y < 0", "x > 0, y < 0"};

if (num > 0 && num <5){System.Console.WriteLine(quads[num-1]);}
else System.Console.WriteLine("Incorrect input");
*/



/*
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
//между ними в 2D пространстве.
//считать по этой формуле sqrt((x2-x1)^2 + (y2-y1)^2)
//Math.Pow(3, 4) - 3^4
//Math.Sqrt(9) - square root (9)
//Math.Round(num, 3) - округляет num до 3 знаков после зпт

int[] acoord = new int[2];
Console.Write("input x1: ");
acoord[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("input y1: ");
acoord[1] = Convert.ToInt32(Console.ReadLine());
int[] bcoord = new int[2];
Console.Write("input x1: ");
bcoord[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("input y1: ");
bcoord[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((bcoord[0] - acoord[0]), 2) + Math.Pow((bcoord[1] - acoord[1]),2)),3));
*/


/*
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
//чтобы можно было массив заполнять легко, через ввод только одной строки
//если у split в скобках ничего нет, то по умолчанию пробел
//! для тогго, чтобы не выводилось предепреждение о пустой стрроке
// Parse - своеобразный коныертер
int num = int.Parse("123");

System.Console.Write(string.Join(", ", array));
//string.Join выводит массив array через разделитель ", " без него в конце
*/


/*
System.Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int index = 1;
double[] array = new double[num];

while (index <= num) {
array[index-1] = Math.Pow(index, 2);
index++;
}
System.Console.WriteLine(string.Join(", ", array));
*/


/* not mine
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= number; i++){
//    Console.Write(string.Format("{0} ", Math.Pow(i, 2)));
    Console.Write(Math.Pow(i, 2) + " ");
}
*/



































/*
//task1
System.Console.Write("input number: ");
string str = Console.ReadLine();

if (str.Length == 5)
{
    if (str[0] == str[4] && str[1] == str[3]) { System.Console.WriteLine("yes"); }
    else { System.Console.WriteLine("no"); }
}
else { System.Console.WriteLine("error"); }
*/



/*
//task3
System.Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());


if (num > 0)
{
    int index = 1;
    double[] array = new double[num];
    while (index <= num)
    {
        array[index - 1] = Math.Pow(index, 3);
        index++;
    }
    System.Console.WriteLine(string.Join(", ", array));

}
else { System.Console.WriteLine("error"); }
*/





/*
//task2
int[] c1 = new int[3];
int[] c2 = new int[3];

System.Console.Write("input x1: ");
c1[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("input y1: ");
c1[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("input z1: ");
c1[2] = Convert.ToInt32(Console.ReadLine());

System.Console.Write("input x2: ");
c2[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("input y2: ");
c2[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("input z2: ");
c2[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Round((Math.Sqrt(Math.Pow(c2[0] - c1[0], 2) + Math.Pow(c2[1] - c1[1], 2) + Math.Pow(c2[2] - c1[2], 2))), 2));
*/







