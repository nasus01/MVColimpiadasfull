using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADOR.paises
{
    public class PaisesDTO
    {

        private int idpais;
        private string nombrepais;

        #region Set - Get Idpais

        public void setIdpais(int valor)
        {
            this.idpais = valor;
        }

        public int getIdpais()
        {
            return this.idpais;
        }

        #endregion


        #region Set - Get Nombrepais
        public void setNombrepais(string valor)
        {
            this.nombrepais = valor;
        }

        public string getNombrepais()
        {
            return this.nombrepais;
        }
        #endregion
    }
}
