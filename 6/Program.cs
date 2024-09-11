/*
//task 2
void Task(){
    int[] array1 = NewArray(3, 0, 100);
    PrintArray(array1);
    if (Triangle(array1))
        {
        Console.WriteLine("Такой треугольник существует");
        }
        else Console.WriteLine("Такой треугольник не возможен");}
    //Проверка треугольник ли 
bool Triangle(int[] array1){
    if ((array1[0] < array1[1] + array1[2]) && (array1[1] < array1[0] + array1[2]) && (array1[2] < array1[1] + array1[0]))
        {return true;}
    return false;}
*/



/*
//task3
int ReadInt()
{
    System.Console.WriteLine("Enter a:");
    return Convert.ToInt32(System.Console.ReadLine());
}

void NumberToBinary(int number)
{
    if (number == 0)
    {
        return;
    }
    NumberToBinary(number / 2);
    System.Console.Write(number % 2);
}

Console.Clear();
int a = ReadInt();
NumberToBinary(a);
*/




//task4
/*
//var1
int Readint(string text){
    System.Console.WriteLine(text);
    return Convert.ToInt32(System.Console.ReadLine());}

int number = Readint("input number: ");
int [] array = new int [number];
array[0] = 0;
array[1] = 1; 

for (int i =2; i<number; i++){
    array[i] = array[i-1]+array[i-2];
}

System.Console.WriteLine(string.Join(" ", array));
*/

/*
//var2
int ReadInt(string text){
    System.Console.Write(text);
    return Convert.ToInt32(System.Console.ReadLine());}

int[] Fibonachi(int a){
    int[] arr = { 0, 1 };
    int[] temp = new int[a];
    for (int i = 0; i < a; i++){
        if (i < 2){
            temp[i] = arr[i];}
        else{
            temp[i] = temp[i - 1] + temp[i - 2];}}
    return temp;}

int a = ReadInt("Если N = ");
int[] array = Fibonachi(a);
System.Console.WriteLine(string.Join(", ", array));
*/


/*
//task 5
void Main (){
    int[] array  = Fillarray(7,0,10);
    Printarray(array);
    int[] array2 = array[..] //копирует массив в отдельные ячейки памяти, без [..] оба массива будут храниться в одном месте и изменяться вместе
    int[] newarray = Copyarray(array);
    Printarray(array);}

void Fillarray(int[] arr){
    Random rand = new Random();
    for (int i = 0; i<8; i++){
    arr[i] = rand.Next(0,2);}}

void Printarray(int[] arr){
    System.Console.WriteLine(string.Join(" ", arr));}

int Copyarray(int[] arraytocopy){
    int[] copiedarray = new int[arraytocopy.Length];
    for(int i = 0; i<copiedarray.Length; i++){
        copiedarray[i] = arraytocopy[i];}
    return copiedarray;}
*/