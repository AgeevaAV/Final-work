// void Main(){
//     int sizeArray = ReadInt("введите размер массива: ");
//     int[] array = GeneratorArray(sizeArray, 0, 30);
//     PrintArray(array);
//     Console.WriteLine(CountPrimes(array));
//     // Console.WriteLine(CountNumbers(array, 7, 1));
// }
// bool isPrime(int number){
//     if (number<2) return false;
//     for(int i=2; i<=Math.Sqrt(number); i++){
//         if(number %i ==0)
//             return false; }
//     return true;
// }
// int CountPrimes ( int[] array){
//     int count =0;
//     foreach (int number in array){
//     if(isPrime(number)){
//         count++;
//     }
//     }
//     return count;
// }
// int ReadInt(string msg)
// {
//     System.Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int[] GeneratorArray(int size, int leftRange, int rightRange){
//     int[] tempArray = new int[size];
//     Random rand = new Random();
//     for (int i =0; i<size; i++){
//         tempArray[i]=rand.Next(leftRange,rightRange+1);
// }
//     return tempArray;
// }
// void PrintArray(int[] arrayForPrint)
// {
//     System.Console.WriteLine("[ " + string.Join(", ", arrayForPrint) + " ]");
// }
// Main();

// задача первая

// void Main()
// {
// while (true) 
// {
//     int sum = 0;
//     Console.Write("Введите число или 'q' для выхода: ");
//     string input = Console.ReadLine(); 
//     if (input == "q") 
// {
//     break;
// }
// int number;
// if (int.TryParse(input, out number)) 
//     while (number > 0) 
// {
//     sum += number % 10; 
// number /= 10; 
// }
// if (sum % 2 == 0) 
// {
// Console.WriteLine("[STOP]");
// break;
// }
// else 
// {
// Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое числоили 'q'.");
// }
// }
// }
// Main();

//задача вторая
// void Main()
// {
//     int sizeArray=ReadInt("введите размер массива: ");
//     int[] numbers = new int[sizeArray]; 
//     Random random = new Random(); 
//     int evenCount = 0; 
//     for (int i = 0; i < numbers.Length; i++)
// {
//         numbers[i] = random.Next(100, 1000); 
//         Console.Write(numbers[i] + " "); 

//     if (numbers[i] % 2 == 0)
// {
//     evenCount++;
// }
// }

// Console.WriteLine($"\nКоличество четных чисел в массиве: {evenCount}");
// }
// Main();
// int ReadInt(string msg)
// {
//     System.Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }

// задач третья 
void Main()
{
int sizeArray = ReadInt("введите размер массива: ");
int[] array = GeneratorArray(sizeArray, 0, 30);
PrintArray(array);
int temp;
Console.Write("Исходный массив: ");
foreach (int number in array)
{
Console.Write(number + " ");
}

for (int i = 0; i < array.Length / 2; i++)
{

    temp = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = temp;
}
Console.Write("\nПеревернутый массив: ");
foreach (int number in array)
{
    Console.Write(number + " ");
}
}
int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int[] GeneratorArray(int size, int leftRange, int rightRange){
    int[] tempArray = new int[size];
    Random rand = new Random();
    for (int i =0; i<size; i++){
        tempArray[i]=rand.Next(leftRange,rightRange+1);
}
    return tempArray;
}
void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[ " + string.Join(", ", arrayForPrint) + " ]");
}
Main();
