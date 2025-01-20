using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W25Week3IntroToInheritance
{
    public class BaseClass
    {
        private int myPrivateVar;
        protected int myProtectedVar;
        public int myPublicVar;

        public BaseClass()
        {
            Console.WriteLine("Base class constructor called");
        }

        public BaseClass(string msg)
        {
            Console.WriteLine("Base class constructor with msg = " + msg);
        }
    }

    class DerivedClass : BaseClass
    {
        public void MyMethod()
        {
            //myPrivateVar = 1;
            myProtectedVar = 1;
            myPublicVar = 1;
        }

        public DerivedClass() : base("hello")
        {
            Console.WriteLine("Derived class constructor called");
        }
    }
}