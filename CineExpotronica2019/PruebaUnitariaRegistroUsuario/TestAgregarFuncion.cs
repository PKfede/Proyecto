using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineExpotronica2019.ViewModel;
using CineExpotronica2019.Model;
using System.Data.Entity;
using CineExpotronica2019.Helper;

namespace PruebaUnitariaRegistroUsuario
{
    [TestClass]
    public class TestAgregarFuncion
    {
        FuncionViewModel ViewModel = new FuncionViewModel();
        [TestMethod]
        public void CamposNoVacios()
        {
            ViewModel.WorkingItem.fechaFuncion = "";
            ViewModel.WorkingItem.horaFuncion = "";
            ViewModel.Pelicula = null;
            string errorMsg;
            bool result = true;
            bool realResult = true;
            for(int i = 0; i<3;i++)
            {
                errorMsg= ViewModel.GetValidationError(ViewModel.ValidatesProperties[i]);
                if(errorMsg != "Es un campo obligatorio")
                {
                    realResult = false;
                }
            }
            Assert.AreEqual(realResult, result);
        }

        [TestMethod]
        public void AgregarFuncionExitoso()
        {

            ViewModel.FechaFuncion= "19/06/2019";
            ViewModel.HoraFuncion = "7:00 PM";
            ViewModel.Precio = "35";
            ViewModel.Pelicula = ViewModel.db.pelicula.Find(2);
            bool realResult;
            bool result = true;

            ViewModel.Add(new object());
            DbSet<funcion> dbset = ViewModel.db.funcion as DbSet<funcion>;
            if (dbset.Find(ViewModel.FechaFuncion, ViewModel.HoraFuncion, ViewModel.Pelicula.idPelicula) == null)
            {
                realResult = false;
            }
            else
            {
                realResult = true;
            }
            Assert.AreEqual(realResult, result);
        }
    }
}
