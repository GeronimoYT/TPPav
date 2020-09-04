using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases
{
    public class Usuario
    {
        string nombre;
        string contrasena;


        public Usuario(string nombre, string contrasena)
        {
            this.nombre = nombre;
            this.contrasena = contrasena;
        }

        public string NombreDeUsuario
        {
            get => nombre;
            set => nombre = value;
        }

        public string Contrasena
        {
            get => contrasena;
            set => contrasena = value;
        }

    }
}
