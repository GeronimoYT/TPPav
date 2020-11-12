using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases
{

    public class Estado
    {
        
        public Estado()
        {

        }
        public Estado(int idEstado)
        {
            this.IdEstado = idEstado;
        }
        public int IdEstado { get; set; }
        public string NombreEstado { get; set; }
        public int Ambito { get; set; }


    }
}
