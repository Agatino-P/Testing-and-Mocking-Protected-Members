using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMockClassLibrary
{
    public class ComplexClass
    {
        public int FeatureUnderTest()
        {
            int a = internalFeature();
            return a* 2;
        }

        protected virtual int internalFeature()
        {
            return 2;
        }
    }
}
