using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.Protected;
using PartialMockClassLibrary;
using System;

namespace PartialMockClassLibraryTest
{
    [TestClass]
    public class ComplexClassTest
    {
        [TestMethod]
        public void Mockless()
        {
            new ComplexClass().FeatureUnderTest().Should().Be(4);
        }

        [TestMethod]
        public void PartialMock()
        {
            Mock<ComplexClass> mockComplexClass = new Mock<ComplexClass>();
            mockComplexClass.CallBase = true;
            mockComplexClass.Protected(). Setup<int>("internalFeature").Returns(3);
            mockComplexClass.Object.FeatureUnderTest().Should().Be(6);
        }
    }
}
