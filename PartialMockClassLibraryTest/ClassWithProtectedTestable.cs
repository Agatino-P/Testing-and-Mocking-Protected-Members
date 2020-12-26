using PartialMockClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMockClassLibraryTest
{
    public class ClassWithProtectedTestable : ClassWithProtected
    {
        public new int protMethod() => base.protMethod();
        
    }
}
