Console.WriteLine ("Введите числа:");
string numbers = Console.ReadLine();
string [] newNumbers = new string [numbers.Length];
int a = 0;
for (int i = 0; i < newNumbers.Length; i++)
{
  if (numbers[i] == ',')
  {
    a++;
  }
  else
  {
    newNumbers[a] = newNumbers[a]+$"{numbers[i]}";
  }
}
a++;
int [] resultNumbers = new int[a];
PrintArray (resultNumbers, newNumbers);
int sum = 0;
for (int i = 0; i < a; i++)
{
  if (resultNumbers[i]>0)
  {
    sum++;
  }
}
Console.WriteLine ("Количество чисел > 0: ="+sum);

void PrintArray (int [] array, string [] string1)
{
  for (int i = 0; i < array.Length; i++)
  {
  array[i] = Convert.ToInt32(string1[i]);
  Console.Write (array[i]+"  ");
  }
Console.WriteLine();
}
 