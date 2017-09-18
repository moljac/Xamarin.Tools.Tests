using System;
namespace PCLProject
{
    #if MOLJAC
    public class MyClass
    #else
    internal class MyClass
    #endif
    {
        public MyClass()
        {
        }
    }
}
