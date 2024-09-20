// See https://aka.ms/new-console-template for more information
string name;
float rollNumber;
float english;
float tamil;
float maths;
float science;
float social;
System.Console.WriteLine("Enter the name:");
System.Console.ReadLine();
System.Console.WriteLine("Enter the roll number:");
System.Console.ReadLine();
System.Console.WriteLine("Enter the english mark:");
english =float.Parse(Console.ReadLine());
System.Console.WriteLine("Enter the tamil mark:");
tamil= float.Parse(Console.ReadLine());
System.Console.WriteLine("Enter the maths mark:");
maths = float.Parse(Console.ReadLine());
System.Console.WriteLine("Enter the science mark:");
science= float.Parse(Console.ReadLine());
System.Console.WriteLine("Enter the social mark:");
social = float.Parse(Console.ReadLine());
float average = (english + tamil + maths + science + social)/5;
System.Console.WriteLine(average);
if (average > 90)
{
    System.Console.WriteLine("excellent");
}
else if (average > 80 && average < 90)
{
    System.Console.WriteLine("very good");
}
else if (average > 70 && average < 80)
{
    System.Console.WriteLine("good");
}
else if (average > 60 && average < 70)
{
    System.Console.WriteLine("average");
}
else if (average > 50 && average < 60)
{
    System.Console.WriteLine("below average");
}
else if (average > 40 && average < 35)
{
    System.Console.WriteLine("need more improment");
}
else 
{
    System.Console.WriteLine("fail");
}




