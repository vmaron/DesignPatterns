using System;

namespace Creational.Prototype
{
    public static class CopyThroughSerialization
    {
        private static void Main()
        {
            var foo = new Foo {Stuff = 42, Whatever = "abc"};

            //Foo foo2 = foo.DeepCopy(); // crashes without [Serializable]
            var foo2 = foo.DeepCopyXml();

            foo2.Whatever = "xyz";
            Console.WriteLine(foo);
            Console.WriteLine(foo2);
        }
    }
}