int[] array = new int[3];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0)
    {
        count++;
    }
    System.Console.Write(array[i] + " ");
}

System.Console.WriteLine(count + " четных чисел");
  
