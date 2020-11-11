namespace Principal.Clases
{
    class TipoEquipaje
    {
        public TipoEquipaje() { }
        public TipoEquipaje(int id, int minimo, int maximo)
        {
            this.id = id;
            this.pesoMinimo = minimo;
            this.pesoMaximo = maximo;
        }

        public int id { get; set; }
        public int pesoMinimo { get; set; }
        public int pesoMaximo { get; set; }
        public string categoria { get; set; }

        public void SetCategoria()
        {
            this.categoria = $"Desde {this.pesoMinimo}kg hasta {this.pesoMaximo}kg";
        }
    }
}
