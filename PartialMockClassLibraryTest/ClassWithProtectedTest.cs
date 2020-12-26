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
            Mock<ClassWithProtectedTest> mock = new Mock<ClassWithProtectedTest>();

            mock.CallBase = true;
            mock.Protected().Setup<int>("internalFeature").Returns(4);
            mock.Object.protMethod().Should().Be(4);

        }
    }
}
