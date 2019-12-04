using System;
using System.Collections.Generic;

namespace LibreriasJuego
{
    public class Continente: IContinente
    {
        internal Continente(String nombre)
        {
            this.nombre = nombre;
            this.misPaises = new Dictionary<string, IPais>();
        }
        public String nombre { get; }
        public IList<IPais> paises { get => new List<IPais>(this.misPaises.Values).AsReadOnly(); }
                
        // tabla donde en la primera columna tengo el nombre del pais y en la otra el objeto pais
        private Dictionary<string,IPais> misPaises { get; }

        public IPais getPais(string nombrePais)
        {
            return this.misPaises[nombrePais];
            

        }
        //no lo meto en el interface para que no se pueda llamar desde fuera
        internal void asignarPais(IPais nuevoPais)
        {
            this.misPaises.Add(nuevoPais.nombre, nuevoPais);
        }

    }
}
