using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CineExpotronica2019.ViewModel;
using CineExpotronica2019.Model;
using System.Data.Entity;

namespace PruebaUnitariaRegistroUsuario

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UsuarioNoRepetidoGetValidationError()
        {
            SignInViewModel SignInVM = new SignInViewModel(); 
            SignInVM.db = new cineEntities();
            SignInVM._dbSet = SignInVM.db.usuario as DbSet<usuario>; 
            SignInVM.Nombre_usuario = "kikeprzn";
            string PropertyName= "Nombre_usuario";
            string errorMsg = "Nombre de usuario ya existente";

            string result = SignInVM.GetValidationError(PropertyName);

            Assert.AreEqual(errorMsg, result);
        }
    }
}
