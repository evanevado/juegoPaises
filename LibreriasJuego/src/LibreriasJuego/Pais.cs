namespace LibreriasJuego
{
    public interface Pais
    {
        string nombre { get; }
        string capital { get; }
        Continente continente { get; }
    }
}