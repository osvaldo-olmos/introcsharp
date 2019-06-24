using System;

namespace OOP_Interfaces
{
    public interface ISomeInterface
    {
        void MethodA();
        void MethodB();
    }

    public class SomeClass : ISomeInterface
    {
        public void MethodA()
        {
            // Even SomeClass can't invoke MethodB without a cast.
            ISomeInterface me = (ISomeInterface)this;
            me.MethodB();
        }

        // public void MethodB()
        // {
            
        // }
        // Explicitly implemented interface member.
        // Not visible in SomeClass.
        void ISomeInterface.MethodB()
        {
            throw new NotImplementedException();
        }
    }
}