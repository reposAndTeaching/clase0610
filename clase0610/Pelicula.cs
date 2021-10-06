using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase0610
{
    class Pelicula
    {
        string nombre;
        int anioDeEstreno;

        public Pelicula(string nombre, int anioDeEstreno)
        {
            this.nombre = nombre;
            this.anioDeEstreno = anioDeEstreno;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int AnioDeEstreno { get => anioDeEstreno; set => anioDeEstreno = value; }
    }
}
