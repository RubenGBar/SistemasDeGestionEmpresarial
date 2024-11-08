﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ENT;

namespace DAL
{
    internal class listaMisionDAL
    {

        public static List<clsMision> listarTodasMisionDAL() { 
        
            return new List<clsMision> {
                new clsMision(1, "Rescate de Baby Yoda", "Debes hacerte con Grogu y llevárselo a Luke SkyWalker para su entrenamiento.", 5000),
                new clsMision(2, "Recuperar armadura Beskar", "Tu armadura de Beskar ha sido robada. Debes encontrarla.", 2000),
                new clsMision(3, "Planeta Sorgon", "Debes llevar a un niño de vuelta a su planeta natal “Sorgon”.", 500),
                new clsMision(4, "Renacuajos", "Debes llevar a una Dama Rana y sus huevos de Tatooine a la luna del estuario Trask, donde su esposo fertilizará los huevos.", 500)
            };

        }

        public static clsMision getMisionDAL(int id)
        {
            clsMision res = new clsMision();
            List<clsMision> lista = listarTodasMisionDAL();
            res = lista.Find(mision => mision.id == id);
            return res;
        }

    }
}
