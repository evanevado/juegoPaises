namespace LibreriasJuego
{
    public interface IPais
    {
        string nombre { get; }
        string capital { get; }
        IContinente continente { get; }
    }
}