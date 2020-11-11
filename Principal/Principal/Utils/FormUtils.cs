using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Añadidos
using System.Windows.Forms;
using System.IO;

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

        public void KeypressNumeros(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; } // Permitir Numeros
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }//Permitit teclas de control
            else { e.Handled = true; } //Desactiva el resto de teclas
 
        }

        public void KeypressLetras(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; } // Permitir letras
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }//Permitit teclas de control
            else { e.Handled = true; } //Desactiva el resto de teclas
        }

        public void KeypressDocumento(string tipo, string documento, object sender, KeyPressEventArgs e)
        {
            //Si es pasaporte solo permite 3 letras al principio seguidas de 7 numeros
            if (tipo == "Pasaporte")
            {
                if (documento.Length < 3) { KeypressLetras(sender, e); } //Permite solo letras
                else if (documento.Length >= 3 && documento.Length < 10 ) { KeypressNumeros(sender, e); } //Permite solo numeros
                else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }//Permitit teclas de control
                else { e.Handled = true; } //No permite nada
            }
            
            //Si es DNI solo se permiten numeros
            else if (tipo == "DNI")
            {
                if (documento.Length < 8) { KeypressNumeros(sender, e); } //Permite solo numeros
                else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }//Permitit teclas de control
                else { e.Handled = true; }//No permite nada
            }
        }
        public void GenerarTXT(string texto)
        {
            string rutaCompleta = @" C:\mi archivo.txt";

            using (StreamWriter mylogs = File.AppendText(rutaCompleta))         //se crea el archivo
            {

                //se adiciona alguna información y la fecha


                DateTime dateTime = new DateTime();
                dateTime = DateTime.Now;
                string strDate = Convert.ToDateTime(dateTime).ToString("yyMMdd");

                mylogs.WriteLine(texto + strDate);

                mylogs.Close();
            }
        }
    }
}
