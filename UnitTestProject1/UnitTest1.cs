using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using InitializeDB;
using RestGenNHibernate;
using RestGenNHibernate.CEN.Rest;
using RestGenNHibernate.EN.Rest;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testbebida()
        {
            InitializeDB.CreateDB.InitializeData();
            BebidaCEN bebidaCEN = new BebidaCEN(); 

            try
            {
                bebidaCEN.Nuevo(String.Empty, -4, RestGenNHibernate.Enumerated.Rest.TipoBebidaEnum.refresco, String.Empty);
            }
            catch (Exception ex)
            {
                
            }            

        }
        [TestMethod]
        public void TestLineaMenu()
        {
            int cantidad = 0;

            LineaPedidoCEN lineaCEN = new LineaPedidoCEN();
            try
            {
                lineaCEN.NuevaLineaMenu(1, cantidad);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
        [TestMethod]
        public void TestModificacionLinea()
        {
            int id = 0;

            LineaPedidoCEN lineaCEN = new LineaPedidoCEN();
            try
            {
                lineaCEN.Eliminar(id);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}
