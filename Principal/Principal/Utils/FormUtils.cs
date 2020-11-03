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
        private static FormUtils instance = null;

        protected FormUtils() {}

        public static FormUtils GetInstance
        {
            get
            {
                if (instance == null) instance = new FormUtils();   
                return instance;
            }
        }

        //Recibe y setea una ComboBox, apartir de los parametros recibidos.
        public void CargarCombo(ref ComboBox combo, BindingSource conectorDeDatos, string displayMember, string valueMember)
        {
            combo.DataSource = conectorDeDatos.DataSource;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
        }
        public static void CargarComboV2(ref ComboBox combo, BindingSource conectorDeDatos, string displayMember, string valueMember)
        {
            combo.DataSource = conectorDeDatos.DataSource;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
        }

        //Recibe y setea una ListBox, apartir de los parametros recibidos.
        public void CargarList(ref ListBox combo, BindingSource conectorDeDatos, string displayMember, string valueMember)
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

        public void KeypressKeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }
}
