
#region Task 1
Console.WriteLine("~Task 1");

{
    Console.WriteLine("Enter a number from 1 to 100:");
    int value = Convert.ToInt32(Console.ReadLine());
    if (value % 3 == 0 && value % 5 == 0)
    {
        Console.WriteLine($"{value} is FizzBuzz");
    }
    else if (value % 3 == 0)
    {
        Console.WriteLine($"{value} is Fizz");
    }
    else if (value % 5 == 0)
    {
        Console.WriteLine($"{value} is Buzz");
    }
    else
    {
        Console.WriteLine("Number is not divisible by 3 or 5");
    }
}
#endregion

#region Task 2

Console.WriteLine("\n\n~Task 2");
Console.WriteLine("Enter number:");
double number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter percent:");
int percent = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{percent} of {number} is {number / 100 * percent}");
#endregion

#region Task 3
Console.WriteLine("\n\n~Task 3");
Console.WriteLine("Enter 1-st number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2-nd number:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 3-rd number:");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 4-th number:");
int num4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Finaly number is {num1 * 1000 + num2 * 100 + num3 * 10 + num4}");
#endregion

#region Task 4
Console.WriteLine("Enter six-digit number:");
int number_swap = Convert.ToInt32(Console.ReadLine());

void my_Swap(int number_swap)
{
    if (number_swap <= 999_999 && number_swap >= 100_000)
    {
        Console.WriteLine($"your number {number_swap}");
        Console.Write("enter index 1 :");
        int index1 = new();
        var index1_bool = Int32.TryParse(Console.ReadLine(), out index1);
        if (index1_bool)
        {
            int a = (int)(Math.Pow(10, index1 + 1)) / 10;
            int a_number = (number_swap / (int)a) % 10;
            Console.Write("enter index 2 :");
            int index2 = new();
            var index2_bool = Int32.TryParse(System.Console.ReadLine(), out index2);
            if (index2_bool)
            {
                int b = (int)(Math.Pow(10, index2 + 1)) / 10;
                int b_number = (number_swap / (int)b) % 10;
                number_swap -= ((a * a_number) + (b * b_number)) - ((a * b_number) + (b * a_number));
                Console.WriteLine($"swap number - {number_swap}");
            }
        }
    }
    else Console.WriteLine("is not six digit number");
}
 my_Swap(number_swap);
#endregion

#region Task 5
Console.WriteLine("\n\n~Task 5");
Console.WriteLine("Enter Year:");
int year = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Month:");
int month = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Day:");
int day = Convert.ToInt32(Console.ReadLine());
DateTime dt = new DateTime(year, month, day);
Console.WriteLine($"{dt.DayOfWeek}");
if (month == 12 || month == 1 || month == 2)
{
    Console.WriteLine("Winter");
}
else if (month == 3 || month == 4 || month == 5)
{
    Console.WriteLine("Spring");
}
else if (month == 6 || month == 7 || month == 8)
{
    Console.WriteLine("Summer");
}
else if (month == 9 || month == 10 || month == 11)
{
    Console.WriteLine("Autumn");
}
#endregion

#region Task 6
Console.WriteLine("\n\n~Task 6");
Console.WriteLine("Enter degree:");
double degree = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Select \n" +
    "Celsius[1]\n" +
    "Fahrenheit[2]");
int select = Convert.ToInt32(Console.ReadLine());
switch (select)
{
    case 1:
        Console.WriteLine($"{degree} Celsius to Fahrenheit is {degree * 1.8 + 30}");
        break;
    case 2:
        Console.WriteLine($"{degree} Fahrenheit to Celsius is {(degree / 1.8) - 30}");
        break;
    default:
        Console.WriteLine("Enter 1 or 2");
        break;
}
#endregion

#region Task 7
Console.WriteLine("\n\n~Task 7");
Console.WriteLine("Enter the beginning of the range ");
int begining = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the end of the range");
int end = Convert.ToInt32(Console.ReadLine());
if(end < begining)
{
    int c;
    c = end;
    end = begining;
    begining = c;
}
while(begining < end)
{
    begining++;
    if(begining % 2 == 0)
    {
        Console.WriteLine(begining);
    }
}
#endregion