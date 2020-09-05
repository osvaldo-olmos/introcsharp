using System;

namespace Structs
{
    class Foo
    {
        public int bar;
    }

    struct MyStruct
    {
        public string myField;
        public int MyProperty { get; set; }
        private Foo foo;

        public MyStruct(string fieldValue, int properyValue)
        {
            myField =fieldValue;
            MyProperty = properyValue;
            foo =new Foo();
        }

        public void DoStuff()
        {
            Console.WriteLine($"doing stuff: myField value is {myField}");
            Console.WriteLine($"doing stuff: foo.bar value is {foo.bar}");
        }
    }
}