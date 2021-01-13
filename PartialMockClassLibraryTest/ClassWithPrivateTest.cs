using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartialMockClassLibrary;

namespace PartialMockClassLibraryTest
{
    [TestClass]
    public class ClassWithPrivateTest
    {
        [TestMethod]
        public void TestPrivate()
        {
            ClassWithPrivate classWithPrivate = new ClassWithPrivate(3);

//            var privateType = new PrivateType(typeof(ClassWithPrivate));
            PrivateObject po1 = new PrivateObject(classWithPrivate);
            int pre1 = (int)po1.GetProperty("_numero");
            int pre11=(int)(new PrivateObject(classWithPrivate).GetProperty("_numero"));
            po1.Invoke("_doppiaNumero");
            int post = (int)po1.GetFieldOrProperty("_numero");
            Assert.AreEqual(post, 6);
        }

    }
}
