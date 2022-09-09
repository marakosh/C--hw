using System.Runtime.CompilerServices;
using System.Text;

Random random = new Random();
#region Task 1


/*
int[] A = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"enter {i + 1} number ");
    int a = Convert.ToInt32(Console.ReadLine());
    A[i] = a;
}

Console.Write("A: ");
for (int i = 0; i < 5; i++)
{
    Console.Write(A[i] + " ");
}

Console.WriteLine($"\nMax element of array A: {A.Max()}"); // максимальный эл. массива
Console.WriteLine($"Min element of array A: {A.Min()}"); // минимальный эл. массива


int sum = 0;// находим сумму эл. массива
for (int i = 0; i < A.Length; i++)
{
    sum += A[i];
}
Console.WriteLine($"Sum = {sum}");

int even = A[0]; // сумма четных элементов массива
int res_ev = 0;
for (int i = 0; i < A[0]; i++)
{
    if (A[i] % 2 == 0)
    {
        res_ev += A[i];
    }
}
//------------------------------------------
int[,] B = new int[3, 4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        B[i, j] = random.Next(100); // заполняет рандомными числами
    }
}

Console.WriteLine("\n\nB:");
for (int y = 0; y < 3; y++)
{
    for (int x = 0; x < 4; x++)
    {
        Console.Write(B[y, x] + " ");
    }
    Console.WriteLine();
}

int maxval = 0; // максимальное значение двумерного массива
foreach (int a in B)
{
    maxval = maxval < a ? a : maxval;
}
Console.WriteLine($"Max element of array B: {maxval} ");

int minval = B[0, 0]; // минимальное значение двумерного массива 
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if (minval > B[i, j])
        {
            minval = B[i, j];
        }
    }
}
Console.WriteLine($"Min element of array B: {minval} ");

int sumOfOdd = 0;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if (j % 2 != 0)
        {
            sumOfOdd += B[i, j];
        }
    }
}
Console.WriteLine($"Sum of Odd values in B array is {sumOfOdd}");
*/
#endregion

#region Task 2
/*
int[,] C = new int[5, 5];
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        C[i, j] = random.Next(-100, 100); // заполняет рандомными числами
    }
}

int max = 0;
foreach (int a in C)
{
    max = max < a ? a : max;
}
Console.WriteLine($"Max element of array C: {max} ");

int min = C[0, 0];
int x_min = 0;
int y_min = 0;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (min > C[i, j])
        {
            min = C[i, j];
            x_min = i;
            y_min = j;
        }
    }
}
Console.WriteLine($"Min element of array C: {min} ");

int Сmin;
int imin = 0;
int imax = 0;
int sum;

int[] C1 = new int[25];
int z = 0;
for (int i = 0; i < 5; i++)
    for (int j = 0; j < 5; j++)
    {
        C1[z] = C[i, j];
        z++;
    }

min = int.MaxValue;
max = int.MinValue;
sum = 0;
for (int i = 0; i < 10; i++)
{
    if (C1[i] < min)
    {
        min = C1[i];
        imin = i;
    }

}
for (int i = 0; i < 10; i++)
{
    if (C1[i] > max)
    {
        max = C1[i];
        imax = i;
    }
}
if (imin < imax)
{

    for (int i = imin + 1; i < imax; i++)
        sum = sum + C1[i];
}
else
{
    for (int i = imax + 1; i < imin; i++)
    { sum = sum + C1[i]; }
}
Console.WriteLine($"sum = {sum}");
*/
#endregion

#region Task 3
/*
var cipher = new CaesarCipher();
Console.Write("Введите текст: ");
var message = Console.ReadLine();
Console.Write("Введите ключ: ");
var secretKey = Convert.ToInt32(Console.ReadLine());
var encryptedText = cipher.Encrypt(message, secretKey);
Console.WriteLine("Зашифрованное сообщение: {0}", encryptedText);
Console.WriteLine("Расшифрованное сообщение: {0}", cipher.Decrypt(encryptedText, secretKey));
Console.ReadLine();
public class CaesarCipher
{
    const string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
    private string CodeEncode(string text, int k)
    {
        //добавляем в алфавит маленькие буквы
        var fullAlfabet = alfabet + alfabet.ToLower();
        var letterQty = fullAlfabet.Length;
        var retVal = "";
        for (int i = 0; i < text.Length; i++)
        {
            var c = text[i];
            var index = fullAlfabet.IndexOf(c);
            if (index < 0)
            {
                retVal += c.ToString();
            }
            else
            {
                var codeIndex = (letterQty + index + k) % letterQty;
                retVal += fullAlfabet[codeIndex];
            }
        }

        return retVal;
    }

    public string Encrypt(string plainMessage, int key)
        => CodeEncode(plainMessage, key);

    public string Decrypt(string encryptedMessage, int key)
        => CodeEncode(encryptedMessage, -key);
}
*/
#endregion

#region Task 5
/*
Console.WriteLine("Task 5");
Console.WriteLine("Enter math expression -> ");
var math_ex = "";
math_ex = Console.ReadLine();
math_ex = math_ex.Replace(" ", "");
char znak = ' ';
int zn_ind = 0;
for (int i = 0; i < math_ex.Length; i++)
{
    if (math_ex[i] == '+')
    {
        zn_ind = i;
        znak = '+';
    }
    else if (math_ex[i] == '-')
    {
        zn_ind = i;
        znak = '-';
    }
}

int sum = 0;
if (znak == '+')
{
    foreach (var item in math_ex.Split(znak))
    {
        sum += Convert.ToInt32(item);
    }
}
else
{
    foreach (var item in math_ex.Split(znak))
    {
        if (sum == 0)
        {
            sum = Convert.ToInt32(item);
        }
        else
        {
            sum -= Convert.ToInt32(item);
        }
    }
}
Console.WriteLine($"Sum -> {sum}");
*/
#endregion

#region Task 6
/*
Console.Write("->");
string text = Console.ReadLine();
string result = "";
for (int i = 0; i < text.Length; i++)
{
    if (text[i] == '.' || text[i] == '?' || text[i] == '!')
    {
        result += text[i];
        char temp = char.ToUpper(text[i + 1]);
        result += temp;
        i++;
    }
    else { result += text[i]; }
}
Console.WriteLine(result);
*/
#endregion

#region Task 7
string text = "To be, or not to be, that is the question,\n" +
    "Whether 'tis nobler in the mind to suffer\n" +
    "The slings and arrows of outrageous fortune,\n" +
    "Or to take arms against a sea of troubles,\n" +
    "And by opposing end them? To die: to sleep;\n" +
    "No more; and by a sleep to say we end\n" +
    "The heart-ache and the thousand natural shocks\n" +
    "That flesh is heir to, 'tis a consummation\n" +
    "Devoutly to be wish'd. To die, to sleep\n";
Console.WriteLine($"");
Console.Write("Enter the word to be banned ->");
string ban = Console.ReadLine();
string lenghtOfBan = "*";
for(int i = 0; i < ban.Length - 1; i++)
{
    lenghtOfBan += "*";
}
int j = 0; int count = 0;
while ((j = text.IndexOf(ban, j)) != -1) { ++count; j += ban.Length; }
string after = text.Replace(ban, lenghtOfBan);
Console.Write(after);
Console.WriteLine($"count of {ban} words : {count}");
#endregion