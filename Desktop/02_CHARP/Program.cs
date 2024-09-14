// Console.Write("Введите кол-во строк: ");
// int rows= Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int cols= Convert.ToInt32(Console.ReadLine());
// int[,] matrix=new int[rows, cols];
// Random rand = new Random();
// for (int i=0; i<matrix.GetLength(0); i++){
//     for (int j=0; j<matrix.GetLength(1); j++){
//         matrix[i,j]= rand.Next(0,10);
//     }
// }
// for (int i=0; i<matrix.GetLength(0); i++){
//     for (int j=0; j<matrix.GetLength(1); j++){
//        if(i%2==0 && j%2==0){
//         matrix[i,j] *= matrix[i,j];
//        }
//     }
// }
// for (int i=0; i<matrix.GetLength(0); i++){
//     for (int j=0; j<matrix.GetLength(1); j++){
//         Console.Write(matrix[i,j] + " ");
//     }
//     Console.WriteLine();
// }
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3 4 3 4 3
// 4 3 4 1 => 4 3 4 1
// 2 9 5 4 2 9 25 4

void Main()
{
int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");

int[,] matrix = GenerateMatrix(rows, cols, 0, 9);

PrintMatrix(matrix);

ChangeMatrix(matrix);

System.Console.WriteLine();

PrintMatrix(matrix);

}

void ChangeMatrix(int[,] oldMatrix)
{
for (int i = 0; i < oldMatrix.GetLength(0); i += 2)
{
for (int j = 0; j < oldMatrix.GetLength(1); j += 2)
{
oldMatrix[i, j] *= oldMatrix[i, j];
}
}
}

void PrintMatrix(int[,] arrayForPrint)
{
for (int i = 0; i < arrayForPrint.GetLength(0); i++)
{
for (int j = 0; j < arrayForPrint.GetLength(1); j++)
{
System.Console.Write(arrayForPrint[i, j] + "\t");
}
System.Console.WriteLine();
}
}

int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange)
{
int[,] tempMatrix = new int[row, col];
Random rand = new Random();

for (int i = 0; i < row; i++)
{
for (int j = 0; j < col; j++)
{
tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
}
}

return tempMatrix;
}

int ReadInt(string msg)
{
System.Console.Write(msg);
return Convert.ToInt32(Console.ReadLine());
}

Main();