using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CineExpotronica2019.ViewModel;
using CineExpotronica2019.Model;
using System.Data.Entity;
using System.Linq;

namespace PruebaUnitariaRegistroUsuario

{
    [TestClass]
    public class TestRegistroUsuario
    {
        SignInViewModel SignInVM = new SignInViewModel(); 
        [TestMethod]
        public void UsuarioNoRepetidoGetValidationError()
        {
            SignInVM.Nombre_usuario = "kikeprzn";
            string PropertyName= "Nombre_usuario";
            string errorMsg = "Nombre de usuario ya existente";

            string result = SignInVM.GetValidationError(PropertyName);

            Assert.AreEqual(errorMsg, result);
        }
        [TestMethod]
        public void CamposNoVacios()
        {
            SignInVM.Nombre = "";
            string PropertyName = "Nombre_usuario";
            string errorMsg = "Es un campo obligatorio";

            string result = SignInVM.GetValidationError(PropertyName);

            Assert.AreEqual(errorMsg, result);
        }
        [TestMethod]
        public void LongitudDeDatosNoMuyLarga()
        {
            SignInVM.Nombre = "sadjasdhjkahsjkdashdghjasgdhjasdjajksdjkasjdkasjkdasjkdjkasdjasdhjasdjdajajhasdjhasdjkhasdjhsadjhasdjhasdhsadhsadj";
            string PropertyName = "Nombre_usuario";
            string errorMsg = "Es un campo obligatorio";
            string result = SignInVM.GetValidationError(PropertyName);
            Assert.AreEqual(errorMsg, result);
        }
        [TestMethod]
        public void RegistroDeUsuarioExitoso()
        {
            
            CineExpotronica2019.Model.usuario usuario = new usuario();
            usuario.nombre_usuario = "federica";
            usuario.nombre = "federico";
            usuario.apPaterno = "Sanchez";
            usuario.apMaterno = "Diaz";
            usuario.tipoUsuario = "Administrador";
            usuario.contra = "1234";
            usuario.telTaquillero = "1234567890";

            bool realResult;
            bool result = true;
            SignInVM.WorkingItem = usuario;
            SignInVM.Add(new object());
            DbSet<usuario> dbset = SignInVM.db.usuario as DbSet<usuario>;
            if (dbset.Where(value => value.nombre_usuario == usuario.nombre_usuario).Count() > 0)
            {
                realResult = true;
            }
            else
            {
                realResult = false;
            }
            Assert.AreEqual(realResult, result);
        }
        [TestMethod]
        public void tipoDatosValidos()
        {
            SignInVM.TelTaquillero = "sad91";
            string PropertyName = "TelTaquillero";
            string errorMsg = "Teléfono solo debe contener números";

            string result = SignInVM.GetValidationError(PropertyName);

            Assert.AreEqual(errorMsg, result);
        }
    }
}
