using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CineExpotronica2019.ViewModel;
using CineExpotronica2019.Model;
using System.Data.Entity;
using System.Linq;

namespace PruebaUnitariaRegistroUsuario
{
    [TestClass]
    public class TestAgregarPelicula
    {
        AddPeliculaViewModel ViewModel = new AddPeliculaViewModel();
        [TestMethod]
        public void Registro()
        {
            ViewModel.Nombre = "sadjasdhjkahsjkdashdghjasgdhjasdjajksdjkasjdkasjkdasjkdjkasdjasdhjasdjdajajhasdjhasdjkhasdjhsadjhasdjhasdhsadhsadj";
            string PropertyName = "Nombre";
            string errorMsg = "Nombre muy largo";
            string result = ViewModel.GetValidationError(PropertyName);
            Assert.AreEqual(errorMsg, result);
        }
        [TestMethod]
        public void RegistroPeliculaExitoso()
        {

            pelicula peli= new pelicula();
            peli.nombre = "Endgame";
            bool realResult;
            bool result = true;
            ViewModel.WorkingItem = peli;
            ViewModel.Add(new object());
            DbSet<pelicula> dbset = ViewModel.db.pelicula as DbSet<pelicula>;
            if (dbset.Where(value => value.nombre == peli.nombre).Count() > 0)
            {
                realResult = true;
            }
            else
            {
                realResult = false;
            }
            Assert.AreEqual(realResult, result);
        }
    }
    
}
