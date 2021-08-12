using System;

namespace tasktwoQ2
{
 
    class Program
    {
        static readonly string logo = @"  

                 ) (   )  (  (                              
                 ( )  (   )  )
                 _____________
                <_____________> ___
                |             |/ _ \
                |               | | |
                |               |_| |
             ___|             |\___/
            /    \___________/    \
            \_____________________/
▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
██░█▀▄█░▄▄█░▄▄▀█░███░█░▄▄▀█░██░████░▄▄▀█░▄▄▀█░▄▄█░▄▄
██░▄▀██░▄▄█░██░█▄▀░▀▄█░▀▀░█░▀▀░████░████░▀▀░█░▄██░▄▄
██░██░█▄▄▄█▄██▄██▄█▄██▄██▄█▀▀▀▄████░▀▀▄█▄██▄█▄███▄▄▄
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀

";
        static double TotalOrder = 0.0;
        static void AddOrder(double itemPrice )
        {
            TotalOrder += itemPrice;
            Console.WriteLine("Item has been added successfully!");
            MainMenu();
        }

        static double CheckDiscount(double totalOrder)
        {
            if (totalOrder >= 15.0)
            
            return totalOrder = totalOrder - (totalOrder * 0.05);  
            else
                return totalOrder;
        }
        static void MainMenu()
        {
            
            Console.Clear();
            Console.Write(logo);
            Console.WriteLine(
@"
 Welcome to Kenway Cafe
------------------------------|
 1) Hot Drinks
 2) Cold Drinks
 3) View The Order
 4) Exit
------------------------------|
");
            Console.Write(" Choose an option: ");
            switch (Console.ReadLine())
            {
                case "1":
                    HotDrinks();
                    break;
                case "2":
                    ColdDrinks();
                    break;
                case "3":
                    ViewOrder();
                    break;
                case "4":
                    Environment.Exit(1);
                    break;
            }
        }
        static void HotDrinks()
        {
            Console.Clear();
            Console.Write(logo);
            Console.WriteLine(
@"
 Hot Drinks:
-------------------------------------|
 1) Espresso                    $7.0
 2) Cappuccino                  $5.0
 3) Latte                       $6.0
 4) Mocha                       $6.0
 5) Back
-------------------------------------|
");
            Console.Write(" Choose an option: ");
            switch (Console.ReadLine())
            {
                case "1":
                    AddOrder(7.0);
                    break;
                case "2":
                    AddOrder(5.0);
                   

                    break;
                case "3":
                    AddOrder(6.0);
                    

                    break;
                case "4":
                    AddOrder(6.0);
                   

                    break;
                case "5":
                    MainMenu();
                    break;
            }

        }



        static void ViewOrder() {
            double TotalWithOutDiscount = TotalOrder;
            TotalOrder= CheckDiscount(TotalOrder);
            Console.Clear();
            Console.Write(logo);
            Console.WriteLine(
$@"
|-------------------------------------|
|             Your Order              |
|-------------------------------------|
|   Total Before Discount: {TotalWithOutDiscount}$ 
|
|   Total Price: {TotalOrder}$
|-------------------------------------|

 b) Back
");
            Console.Write(" Choose an option: ");
            switch (Console.ReadLine())
            {
                case "b":
                    MainMenu();
                    break;
            }

        }

        static void ColdDrinks()
        {
            Console.Clear();
            Console.Write(logo);
            Console.WriteLine(
@"
 Cold Drinks:
-------------------------------------|
 1) Strawberry Lemon Freeze     $7.0
 2) Strawberry Bliss            $5.0
 3) Caramel                     $6.0
 4) Back
-------------------------------------|
");
            Console.Write(" Choose an option: ");
            switch (Console.ReadLine())
            {
                case "1":
                    AddOrder(7.0 );
                    break;
                case "2":
                    AddOrder(5.0 );
                    break;
                case "3":
                    AddOrder(6.0 );
                    break;
                case "4":
                    MainMenu();
                    break;
            }

        }
        static void Main(string[] args)
        {
            MainMenu();
        }
    }
}
