int num1,num2;
System.Console.WriteLine("Enter the value of num1");
num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the value of num2");
num2 = Convert.ToInt32(Console.ReadLine());
string result =num1 > num2 ? $"[{num2},{num1}]" : $"[{num1},{num2}]";
System.Console.WriteLine("Result="+result);
