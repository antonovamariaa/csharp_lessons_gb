

/*
//напишите программу которая принимает на вход число и выдает сумму чисел от 1 до числа
System.Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= num; i++){
    sum = sum+i;
}
System.Console.WriteLine(sum);
*/


/*
int Readint(string text){
    System.Console.Write(text);
    int tempn = Convert.ToInt32(Console.ReadLine());
    return tempn;}
    // return Convert.ToInt32(Console.ReadLine());

int Sumnum(int n){
    int sum = 0;
    for (int i = 1; i <= n; i++){sum += i;}//sum = sum + i
    return sum;}
//------------------------------------------------------------------
int num = Readint("input number: ");
int summ = Sumnum(num);
System.Console.WriteLine(summ);

System.Console.WriteLine(Sumnum(1));
System.Console.WriteLine(Sumnum(2));
System.Console.WriteLine(Sumnum(3));
*/



/*
//считаем количество цифр в числе

System.Console.Write("input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (number>0){
    number /= 10; // number = number/10
    count++;
}
System.Console.WriteLine(count);
*/


/*
int Readint(string text){
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));}

int Count (int n){
    int count = 0;
    if (n==0) {count = 1;}
    while (n>0){
        n /= 10; // number = number/10
        count++;}
    return count;}

int number  = Readint("input number: ");
int count = Count(number);
//int count = Count(Readint("input number: "));
System.Console.WriteLine(count);
*/


/*
//факториал числа
int Readint(string text){
    System.Console.Write(text);
    int tempn = Convert.ToInt32(Console.ReadLine());
    return tempn;}
    // return Convert.ToInt32(Console.ReadLine());

int Sumnum(int n){
    int sum = 1;
    for (int i = 1; i <= n; i++){sum=sum*i;}
    return sum;}

int num = Readint("input number: ");
int summ = Sumnum(num);
System.Console.WriteLine(summ);
*/


/*
//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
void Fillarray(int[] arr){
    Random rand = new Random();
    for (int i = 0; i<8; i++){
    arr[i] = rand.Next(0,2);}}

void Printarray(int[] arr){
    System.Console.WriteLine(string.Join(" ", arr));
}


int[] array = new int[8];
Fillarray(array);
Printarray(array);
*/



