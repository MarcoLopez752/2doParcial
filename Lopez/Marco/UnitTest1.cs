using System;
using Biblioteca;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Marco
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSave()
        {
            //Organizar
            Person Cliente = new Person("Pedro", 500);
            double valoresperado = 600;

            //Actuar
            Cliente.Save(100);
            double valorobtenido = Cliente.SaveMoney;

            //Afirmar

            Assert.AreEqual(valoresperado, valorobtenido);
        }

        [TestMethod]
        public void TestSpend()
        {
            //Organizar
            Person Cliente = new Person("Luana", 1000);
            double valoresperado = 800;

            //Actuar
            Cliente.Spend(200);
            double valorobtenido = Cliente.SaveMoney;

            //Afirmar
            Assert.AreEqual(valoresperado, valorobtenido);
        }



    }
    
        
    



}
