using System.Drawing;
using System.Reflection;
using System.Threading.Channels;

namespace Assignment05
{

    //enum TheDaysOfWeek
    //{


    //    monday =1,
    //    tuesday,
    //    wednesday,
    //    thursday,
    //    friday ,
    //    saturday, 
    //    sunday
    //}


    //enum Season
    //{
    //    Spring,
    //    Summer,
    //    Autumn,
    //    Winter

    //}

    //[Flags]
    //enum Permisions
    //{
    //    Read = 8,
    //    Write = 4,
    //    Excute = 2,
    //    Delete = 1

    //}


    enum Color
    {
        Red ,
        Green ,
        Blue 

    }




    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 : Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.Then, write a C# program that prints out all the days of the week using this enum.


            //Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
            //Then, write a C# program that prints out all the days of the week using this enum.

            //foreach (TheDaysOfWeek val in Enum.GetValues(typeof(TheDaysOfWeek)))
            //{
            //    Console.WriteLine(val);
            //}





            //for (int i = 0; i <=7  ; i++)
            //{
            //    Console.WriteLine(TheDaysOfWeek();
            //} 
            #endregion

            #region Q2:  //Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
            //Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
            //Note range for seasons ( spring march to may , summer june to august , autumn September to November ,
            //winter December to February)
            //Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
            //Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
            //Note range for seasons ( spring march to may , summer june to august , autumn September to November ,
            //winter December to February)
            //September, October, November, December ,January, February, March, April, May, June, July, August

            //Season Se;
            //Console.WriteLine(" Enter a Season");

            //Se = (Season)Enum.Parse(typeof(Season), Console.ReadLine(), true);



            //switch (Se)
            //{
            //    case Season.Spring :
            //        Console.WriteLine("Spring from march to may");
            //        break;

            //    case Season.Autumn :
            //        Console.WriteLine("Autom from September to November");
            //        break;

            //        case Season.Summer :
            //        Console.WriteLine("summer from  june to august ");
            //        break;
            //    case Season.Winter :
            //        Console.WriteLine("winter from December to February ");
            //        break;


            //}

            #endregion

            #region Q4  unsolved:Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum. Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable

            // Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            // Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable




            //Permisions Per = Permisions.Write;
            //Per ^= Permisions.Delete;
            //Console.WriteLine(Per); 
            #endregion

            #region Q5 :Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.


            // . Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            //Color C1;


            //Console.WriteLine(" Enter A Color ");


            //try
            //{
            //    C1 = (Color)Enum.Parse(typeof(Color), Console.ReadLine(), true);

            //    if (C1 == Color.Red)
            //    {
            //        Console.WriteLine($"the {C1} is Basic Color");
            //    }
            //    else if (C1 == Color.Green)
            //    {
            //        Console.WriteLine($"the {C1} is Basic Color");
            //    }
            //    else if (C1 == Color.Blue)
            //    {
            //        Console.WriteLine($"the {C1} is Basic Color");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"the {C1} is not a Basic Color");
            //    }


            //}
            //catch
            //{
            //    Console.WriteLine("is not a basic Color");
            //} 
            #endregion














        }
    }
}
