using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASTER_TUNE_UP.Clases
{
    class Valores
    {

        public static void Letras(KeyPressEventArgs L)
        {
            if (char.IsLetter(L.KeyChar))
            {
                L.Handled = false;
            }
            else if (char.IsSeparator(L.KeyChar))
            {
                L.Handled = false;
            }
            else if (char.IsControl(L.KeyChar))
            {
                L.Handled = false;
            }
            else
            {
                L.Handled = true;
                MessageBox.Show("Solo letras");
            }

        }
        public static void Numeros(KeyPressEventArgs L)
        {
            if (char.IsDigit(L.KeyChar))
            {
                L.Handled = false;
            }
            else if (char.IsSeparator(L.KeyChar))
            {
                L.Handled = false;
            }
            else if (char.IsControl(L.KeyChar))
            {
                L.Handled = false;
            }
            else
            {
                L.Handled = true;
                MessageBox.Show("Solo Numeros");
            }


        }
    }
}
