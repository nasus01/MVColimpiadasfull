using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using System.Data;
using System.Data.SqlClient;

namespace CONTROLADOR.paises
{
    public class PaisesDAO
    {
        ClsDatos clsDatos = null;
        PaisesDTO paisesDTO = null;
        DataTable listaDatos = null;


        public PaisesDAO(PaisesDTO paisesDTO)
        {
            this.paisesDTO = paisesDTO;
        }

        public DataTable ListarPaises()
        {
            listaDatos = new DataTable();

            try
            {
                clsDatos = new ClsDatos();
                SqlParameter[] parametros = null;

                if (this.paisesDTO == null) {

                    parametros = new SqlParameter[2];

                    parametros[0] = new SqlParameter();
                    parametros[0].ParameterName = "@idpais";
                    parametros[0].SqlDbType = SqlDbType.Int;
                    parametros[0].SqlValue = paisesDTO.getIdpais();

                    parametros[1] = new SqlParameter();
                    parametros[1].ParameterName = "@nombrepais";
                    parametros[1].SqlDbType = SqlDbType.VarChar;
                    parametros[1].Size = 50;
                    parametros[1].SqlValue = paisesDTO.getNombrepais();

                } else {

                    parametros = null;
                }


                //SqlParameter[] parametros = null;



                listaDatos = clsDatos.RetornarTabla(parametros, "spConsultaPaises");
            }
            catch (Exception exception){

                throw new Exception(exception.Message);
            }
            return listaDatos;
        }


        public void GuardarPais()
        {
            try {

                clsDatos = new ClsDatos();
                SqlParameter[] parametro = new SqlParameter[1];

                parametro[0] = new SqlParameter();
                parametro[0].ParameterName = "@nombrepais";
                parametro[0].SqlDbType = SqlDbType.VarChar;
                parametro[0].Size = 50;
                parametro[0].SqlValue = paisesDTO.getNombrepais();

                clsDatos.EjecutaSP(parametro, "spNueoPais");


            } catch(Exception exception){

                throw new Exception(exception.Message);
            }

        }



        public void GuardarCambiosPais()
        {
            try
            {

                clsDatos = new ClsDatos();
                SqlParameter[] parametro = new SqlParameter[2];

                parametro[1] = new SqlParameter();
                parametro[1].ParameterName = "@nombrepais";
                parametro[1].SqlDbType = SqlDbType.VarChar;
                parametro[1].Size = 50;
                parametro[1].SqlValue = paisesDTO.getNombrepais();

                parametro[0] = new SqlParameter();
                parametro[0].ParameterName = "@idpais";
                parametro[0].SqlDbType = SqlDbType.Int;
                parametro[0].SqlValue = paisesDTO.getIdpais();

                clsDatos.EjecutaSP(parametro, "spGuardarCambiosPais");


            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message);
            }

        }


        public void EliminarPais()
        {
            try
            {

                clsDatos = new ClsDatos();
                SqlParameter[] parametro = new SqlParameter[1];

                parametro[0] = new SqlParameter();
                parametro[0].ParameterName = "@idpais";
                parametro[0].SqlDbType = SqlDbType.Int;
                parametro[0].SqlValue = paisesDTO.getIdpais();

                clsDatos.EjecutaSP(parametro, "spEliminarPais");


            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message);
            }

        }



    }
}
