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
    }

    class DerivedClass : BaseClass
    {
        public void MyMethod()
        {
            //myPrivateVar = 1;
            myProtectedVar = 1;
            myPublicVar = 1;
        }
    }
}
