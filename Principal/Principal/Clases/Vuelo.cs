using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases
{
    public class Vuelo
    {
        public int NroVuelo { get; set; }
        public DateTime FechaHoraSalida { get; set; }
        public DateTime FechaHoraLlegada { get; set; }
        public int NroAvion { get; set; }
        public string IdTipoAvion { get; set; }
        public int IdAeropuerto { get; set; }
        public int IdAeropuertoDestino { get; set; }
        public int Estado { get; set; }

        //Cree otros atibutos para poder usarlos en el pasaje en VueloV2

        
    }

}

/*public class Bug
{
    public long Id { get; set; }
    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    public DateTime FechaAlta { get; set; }
    public Usuario UsuarioResponsable { get; set; }
    public Usuario UsuarioAsignado { get; set; }
    public Producto Producto { get; set; }
    public Estado Estado { get; set; }
    public Criticidad Criticidad { get; set; }
    public Prioridad Prioridad { get; set; }


    public void ValidarTitulo()
    {
        if (string.IsNullOrEmpty(this.Titulo))
            throw new ApplicationException("El título es requerido");
        if (!string.IsNullOrEmpty(this.Titulo) && this.Titulo.Length > 100)
            throw new ApplicationException("Título inválido. El título no debe superar los 100 caracteres");
    }

    public void ValidarProducto()
    {
        if (Producto == null || Producto.Id == 0)
            throw new ApplicationException("El producto es requerido");
    }

    public void ValidarFecha()
    {
        if (FechaAlta == DateTime.MinValue)
            throw new ApplicationException("la fecha de alta es requerida");
        FechaAlta = new DateTime(FechaAlta.Year, FechaAlta.Month, FechaAlta.Day);
        if (FechaAlta > DateTime.Today)
            throw new ApplicationException("la fecha de alta es debe ser menor o igual que la fecha actual");
    }



    public void ValidarPrioridad()
    {
        if (Prioridad != null && Prioridad.Id == 0)
            throw new ApplicationException("Prioridad Inválida");
    }

    public bool TienePrioridad()
    {
        return Prioridad != null;
    }

    public bool TieneCriticidad()
    {
        return Criticidad != null;
    }
}*/



