/*//это база
int[,] Fillmatrix (int row, int col, int min, int max){
    int[,] matrix = new int[row, col]; // запятая показывает количество измерений в массиве, 1 = двумерный, 2 = трехмерный [,,,]   в скобках тоже будет несколько параметров череез запятую
    Random rand = new Random();   // GetLength(0) - обращаемся к 0 измерению, т.е. к длине, 1 - колво столбцов  в данном случае, length выдает колво элементов
    for (int i = 0; i<matrix.GetLength(0); i++) {
        for (int j = 0; j<matrix.GetLength(1); j++) {
            matrix[i,j] = rand.Next(min, max+1);}}
    return matrix;  }

void Printmatrix(int[,] matrix){
    for (int i = 0; i<matrix.GetLength(0); i++) {
        for (int j = 0; j<matrix.GetLength(1); j++) {System.Console.Write(matrix[i,j] + "\t");} // \t - табуляция, просто для красоты
        System.Console.WriteLine();}}

int Input (string text) {
    System.Console.Write(text);
    return Convert.ToInt32(System.Console.ReadLine());}


int columns = Input("input columns: ");
int rows = Input("input lines: ");
int minnum = Input("input minimal number: ");
int maxnum = Input("input maximum number: ");
int[,] matrix = Fillmatrix(rows, columns, minnum, maxnum); 

Printmatrix(matrix);

*/



/*
//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами 
//первую и последнюю строку массива.
int[,] Fillmatrix (int row, int col, int min, int max){
    int[,] matrix = new int[row, col]; 
    Random rand = new Random();   
    for (int i = 0; i<matrix.GetLength(0); i++) {
        for (int j = 0; j<matrix.GetLength(1); j++) {
            matrix[i,j] = rand.Next(min, max+1);}}
    return matrix;  }

void Printmatrix(int[,] matrix){
    for (int i = 0; i<matrix.GetLength(0); i++) {
        for (int j = 0; j<matrix.GetLength(1); j++) {System.Console.Write(matrix[i,j] + "\t");} 
        System.Console.WriteLine();}}

int Input (string text) {
    System.Console.Write(text);
    return Convert.ToInt32(System.Console.ReadLine());}

void Swap(int[,] array){
    for (int i = 0; i<array.GetLength(0); i++){
        int buffer = array[0,i];
        array[0,i] = array[array.GetLength(0)-1, i];
        array[array.GetLength(0)-1, i] = buffer;}}


int columns = Input("input columns: ");
int rows = Input("input lines: ");
int minnum = Input("input minimal number: ");
int maxnum = Input("input maximum number: ");
int[,] matrix = Fillmatrix(rows, columns, minnum, maxnum); 

Printmatrix(matrix);
Swap(matrix);
System.Console.WriteLine();
Printmatrix(matrix);
*/


/*
//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
int[,] Fillmatrix (int row, int col, int min, int max){
    int[,] matrix = new int[row, col]; // запятая показывает количество измерений в массиве, 1 = двумерный, 2 = трехмерный [,,,]   в скобках тоже будет несколько параметров череез запятую
    Random rand = new Random();   // GetLength(0) - обращаемся к 0 измерению, т.е. к длине, 1 - колво столбцов  в данном случае, length выдает колво элементов
    for (int i = 0; i<matrix.GetLength(0); i++) {
        for (int j = 0; j<matrix.GetLength(1); j++) {
            matrix[i,j] = rand.Next(min, max+1);}}
    return matrix;  }

void Printmatrix(int[,] matrix){
    for (int i = 0; i<matrix.GetLength(0); i++) {
        for (int j = 0; j<matrix.GetLength(1); j++) {System.Console.Write(matrix[i,j] + "\t");} // \t - табуляция, просто для красоты
        System.Console.WriteLine();}}

int Input (string text) {
    System.Console.Write(text);
    return Convert.ToInt32(System.Console.ReadLine());}

int[,] Swap(int[,] matrix){
    int [,] swapmatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i<swapmatrix.GetLength(0); i++){
        for (int j = 0; j<swapmatrix.GetLength(1); j++) {
            swapmatrix[i,j] = matrix[j,i];}}
    return swapmatrix;}


int columns = Input("input columns: ");
int rows = Input("input lines: ");
int minnum = Input("input minimal number: ");
int maxnum = Input("input maximum number: ");
int[,] matrix = Fillmatrix(rows, columns, minnum, maxnum); 

Printmatrix(matrix);
System.Console.WriteLine();
Printmatrix(Swap(matrix));
*/





