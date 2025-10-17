namespace assignEight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P.ToString());

            //int x, y, z;

            //Console.WriteLine($"\nEnter coordinates :");

            //x = ReadInt("X");
            //y = ReadInt("Y");
            //z = ReadInt("Z");
            //Point3D P1 = new Point3D(x, y, z);

            //Console.WriteLine($"\nEnter coordinates :");

            //x = ReadInt("X");
            //y = ReadInt("Y");
            //z = ReadInt("Z");
            //Point3D P2 = new Point3D(x, y, z);

            //Console.WriteLine(P1 == P2 ? "P1 and P2 are equal." : "P1 and P2 are not equal.");

            //Point3D clone = (Point3D)P1.Clone();
            //Console.WriteLine("Cloned Point: " + clone);

            //Point3D[] points = {
            //new Point3D(3, 2, 5),
            //new Point3D(1, 7, 0),
            //new Point3D(1, 5, 9),
            //new Point3D(2, 1, 3)
            //};

            //Array.Sort(points);
            //Console.WriteLine("\nSorted Points by X then Y:");
            //foreach (var point in points)
            //{
            //    Console.WriteLine(point);
            //} 
            #endregion
            #region q2
            //double num1 = 20;
            //double num2 = 0;

            //Console.WriteLine("Addition: " + Maths.Add(num1, num2));
            //Console.WriteLine("Subtraction: " + Maths.Subtract(num1, num2));
            //Console.WriteLine("Multiplication: " + Maths.Multiply(num1, num2));
            //Console.WriteLine("Division: " + Maths.Divide(num1, num2)); 
            #endregion
            #region q3
            //Console.WriteLine("Enter user type (regular / premium / guest): ");
            //string userType = Console.ReadLine();

            //User user;

            //switch (userType)
            //{
            //    case "regular":
            //        user = new RegularUser("regular User");
            //        break;
            //    case "premium":
            //        user = new PremiumUser("premium User");
            //        break;
            //    default:
            //        user = new GuestUser("guest User");
            //        break;
            //}

            //Console.Write("Enter product price: ");
            //decimal price = Convert.ToDecimal(Console.ReadLine());

            //Console.Write("Enter quantity: ");
            //int quantity = Convert.ToInt32(Console.ReadLine());

            //Discount discount = user.GetDiscount();

            //decimal discountAmount = 0;
            //if (discount != null)
            //{
            //    discountAmount = discount.CalculateDiscount(price, quantity);
            //    Console.WriteLine($"\nDiscount Applied: {discount.Name}");
            //    Console.WriteLine($"Discount Amount: ${discountAmount:F2}");
            //}
            //else
            //{
            //    Console.WriteLine("\nNo discount applied for Guest User.");
            //}

            //decimal total = (price * quantity) - discountAmount;

            //Console.WriteLine($"Final Price after Discount: ${total:F2}"); 
            #endregion
        }

        #region q1
        //static int ReadInt(string coordinateName)
        //{
        //    int value;
        //    while (true)
        //    {
        //        Console.Write($"Enter {coordinateName}: ");
        //        string input = Console.ReadLine();

        //        if (int.TryParse(input, out value))
        //            return value;

        //        try
        //        {
        //            value = Convert.ToInt32(input);
        //            return value;
        //        }
        //        catch
        //        {
        //            Console.WriteLine("Invalid input! Please enter a valid integer.");
        //        }
        //    } 
        #endregion
    }
    
}
