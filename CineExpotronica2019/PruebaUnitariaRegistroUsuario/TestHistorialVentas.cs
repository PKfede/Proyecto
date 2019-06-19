using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CineExpotronica2019.ViewModel;
using CineExpotronica2019.Model;
using System.Data.Entity;
using System.Linq;

namespace PruebaUnitariaRegistroUsuario
{
    [TestClass]
    public class TestHistorialVentas
    {
        [TestMethod]
        public void BusquedaPorFecha()
        {
            RegistrosViewModel ViewModel = new RegistrosViewModel();
            ViewModel.SelectedIndex = 0;

            ViewModel.Buscar = ""; // pa que encuentre todo;
            ViewModel.Find(new object());
            bool realresult = false;
            if(ViewModel.ListBoletos.Count > 0)
            {
                realresult = true;
            }
            bool result = true;

            Assert.AreEqual(realresult, result);
        }

        [TestMethod]
        public void BusquedaPorPelicula()
        {
            RegistrosViewModel ViewModel = new RegistrosViewModel();
            ViewModel.SelectedIndex = 1;

            ViewModel.Buscar = ""; // pa que encuentre todo;
            ViewModel.Find(new object());
            bool realresult = false;
            if(ViewModel.ListBoletos.Count > 0)
            {
                realresult = true;
            }
            bool result = true;

            Assert.AreEqual(realresult, result);
        }
    }
}
