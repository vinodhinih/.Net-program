
System.Console.WriteLine("Electricity bill");
System.Console.WriteLine("select your choice");
System.Console.WriteLine("1.residential\n2.commercial");
int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:

        System.Console.WriteLine("residential bill");
        System.Console.WriteLine("Enter consumed unit");
        int consumed_unit = Convert.ToInt32(Console.ReadLine());
        if (consumed_unit >= 1 && consumed_unit <= 50)
        {
            System.Console.Write("consumed unit=0");
        }
        else if (consumed_unit >= 50 && consumed_unit <= 150)
        {
            double bill_amount = (consumed_unit - 50) * 5.50;
            System.Console.Write(bill_amount);
        }
        else if (consumed_unit >= 150 && consumed_unit <= 250)
        {
            double bill_amount = (consumed_unit - 50) * 8.5;
            System.Console.Write(bill_amount);
        }
        else if (consumed_unit >= 251 && consumed_unit <= 500)
        {
            double bill_amount = (consumed_unit - 50) * 13;
            System.Console.Write(bill_amount);
        }
        break;


    case 2:

        System.Console.WriteLine("commercial bill");
        System.Console.WriteLine("Enter consumed unit");
        int consumed_unit2 = Convert.ToInt32(Console.ReadLine());
        if (consumed_unit2 >= 1 && consumed_unit2 < 50)
        {
            System.Console.Write("consumed unit2=10");
        }
        else if (consumed_unit2 >= 50 && consumed_unit2 < 150)
        {
            double bill_amount = (consumed_unit2 - 50) * 15.5;
            System.Console.Write(bill_amount);
        }
        else if (consumed_unit2 >= 150 && consumed_unit2 < 250)
        {
            double bill_amount = (consumed_unit2 - 50) * 18.5;
            System.Console.Write(bill_amount);
        }
        else if (consumed_unit2 >= 251 && consumed_unit2 <= 500) ;
        {
            double bill_amount = (consumed_unit2 - 50) * 23;
            System.Console.Write(bill_amount);
        }
        break;


}



