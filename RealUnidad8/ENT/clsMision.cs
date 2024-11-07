using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class clsMision
    {
        int idMision { get; set; }
        String nombre { get; set; }
        String descripcion { get; set; }
        int recompensa { get; set; }

        public clsMision() { }
        public clsMision(string nombre, string descripcion, int recompensa)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.recompensa = recompensa;
        }
    }
}
