using System;

namespace assginFour
{
    //enum Food
    //{
    //    Pizza, 
    //    Burger,
    //    Salad
    //}
    //enum WeekDay
    //{
    //    monday,
    //    tuesday,
    //    wednesday,
    //    thursday,
    //    friday,
    //    saturday,
    //    sunday
    //}

    //struct Person
    //{
    //    public string Name;
    //    public int age;
    //}
    //enum Seas_on
    //{
    //    Spring,
    //    Summer,
    //    Autumn,
    //    Winter
    //}
    //[Flags]
    //enum Permisions
    //{
    //    read = 1,
    //    write = 2,
    //    delete = 4,
    //    excute = 8
    //}

    //enum Colors
    //{
    //    Red,
    //    Green,
    //    Blue
    //}
    //struct Point
    //{
    //    public int X;
    //    public int Y;
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task
            //Console.Write("Enter your favourite food: ");
            //string? input = Console.ReadLine();
            //bool check = Enum.TryParse(input, true, out Food food);
            //if (check)
            //    Console.WriteLine("You chose: Pizza (or Burger / Salad)");
            //else
            //    Console.WriteLine("That food is not on the menu!");
            #endregion
            #region q1
            //WeekDay day = new WeekDay();
            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine((WeekDay)i);
            //}
            #endregion
            #region q2
            //Person[] people = new Person[3];
            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine("Eneter name and age: ");
            //    people[i].Name = Console.ReadLine();
            //    people[i].age = int.Parse(Console.ReadLine());
            //}
            //foreach (Person person in people)
            //{
            //    Console.Write("name is " + person.Name);
            //    Console.WriteLine("\t age is "+ person.age);
            //}
            #endregion
            #region q3
            //Console.Write("enter the season: ");
            //Enum.TryParse(Console.ReadLine(), true, out Seas_on sea);
            //switch(sea)
            //{
            //    case Seas_on.Spring:
            //        Console.WriteLine("the spring is from march to may.");
            //        break;
            //    case Seas_on.Winter:
            //        Console.WriteLine("the winter is from December to February.");
            //        break;
            //    case Seas_on.Summer:
            //        Console.WriteLine("the summer is from june to august .");
            //        break;
            //    case Seas_on.Autumn:
            //        Console.WriteLine("the autumn is from September to November.");
            //        break;
            //}
            #endregion
            #region q4
            //Permisions per1 = Permisions.read;
            //per1 ^= Permisions.write;
            //Console.WriteLine("permision added succesfully.");
            //if ((per1 & Permisions.write) == Permisions.write)
            //{
            //    per1 ^= Permisions.write;
            //    Console.WriteLine("permision removed succesfully.");
            //}
            //else
            //{
            //    per1 |= Permisions.write;
            //    Console.WriteLine("permision added succesfully.");
            //}
            //Console.WriteLine($"the user permisions are {per1}");

            #endregion
            #region q5
            //Console.Write("Enter a color name: ");
            //if (Enum.TryParse(Console.ReadLine(), true, out Colors col))
            //    Console.WriteLine("color is primary");
            //else
            //    Console.WriteLine("color is not primary");
            #endregion
            #region q6
            //Point p1 = new Point();
            //Point p2 = new Point();
            //Console.WriteLine("enter point x1|y1: ");
            //p1.X = int.Parse(Console.ReadLine());
            //p1.Y = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter point x2|y2: ");
            //p2.X = int.Parse(Console.ReadLine());
            //p2.Y = int.Parse(Console.ReadLine());
            //int distance = (int)Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
            //Console.WriteLine($"the distance is {distance}");
            #endregion
            #region q7
            //Person[] people = new Person[3];
            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine("Eneter name and age: ");
            //    people[i].Name = Console.ReadLine();
            //    people[i].age = int.Parse(Console.ReadLine());
            //}
            //int oldest = people[0].age;
            //string name = " ";
            //for (int i = 0; i < people.Length; i++)
            //{
            //    if (oldest < people[i].age)
            //    {
            //        oldest = people[i].age;
            //        name = people[i].Name;
            //    }
            //}
            //Console.WriteLine($"the oldest person is {name} and his age is {oldest}.");
            #endregion
        }
    }
}
