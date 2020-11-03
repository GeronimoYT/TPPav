using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases
{
    class Pasajero
    {
        public Pasajero()
        {

        }
        public TipoDocumento TipoDocumento { get; set; }
        public string NroDocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Nacionalidad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public int Edad
        {

            get
            {
                //DateTime now = DateTime.Today;
                int edad = DateTime.Today.Year - FechaNacimiento.Year;

                if (DateTime.Today < FechaNacimiento.AddYears(edad))
                    return --edad;
                else
                    return edad;
            }
            //get { return CalcularEdad(); }
            //set { _edad = value; }
        }



        public void ValidarNroDocumento()
        {
            if (string.IsNullOrEmpty(this.NroDocumento))
                throw new ApplicationException("El nro documento es requerido");
            //return "El Nro Documento es requerido";
            if (!string.IsNullOrEmpty(this.NroDocumento) && this.NroDocumento.Length > 20)
                throw new ApplicationException("nro Documento inválido. El nro documento no debe superar los 20 caracteres");
            /*return "Nro Documento inválido. El nombre no debe superar los 20 caracteres";
        return null;*/
        }
        public void ValidarNombre()
        {
            if (string.IsNullOrEmpty(this.Nombre))
                throw new ApplicationException("El nombre es requerido");
            //return "El nombre es requerido";
            if (!string.IsNullOrEmpty(this.Nombre) && this.Nombre.Length > 20)
                throw new ApplicationException("Nombre inválido. El nombre no debe superar los 20 caracteres");
            /*return "Nombre inválido. El nombre no debe superar los 20 caracteres";
        return null;*/
        }
        public void ValidarApellido()
        {
            if (string.IsNullOrEmpty(this.Apellido))
                throw new ApplicationException("El apellido es requerido");
            //return "El apellido es requerido";
            if (!string.IsNullOrEmpty(this.Apellido) && this.Apellido.Length > 20)
                throw new ApplicationException("Apellido inválido. El nombre no debe superar los 20 caracteres");
            /*return "Apellido inválido. El nombre no debe superar los 20 caracteres";
        return null;*/
        }
        public void ValidarTelefono()
        {
            if (string.IsNullOrEmpty(this.Telefono))
                throw new ApplicationException("El telefono es requerido");
            //return "El telefono es requerido";
            if (!string.IsNullOrEmpty(this.Telefono) && this.Telefono.Length > 20)
                throw new ApplicationException("Telefono inválido. El nombre no debe superar los 20 caracteres");
            /*return "Telefono inválido. El nombre no debe superar los 20 caracteres";
        return null;*/
        }

        public void ValidarEmail()
        {
            if (!string.IsNullOrEmpty(this.Email) && this.Email.Length > 60)
                throw new ApplicationException("Email inválido. El email no debe superar los 60 caracteres");
            /*return "Email inválido. El email no debe superar los 60 caracteres";
        return null;*/
        }
        public void ValidarTipoDocumento()
        {
            if (TipoDocumento == null || NroDocumento == "0")
            {
                throw new ApplicationException("Indetificacion por Documento Invalido");
            }
            if (TipoDocumento.Id == "Seleccionar")
            {
                throw new ApplicationException("Debe seleccionar el tipo de Documento");
            }
        }
        public string EstadoABD()
        {
            //si estado es true devuelve S y si el falso una N
            return Estado ? "S" : "N";
        }
        public void ValidarFechaNacimiento()
        {
            if (!string.IsNullOrEmpty(this.Email) && this.Email.Length > 60)
                throw new ApplicationException("Email inválido. El email no debe superar los 60 caracteres");
            /*return "Email inválido. El email no debe superar los 60 caracteres";
        return null;*/
        }
    }
}
