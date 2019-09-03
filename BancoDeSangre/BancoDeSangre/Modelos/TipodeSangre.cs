using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeSangre.Modelos
{
    public class TipodeSangre
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }

        public TipodeSangre()
        {

        }

        public TipodeSangre(int id, string descripcion, double precio)
        {
            Id = id;
            Descripcion = descripcion;
            Precio = precio;
        }
    }
}
