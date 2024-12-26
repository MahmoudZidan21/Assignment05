namespace Demo5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Boxing And UnBoxing

            // Boxing And UnBoxing

            // Boxing   : Casting From ValueType TO ReferenceType
            // UnBoxing : Casting From ReferenceType TO ValueType


            //object O1;

            // O1 => Can Referer to Instance of " Object" Or any Instance From Any Type 

            //O1 = 1;
            //O1 = " Ahmed ";

            //O1 = 3;             // Cast From VAlueType(int) TO ReferenceType (Object) => // Boxing
            //O1 = 3.5;           //  Cast From VAlueType(double) TO ReferenceType (Object) => // Boxing
            //O1 = "A";           //  Cast From VAlueType(Char) TO ReferenceType (Object) => // Boxing
            //O1 = true;          //Cast From VAlueType(bool) TO ReferenceType(Object) => // Boxing
            //O1 =new DateTime(); //Cast From VAlueType(DateTime) TO ReferenceType(Object) => // Boxing


            //int X = 5;

            //object O1 = X; 
            // Imblicit Casting
            // Safe Casting 
            // Boxing 
            // Parent = Child => Child is A parent 
            // Animal = Dog => Dog Is Animel 


            //object O1 = 3;

            //int X =(int) O1;
            // Explicit Casting
            // Unsafe Casting (May throw Exeption )
            // UnBoxing
            // Dog = (Dog) Animal => Animal Is Dog
            // 


            #endregion

            #region Nullable Value Type
            // Nullable Types 
            // Value Type
            // Reference Type

            //int X = 8;
            //X = null; // Invalid

            // NullAble<int> : Allow Int Valeu or Null As Valid value  
            //int? Age = 20; 
            //Age = null;

            // NullAble<double> : Allow Int Valeu or Null As Valid value
            //double? Salary = 4000.5;
            //Salary = null;


            //int X = 5;
            //// Y : Nullable<int>
            //// Y : Allow int Value or Null

            //int? Y = /*(int)*/X;
            //// Imlicit Casting
            //// Safe CAsting

            //Console.WriteLine(Y);



            //  int?X = 5;
            //X = null;
            // Y : Nullable<int>
            // Y : Allow int Value only 

            // int Y = (int)X;
            // Explicit Casting
            // UnSafe CAsting
            //May throw Exeption

            //int Y;

            //// Defensive Code
            //if (X != null) 
            //          Y = (int)X;
            //else 
            //    Y = 0;
            //// 
            //if (X is not null)
            //    Y = (int)X;
            //else
            //    Y = 0;

            // =============================

            //if (X.HasValue) 
            //    Y = X.Value;
            //else
            //    Y = 0;

            //Console.WriteLine(Y);

            // =======================

            // Null Coalescing Operator

            //Y = X ?? 0;

            //Console.WriteLine(Y);


            #endregion

            #region NullAble Reference Type
            // NullAble Reference Type [C# 10.0  .NET 6.0]

            //string Message = null;  // Required
            //string? Message1 = null; // NUllable

            //Console.WriteLine(Message.Length);
            //Console.WriteLine(Message1);

            #endregion










        }
    }
}
