namespace LibreriasJuego
{
    public class Pais:IPais
    {
        internal Pais(IContinente continente,string nombre, string capital)
        {
            this.nombre = nombre;
            this.capital = capital;
            this.continente = continente;
        }
        public string nombre { get; }
        public string capital { get; }
        public IContinente continente { get; }
    }
}