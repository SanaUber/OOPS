using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //static classes
    //no instantiation required
    //it's methods, fields can be used anywhere with the classname directly
    //Utility class can be used any where example in C# MAth.Sqrt(),Console(static class) .Readline/Writeline()static methods 

    static class OperationArea
    {
        public static double pi = 3.14;
        public static double SqaareArea(double x, double y)// can be used as OperationArea.SqaareArea(1,2)
        { return x * y; }
        public static double CircleArea(double r)// can be used as OperationArea.CircleArea(1,2)
        { return (pi * r * r); }





    }

    //Interface same as abstract but with small diffrences
    //1.interfaces support multiple inheritance
    //2.have only abstract function no need to mention public and abstract keyword before them
    //3.keyword for class interface
    //4.no constructor in the interfaces
    //When to use abstract and when to use interfaces
    //Interfaces for common features eg: name,age is necessary for all employees
    //whether permanent employee or temp employee
    //Abstract for common features but some can have definition eg: designation,department will be different for employees
    //,dresscolorcode is necessary for all employees to be in color "BLUE" then we can define this

    interface IBasicInformation
    {
        void Iname();
        void IAge();
    }
    interface IBasicInformation1
    {
        void IEmail();
        void IAddress();
    }

    abstract class AbstractBsicInf
    {
        abstract public void ADesig();
        abstract public void ADept();

        public  virtual void DressColor() //to override
        {
            Console.WriteLine("BLUE--concrete func");
        }

    }
    class CallInterfaces : IBasicInformation, IBasicInformation1
    {
        public void IAddress()
        {
            Console.WriteLine("Address for employee--interface");
        }

        public void IAge()
        {
            Console.WriteLine("Age for employee --interface");
        }

        public void IEmail()
        {
            Console.WriteLine("Email for employee--interface");
        }

        public void Iname()
        {
            Console.WriteLine("Name for employee--interface");
        }
    }

    class CallAbstractClass : AbstractBsicInf
    {
        public override void ADept()
        {
            Console.WriteLine("Dept1 --abstract");
        }

        public override void ADesig()
        {
            Console.WriteLine("Desig1 --abstract");
        }
    }



    //Abstract class and func
    //abstract func cannot virtual
    //abstract func is only declared not defined
    //abstract class cannot be insatiated
    //abstract class  can have both abstract method and nonabstract method
    //abstarct class is the common features that can be used by any class





    abstract class CommonFeatures
    {
        public virtual void AbstractFuncVir()
        {
            Console.WriteLine("Abstract class non abstract function");
            
            //need to define also as not abstract
        }
        abstract public void AbstractFunc();
        //no need to define


    }
    class CallingCommonFeatures : CommonFeatures
    {// need to define the abstract func in the class calling abstract class
        public override void AbstractFunc()
        {
            Console.WriteLine("Abstract func is called in Derieved Class Mandatory to define");
        }
        //public override  void AbstractFuncVir() // if override used will take the func from abstract class else will make a new func
        //                                // same func name 
        //{ Console.WriteLine("Non Abstract Func"); }
    }


    //structure of class
    class FirstClass//BASECLASS LETS CALL THIS IN DERIEVED CLASS
    {
        string willdoOperation = "yes";
        int anyNo = 3;
        public void func1()
        {
            Console.WriteLine(willdoOperation);
            Console.WriteLine(anyNo);
        }

        public virtual void BaseClassfuncTobeCalled()
        {
            Console.WriteLine(willdoOperation);
            Console.WriteLine(anyNo);
        }




        //will make constructors


        //no arg constructor
        public FirstClass() 
        {  //and this data too
            //3.from here the derieved class after
            Console.WriteLine("wdO");
            Console.WriteLine("anyNocnst");
        }
        public  FirstClass(string wdO, int anyNocnst)
        { 
            Console.WriteLine(wdO);
            Console.WriteLine(anyNocnst);
        }
        // will do consructors with different parameters
     public   FirstClass(string wdO)
        {

            Console.WriteLine(wdO);
        }
        // need to make access modifier as PUBLIC so as to access outside file or class
    public    FirstClass(string wd0cnstdiff,int anyNocnstdiff,string newparam)
        {
            Console.WriteLine(wd0cnstdiff);
            Console.WriteLine(anyNocnstdiff);
            Console.WriteLine(newparam);

        }
        //NOW if i have call one class  into another INHERITANCE need to use":" to implement the base class in derived class
     }



     

    class DerievedClass:FirstClass
    {// as there was no constructor for derieved class with 0 arg
        public DerievedClass()//2.from here the derieved class after
        { 
            Console.WriteLine("dcwd");
            Console.WriteLine(10 * 10);

        }

        public DerievedClass(string dcwd,int dcint)
        { 
            Console.WriteLine(dcwd);
            Console.WriteLine(dcint*dcint);

        }
        // now one can make this class object get the details in main class
        //let's see

        // calling in derieved class that is inheriting base class
        //a dd keyword override

//Data is coming from
public  override void BaseClassfuncTobeCalled()
        {// bringing this data
            Console.WriteLine("willdoOperation");
            Console.WriteLine(8+8);// 1.from here the derieved class after
        }

    }







}
