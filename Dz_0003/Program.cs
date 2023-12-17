int[] array = new int[10];
int[] newArray = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    System.Console.Write(array[i] + " ");
}
System.Console.WriteLine();

for (int i = array.Length - 1; i >= 0; i--)
{
    newArray[i] = array[i];
    System.Console.Write(array[i] + " ");
}