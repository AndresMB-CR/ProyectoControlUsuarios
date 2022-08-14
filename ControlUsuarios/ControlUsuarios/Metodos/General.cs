using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ControlUsuarios.Models;

namespace ControlUsuarios.Metodos
{
    public class General
    {
        public static int estadoMantenimientoUsuario;
        public static int estadoGeneral;
        public static int idobjeto;
        public static int cargaSuper;
        public static int cargarRepInv;
        public static int cargarManinv;


        public static int getCargarSup()
        {
            return cargaSuper;
        }
        public static int getcargarRepInv()
        {
            return cargarRepInv;
        }
        public static void setCargarSup(int a)
        {
            cargaSuper = a;
        }
        public static void setCargarRepInv(int a)
        {
            cargarRepInv = a;
        }
        public static int getEstadoMentinimientoUsuario()
        {
            int estado = estadoMantenimientoUsuario;
            return estado;

        }
        public static int getidobjeto()
        {
            return idobjeto;
        }
        public static void setidobjeto(int a)
        {
            idobjeto = a;
        }
        public static void setEstadoMentinimientoUsuario(int a)
        {
            estadoMantenimientoUsuario = a;
        }
        public static void setestadoG(int a)
        {
            estadoGeneral = a;
        }
        public static int getestadoG()
        {
            return estadoGeneral;
        }
        public static void setCargaInv(int a)
        {
            cargarManinv = a;
        }
        public static int getCargaInv()
        {
            return cargarManinv;
        }
        public static List<Usuarios> ListaUsuario()// trae una lista general de los usuarios
        {
            List<Usuarios> Lista;

            using (ControlUsuariosEntities BDContexto = new ControlUsuariosEntities())
            {//profesor

                Lista = BDContexto.Usuarios.ToList();// aqui falta agregar el día del curso 
            }

            return Lista;

        }
    


    }
}