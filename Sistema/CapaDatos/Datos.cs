using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidad;
namespace CapaDatos
{
    public class Datos
    {
        public int login(Entidad obj)
        {
            {
                int n;
                string user, pass;
                user =  obj.usuario;
                pass = obj.pasword;
                if (user == "PRISIONERO")
                {
                    if (pass == "computron")
                    {
                        n = 1;  
                    }
                    else
                    {
                        n = 2;  
                    }
                }
                else
                {
                    n = 2;
                }
                return n;

            }
        }

     }
}
