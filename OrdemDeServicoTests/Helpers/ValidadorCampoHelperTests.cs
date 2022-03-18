using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrdemDeServico.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdemDeServico.Helpers.Tests
{
    [TestClass()]
    public class ValidadorCampoHelperTests
    {
        [TestMethod()]
        public void ValidaSenhaTest()
        {
            string novaSenha = "NovaSenha321"; 
            string confirmarSenha = "NovaSenha321";
            //bool esperado = false;
            var resultado = ValidadorCampoHelper.ValidaSenha(novaSenha, confirmarSenha);
           // Assert.AreEqual(resultado, esperado);
           Assert.IsTrue(resultado);
        }

        [TestMethod()]
        public void CampoBrancoTest()
        {
            string texto = "não está branco";
            var resultado = ValidadorCampoHelper.CampoBranco(texto);
            Assert.IsTrue(resultado);
        }

        [TestMethod()]
        public void CampoBrancoTest1()
        {
            string campo1 = "não está branco";
            string campo2 = "não está branco";            
            var resultado = ValidadorCampoHelper.CampoBranco(campo1, campo2);            
            Assert.IsTrue(resultado);
        }

        [TestMethod()]
        public void CampoBrancoTest2()
        {
            string campo1 = "não está branco";
            string campo2 = "não está branco";
            string campo3 = "não está branco";
            var resultado = ValidadorCampoHelper.CampoBranco(campo1, campo2, campo3);
            Assert.IsTrue(resultado);
        }

        [TestMethod()]
        public void CampoBrancoTest3()
        {
            string campo1 = "não está branco";
            string campo2 = "não está branco";
            ComboBox cb = new ComboBox();
            var resultado = ValidadorCampoHelper.CampoBranco(campo1, campo2, cb);
        }

        [TestMethod()]
        public void CampoBrancoTest4()
        {
            string campo1 = "não está branco";            
            ComboBox cb1 = new ComboBox();
            ComboBox cb2 = new ComboBox();
            var resultado = ValidadorCampoHelper.CampoBranco(campo1, cb1, cb2);
        }

        [TestMethod()]
        public void CampoNumericoTest()
        {
            string campo = "10";
            var resultado = ValidadorCampoHelper.CampoNumerico(campo);
            Assert.IsTrue(resultado);
        }
    }
}