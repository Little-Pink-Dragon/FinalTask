Random rnd = new Random();
int R = rnd.Next(1, 7);
Console.WriteLine($"Введите {R} слов(а) или цифр:");
int size = R;

string[] arrayInitial = new string[size];
for (int i = 0; i < size; i++)
{
 Console.WriteLine($"Введите {i+1}-ое слово или цифру: ");
 string word = Convert.ToString(Console.ReadLine());
 arrayInitial[i] = word;
}
string[] arrayFinite = new string[size];
int len = 3;
int pos = 0;

for (int j = 0; j < R; j++)
{
 if (arrayInitial[j].Length <= len)
    {
 arrayFinite[pos] = arrayInitial[j];
 pos++;
    }
}

Console.Write("[ ");

void PrintArray(string[] array)
{
 for (int i = 0; i < array.Length; i++)
    {
 Console.Write(array[i] + " ");
    }
 Console.Write("] - слова, в которых меньше 4 символов");
}
PrintArray(arrayFinite);