/*
//Задача 57: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
//1, 2, 3 
//4, 6, 1 
//2, 1, 6
//1 встречается 3 раза 
//2 встречается 2 раз 
//3 встречается 1 раз 
//4 встречается 1 раз 
//6 встречается 2 раза

//var1
int[,] Fillmatrix (int row, int col, int min, int max){
    int[,] matrix = new int[row, col]; 
    Random rand = new Random(); 
    for (int i = 0; i<matrix.GetLength(0); i++) {
        for (int j = 0; j<matrix.GetLength(1); j++) {
            matrix[i,j] = rand.Next(min, max+1);}}
    return matrix;  }

void Printmatrix(int[,] matrix){
    for (int i = 0; i<matrix.GetLength(0); i++) {
        for (int j = 0; j<matrix.GetLength(1); j++) {System.Console.Write(matrix[i,j] + "\t");} 
        System.Console.WriteLine();}}

int Input (string text) {
    System.Console.Write(text);
    return Convert.ToInt32(System.Console.ReadLine());}

void Frequency (int [,] matrix) {
    for(int k = 0; k<10; k++){
        int count = 0;
        for (int i = 0; i<matrix.GetLength(0); i++){
            for (int j = 0; j<matrix.GetLength(1); j++){
                if(k==matrix[i,j]){count = count + 1;}}}
        if (count != 0){System.Console.WriteLine($"number {k} appears {count} times");}}}



int columns = Input("input columns: ");
int rows = Input("input lines: ");
int minnum = Input("input minimal number >= 0: ");
int maxnum = Input("input maximum number <= 9: ");
int[,] matrix = Fillmatrix(rows, columns, minnum, maxnum); 

Printmatrix(matrix);
Frequency(matrix);
*/

//var2
/*
void FreqDictionary(int[,] array){
    // int[] countArray = new int[10];
    int max = array.Cast<int>().Max();
    int[] countArray = new int[max+1];//эти 2 строчки - более эффективное выделение памяти
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){countArray[array[i,j]]++;}}
    for (int k = 0; k < countArray.Length; k++){
        if (countArray[k] != 0) {Console.WriteLine($"Число {k} в массиве встречается {countArray[k]}");}}}
*/





/*
//Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Наименьший элемент - 1, на выходе получим 
//следующий массив:
//9 2 3
//4 2 4
//2 6 7



int[,] Fillmatrix (int row, int col, int min, int max){
    int[,] matrix = new int[row, col]; 
    Random rand = new Random(); 
    for (int i = 0; i<matrix.GetLength(0); i++) {
        for (int j = 0; j<matrix.GetLength(1); j++) {
            matrix[i,j] = rand.Next(min, max+1);}}
    return matrix;  }

void Printmatrix(int[,] matrix){
    for (int i = 0; i<matrix.GetLength(0); i++) {
        for (int j = 0; j<matrix.GetLength(1); j++) {System.Console.Write(matrix[i,j] + "\t");} 
        System.Console.WriteLine();}}

int Input (string text) {
    System.Console.Write(text);
    return Convert.ToInt32(System.Console.ReadLine());}



int columns = Input("input columns: ");
int rows = Input("input lines: ");
int minnum = Input("input minimal number: ");
int maxnum = Input("input maximum number: ");
int[,] matrix = Fillmatrix(rows, columns, minnum, maxnum); 

Printmatrix(matrix);
//отсюда ломаются имена, все переделать.
int row = ReadInt("Введите количество строк: ");
int col = ReadInt("Введите количество стобцов: ");
int[,] array = FillMatrix(row, col, 5, 9);
PrintMatrix(array);

int[,] newArray = new int[row - 1, col - 1];
int indexI = 0; int indexJ = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[indexI, indexJ] > array[i, j])
        {
            indexI = i;
            indexJ = j;
        }
    }
}

for (int i = 0, newRow = 0; i < array.GetLength(0); i++)
{
    if (i == indexI) continue;  //переход к следующей итерации
    for (int j = 0, newCol = 0; j < array.GetLength(1); j++)
    {
        if (j == indexJ) continue;
        newArray[newRow, newCol] = array[i, j];
        newCol++;
    }
    newRow++;
}

System.Console.WriteLine();
PrintMatrix(newArray);
*/


