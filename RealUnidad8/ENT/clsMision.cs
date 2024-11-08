using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class clsMision
    {
        public int id { get; set; }
        String nombre { get; set; }
        String descripcion { get; set; }
        int recompensa { get; set; }

        public clsMision() { }
        public clsMision(int Id, string Nombre, string Descripcion, int Recompensa)
        {
            id = Id;
            nombre = Nombre;
            descripcion = Descripcion;
            recompensa = Recompensa;
        }
    }
}
