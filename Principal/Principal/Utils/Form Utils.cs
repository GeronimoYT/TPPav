using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Añadidos
using System.Windows.Forms;

namespace Principal.Utils
{
    public class Form_Utils
    {
        //Recibe y setea una ComboBox, apartir de los parametros recibidos.
        public static void CargarCombo(ref ComboBox combo, BindingSource conectorDeDatos, string displayMember, string valueMember)
        {
            combo.DataSource = conectorDeDatos.DataSource;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
        }
    }
}
