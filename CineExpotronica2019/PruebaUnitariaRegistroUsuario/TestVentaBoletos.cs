using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
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
    public class TestVentaBoletos
    {
        AsientosMapaViewModel ViewModel = new AsientosMapaViewModel();

        [TestMethod]
        public void CambioBoleto()
        {
            funcion funcion = ViewModel.db.funcion.Find("19/06/2019", "10:00 PM", 1);
            ViewModel.CurrentFuncion = funcion; // se genero el diagrama
            ViewModel.SeatsTop.Where(value => value.Row == "N" && value.SeatNumber == 2).First<Seat>().Status = false; // El checkbox es presionado y cambia a false;
            ViewModel.SeatsTop.Where(value => value.Row == "N" && value.SeatNumber == 2).First<Seat>().Status = true; //El mismo checkbox es seleccionado y su valor vuelve a cambiar. Cambia a true;
            ViewModel.SeatsTop.Where(value => value.Row == "N" && value.SeatNumber == 3).First<Seat>().Status = false; // ahora cambiamos al bueno

            bool realResult = false;
            if (ViewModel.SeatsTop.Where(value => value.Row == "N" && value.SeatNumber == 2).First<Seat>().Status == true && ViewModel.SeatsTop.Where(value => value.Row == "N" && value.SeatNumber == 3).First<Seat>().Status == false)
            {
                // si se cumple esta condicion es que el que se selecciono primero se deseleccion y se selecciono el que se queria 
                realResult = true;
            }
            bool result = true;
            Assert.AreEqual(realResult, result);
        }

        [TestMethod]
        public void CancelacionBoleto()
        {
            funcion funcion = ViewModel.db.funcion.Find("19/06/2019", "10:00 PM", 1);
            ViewModel.CurrentFuncion = funcion; // se genero el diagrama
            ViewModel.SeatsTop.Where(value => value.Row == "N" && value.SeatNumber == 2).First<Seat>().Status = false;// El checkbox es presionado y cambia a false;
            ViewModel.SeatsTop.Where(value => value.Row == "N" && value.SeatNumber == 2).First<Seat>().Status = true;//El mismo checkbox es seleccionado y su valor vuelve a cambiar. Cambia a true;
            bool result = true;
            Assert.AreEqual(ViewModel.SeatsTop.Where(value => value.Row == "N" && value.SeatNumber == 2).First<Seat>().Status, result);
        }
        

    }
}
