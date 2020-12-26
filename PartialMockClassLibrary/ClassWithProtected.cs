using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMockClassLibrary
{
    public class ClassWithProtected
    {
        protected int protMethod() => internalFeature();

        protected virtual int internalFeature()
        {
            return 3;
        }
    }
}
