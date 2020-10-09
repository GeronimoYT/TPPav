using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Añadidos
using System.Windows.Forms;

namespace Principal.Utils
{
    public class FormUtils
    {
        //Recibe y setea una ComboBox, apartir de los parametros recibidos.
        public void CargarCombo(ref ComboBox combo, BindingSource conectorDeDatos, string displayMember, string valueMember)
        {
            combo.DataSource = conectorDeDatos.DataSource;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
        }

        public string GetValorCelda(DataGridView dgv, int num)
        {
            string valor = "";

            valor = dgv.Rows[dgv.CurrentRow.Index].Cells[num].Value.ToString();

            return valor;
        }
    }
}
