using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASTER_TUNE_UP.Clases
{
    class Usuario
    {
        private String us_login;
        private String us_password;
        private int us_nivel;
        public Usuario()
        {

        }
        public Usuario(String us_login, String us_password, int us_nivel)
        {
            this.Us_login = us_login; //ESTAR GUARDANDO LOS DATOS
            this.Us_password = us_password;
            this.Us_nivel = us_nivel;
        }

        public string Us_login { get => us_login; set => us_login = value; }
        public string Us_password { get => us_password; set => us_password = value; }
        public int Us_nivel { get => us_nivel; set => us_nivel = value; }
    }
}
