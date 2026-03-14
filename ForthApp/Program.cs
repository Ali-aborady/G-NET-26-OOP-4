using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ForthApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1 — Static Binding vs Dynamic Binding
            //Binding is the process of linking a function call to the actual code(method body) that should execute.

            //Static Binding(Early Binding): The compiler determines which method to call at compile time.
            //This happens with static, private, or final methods because they cannot be changed by subclasses.
            //It is generally faster because the decision is made before the program even starts.


            //Dynamic Binding(Late Binding): The program determines which method to call at runtime.
            //This happens when a method is overridden in a subclass. The computer looks at the actual object type
            //(not just the variable type) during execution to find the right version of the method.

            #endregion

            #region Q2: Overloading vs. Overriding
            //Method Overloading:-
            //Method Overloading occurs within the same class. It allows you to use the same method name multiple times,
            //provided that each version has a different "signature" (different number or types of parameters).

            //Method Overriding:-
            //Method Overriding occurs between a Superclass(Parent) and a Subclass(Child).It happens when a child class provides 
            //specific implementation for a method that is already defined in its parent class.

            #endregion



        }
    }
}
