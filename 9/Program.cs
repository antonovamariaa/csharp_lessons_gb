/*
//Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

int Input (string text) {
    System.Console.Write(text);
    return Convert.ToInt32(System.Console.ReadLine());}

void Numbers (int N) {
    if (N==0) return;
    Numbers(N-1);
    System.Console.Write(N + " ");}
    //System.Console.Write(N + " ");}
    //Numbers(N-1); // для вывода в обратном порядке

Numbers(Input("input number: ")) ;
*/





/*
//Задача 65: Задайте значения M и N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от M до N.
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 6, 7, 8"
int ReadInt(string text){
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());}


void Numbers(int M, int N){
    if (M > N) return;
    System.Console.Write(M + " ");
    Numbers(M + 1, N);}


int M = ReadInt("input  m: ");
int N = ReadInt("input n: ");
if (M > N){
    System.Console.WriteLine("incorrect numbers.");
    return;}

Numbers(M, N);
*/






/*
//Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9
int Input (string text){
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());}

int  Sumnum (int num) {
    if (num <= 0) {return 0;}
    return num % 10 + Sumnum(num / 10);}

int num = Input ("input number: ");
System.Console.WriteLine("sum of digits = " + Sumnum(num));
*/






//Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит 
//число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8
//Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8

int ReadInt(string text){
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());}

int Power(int X, int Y){
    if (Y == 0) return 1;
    return X * Power(X, Y - 1);}



int X = ReadInt("input number: ");
int Y = ReadInt("input power: ");
System.Console.WriteLine($"{X} in a power of {Y}: {Power(X,Y)}");
