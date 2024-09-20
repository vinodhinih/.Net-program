System.Console.WriteLine("customer care execute");
System.Console.WriteLine("select your language");
System.Console.WriteLine("1.kannada\n2.english\n3.hindi");
int language =Convert.ToInt32(Console.ReadLine());
switch (language)
{
    case 1:
        System.Console.WriteLine("your selcted language is kannada");
        System.Console.WriteLine("your customer executive is ram");
        break;
    case 2:
        System.Console.WriteLine("your selcted language is tamil");
        System.Console.WriteLine("your customer is executive shiva");
        break;
    case 3:
        System.Console.WriteLine("your selcted language is hindi");
        System.Console.WriteLine("your customer is executive arun");
        break;
}

    
        