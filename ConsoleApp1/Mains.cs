using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{// in new file call the classes from program.cs

      class Mains
    {
        static void Main(string[] args)
        {

            //Direct Instantiated the class used the constructor and func from BASECLASS
            //{
            //    FirstClass f1 = new FirstClass("yes to constructor", 99);// here class got instantiated //bydefault empty constructor is called
            //                                                             //will instatiate the func too
            //    f1.func1();                                                       //   f1.func1();
            //    FirstClass f2 = new FirstClass("yes to constructor new", 990, "newconstructor");// here class got instantiated //bydefault empty constructor is called
            //    FirstClass f3 = new FirstClass("yes to constructor new with one parameter");// here class got instantiated //bydefault empty constructor is called
            //}

            //Now if i need func1() to change data  
            //  call the changed func from derieved class and change it in derieved class
            // DerievedClass dc1 = new DerievedClass();// because 0 arg constructor is called
            // DerievedClass dc2 = new DerievedClass("derievdclassconstruc",9);// calling the constructor in derieved class
            // these two are called

            //and now use "virtual" keyword in front of function in base class 
            //what it can call //extra parmeter going NULL
            //dc1.func1();// derieved class is calling baseclass function
            //  dc1.BaseClassfuncTobeCalled();//can call the  base class func with changes coming from derieved class
            // let see what is in the result
            //abstract class cannot be insatiated
            //CallingCommonFeatures callingCommonFeatures = new CallingCommonFeatures();
            //  callingCommonFeatures.AbstractFunc();
            //callingCommonFeatures.AbstractFuncVir();//now non abstract func is not defined  in the CallingCommonFeatures
            //so will call the func in the abstract class defined else if it defined will cal from derieved class
            //when we want to use abstract class and when baseclas??
            //only when we want to enforce the class to define the any method
            //CallInterfaces ci= new CallInterfaces();
            //ci.IAge();
            //ci.IAddress();
            //ci.Iname();
            //ci.IEmail();
            //CallAbstractClass callAbstractClass = new CallAbstractClass();  
            //callAbstractClass.ADept();
            //callAbstractClass.ADesig();
            //callAbstractClass.DressColor();
            double sqarea = OperationArea.CircleArea(2);
            Console.WriteLine(sqarea);

            Console.ReadLine();
        }
    }
}
