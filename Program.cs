Console.Write("Сколько слов и цифр Вы хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
 Console.WriteLine($"Введите {i+1}-ое слово или цифру: ");
 string word = Convert.ToString(Console.ReadLine());
 arrayStrings[i] = word;
}

