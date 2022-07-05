int [] array = {3, 5, 4, 8, 2, 6, 1};
void PrintArray (int [] array)
{
    int Length = array.Length;
for (int i = 0; i < Length; i++)
{
    Console.Write($"{array[i]} ");
}
}
void SortArray (int [] array)
{
for (int i = 0; i < array.Length - 1; i++)
{
    int min = i;
for (int j = i + 1; j < array.Length; j++)
{
if (array[j] < array [min]) min = j;
}
    int temporary = array[i];
    array[i] = array[min];
    array[min] = temporary;
}
}
SortArray (array);
PrintArray(array);