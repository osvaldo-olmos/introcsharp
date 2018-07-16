using System;

namespace OverrrideAndNew
{
    class BaseClass  
    {  
        public virtual void Method1()  
        {  
            Console.WriteLine("Base - Method1");  
        }

        public void Method2()  
        {  
            Console.WriteLine("Base - Method2");  
        }  
    }  

    class DerivedClass : BaseClass  
    {
        public override void Method1()  
        {  
            Console.WriteLine("Derived - Method1");  
        }  

        public new void Method2()
        {  
            Console.WriteLine("Derived - Method2");  
        }  
    }

class Program  
{  
    static void Main(string[] args)  
    {  
        BaseClass bc = new BaseClass();  
        DerivedClass dc = new DerivedClass();  
        BaseClass bcdc = new DerivedClass();  

        bc.Method1();  
        bc.Method2();
        dc.Method1();  
        dc.Method2();  
        bcdc.Method1();
        bcdc.Method2();
    }  
    /* Output:  
        Base - Method1
        Base - Method2
        Derived - Method1
        Derived - Method2
        Derived - Method1 //Because override makes to use the method from the derived class
        Base - Method2  //Because Method2 implementation are different (due to new usage) in Base and Derived
                        //Classes. bcdc reference is type of BaseClass, then it access to its implementation.
    */
}  
}
