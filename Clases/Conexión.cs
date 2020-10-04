using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASTER_TUNE_UP.Clases
{
    class Conexión
    {
        public string Conn()
        {
            //Defino  la cadena de conexion para para uso en el proyecto pventa
            string conexion = (@"Data Source=DESKTOP-U6Q9M2G;Initial Catalog=Taller;Integrated Security=True");
            return conexion;
        }
    }
}
