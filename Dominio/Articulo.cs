using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio

{
    public class Articulo
    {
        public int id { get; set; }

       

        [DisplayName("Codigo De Articulo")]
        public string CodArt { get; set; }
        public string Nombre { get; set; }

        [DisplayName("Descripcíon")]
        public string Descripcion { get; set; }

        public string Imagen { get; set; }
        public decimal Precio { get; set; }

        public Talle Marca { get; set; }

        [DisplayName("Categoría")]
        public Cat Categoria { get; set; }

        public bool activo { get; set; }

    }
}
