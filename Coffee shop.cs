System.Console.WriteLine("welcome to my coffee shop");
float discount;
float bill_amount;
System.Console.WriteLine("1.gold member\n2.silver member\n3.bronze member");
System.Console.WriteLine("select member");
discount = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter bill amount");
bill_amount= Convert.ToInt32(Console.ReadLine());
switch (discount)
{
    case 1:
        if (bill_amount > 50)
        {
            bill_amount = bill_amount - bill_amount * 20 / 100;
            System.Console.WriteLine("total bill amount="+bill_amount);
        }
        break;
    case 2:
        if (bill_amount > 30)
        {
            bill_amount = bill_amount - bill_amount * 10 / 100;
            System.Console.WriteLine("total bill amount=" + bill_amount);
        }
        break;
    case 3:
            bill_amount = bill_amount - bill_amount * 5 / 100;
            System.Console.WriteLine("total bill amount=" + bill_amount);
        
        break;
}
