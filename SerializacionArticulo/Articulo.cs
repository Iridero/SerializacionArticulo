using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionArticulo
{
    [Serializable]
    public class Articulo
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

    }
}
