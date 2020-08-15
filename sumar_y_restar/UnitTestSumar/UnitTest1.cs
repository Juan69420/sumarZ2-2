using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sumar.Controllers;

namespace UnitTestSumar
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd1()
        {
            //Arrange
            Sumacontroller sumacontroller = new Sumacontroller();
            int a = 5;
            int b = 8;
            int esperado = 13;
            //Act
            int resultado = sumacontroller.Add(a, b);
            //Assert
            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void TestProduct1()
        {
            //Arrange
            Sumacontroller sumacontroller = new Sumacontroller();
            int a = 5;
            int b = 8;
            int esperado = 40;
            //Act
            int resultado = sumacontroller.Product(a, b);
            //Assert
            Assert.AreEqual(esperado, resultado);
        }
    }

    internal class SumaController
    {
        internal int Add1(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
