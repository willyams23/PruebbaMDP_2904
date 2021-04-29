using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    public class ValidarRango
    {
        [Test]
        public void Rango01()
        {
            //Arrange
            int[] Array01 = { 2, 1, 4, 5 };
            int[] Expectd = { 1, 2, 3, 4, 5 };


            //Act
            int[] Respuesta = PruebaNet01.Prueba.CompletaRango(Array01);

            //Assert
            Assert.AreEqual(Expectd, Respuesta);
        }

        [Test]
        public void Rango02()
        {
            //Arrange
            int[] Array02 = { 100, 96, 101, 102, 105 };
            int[] Expectd = { 96, 97, 98, 99, 100, 101, 102, 103, 104, 105};


            //Act
            int[] Respuesta = PruebaNet01.Prueba.CompletaRango(Array02);

            //Assert
            Assert.AreEqual(Expectd, Respuesta);
        }

        [Test]
        public void Rango03()
        {
            //Arrange
            int[] Array03 = { 22, 25 };
            int[] Expectd = { 22, 23, 24, 25};


            //Act
            int[] Respuesta = PruebaNet01.Prueba.CompletaRango(Array03);

            //Assert
            Assert.AreEqual(Expectd, Respuesta);
        }
    }
}
