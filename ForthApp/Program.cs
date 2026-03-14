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

            #region Q3: Keywords for Method Overriding

            //1. virtual
            //Used in the base class (the parent). It tells the compiler, "Hey, I expect my children to change this method later. Use dynamic binding for this."

            //2. override
            //Used in the derived class (the child). It explicitly states, "I am intentionally replacing a method from my parent." In Java, it’s written as @Override.This is a safety net; if you make a typo in the method name, the compiler will yell at you instead of letting you create a brand new, unrelated method.

            //3. super or base
            //Used inside the child's method to call the parent's version of that same method. It’s useful when you want to add to the parent's logic rather than completely replacing it.

            //4. final or sealed
            //The "stop" button.If you label a method with this, no subclass is allowed to override it.It locks the implementation.

            #endregion


        }
    }
}
