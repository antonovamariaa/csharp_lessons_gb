
/*int[,] Fillmatrix (int row, int col, int min, int max){
    int[,] matrix = new int[row, col]; // запятая показывает количество измерений в массиве, 1 = двумерный, 2 = трехмерный [,,,]   в скобках тоже будет несколько параметров череез запятую
    Random rand = new Random();   // GetLength(0) - обращаемся к 0 измерению, т.е. к длине, 1 - колво столбцов  в данном случае, length выдает колво элементов
    for (int i = 0; i<matrix.GetLength(0); i++) {
        for (int j = 0; j<matrix.GetLength(1); j++) {
            matrix[i,j] = rand.Next(min, max+1);
        }
    }
    return matrix;  
}

void Printmatrix(int[,] matrix){
    for (int i = 0; i<matrix.GetLength(0); i++) {
        for (int j = 0; j<matrix.GetLength(1); j++) {
            System.Console.Write(matrix[i,j] + "\t");; // \t - табуляция, просто для красоты
        }
        System.Console.WriteLine();
    }
    }

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
//Задача 48: Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
//rows = 3, cols = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5
int[,] Fillmatrix (int row, int col){
    int[,] matrix = new int[row, col]; // запятая показывает количество измерений в массиве, 1 = двумерный, 2 = трехмерный [,,,]   в скобках тоже будет несколько параметров череез запятую
    // GetLength(0) - обращаемся к 0 измерению, т.е. к длине, 1 - колво столбцов  в данном случае, length выдает колво элементов
    for (int i = 0; i<matrix.GetLength(0); i++) {
        for (int j = 0; j<matrix.GetLength(1); j++) {
            matrix[i,j] = i+j;
        }
    }
    return matrix;  
}

void Printmatrix(int[,] matrix){
    for (int i = 0; i<matrix.GetLength(0); i++) {
        for (int j = 0; j<matrix.GetLength(1); j++) {
            System.Console.Write(matrix[i,j] + "\t");; // \t - табуляция, просто для красоты
        }
        System.Console.WriteLine();
    }
    }

int Input (string text) {
    System.Console.Write(text);
    return Convert.ToInt32(System.Console.ReadLine());}


int columns = Input("input columns: ");
int rows = Input("input lines: ");
int[,] matrix = Fillmatrix(rows, columns); 

Printmatrix(matrix);
*/



/*
//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
//Например, изначально массив выглядел вот так:  а потом вот так:
//1 4 7 2                           1 4 7 2
//5 9 2 3                           5 81 2 9
//8 4 2 4                           8 4 2 4

int[,] Fillmatrix (int row, int col, int min, int max){
    int[,] matrix = new int[row, col]; // запятая показывает количество измерений в массиве, 1 = двумерный, 2 = трехмерный [,,,]   в скобках тоже будет несколько параметров череез запятую
    Random rand = new Random();   // GetLength(0) - обращаемся к 0 измерению, т.е. к длине, 1 - колво столбцов  в данном случае, length выдает колво элементов
    for (int i = 0; i<matrix.GetLength(0); i++) {
        for (int j = 0; j<matrix.GetLength(1); j++) {
            matrix[i,j] = rand.Next(min, max+1);}}
    return matrix;  }

void Modify(int[,] matrix){
    for (int i = 0; i<matrix.GetLength(0); i++) {
        for (int j = 0; j<matrix.GetLength(1); j++) {
            if (i%2 == 1 && j%2 == 1) {
                matrix[i,j] = (int)Math.Pow (matrix[i,j], 2);}}}}

//void Modify(int[,] matrix){
//    for (int i = 1; i<matrix.GetLength(0); i+=2) {
//        for (int j = 1; j<matrix.GetLength(1); j+=2) {           
//            matrix[i,j] = (int)Math.Pow (matrix[i,j], 2);}}}

void Printmatrix(int[,] matrix){
    for (int i = 0; i<matrix.GetLength(0); i++) {
        for (int j = 0; j<matrix.GetLength(1); j++) {
            System.Console.Write(matrix[i,j] + "\t");} // \t - табуляция, просто для красоты
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
Modify(matrix);
System.Console.WriteLine();
Printmatrix(matrix);
*/



/*
//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
//(с индексами (0,0); (1;1) и т.д. Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Сумма элементов главной диагонали: 1+9+2 = 12

int[,] Fillmatrix (int row, int col, int min, int max){
    int[,] matrix = new int[row, col]; // запятая показывает количество измерений в массиве, 1 = двумерный, 2 = трехмерный [,,,]   в скобках тоже будет несколько параметров череез запятую
    Random rand = new Random();   // GetLength(0) - обращаемся к 0 измерению, т.е. к длине, 1 - колво столбцов  в данном случае, length выдает колво элементов
    for (int i = 0; i<matrix.GetLength(0); i++) {
        for (int j = 0; j<matrix.GetLength(1); j++) {
            matrix[i,j] = rand.Next(min, max+1);
        }
    }
    return matrix;  
}

void Printmatrix(int[,] matrix){
    for (int i = 0; i<matrix.GetLength(0); i++) {
        for (int j = 0; j<matrix.GetLength(1); j++) {
            System.Console.Write(matrix[i,j] + "\t");; // \t - табуляция, просто для красоты
        }
        System.Console.WriteLine();
    }
    }

int Input (string text) {
    System.Console.Write(text);
    return Convert.ToInt32(System.Console.ReadLine());}
//можно только одной переменной, т к проверяем одинаковые индексы и тут и там, оптимизация получается
int TaskMatrix(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
    {
       sum = sum + array[i,i];
    }
    return sum;
}


int columns = Input("input columns: ");
int rows = Input("input lines: ");
int minnum = Input("input minimal number: ");
int maxnum = Input("input maximum number: ");
int[,] matrix = Fillmatrix(rows, columns, minnum, maxnum); 

Printmatrix(matrix);
System.Console.WriteLine(TaskMatrix(matrix));
*/






