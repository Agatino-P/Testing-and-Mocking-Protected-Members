using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.Protected;
using PartialMockClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMockClassLibraryTest
{
    [TestClass]
    public class ClassWithProtectedTest : ClassWithProtected
    {
        [TestMethod]
        public void ProtMethodtest()
        {
        ClassWithProtectedTest cwp = new ClassWithProtectedTest();
            cwp.protMethod().Should().Be(3);

        }

        [TestMethod]
        public void PartialMock()
        {
            Mock<ClassWithProtectedTest> mock = new Mock<ClassWithProtectedTest>() { CallBase = true};
            mock.Protected().Setup<int>("internalFeature").Returns(4);
            mock.Object.protMethod().Should().Be(4);

        }
        [TestMethod]
        public void PrivateObjectTest()
        {
            ClassWithProtected cwp = new ClassWithProtected();
            PrivateObject privateObject = new PrivateObject(cwp);
            int res = (int)privateObject.Invoke("protMethod");
            res.Should().Be(3);
        }
        
        public void Testable()
        {
            ClassWithProtectedTestable cwpt = new ClassWithProtectedTestable();
            cwpt.protMethod().Should().Be(3);
        }
    }

}
