using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidad;
using CapaDatos;
namespace CapaNegocio
{
    public class Negocio
    {
        Datos dts = new Datos();

        public int N_login(Entidad obj)
        {
            return dts.login(obj);
        }

    }
        
    
}
